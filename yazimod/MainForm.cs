/*
 * Developer: Muzaffer
 * Date: 17.10.2016
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms;

namespace yazimod
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Wisp\Touch", true);
		string ctrl;
		
		void Button1Click(object sender, EventArgs e)
		{
			if(ctrl!="0"){
				try{
				rkey2.SetValue("TouchMode_hold", 00000000);
				}catch{
					MessageBox.Show("Hata Kodu : 1111","HATA");
				}
				
			}else{
				try{
				rkey2.SetValue("TouchMode_hold", 00000001);
				}catch{
					MessageBox.Show("Hata Kodu : 1111","HATA");
				}
			}
			kontrol();
		
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			kontrol();

		}
		void kontrol(){
			try{ctrl =	rkey2.GetValue("TouchMode_hold").ToString();
			if(ctrl!="0"){
					button1.Text="Enabled";
					button1.BackColor=Color.LawnGreen;
					button1.ForeColor=Color.Black;
				}else{
					button1.Text="Disabled";
					button1.BackColor=Color.Red;
					button1.ForeColor=Color.White;
				}
			}catch{
					button1.Text="Disabled";
			}
		}
	}
}
