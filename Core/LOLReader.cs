/*
 * Created by SharpDevelop.
 * User: Noctis
 * Date: 10.09.2014
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace League_Of_Legends.Core
{
	/// <summary>
	/// Description of LOLReader.
	/// </summary>
	public class LOLReader
	{
		private string SystemPath = Environment.CurrentDirectory + "\\RADS\\system\\";
		private const string fileLocalName = "locale.CFG";
		private const string filesystemName = "system.CFG";
		private const string filelauncherName = "launcher.CFG";
		
		private string defaultLocale = "";
		private string defaultLanguage = "";
		
		public LOLReader()
		{
			readDefaultStrings();
		}
		
		public void acceptConfiguration(string RegionCode, string LanguageCode){
			
			//system.CFG
			if (File.Exists(SystemPath + filesystemName)) 
			{ 
			    string[] FileText = File.ReadAllLines(SystemPath + filesystemName); 
			    for(int i = 0; i<FileText.Length; i++ )
			    	if(FileText[i].StartsWith("Region"))
			    		FileText[i] = "Region = " + RegionCode;
				File.WriteAllLines(SystemPath + filesystemName, FileText);
			}
			
			//locale.CFG
			if (File.Exists(SystemPath + fileLocalName)) 
			{ 
			    string[] FileText = File.ReadAllLines(SystemPath + fileLocalName); 
			    for(int i = 0; i<FileText.Length; i++ )
			    	if(FileText[i].StartsWith("locale"))
			    		FileText[i] = "locale = " + LanguageCode;
				File.WriteAllLines(SystemPath + fileLocalName, FileText);
			}
			
			//launcher.CFG
			if (File.Exists(SystemPath + filelauncherName)) 
			{ 
			    string[] FileText = File.ReadAllLines(SystemPath + filelauncherName); 
			    for(int i = 0; i<FileText.Length; i++ )
			    	if(FileText[i].StartsWith("airConfigProject")){
			    	if(RegionCode == "RU")
			    		FileText[i] = "airConfigProject = lol_air_client_config_ru";
			    	else if(RegionCode == "EUW")
			    		FileText[i] = "airConfigProject = lol_air_client_config_euw";
			    	else if(RegionCode == "NA")
			    		FileText[i] = "airConfigProject = lol_air_client_config_na";
			    }
				File.WriteAllLines(SystemPath + filelauncherName, FileText);
			}
		}
		
		private void readDefaultStrings(){
			if(File.Exists(SystemPath + filesystemName)){
				try {                                  //чтение файла
	                string[] allText = File.ReadAllLines(SystemPath + filesystemName);
	                defaultLocale = ScanLocale(allText);
	            } catch (FileNotFoundException e) {
					System.Windows.Forms.MessageBox.Show("Ошибка чтения файла, возможно он открыт в другой программе. Error: "+e.Message);
	            } 
			}else{
				System.Windows.Forms.MessageBox.Show("Файл локализации не найден");
			}
			if(File.Exists(SystemPath + filesystemName)){
				try {                                  //чтение файла
	                string[] allText = File.ReadAllLines(SystemPath + fileLocalName);
	                defaultLanguage = ScanLanguage(allText);
	            } catch (FileNotFoundException e) {
					System.Windows.Forms.MessageBox.Show("Ошибка чтения файла, возможно он открыт в другой программе. Error: "+e.Message);
	            } 
			}else{
				System.Windows.Forms.MessageBox.Show("Файл языка не найден");
			}
		}
		
		private string ScanLocale(string[] StringText){
			string ReturnString = "";
			bool swch = false;
			foreach (string s in StringText) {
				if(s.StartsWith("Region")){
					for(int i = 6; i<s.Length; i++){
						if(swch){
							if(s[i] != ' ')
								ReturnString+=s[i];
						}
						if(s[i] == '=' && swch == false){
							swch = !swch;
						}
					}
				}
			}
			return ReturnString;
		}
		
		private string ScanLanguage(string[] StringText){
			string ReturnString = "";
			bool swch = false;
			foreach (string s in StringText) {
				if(s.StartsWith("locale")){
					for(int i = 6; i<s.Length; i++){
						if(swch){
							if(s[i] != ' ')
								ReturnString+=s[i];
						}
						if(s[i] == '=' && swch == false){
							swch = !swch;
						}
					}
				}
			}
			return ReturnString;
		}
		
		public string getDefaultLocale(){
			return this.defaultLocale;
		}
		
		public string getDefaultLanguage(){
			return this.defaultLanguage;
		}
	}
}
