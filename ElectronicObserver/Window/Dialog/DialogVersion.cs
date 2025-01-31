﻿using ElectronicObserver.Resource;
using ElectronicObserver.Utility;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicObserver.Window.Dialog
{
	public partial class DialogVersion : Form
	{
		public DialogVersion()
		{
			InitializeComponent();

			TextVersion.Text = string.Format("{0} (ver. {1})", SoftwareInformation.VersionJapanese, SoftwareInformation.VersionEnglish);
		}

		private void TextAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://twitter.com/andanteyk");
		}

		private void ButtonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TextInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://electronicobserver.blog.fc2.com/");
		}

		private void TextInformation2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/yosxpeee/ElectronicObserver");
		}

		private void DialogVersion_Load(object sender, EventArgs e)
		{
			this.Icon = ResourceManager.Instance.AppIcon;

			//version.txtを読み取って設定
			StreamReader sr = new StreamReader("version.txt");

			sr.ReadLine(); //1行目は読み飛ばす
			labelLastUpdate.Text = sr.ReadLine();

			sr.Close();
		}
	}
}
