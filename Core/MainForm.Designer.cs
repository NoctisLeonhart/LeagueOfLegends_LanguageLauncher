/*
 * Created by SharpDevelop.
 * User: Noctis
 * Date: 10.09.2014
 * Time: 23:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace League_Of_Legends
{
	partial class MainForm
	{

		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.StartButton = new System.Windows.Forms.Button();
			this.RegionCB = new System.Windows.Forms.ComboBox();
			this.RegionLB = new System.Windows.Forms.Label();
			this.LanguageLB = new System.Windows.Forms.Label();
			this.LanguageCB = new System.Windows.Forms.ComboBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItemOpen = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.CloseBut = new System.Windows.Forms.Button();
			this.HideBut = new System.Windows.Forms.Button();
			this.runAdmonCB = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StartButton.Location = new System.Drawing.Point(53, 146);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(140, 36);
			this.StartButton.TabIndex = 0;
			this.StartButton.Text = "ЗАПУСК";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// RegionCB
			// 
			this.RegionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RegionCB.FormattingEnabled = true;
			this.RegionCB.Items.AddRange(new object[] {
									"Россия",
									"Западная Европа",
									"Северная Америка"});
			this.RegionCB.Location = new System.Drawing.Point(74, 49);
			this.RegionCB.Name = "RegionCB";
			this.RegionCB.Size = new System.Drawing.Size(136, 21);
			this.RegionCB.TabIndex = 1;
			// 
			// RegionLB
			// 
			this.RegionLB.AutoSize = true;
			this.RegionLB.BackColor = System.Drawing.Color.Transparent;
			this.RegionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RegionLB.ForeColor = System.Drawing.Color.Transparent;
			this.RegionLB.Location = new System.Drawing.Point(12, 50);
			this.RegionLB.Name = "RegionLB";
			this.RegionLB.Size = new System.Drawing.Size(58, 15);
			this.RegionLB.TabIndex = 3;
			this.RegionLB.Text = "Регион:";
			// 
			// LanguageLB
			// 
			this.LanguageLB.AutoSize = true;
			this.LanguageLB.BackColor = System.Drawing.Color.Transparent;
			this.LanguageLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LanguageLB.ForeColor = System.Drawing.Color.Transparent;
			this.LanguageLB.Location = new System.Drawing.Point(23, 77);
			this.LanguageLB.Name = "LanguageLB";
			this.LanguageLB.Size = new System.Drawing.Size(45, 15);
			this.LanguageLB.TabIndex = 4;
			this.LanguageLB.Text = "Язык:";
			// 
			// LanguageCB
			// 
			this.LanguageCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LanguageCB.FormattingEnabled = true;
			this.LanguageCB.Items.AddRange(new object[] {
									"Русский",
									"Английский"});
			this.LanguageCB.Location = new System.Drawing.Point(74, 76);
			this.LanguageCB.Name = "LanguageCB";
			this.LanguageCB.Size = new System.Drawing.Size(136, 21);
			this.LanguageCB.TabIndex = 5;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenu = this.contextMenu1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "League Of Legends";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
									this.menuItemOpen,
									this.menuItemExit});
			// 
			// menuItemOpen
			// 
			this.menuItemOpen.Index = 0;
			this.menuItemOpen.Text = "O&pen";
			this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
			// 
			// menuItemExit
			// 
			this.menuItemExit.Index = 1;
			this.menuItemExit.Text = "E&xit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// CloseBut
			// 
			this.CloseBut.Location = new System.Drawing.Point(211, 0);
			this.CloseBut.Name = "CloseBut";
			this.CloseBut.Size = new System.Drawing.Size(25, 21);
			this.CloseBut.TabIndex = 6;
			this.CloseBut.Text = "X";
			this.CloseBut.UseVisualStyleBackColor = true;
			this.CloseBut.Click += new System.EventHandler(this.CloseClick);
			// 
			// HideBut
			// 
			this.HideBut.Location = new System.Drawing.Point(185, 0);
			this.HideBut.Name = "HideBut";
			this.HideBut.Size = new System.Drawing.Size(25, 21);
			this.HideBut.TabIndex = 7;
			this.HideBut.Text = "_";
			this.HideBut.UseVisualStyleBackColor = true;
			this.HideBut.Click += new System.EventHandler(this.HideButClick);
			// 
			// runAdmonCB
			// 
			this.runAdmonCB.BackColor = System.Drawing.Color.Transparent;
			this.runAdmonCB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.runAdmonCB.Location = new System.Drawing.Point(99, 100);
			this.runAdmonCB.Name = "runAdmonCB";
			this.runAdmonCB.Size = new System.Drawing.Size(111, 40);
			this.runAdmonCB.TabIndex = 8;
			this.runAdmonCB.Text = "Запуск от имени администратора";
			this.runAdmonCB.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(240, 196);
			this.Controls.Add(this.runAdmonCB);
			this.Controls.Add(this.HideBut);
			this.Controls.Add(this.CloseBut);
			this.Controls.Add(this.LanguageCB);
			this.Controls.Add(this.LanguageLB);
			this.Controls.Add(this.RegionLB);
			this.Controls.Add(this.RegionCB);
			this.Controls.Add(this.StartButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "League Of Legends";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox runAdmonCB;
		private System.Windows.Forms.MenuItem menuItemOpen;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.Button HideBut;
		private System.Windows.Forms.Button CloseBut;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ComboBox LanguageCB;
		private System.Windows.Forms.Label LanguageLB;
		private System.Windows.Forms.Label RegionLB;
		private System.Windows.Forms.ComboBox RegionCB;
		private System.Windows.Forms.Button StartButton;
	}
}
