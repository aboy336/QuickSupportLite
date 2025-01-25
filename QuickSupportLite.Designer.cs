namespace QuickSupportLite
{
    partial class QuickSupportLite
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickSupportLite));
            this.bafButton = new System.Windows.Forms.Button();
            this.clupButton = new System.Windows.Forms.Button();
            this.apciFixButton = new System.Windows.Forms.Button();
            this.wafButton = new System.Windows.Forms.Button();
            this.rootElementButton = new System.Windows.Forms.Button();
            this.baldoLocalButton = new System.Windows.Forms.Button();
            this.logFolderButton = new System.Windows.Forms.Button();
            this.apciFolderButton = new System.Windows.Forms.Button();
            this.appwizButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fidoStatusIcon = new System.Windows.Forms.PictureBox();
            this.clupStatusIcon = new System.Windows.Forms.PictureBox();
            this.serviceStatusIcon = new System.Windows.Forms.PictureBox();
            this.fidoButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.servicesButton = new System.Windows.Forms.Button();
            this.systemInfoButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.serviceStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.clupStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.fidoStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.techToolVersionLabel = new System.Windows.Forms.Label();
            this.bafTip = new System.Windows.Forms.ToolTip(this.components);
            this.clupTip = new System.Windows.Forms.ToolTip(this.components);
            this.fidoTip = new System.Windows.Forms.ToolTip(this.components);
            this.apciResetTip = new System.Windows.Forms.ToolTip(this.components);
            this.wafTip = new System.Windows.Forms.ToolTip(this.components);
            this.rootElementTip = new System.Windows.Forms.ToolTip(this.components);
            this.baldoLocalTip = new System.Windows.Forms.ToolTip(this.components);
            this.apciFolderTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fidoStatusIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clupStatusIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStatusIcon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bafButton
            // 
            this.bafButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bafButton.Location = new System.Drawing.Point(6, 97);
            this.bafButton.Name = "bafButton";
            this.bafButton.Size = new System.Drawing.Size(109, 40);
            this.bafButton.TabIndex = 0;
            this.bafButton.Text = "BAF";
            this.bafTip.SetToolTip(this.bafButton, "BAF is the main TechTool Service. It takes awhile to load.\r\nTurn this off if you " + "are trying to fix any problems. ");
            this.bafButton.UseVisualStyleBackColor = false;
            this.bafButton.Click += new System.EventHandler(this.bafButton_Click);
            // 
            // clupButton
            // 
            this.clupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clupButton.Location = new System.Drawing.Point(121, 97);
            this.clupButton.Name = "clupButton";
            this.clupButton.Size = new System.Drawing.Size(109, 40);
            this.clupButton.TabIndex = 1;
            this.clupButton.Text = "CLUP";
            this.clupTip.SetToolTip(this.clupButton, resources.GetString("clupButton.ToolTip"));
            this.clupButton.UseVisualStyleBackColor = false;
            this.clupButton.Click += new System.EventHandler(this.clupButton_Click);
            // 
            // apciFixButton
            // 
            this.apciFixButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.apciFixButton.Location = new System.Drawing.Point(9, 21);
            this.apciFixButton.Name = "apciFixButton";
            this.apciFixButton.Size = new System.Drawing.Size(109, 40);
            this.apciFixButton.TabIndex = 3;
            this.apciFixButton.Text = "APCI";
            this.apciResetTip.SetToolTip(this.apciFixButton, "APCI Repair is often used when trying to connect to a truck, \r\nthe connection cir" + "cle starts to read and disappears. \r\nIf this doesnt resolve connecting to a vehi" + "cle, please call support.");
            this.apciFixButton.UseVisualStyleBackColor = true;
            this.apciFixButton.Click += new System.EventHandler(this.apciFixButton_Click);
            // 
            // wafButton
            // 
            this.wafButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wafButton.Location = new System.Drawing.Point(122, 21);
            this.wafButton.Name = "wafButton";
            this.wafButton.Size = new System.Drawing.Size(109, 40);
            this.wafButton.TabIndex = 4;
            this.wafButton.Text = "WAF";
            this.wafTip.SetToolTip(this.wafButton, "WAF resets TechTool\'s adaptor settings. It is related to \r\nRoot Element and shoul" + "d be used together. \r\nUse this if you have recently switched adaptors and are \r\n" + "unable to connect to a vehicle. ");
            this.wafButton.UseVisualStyleBackColor = true;
            this.wafButton.Click += new System.EventHandler(this.wafButton_Click);
            // 
            // rootElementButton
            // 
            this.rootElementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rootElementButton.Location = new System.Drawing.Point(235, 21);
            this.rootElementButton.Name = "rootElementButton";
            this.rootElementButton.Size = new System.Drawing.Size(109, 40);
            this.rootElementButton.TabIndex = 5;
            this.rootElementButton.Text = "Root Element";
            this.rootElementTip.SetToolTip(this.rootElementButton, "Root Element and WAF are often used together. \r\nThis resets TechTool\'s profile in" + "formation. If you\'ve switched\r\nadaptors or are unable to connect to a truck, run" + " this fix. ");
            this.rootElementButton.UseVisualStyleBackColor = true;
            this.rootElementButton.Click += new System.EventHandler(this.rootElementButton_Click);
            // 
            // baldoLocalButton
            // 
            this.baldoLocalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.baldoLocalButton.Location = new System.Drawing.Point(122, 65);
            this.baldoLocalButton.Name = "baldoLocalButton";
            this.baldoLocalButton.Size = new System.Drawing.Size(109, 40);
            this.baldoLocalButton.TabIndex = 6;
            this.baldoLocalButton.Text = "BaldoLocal";
            this.baldoLocalTip.SetToolTip(this.baldoLocalButton, "BaldoLocal is a database related to TechTool and being\r\nable to sign in to your U" + "serID.\r\nWhen  you see the error \"unable to synchronize user profile\"\r\nthis is th" + "e fix.");
            this.baldoLocalButton.UseVisualStyleBackColor = true;
            this.baldoLocalButton.Click += new System.EventHandler(this.baldoLocalButton_Click);
            // 
            // logFolderButton
            // 
            this.logFolderButton.Location = new System.Drawing.Point(11, 29);
            this.logFolderButton.Name = "logFolderButton";
            this.logFolderButton.Size = new System.Drawing.Size(109, 40);
            this.logFolderButton.TabIndex = 7;
            this.logFolderButton.Text = "Log Folder";
            this.logFolderButton.UseVisualStyleBackColor = true;
            this.logFolderButton.Click += new System.EventHandler(this.logFolderButton_Click);
            // 
            // apciFolderButton
            // 
            this.apciFolderButton.Location = new System.Drawing.Point(233, 29);
            this.apciFolderButton.Name = "apciFolderButton";
            this.apciFolderButton.Size = new System.Drawing.Size(109, 40);
            this.apciFolderButton.TabIndex = 8;
            this.apciFolderButton.Text = "APCI Folder";
            this.apciFolderTip.SetToolTip(this.apciFolderButton, "APCI Database folder. When you run the APCI fix, the \r\nfolder APCIPlus.Database.c" + "ache, will redownload.\r\nIt takes around 15-30 to redownload. ");
            this.apciFolderButton.UseVisualStyleBackColor = true;
            this.apciFolderButton.Click += new System.EventHandler(this.apciFolderButton_Click);
            // 
            // appwizButton
            // 
            this.appwizButton.Location = new System.Drawing.Point(11, 29);
            this.appwizButton.Name = "appwizButton";
            this.appwizButton.Size = new System.Drawing.Size(109, 40);
            this.appwizButton.TabIndex = 9;
            this.appwizButton.Text = "AppWiz";
            this.appwizButton.UseVisualStyleBackColor = true;
            this.appwizButton.Click += new System.EventHandler(this.appwizButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fidoStatusIcon);
            this.groupBox1.Controls.Add(this.clupStatusIcon);
            this.groupBox1.Controls.Add(this.serviceStatusIcon);
            this.groupBox1.Controls.Add(this.fidoButton);
            this.groupBox1.Controls.Add(this.clupButton);
            this.groupBox1.Controls.Add(this.bafButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 154);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TechTool Services";
            // 
            // fidoStatusIcon
            // 
            this.fidoStatusIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fidoStatusIcon.Location = new System.Drawing.Point(257, 40);
            this.fidoStatusIcon.Name = "fidoStatusIcon";
            this.fidoStatusIcon.Size = new System.Drawing.Size(61, 53);
            this.fidoStatusIcon.TabIndex = 5;
            this.fidoStatusIcon.TabStop = false;
            // 
            // clupStatusIcon
            // 
            this.clupStatusIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clupStatusIcon.Location = new System.Drawing.Point(141, 40);
            this.clupStatusIcon.Name = "clupStatusIcon";
            this.clupStatusIcon.Size = new System.Drawing.Size(61, 53);
            this.clupStatusIcon.TabIndex = 4;
            this.clupStatusIcon.TabStop = false;
            // 
            // serviceStatusIcon
            // 
            this.serviceStatusIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.serviceStatusIcon.Location = new System.Drawing.Point(30, 40);
            this.serviceStatusIcon.Name = "serviceStatusIcon";
            this.serviceStatusIcon.Size = new System.Drawing.Size(61, 53);
            this.serviceStatusIcon.TabIndex = 3;
            this.serviceStatusIcon.TabStop = false;
            // 
            // fidoButton
            // 
            this.fidoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fidoButton.Location = new System.Drawing.Point(233, 97);
            this.fidoButton.Name = "fidoButton";
            this.fidoButton.Size = new System.Drawing.Size(109, 40);
            this.fidoButton.TabIndex = 2;
            this.fidoButton.Text = "FIDO";
            this.fidoTip.SetToolTip(this.fidoButton, "FIDO is a service closely related to CLUP. If this is not running\r\nCLUP will not " + "update and Client Update will not work. \r\nThis service doesn\'t usually have prob" + "lems. ");
            this.fidoButton.UseVisualStyleBackColor = false;
            this.fidoButton.Click += new System.EventHandler(this.fidoButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baldoLocalButton);
            this.groupBox2.Controls.Add(this.rootElementButton);
            this.groupBox2.Controls.Add(this.wafButton);
            this.groupBox2.Controls.Add(this.apciFixButton);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(9, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 123);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TechTool Fixes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.apciFolderButton);
            this.groupBox3.Controls.Add(this.logFolderButton);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(9, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 84);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TechTool Folders";
            // 
            // servicesButton
            // 
            this.servicesButton.Location = new System.Drawing.Point(124, 29);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(109, 40);
            this.servicesButton.TabIndex = 13;
            this.servicesButton.Text = "Services";
            this.servicesButton.UseVisualStyleBackColor = true;
            this.servicesButton.Click += new System.EventHandler(this.servicesButton_Click);
            // 
            // systemInfoButton
            // 
            this.systemInfoButton.Location = new System.Drawing.Point(237, 29);
            this.systemInfoButton.Name = "systemInfoButton";
            this.systemInfoButton.Size = new System.Drawing.Size(109, 40);
            this.systemInfoButton.TabIndex = 14;
            this.systemInfoButton.Text = "System Info";
            this.systemInfoButton.UseVisualStyleBackColor = true;
            this.systemInfoButton.Click += new System.EventHandler(this.systemInfoButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.systemInfoButton);
            this.groupBox4.Controls.Add(this.servicesButton);
            this.groupBox4.Controls.Add(this.appwizButton);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(9, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 84);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "System Components";
            // 
            // serviceStatusTimer
            // 
            this.serviceStatusTimer.Tick += new System.EventHandler(this.serviceStatusTimer_Tick);
            // 
            // clupStatusTimer
            // 
            this.clupStatusTimer.Tick += new System.EventHandler(this.clupStatusTimer_Tick);
            // 
            // fidoStatusTimer
            // 
            this.fidoStatusTimer.Tick += new System.EventHandler(this.fidoStatusTimer_Tick);
            // 
            // techToolVersionLabel
            // 
            this.techToolVersionLabel.AutoSize = true;
            this.techToolVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techToolVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.techToolVersionLabel.Location = new System.Drawing.Point(7, 6);
            this.techToolVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.techToolVersionLabel.Name = "techToolVersionLabel";
            this.techToolVersionLabel.Size = new System.Drawing.Size(146, 18);
            this.techToolVersionLabel.TabIndex = 16;
            this.techToolVersionLabel.Text = "TechTool Version:";
            // 
            // QuickSupportLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(371, 507);
            this.Controls.Add(this.techToolVersionLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuickSupportLite";
            this.Text = "QuickSupport Lite";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fidoStatusIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clupStatusIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStatusIcon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bafButton;
        private System.Windows.Forms.Button clupButton;
        private System.Windows.Forms.Button apciFixButton;
        private System.Windows.Forms.Button wafButton;
        private System.Windows.Forms.Button rootElementButton;
        private System.Windows.Forms.Button baldoLocalButton;
        private System.Windows.Forms.Button logFolderButton;
        private System.Windows.Forms.Button apciFolderButton;
        private System.Windows.Forms.Button appwizButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox fidoStatusIcon;
        private System.Windows.Forms.PictureBox clupStatusIcon;
        private System.Windows.Forms.PictureBox serviceStatusIcon;
        private System.Windows.Forms.Button fidoButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button servicesButton;
        private System.Windows.Forms.Button systemInfoButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer serviceStatusTimer;
        private System.Windows.Forms.Timer clupStatusTimer;
        private System.Windows.Forms.Timer fidoStatusTimer;
        private System.Windows.Forms.Label techToolVersionLabel;
        private System.Windows.Forms.ToolTip bafTip;
        private System.Windows.Forms.ToolTip clupTip;
        private System.Windows.Forms.ToolTip fidoTip;
        private System.Windows.Forms.ToolTip apciResetTip;
        private System.Windows.Forms.ToolTip wafTip;
        private System.Windows.Forms.ToolTip rootElementTip;
        private System.Windows.Forms.ToolTip baldoLocalTip;
        private System.Windows.Forms.ToolTip apciFolderTip;
    }
}

