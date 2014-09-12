/*
 * Сделано в SharpDevelop.
 * Пользователь: Noctis
 * Дата: 11.09.2014
 * Время: 17:10
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Diagnostics;
using System.Timers;

namespace League_Of_Legends.Core
{
	/// <summary>
	/// Description of ProcessChecker.
	/// </summary>
	public class ProcessChecker
	{
		private Process[] LOLProcess;
			
		public ProcessChecker()
		{
		}
		
		public bool IsProcessOpen(string ProcessName){
			LOLProcess = Process.GetProcessesByName(ProcessName);
			if(LOLProcess.Length>0)
				return true;
			else
				return false;
		}
		
		public bool ThisProcessIsOpen(){
			LOLProcess = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
			if(LOLProcess.Length>1)
				return true;
			else
				return false;
		}
		
		public void KillHimself(){
			try{Process.GetProcessById(Process.GetCurrentProcess().Id).Kill();}catch(Exception ex){}
		}
	}
}
