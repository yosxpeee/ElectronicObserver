﻿namespace ElectronicObserver.Window.Dialog
{
	partial class DialogVersion
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
            this.TextVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextAuthor = new System.Windows.Forms.LinkLabel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextInformation = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLastUpdate = new System.Windows.Forms.Label();
            this.TextInformation2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextVersion
            // 
            this.TextVersion.AutoSize = true;
            this.TextVersion.Location = new System.Drawing.Point(127, 10);
            this.TextVersion.Margin = new System.Windows.Forms.Padding(3);
            this.TextVersion.Name = "TextVersion";
            this.TextVersion.Size = new System.Drawing.Size(208, 15);
            this.TextVersion.TabIndex = 1;
            this.TextVersion.Text = "試製七四式電子観測儀零型 (ver. 0.0)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original Version：";
            // 
            // TextAuthor
            // 
            this.TextAuthor.AutoSize = true;
            this.TextAuthor.Location = new System.Drawing.Point(73, 31);
            this.TextAuthor.Name = "TextAuthor";
            this.TextAuthor.Size = new System.Drawing.Size(55, 15);
            this.TextAuthor.TabIndex = 3;
            this.TextAuthor.TabStop = true;
            this.TextAuthor.Text = "Andante";
            this.TextAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TextAuthor_LinkClicked);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Location = new System.Drawing.Point(377, 127);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "閉じる";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextInformation
            // 
            this.TextInformation.AutoSize = true;
            this.TextInformation.Location = new System.Drawing.Point(12, 52);
            this.TextInformation.Name = "TextInformation";
            this.TextInformation.Size = new System.Drawing.Size(235, 15);
            this.TextInformation.TabIndex = 5;
            this.TextInformation.TabStop = true;
            this.TextInformation.Text = "http://electronicobserver.blog.fc2.com/";
            this.TextInformation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TextInformation_LinkClicked);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 2);
            this.label3.TabIndex = 6;
            // 
            // labelLastUpdate
            // 
            this.labelLastUpdate.AutoSize = true;
            this.labelLastUpdate.Location = new System.Drawing.Point(127, 78);
            this.labelLastUpdate.Name = "labelLastUpdate";
            this.labelLastUpdate.Size = new System.Drawing.Size(77, 15);
            this.labelLastUpdate.TabIndex = 7;
            this.labelLastUpdate.Text = "YYYYMMDD";
            // 
            // TextInformation2
            // 
            this.TextInformation2.AutoSize = true;
            this.TextInformation2.Location = new System.Drawing.Point(12, 122);
            this.TextInformation2.Name = "TextInformation2";
            this.TextInformation2.Size = new System.Drawing.Size(293, 15);
            this.TextInformation2.TabIndex = 9;
            this.TextInformation2.TabStop = true;
            this.TextInformation2.Text = "https://github.com/yosxpeee/ElectronicObserver";
            this.TextInformation2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TextInformation2_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "開発者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "改変者：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "ヨシヒロ＠パラオ泊地";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Forked Version：";
            // 
            // DialogVersion
            // 
            this.AcceptButton = this.ButtonClose;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(464, 162);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextInformation2);
            this.Controls.Add(this.labelLastUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextInformation);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.TextAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextVersion);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogVersion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "バージョン";
            this.Load += new System.EventHandler(this.DialogVersion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TextVersion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel TextAuthor;
		private System.Windows.Forms.Button ButtonClose;
		private System.Windows.Forms.LinkLabel TextInformation;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelLastUpdate;
		private System.Windows.Forms.LinkLabel TextInformation2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}