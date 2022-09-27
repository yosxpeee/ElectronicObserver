﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicObserver.Data;

namespace ElectronicObserver.Window.Dialog
{
	public partial class DialogChooseAirBase : Form
	{
		public int areaId = 0;

		public class AirBaseArea
		{
			public string AreaName { get; set; }
			public int AreaId { get; set; }

			public AirBaseArea(int v, string s)
			{
				AreaName = s;
				AreaId = v;
			}
		}

		public DialogChooseAirBase()
		{
			InitializeComponent();
		}

		private void DialogChooseAirBase_Shown(object sender, EventArgs e)
		{
			KCDatabase db = KCDatabase.Instance;
			List<AirBaseArea> src = new List<AirBaseArea>();

			src.Add(new AirBaseArea(0, "0:なし"));
			foreach (KeyValuePair<int, BaseAirCorpsData> corps in db.BaseAirCorps)
			{
				bool found = false;
				string areaName = KCDatabase.Instance.MapArea.ContainsKey(corps.Value.MapAreaID) ? KCDatabase.Instance.MapArea[corps.Value.MapAreaID].Name : "バミューダ海域";
				AirBaseArea item = new AirBaseArea(corps.Value.MapAreaID, corps.Value.MapAreaID + ":" + areaName);
				foreach (AirBaseArea a in src)
				{
					if(a.AreaId == item.AreaId)
					{
						found = true;
						break;
					}
				}
				if (found == false)
				{
					src.Add(item);
					//Console.WriteLine(item);
				}
			}
			ComboBox_ID.DataSource = src;
			ComboBox_ID.DisplayMember = "AreaName";
			ComboBox_ID.ValueMember = "AreaId";

			ComboBox_ID.SelectedIndex = 0;
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			//念のため0を入れておく
			areaId = 0;
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			areaId = (int)ComboBox_ID.SelectedValue;
		}
	}
}