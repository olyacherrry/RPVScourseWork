﻿namespace CurceRPVS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrafMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingGrafMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGraf = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.параметрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.свойствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.phisicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelGraf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phisicsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.видToolStripMenuItem,
            this.импортToolStripMenuItem,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingMenu,
            this.toolStripSeparator1,
            this.closeMenu});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // settingMenu
            // 
            this.settingMenu.Name = "settingMenu";
            this.settingMenu.Size = new System.Drawing.Size(134, 22);
            this.settingMenu.Text = "Настройки";
            this.settingMenu.Click += new System.EventHandler(this.settingMenu_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(134, 22);
            this.closeMenu.Text = "Выход";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrafMenu,
            this.TableMenu});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // GrafMenu
            // 
            this.GrafMenu.CheckOnClick = true;
            this.GrafMenu.Name = "GrafMenu";
            this.GrafMenu.Size = new System.Drawing.Size(121, 22);
            this.GrafMenu.Text = "График";
            this.GrafMenu.Click += new System.EventHandler(this.GrafMenu_Click);
            // 
            // TableMenu
            // 
            this.TableMenu.CheckOnClick = true;
            this.TableMenu.Name = "TableMenu";
            this.TableMenu.Size = new System.Drawing.Size(121, 22);
            this.TableMenu.Text = "Таблица";
            this.TableMenu.Click += new System.EventHandler(this.TableMenu_Click);
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelMenu});
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.импортToolStripMenuItem.Text = "Импорт";
            // 
            // ExcelMenu
            // 
            this.ExcelMenu.Name = "ExcelMenu";
            this.ExcelMenu.Size = new System.Drawing.Size(100, 22);
            this.ExcelMenu.Text = "Excel";
            this.ExcelMenu.Click += new System.EventHandler(this.ExcelMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem,
            this.SettingGrafMenu,
            this.очиститьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 70);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.optoinsMenu_Click);
            // 
            // SettingGrafMenu
            // 
            this.SettingGrafMenu.Name = "SettingGrafMenu";
            this.SettingGrafMenu.Size = new System.Drawing.Size(138, 22);
            this.SettingGrafMenu.Text = "Свойства";
            this.SettingGrafMenu.Click += new System.EventHandler(this.settingMenu_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.clearMenu_Click);
            // 
            // panelGraf
            // 
            this.panelGraf.Controls.Add(this.chart1);
            this.panelGraf.Location = new System.Drawing.Point(359, 30);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(429, 228);
            this.panelGraf.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.MaximumAutoSize = 0F;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(762, 395);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dataGridView1);
            this.panelTable.Location = new System.Drawing.Point(12, 27);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(341, 230);
            this.panelTable.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(329, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem1,
            this.свойствоToolStripMenuItem,
            this.UpdateMenu,
            this.ClearTableMenu});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(139, 92);
            // 
            // параметрыToolStripMenuItem1
            // 
            this.параметрыToolStripMenuItem1.Name = "параметрыToolStripMenuItem1";
            this.параметрыToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.параметрыToolStripMenuItem1.Text = "Параметры";
            this.параметрыToolStripMenuItem1.Click += new System.EventHandler(this.optoinsMenu_Click);
            // 
            // свойствоToolStripMenuItem
            // 
            this.свойствоToolStripMenuItem.Name = "свойствоToolStripMenuItem";
            this.свойствоToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.свойствоToolStripMenuItem.Text = "Свойство";
            this.свойствоToolStripMenuItem.Click += new System.EventHandler(this.settingMenu_Click);
            // 
            // UpdateMenu
            // 
            this.UpdateMenu.Name = "UpdateMenu";
            this.UpdateMenu.Size = new System.Drawing.Size(138, 22);
            this.UpdateMenu.Text = "Обновить";
            this.UpdateMenu.Click += new System.EventHandler(this.UpdateMenu_Click);
            // 
            // ClearTableMenu
            // 
            this.ClearTableMenu.Name = "ClearTableMenu";
            this.ClearTableMenu.Size = new System.Drawing.Size(138, 22);
            this.ClearTableMenu.Text = "Очистить";
            this.ClearTableMenu.Click += new System.EventHandler(this.ClearTableMenu_Click);
            // 
            // phisicsBindingSource
            // 
            this.phisicsBindingSource.DataSource = typeof(CurceRPVS.Model.Phisics);
            // 
            // HelpMenu
            // 
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(68, 20);
            this.HelpMenu.Text = "Помощь";
            this.HelpMenu.Click += new System.EventHandler(this.HelpMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelGraf);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Курсовой проект";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelGraf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phisicsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExcelMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingGrafMenu;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GrafMenu;
        private System.Windows.Forms.ToolStripMenuItem TableMenu;
        private System.Windows.Forms.Panel panelGraf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource phisicsBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem свойствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearTableMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
    }
}

