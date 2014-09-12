/*
 * Created by SharpDevelop.
 * User: Noctis
 * Date: 10.09.2014
 * Time: 23:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using League_Of_Legends.Core;

namespace League_Of_Legends
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private static Timer LOLProcessTimer = new Timer();
		private LOLReader lolreader = new LOLReader();
		private static ProcessChecker LOLProcess = new ProcessChecker();
		private const string LOLProcessName = "LoLLauncher";
				
		public MainForm()
		{
			ThisProcessCheck();
			InitializeComponent();
			loadDefaultSettings();
		}	
		
		private void ThisProcessCheck(){
			if(LOLProcess.ThisProcessIsOpen()){
				MessageBox.Show("League Of Legends Language Launcher уже запущен, проверьте трей");
				LOLProcess.KillHimself();
			}
				
		}
		
		private void loadDefaultSettings(){
			this.RegionCB.Text = SelectDefaultRegion(lolreader.getDefaultLocale());
			this.LanguageCB.Text = SelectDefaultLanguage(lolreader.getDefaultLanguage());
			LOLProcessTimer.Tick += new EventHandler(TimerEventProcessor);
			LOLProcessTimer.Interval = 500;
		}
		
		private void TimerEventProcessor(Object myObject, EventArgs myEventArgs){
			if(!LOLProcess.IsProcessOpen(LOLProcessName)){
				ShowLauncher();
				LOLProcessTimer.Stop();
			}
		}
		
		private string SelectDefaultRegion(string regionCode){
			string returnString = "";
			if(regionCode == "RU")
				returnString = "Россия";
			else if(regionCode == "EUW")
				returnString = "Западная Европа";
			else if(regionCode == "NA")
				returnString = "Северная Америка";
			return returnString;
		}
		
		private string SelectDefaultLanguage(string LanguageCode){
			string returnString = "";
			if(LanguageCode == "ru_ru")
				returnString = "Русский";
			else if(LanguageCode == "en_gb" || LanguageCode == "en_us" )
				returnString = "Английский";
			return returnString;	
		}
		
		private string SelectRegion(string regionName){
			string returnString = "EUW";
			if(regionName == "Россия")
				returnString = "RU";
			else if(regionName == "Западная Европа")
				returnString = "EUW";
			else if(regionName == "Северная Америка")
				returnString = "NA";
			return returnString;		
		}
		
		private string SelectLanguage(string regionName, string LanguageName){
			string returnString = "ru_ru";
			if(LanguageName == "Русский")
				returnString = "ru_ru";
			else if(LanguageName == "Английский" && regionName == "Россия")
				returnString = "en_us";
			else if(LanguageName == "Английский" && regionName == "Западная Европа")
				returnString = "en_gb";
			else if(LanguageName == "Английский"  && regionName == "Северная Америка")
				returnString = "en_us";
			return returnString;	
		}
		
		void StartButtonClick(object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			this.ShowInTaskbar = false; 
		    notifyIcon1.Visible = true; 
			lolreader.acceptConfiguration(SelectRegion(RegionCB.Text), SelectLanguage(RegionCB.Text,LanguageCB.Text));
			try{
			if(runAdmonCB.Checked)
				System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\lol.launcher.admin.exe");
			else
				System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\lol.launcher.exe");
			for(int i = 0; i<4; i++){
				if(LOLProcess.IsProcessOpen(LOLProcessName))
					break;
				System.Threading.Thread.Sleep(1000);
			}
			LOLProcessTimer.Start();
			}catch(Exception exc){ShowLauncher();}
		}
						
		private void NotifyIcon1_MouseClick(Object sender, MouseEventArgs e)
		{
			ShowLauncher();
		}
		
		private void CloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void HideButClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;		
			this.ShowInTaskbar = false; 
		    notifyIcon1.Visible = true; 
		}
		
		private void menuItemExit_Click(object sender, EventArgs e){
			this.Close();
		}
		
		private void menuItemOpen_Click(object sender, EventArgs e){
			ShowLauncher();
		}
		
		private void ShowLauncher(){
			if (this.WindowState == FormWindowState.Minimized)
		    { 
		       this.WindowState = FormWindowState.Normal; 
		       this.ShowInTaskbar = true; 
		       notifyIcon1.Visible = false; 
		    } 
		}
	}
}
