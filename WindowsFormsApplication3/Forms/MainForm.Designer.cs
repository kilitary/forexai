﻿namespace FinancePermutator.Forms
{
     using System.ComponentModel;
     using System.Windows.Forms;
     using System.Windows.Forms.DataVisualization.Charting;

     partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.loadPricesButton = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.showValues = new System.Windows.Forms.CheckBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.minSavePercTextBox = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.configurationTab = new System.Windows.Forms.TextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.statsBox = new System.Windows.Forms.RichTextBox();
			this.statusLabel = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonExecute = new System.Windows.Forms.Button();
			this.loadTAButton = new System.Windows.Forms.Button();
			this.timeFast = new System.Windows.Forms.Timer(this.components);
			this.debugView = new System.Windows.Forms.ListBox();
			this.funcListLabel = new System.Windows.Forms.TextBox();
			this.nodelayCheckbox = new System.Windows.Forms.CheckBox();
			this.mainProgressBar = new System.Windows.Forms.ProgressBar();
			this.listTrain = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// loadPricesButton
			// 
			this.loadPricesButton.AllowDrop = true;
			this.loadPricesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.loadPricesButton.BackColor = System.Drawing.SystemColors.Menu;
			this.loadPricesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.loadPricesButton.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.loadPricesButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.loadPricesButton.FlatAppearance.BorderSize = 2;
			this.loadPricesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.loadPricesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
			this.loadPricesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.loadPricesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadPricesButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loadPricesButton.ForeColor = System.Drawing.Color.Navy;
			this.loadPricesButton.Location = new System.Drawing.Point(723, 28);
			this.loadPricesButton.Margin = new System.Windows.Forms.Padding(7);
			this.loadPricesButton.Name = "loadPricesButton";
			this.loadPricesButton.Size = new System.Drawing.Size(103, 30);
			this.loadPricesButton.TabIndex = 0;
			this.loadPricesButton.Text = "load prices";
			this.loadPricesButton.UseVisualStyleBackColor = false;
			this.loadPricesButton.Click += new System.EventHandler(this.LoadPricesButtonClick);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon1.BalloonTipText = "ef vf df dd fg";
			this.notifyIcon1.BalloonTipTitle = "d gfhth rhgh";
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayClick);
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
			// 
			// showValues
			// 
			this.showValues.AutoSize = true;
			this.showValues.BackColor = System.Drawing.Color.RoyalBlue;
			this.showValues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.showValues.Cursor = System.Windows.Forms.Cursors.Hand;
			this.showValues.ForeColor = System.Drawing.Color.OldLace;
			this.showValues.Location = new System.Drawing.Point(143, 24);
			this.showValues.Margin = new System.Windows.Forms.Padding(0);
			this.showValues.Name = "showValues";
			this.showValues.Size = new System.Drawing.Size(83, 20);
			this.showValues.TabIndex = 1;
			this.showValues.Text = "showValues";
			this.showValues.UseVisualStyleBackColor = false;
			this.showValues.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(1, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(9);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(9, 3);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(720, 464);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage1.Controls.Add(this.chart);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(712, 435);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Preload";
			// 
			// chart
			// 
			lineAnnotation2.Name = "LineAnnotation1";
			this.chart.Annotations.Add(lineAnnotation2);
			this.chart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
			this.chart.BackColor = System.Drawing.Color.Ivory;
			this.chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
			this.chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.chart.BackImage = "G:\\Pics\\WP.png";
			this.chart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
			this.chart.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.chart.BackSecondaryColor = System.Drawing.Color.Silver;
			this.chart.BorderlineColor = System.Drawing.Color.Coral;
			this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
			this.chart.BorderSkin.BackColor = System.Drawing.Color.Maroon;
			this.chart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.chart.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
			this.chart.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
			this.chart.BorderSkin.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.chart.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.chart.BorderSkin.BorderColor = System.Drawing.Color.MediumBlue;
			this.chart.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
			this.chart.BorderSkin.BorderWidth = 3;
			this.chart.BorderSkin.PageColor = System.Drawing.Color.Turquoise;
			this.chart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea2.Area3DStyle.IsRightAngleAxes = false;
			chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			chartArea2.Area3DStyle.WallWidth = 0;
			chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
			chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea2.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
			chartArea2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
			chartArea2.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea2);
			this.chart.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.chart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			legend2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
			legend2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			legend2.BorderWidth = 5;
			legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			legend2.IsTextAutoFit = false;
			legend2.Name = "xxx";
			legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chart.Legends.Add(legend2);
			this.chart.Location = new System.Drawing.Point(-2, 6);
			this.chart.Margin = new System.Windows.Forms.Padding(0);
			this.chart.Name = "chart";
			this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "xxx";
			series2.Name = "Series1";
			series2.YValuesPerPoint = 6;
			this.chart.Series.Add(series2);
			this.chart.Size = new System.Drawing.Size(717, 432);
			this.chart.TabIndex = 5;
			this.chart.Text = "chart1";
			this.chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
			title2.Name = "Title1";
			this.chart.Titles.Add(title2);
			this.chart.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.Chart_PostPaint);
			this.chart.Click += new System.EventHandler(this.ChartClick);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage2.Controls.Add(this.minSavePercTextBox);
			this.tabPage2.Controls.Add(this.showValues);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(712, 435);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "options";
			// 
			// minSavePercTextBox
			// 
			this.minSavePercTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.minSavePercTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.minSavePercTextBox.Cursor = System.Windows.Forms.Cursors.UpArrow;
			this.minSavePercTextBox.ForeColor = System.Drawing.SystemColors.Info;
			this.minSavePercTextBox.Location = new System.Drawing.Point(143, 54);
			this.minSavePercTextBox.Name = "minSavePercTextBox";
			this.minSavePercTextBox.Size = new System.Drawing.Size(100, 20);
			this.minSavePercTextBox.TabIndex = 2;
			this.minSavePercTextBox.Text = "86";
			this.minSavePercTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Maroon;
			this.tabPage3.Controls.Add(this.configurationTab);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(712, 435);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "configuration";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// configurationTab
			// 
			this.configurationTab.AcceptsReturn = true;
			this.configurationTab.AcceptsTab = true;
			this.configurationTab.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
			this.configurationTab.BackColor = System.Drawing.Color.LightSteelBlue;
			this.configurationTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.configurationTab.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.configurationTab.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.configurationTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.configurationTab.Location = new System.Drawing.Point(0, 0);
			this.configurationTab.Margin = new System.Windows.Forms.Padding(0);
			this.configurationTab.Multiline = true;
			this.configurationTab.Name = "configurationTab";
			this.configurationTab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.configurationTab.Size = new System.Drawing.Size(598, 432);
			this.configurationTab.TabIndex = 0;
			this.configurationTab.Text = resources.GetString("configurationTab.Text");
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.CornflowerBlue;
			this.tabPage4.BackgroundImage = global::FinancePermutator.Properties.Resources.nuke;
			this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage4.Controls.Add(this.statsBox);
			this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage4.ForeColor = System.Drawing.SystemColors.Info;
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabPage4.Size = new System.Drawing.Size(712, 435);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "stats";
			// 
			// statsBox
			// 
			this.statsBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.statsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statsBox.ForeColor = System.Drawing.Color.Azure;
			this.statsBox.Location = new System.Drawing.Point(4, 3);
			this.statsBox.Name = "statsBox";
			this.statsBox.Size = new System.Drawing.Size(587, 424);
			this.statsBox.TabIndex = 0;
			this.statsBox.Text = "Networks done: 2\nSuccess: 0\nNumber of broken data: 3\nBad networks: 1";
			// 
			// statusLabel
			// 
			this.statusLabel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.statusLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.statusLabel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.statusLabel.Location = new System.Drawing.Point(10, 473);
			this.statusLabel.MaximumSize = new System.Drawing.Size(0, 19);
			this.statusLabel.MinimumSize = new System.Drawing.Size(800, 0);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(800, 19);
			this.statusLabel.TabIndex = 6;
			this.statusLabel.Text = "idle";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button3.FlatAppearance.BorderSize = 2;
			this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.Color.Navy;
			this.button3.Location = new System.Drawing.Point(723, 170);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(103, 35);
			this.button3.TabIndex = 4;
			this.button3.Text = "clear log";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.ExecuteButtonClick);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button2.FlatAppearance.BorderSize = 2;
			this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.Color.Navy;
			this.button2.Location = new System.Drawing.Point(723, 135);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "clear";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.CreateNetworkButtonClick);
			// 
			// buttonExecute
			// 
			this.buttonExecute.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonExecute.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonExecute.Enabled = false;
			this.buttonExecute.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttonExecute.FlatAppearance.BorderSize = 2;
			this.buttonExecute.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.buttonExecute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
			this.buttonExecute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExecute.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExecute.ForeColor = System.Drawing.Color.Navy;
			this.buttonExecute.Location = new System.Drawing.Point(723, 102);
			this.buttonExecute.Name = "buttonExecute";
			this.buttonExecute.Size = new System.Drawing.Size(103, 28);
			this.buttonExecute.TabIndex = 2;
			this.buttonExecute.Text = "execute";
			this.buttonExecute.UseVisualStyleBackColor = false;
			this.buttonExecute.Click += new System.EventHandler(this.GenerateTrainButtonClick);
			// 
			// loadTAButton
			// 
			this.loadTAButton.AllowDrop = true;
			this.loadTAButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.loadTAButton.BackColor = System.Drawing.SystemColors.Control;
			this.loadTAButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loadTAButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.loadTAButton.FlatAppearance.BorderSize = 2;
			this.loadTAButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.loadTAButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
			this.loadTAButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.loadTAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadTAButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loadTAButton.ForeColor = System.Drawing.Color.Navy;
			this.loadTAButton.Location = new System.Drawing.Point(723, 66);
			this.loadTAButton.Margin = new System.Windows.Forms.Padding(7);
			this.loadTAButton.Name = "loadTAButton";
			this.loadTAButton.Size = new System.Drawing.Size(103, 30);
			this.loadTAButton.TabIndex = 1;
			this.loadTAButton.Text = "load talib";
			this.loadTAButton.UseVisualStyleBackColor = false;
			this.loadTAButton.Click += new System.EventHandler(this.LoadTaLib);
			// 
			// timeFast
			// 
			this.timeFast.Enabled = true;
			this.timeFast.Interval = 150;
			this.timeFast.Tick += new System.EventHandler(this.TimeFastTick);
			// 
			// debugView
			// 
			this.debugView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.debugView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.debugView.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.debugView.Font = new System.Drawing.Font("DejaVu Sans Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.debugView.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.debugView.HorizontalScrollbar = true;
			this.debugView.ItemHeight = 11;
			this.debugView.Items.AddRange(new object[] {
            "Functions:",
            " Atan ",
            "  arg 0 startIdx: 0 ",
            "  arg 1 endIdx: 7 ",
            "  arg 2 inReal: System.Double[] %Close% 8",
            "  arg 3 outBegIdx: 0 ",
            "  arg 4 outNBElement: 0 ",
            "  arg 5 outReal: System.Double[] ",
            " Tan ",
            "  arg 0 startIdx: 0 ",
            "  arg 1 endIdx: 7 ",
            "  arg 2 inReal: System.Double[] %Open% 8",
            "  arg 3 outBegIdx: 0 ",
            "  arg 4 outNBElement: 0 ",
            "  arg 5 outReal: System.Double[] ",
            "",
            "InputDimension: 13"});
			this.debugView.Location = new System.Drawing.Point(829, 22);
			this.debugView.Margin = new System.Windows.Forms.Padding(0);
			this.debugView.Name = "debugView";
			this.debugView.ScrollAlwaysVisible = true;
			this.debugView.Size = new System.Drawing.Size(695, 431);
			this.debugView.TabIndex = 3;
			this.debugView.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DebugView_Draw);
			// 
			// funcListLabel
			// 
			this.funcListLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.funcListLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.funcListLabel.Cursor = System.Windows.Forms.Cursors.Default;
			this.funcListLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.funcListLabel.ForeColor = System.Drawing.Color.Blue;
			this.funcListLabel.Location = new System.Drawing.Point(611, 473);
			this.funcListLabel.Margin = new System.Windows.Forms.Padding(0);
			this.funcListLabel.MaximumSize = new System.Drawing.Size(800, 999);
			this.funcListLabel.MinimumSize = new System.Drawing.Size(800, 12);
			this.funcListLabel.Name = "funcListLabel";
			this.funcListLabel.Size = new System.Drawing.Size(800, 15);
			this.funcListLabel.TabIndex = 5;
			this.funcListLabel.Text = "conmtraimer";
			this.funcListLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.funcListLabel.WordWrap = false;
			// 
			// nodelayCheckbox
			// 
			this.nodelayCheckbox.AutoSize = true;
			this.nodelayCheckbox.Checked = true;
			this.nodelayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.nodelayCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nodelayCheckbox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nodelayCheckbox.Location = new System.Drawing.Point(733, 211);
			this.nodelayCheckbox.Name = "nodelayCheckbox";
			this.nodelayCheckbox.Size = new System.Drawing.Size(65, 20);
			this.nodelayCheckbox.TabIndex = 6;
			this.nodelayCheckbox.Text = "no delay";
			this.nodelayCheckbox.UseVisualStyleBackColor = true;
			// 
			// mainProgressBar
			// 
			this.mainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mainProgressBar.BackColor = System.Drawing.SystemColors.Info;
			this.mainProgressBar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.mainProgressBar.Location = new System.Drawing.Point(829, 453);
			this.mainProgressBar.Margin = new System.Windows.Forms.Padding(0);
			this.mainProgressBar.Name = "mainProgressBar";
			this.mainProgressBar.Size = new System.Drawing.Size(695, 20);
			this.mainProgressBar.Step = 1;
			this.mainProgressBar.TabIndex = 7;
			this.mainProgressBar.Click += new System.EventHandler(this.mainProgressBar_Click);
			// 
			// listTrain
			// 
			this.listTrain.AllowDrop = true;
			this.listTrain.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.listTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listTrain.ColumnWidth = 33;
			this.listTrain.ForeColor = System.Drawing.Color.Red;
			this.listTrain.FormattingEnabled = true;
			this.listTrain.Items.AddRange(new object[] {
            "sarprop",
            "quickprop",
            "rprop"});
			this.listTrain.Location = new System.Drawing.Point(724, 296);
			this.listTrain.Name = "listTrain";
			this.listTrain.Size = new System.Drawing.Size(102, 93);
			this.listTrain.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoEllipsis = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DeepPink;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Location = new System.Drawing.Point(718, 420);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 32);
			this.label3.TabIndex = 9;
			this.label3.Text = "sarTemp";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FinancePermutator.Properties.Resources._39;
			this.pictureBox1.Location = new System.Drawing.Point(760, 391);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 26);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.BackgroundImage = global::FinancePermutator.Properties.Resources.nicebg;
			this.ClientSize = new System.Drawing.Size(1533, 500);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listTrain);
			this.Controls.Add(this.mainProgressBar);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.nodelayCheckbox);
			this.Controls.Add(this.funcListLabel);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.debugView);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonExecute);
			this.Controls.Add(this.loadPricesButton);
			this.Controls.Add(this.loadTAButton);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.Resize += new System.EventHandler(this.Form1Resize);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        public System.Windows.Forms.ListBox listTrain;

        #endregion

        public Button loadPricesButton;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        public CheckBox showValues;
        public TabControl tabControl1;
        public TabPage tabPage1;
        public TabPage tabPage2;
        public Button loadTAButton;
        public System.Windows.Forms.Timer timeFast;
        public Button button2;
        public Button buttonExecute;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public TabPage tabPage3;
        public System.Windows.Forms.ListBox debugView;
        public TextBox funcListLabel;
        public Label statusLabel;
        public TextBox configurationTab;
        public CheckBox nodelayCheckbox;
        public TabPage tabPage4;
        public RichTextBox statsBox;
        public System.Windows.Forms.ProgressBar mainProgressBar;
        public TextBox minSavePercTextBox;
		public Label label3;
		private PictureBox pictureBox1;
	}
}
