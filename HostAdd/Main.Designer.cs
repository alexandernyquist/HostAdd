namespace HostAdd
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDocumentRoot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApacheHostFile = new System.Windows.Forms.TextBox();
            this.btnGogogo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDocumentRoot);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApacheHostFile);
            this.groupBox1.Controls.Add(this.btnGogogo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHostname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new host";
            // 
            // txtDocumentRoot
            // 
            this.txtDocumentRoot.Location = new System.Drawing.Point(9, 81);
            this.txtDocumentRoot.Name = "txtDocumentRoot";
            this.txtDocumentRoot.Size = new System.Drawing.Size(444, 20);
            this.txtDocumentRoot.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Document root";
            // 
            // txtApacheHostFile
            // 
            this.txtApacheHostFile.Location = new System.Drawing.Point(9, 129);
            this.txtApacheHostFile.Name = "txtApacheHostFile";
            this.txtApacheHostFile.Size = new System.Drawing.Size(441, 20);
            this.txtApacheHostFile.TabIndex = 3;
            // 
            // btnGogogo
            // 
            this.btnGogogo.Location = new System.Drawing.Point(375, 155);
            this.btnGogogo.Name = "btnGogogo";
            this.btnGogogo.Size = new System.Drawing.Size(75, 23);
            this.btnGogogo.TabIndex = 4;
            this.btnGogogo.Text = "Add";
            this.btnGogogo.UseVisualStyleBackColor = true;
            this.btnGogogo.Click += new System.EventHandler(this.btnGogogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path to Apache VirtualHost-file";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(9, 32);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(441, 20);
            this.txtHostname.TabIndex = 1;
            this.txtHostname.Text = "test.localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hostname";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 207);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Add new host";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGogogo;
        private System.Windows.Forms.TextBox txtApacheHostFile;
        private System.Windows.Forms.TextBox txtDocumentRoot;
        private System.Windows.Forms.Label label3;
    }
}

