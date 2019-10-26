namespace DevtexGen
{
    partial class mainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.titleInputBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.programTitle = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.subtitleInputBox = new System.Windows.Forms.TextBox();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.finalTexture = new System.Windows.Forms.PictureBox();
            this.saveAsPngLink = new System.Windows.Forms.LinkLabel();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.finalTexturePanel = new System.Windows.Forms.Panel();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalTexture)).BeginInit();
            this.finalTexturePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleInputBox
            // 
            this.titleInputBox.Location = new System.Drawing.Point(13, 31);
            this.titleInputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleInputBox.Name = "titleInputBox";
            this.titleInputBox.Size = new System.Drawing.Size(510, 29);
            this.titleInputBox.TabIndex = 0;
            this.titleInputBox.TextChanged += new System.EventHandler(this.titleInputBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 21);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "• Title";
            // 
            // programTitle
            // 
            this.programTitle.AutoSize = true;
            this.programTitle.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.programTitle.Location = new System.Drawing.Point(5, 5);
            this.programTitle.Name = "programTitle";
            this.programTitle.Size = new System.Drawing.Size(205, 51);
            this.programTitle.TabIndex = 2;
            this.programTitle.Text = "DevtexGen";
            // 
            // formPanel
            // 
            this.formPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formPanel.Controls.Add(this.subtitleInputBox);
            this.formPanel.Controls.Add(this.subtitleLabel);
            this.formPanel.Controls.Add(this.titleInputBox);
            this.formPanel.Controls.Add(this.titleLabel);
            this.formPanel.Location = new System.Drawing.Point(-1, 63);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(543, 142);
            this.formPanel.TabIndex = 3;
            // 
            // subtitleInputBox
            // 
            this.subtitleInputBox.Location = new System.Drawing.Point(13, 94);
            this.subtitleInputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subtitleInputBox.Name = "subtitleInputBox";
            this.subtitleInputBox.Size = new System.Drawing.Size(510, 29);
            this.subtitleInputBox.TabIndex = 2;
            this.subtitleInputBox.TextChanged += new System.EventHandler(this.subtitleInputBox_TextChanged);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Location = new System.Drawing.Point(12, 71);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(74, 21);
            this.subtitleLabel.TabIndex = 3;
            this.subtitleLabel.Text = "• Subtitle";
            // 
            // finalTexture
            // 
            this.finalTexture.Image = global::DevtexGen.Properties.Resources.template;
            this.finalTexture.Location = new System.Drawing.Point(0, 0);
            this.finalTexture.Name = "finalTexture";
            this.finalTexture.Size = new System.Drawing.Size(512, 512);
            this.finalTexture.TabIndex = 4;
            this.finalTexture.TabStop = false;
            this.finalTexture.Paint += new System.Windows.Forms.PaintEventHandler(this.finalTexture_Paint);
            // 
            // saveAsPngLink
            // 
            this.saveAsPngLink.AutoSize = true;
            this.saveAsPngLink.Location = new System.Drawing.Point(425, 9);
            this.saveAsPngLink.Name = "saveAsPngLink";
            this.saveAsPngLink.Size = new System.Drawing.Size(108, 21);
            this.saveAsPngLink.TabIndex = 5;
            this.saveAsPngLink.TabStop = true;
            this.saveAsPngLink.Text = "Save as *.PNG";
            this.saveAsPngLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveAsPngLink_LinkClicked);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "*.png|*.png";
            this.saveDialog.Title = "*.PNG";
            this.saveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDialog_FileOk);
            // 
            // finalTexturePanel
            // 
            this.finalTexturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalTexturePanel.Controls.Add(this.finalTexture);
            this.finalTexturePanel.Location = new System.Drawing.Point(10, 218);
            this.finalTexturePanel.Name = "finalTexturePanel";
            this.finalTexturePanel.Size = new System.Drawing.Size(514, 514);
            this.finalTexturePanel.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 744);
            this.Controls.Add(this.finalTexturePanel);
            this.Controls.Add(this.saveAsPngLink);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.programTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "DevtexGen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalTexture)).EndInit();
            this.finalTexturePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleInputBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label programTitle;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.TextBox subtitleInputBox;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.PictureBox finalTexture;
        private System.Windows.Forms.LinkLabel saveAsPngLink;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.Panel finalTexturePanel;
    }
}

