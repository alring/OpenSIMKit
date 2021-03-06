﻿namespace SimKit.UserInterface
{
    partial class MainApplicationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplicationWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label4 = new System.Windows.Forms.Label();
            this.abayimaButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.socialHomeButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.socialTwitterButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.socialGithubButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.abayimaButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialHomeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialTwitterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialGithubButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(5, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open SIM Kit (OSK) is open source \r\nsoftware for editing the content of \r\nSIM car" +
    "ds.";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPanel.ForeColor = System.Drawing.Color.Gray;
            this.contentPanel.Location = new System.Drawing.Point(282, 110);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(500, 500);
            this.contentPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(118, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 82);
            this.label2.TabIndex = 8;
            this.label2.Text = "Open SIM Kit (OSK)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(41, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Connect with the OSK project";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(794, 622);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 22;
            this.lineShape2.X2 = 261;
            this.lineShape2.Y1 = 357;
            this.lineShape2.Y2 = 357;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 22;
            this.lineShape1.X2 = 261;
            this.lineShape1.Y1 = 228;
            this.lineShape1.Y2 = 228;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(45, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "News from the world of OSK";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // abayimaButton
            // 
            this.abayimaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abayimaButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.abayimaButton.DownImage = null;
            this.abayimaButton.HoverImage = null;
            this.abayimaButton.Location = new System.Drawing.Point(710, 12);
            this.abayimaButton.Name = "abayimaButton";
            this.abayimaButton.NormalImage = global::SimKit.Properties.Resources.app_abayima_logo;
            this.abayimaButton.Size = new System.Drawing.Size(72, 93);
            this.abayimaButton.TabIndex = 12;
            this.abayimaButton.TabStop = false;
            this.abayimaButton.Click += new System.EventHandler(this.abayimaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimKit.Properties.Resources.app_logo_large;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 93);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // socialHomeButton
            // 
            this.socialHomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialHomeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.socialHomeButton.DownImage = null;
            this.socialHomeButton.HoverImage = global::SimKit.Properties.Resources.app_button_social_home_over;
            this.socialHomeButton.Location = new System.Drawing.Point(58, 283);
            this.socialHomeButton.Name = "socialHomeButton";
            this.socialHomeButton.NormalImage = global::SimKit.Properties.Resources.app_button_social_home_out;
            this.socialHomeButton.Size = new System.Drawing.Size(50, 50);
            this.socialHomeButton.TabIndex = 5;
            this.socialHomeButton.TabStop = false;
            this.socialHomeButton.Click += new System.EventHandler(this.socialHomeButton_Click);
            // 
            // socialTwitterButton
            // 
            this.socialTwitterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialTwitterButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.socialTwitterButton.DownImage = null;
            this.socialTwitterButton.HoverImage = global::SimKit.Properties.Resources.app_button_social_twitter_over;
            this.socialTwitterButton.Location = new System.Drawing.Point(170, 283);
            this.socialTwitterButton.Name = "socialTwitterButton";
            this.socialTwitterButton.NormalImage = global::SimKit.Properties.Resources.app_button_social_twitter_out;
            this.socialTwitterButton.Size = new System.Drawing.Size(50, 50);
            this.socialTwitterButton.TabIndex = 4;
            this.socialTwitterButton.TabStop = false;
            this.socialTwitterButton.Click += new System.EventHandler(this.socialTwitterButton_Click);
            // 
            // socialGithubButton
            // 
            this.socialGithubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialGithubButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.socialGithubButton.DownImage = null;
            this.socialGithubButton.HoverImage = global::SimKit.Properties.Resources.app_button_social_github_over;
            this.socialGithubButton.Location = new System.Drawing.Point(114, 283);
            this.socialGithubButton.Name = "socialGithubButton";
            this.socialGithubButton.NormalImage = global::SimKit.Properties.Resources.app_button_social_github_out;
            this.socialGithubButton.Size = new System.Drawing.Size(50, 50);
            this.socialGithubButton.TabIndex = 2;
            this.socialGithubButton.TabStop = false;
            this.socialGithubButton.Click += new System.EventHandler(this.socialGithubButton_Click);
            // 
            // MainApplicationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 622);
            this.Controls.Add(this.abayimaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.socialHomeButton);
            this.Controls.Add(this.socialTwitterButton);
            this.Controls.Add(this.socialGithubButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApplicationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIM Kit - Turning the worlds feature phones into ereaders!";
            ((System.ComponentModel.ISupportInitialize)(this.abayimaButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialHomeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialTwitterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialGithubButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SIMKIT.UserInterface.CustomControls.ImageButton socialGithubButton;
        private SIMKIT.UserInterface.CustomControls.ImageButton socialTwitterButton;
        private SIMKIT.UserInterface.CustomControls.ImageButton socialHomeButton;
        private System.Windows.Forms.Panel contentPanel;
        private ContentPanels.WaitingContentPanel waitingContentPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label4;
        private SIMKIT.UserInterface.CustomControls.ImageButton abayimaButton;
    }
}