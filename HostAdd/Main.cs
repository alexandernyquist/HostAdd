using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HostAdd
{
    public partial class Main : Form
    {
        private readonly string _vhostTemplate = Environment.NewLine + Environment.NewLine + @"<VirtualHost *:80>
    ServerAdmin webmaster@dummy-host2.example.com
    DocumentRoot ""{0}""
    ServerName {1}
    ErrorLog ""logs/dummy-host2.example.com-error.log""
    CustomLog ""logs/dummy-host2.example.com-access.log"" common
</VirtualHost>";

        public Main()
        {
            InitializeComponent();

            // Try to guess path to VHost-file
            if (Directory.Exists(@"C:\wamp") && Directory.Exists(@"C:\wamp\bin\apache"))
            {
                var apacheVersions = Directory.GetDirectories(@"C:\wamp\bin\apache");
                if (apacheVersions.Any())
                {
                    var directoryInfo = new DirectoryInfo(apacheVersions[0]);
                    txtApacheHostFile.Text = string.Format(directoryInfo.FullName + @"\conf\extra\httpd-vhosts.conf");
                }
            }
        }

        private void btnGogogo_Click(object sender, EventArgs e)
        {
            if (!ValidatePaths())
            {
                MessageBox.Show("All path are required to be filled in.", "HostAdd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var backupTime = DateTime.Now.ToString().Replace(":", "-");

            if (!File.Exists(txtApacheHostFile.Text))
            {
                FailExit("Apache v-host file not found");
            }

            // Make a backup
            var apacheHostFile = new FileInfo(txtApacheHostFile.Text);
            if (!Directory.Exists("backups"))
            {
                Directory.CreateDirectory("backups");
            }

            apacheHostFile.CopyTo(string.Format("backups/{0}-{1}", backupTime, apacheHostFile.Name));

            // Validate
            if (File.ReadAllText(apacheHostFile.FullName).Contains(txtHostname.Text))
            {
                if(!Confirm(txtHostname.Text + " already exists in v-host file. Continue anyway?"))
                {
                    Environment.Exit(0);   
                }
            }

            // Add new host
            var template = string.Format(_vhostTemplate, txtDocumentRoot.Text, txtHostname.Text);
            File.AppendAllText(apacheHostFile.FullName, template);

            // Add host to /etc/hosts
            var hostsFile = new FileInfo(@"C:\Windows\System32\drivers\etc\hosts");
            if (!hostsFile.Exists)
            {
                FailExit(@"Could not find hosts file C:\Windows\System32\drivers\etc\hosts! Broken system?");
            }

            // Backup hosts file
            hostsFile.CopyTo(string.Format("backups/{0}-hosts", backupTime));

            // Validate
            if (File.ReadAllText(hostsFile.FullName).Contains(txtHostname.Text))
            {
                if (!Confirm(txtHostname.Text + " already exists in hosts file. Continue anyway?"))
                {
                    Environment.Exit(0);
                }
            }

            // Add host
            File.AppendAllText(hostsFile.FullName, string.Format("\n{0}\t{1}", "127.0.0.1", txtHostname.Text));

            // Create document root folder if not exists
            if (!Directory.Exists(txtDocumentRoot.Text))
            {
                if (Confirm(string.Format("Document root folder ({0}) does not exist. Create?", txtDocumentRoot.Text)))
                {
                    Directory.CreateDirectory(txtDocumentRoot.Text);
                }
            }

            // Done!
            var openHost = MessageBox.Show(string.Format("Done! Remember to restart Apache. Go to http://{0}?", txtHostname.Text), "HostAdd",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (openHost == DialogResult.Yes)
            {
                Process.Start("http://" + txtHostname.Text + "/");
            }

            Environment.Exit(0);
        }

        private void FailExit(string message)
        {
            MessageBox.Show(message, "HostAdd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Environment.Exit(1);
        }

        private static bool Confirm(string question)
        {
            var confirm = MessageBox.Show(question, "HostAdd", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return confirm == DialogResult.Yes;
        }

        private bool ValidatePaths()
        {
            return !string.IsNullOrWhiteSpace(txtHostname.Text) &&
                   !string.IsNullOrWhiteSpace(txtDocumentRoot.Text) &&
                   !string.IsNullOrWhiteSpace(txtApacheHostFile.Text);
        }
    }
}
