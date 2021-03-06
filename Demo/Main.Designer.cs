﻿namespace Demo
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            Minimal.Components.Core.MComponent mComponent1 = new Minimal.Components.Core.MComponent();
            Minimal.Components.Core.MComponent mComponent9 = new Minimal.Components.Core.MComponent();
            Minimal.Components.Core.MComponent mComponent8 = new Minimal.Components.Core.MComponent();
            Minimal.Components.Core.MComponent mComponent7 = new Minimal.Components.Core.MComponent();
            Minimal.Components.Core.MComponent mComponent6 = new Minimal.Components.Core.MComponent();
            Minimal.Components.Core.MComponent mComponent4 = new Minimal.Components.Core.MComponent();
            Minimal.Components.Core.MComponent mComponent5 = new Minimal.Components.Core.MComponent();
            Minimal.Components.Core.MComponent mComponent3 = new Minimal.Components.Core.MComponent();
            Minimal.Components.Core.MComponent mComponent2 = new Minimal.Components.Core.MComponent();
            Minimal.Themes.Theme theme1 = new Minimal.Themes.Theme();
            Minimal.Themes.ThemeColor themeColor1 = new Minimal.Themes.ThemeColor();
            Minimal.Themes.ThemeColor themeColor2 = new Minimal.Themes.ThemeColor();
            Minimal.Themes.ThemeColor themeColor3 = new Minimal.Themes.ThemeColor();
            Minimal.Themes.ThemeColor themeColor4 = new Minimal.Themes.ThemeColor();
            Minimal.Themes.ThemeColor themeColor5 = new Minimal.Themes.ThemeColor();
            Minimal.Themes.ThemeColor themeColor6 = new Minimal.Themes.ThemeColor();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpuChart = new Minimal.Components.MChart();
            this.lbCpu = new Minimal.Components.MLabel();
            this.lbUsage = new Minimal.Components.MLabel();
            this.mLabel1 = new Minimal.Components.MLabel();
            this.mLabel2 = new Minimal.Components.MLabel();
            this.lbProcesses = new Minimal.Components.MLabel();
            this.lbThreads = new Minimal.Components.MLabel();
            this.mLabel4 = new Minimal.Components.MLabel();
            this.mLabel3 = new Minimal.Components.MLabel();
            this.mLabel5 = new Minimal.Components.MLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // cpuChart
            // 
            this.cpuChart.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.cpuChart.GridDimenstions = new System.Drawing.Size(20, 10);
            this.cpuChart.Location = new System.Drawing.Point(33, 177);
            this.cpuChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpuChart.Name = "cpuChart";
            this.cpuChart.Size = new System.Drawing.Size(1264, 455);
            this.cpuChart.TabIndex = 6;
            this.cpuChart.ValueDimensions = new System.Drawing.Size(20, 100);
            // 
            // lbCpu
            // 
            this.lbCpu.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.lbCpu.AutoSize = true;
            mComponent1.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            mComponent1.CustomTheme = null;
            mComponent1.Outdated = true;
            mComponent1.ParentForm = this;
            mComponent1.SourceTheme = theme1;
            this.lbCpu.Component = mComponent1;
            this.lbCpu.CustomTheme = null;
            this.lbCpu.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpu.Location = new System.Drawing.Point(18, 14);
            this.lbCpu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCpu.Name = "lbCpu";
            this.lbCpu.Size = new System.Drawing.Size(310, 86);
            this.lbCpu.TabIndex = 7;
            this.lbCpu.Text = "Processor";
            this.lbCpu.Type = Minimal.LabelType.Standard;
            // 
            // lbUsage
            // 
            this.lbUsage.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.lbUsage.AutoSize = true;
            mComponent9.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            mComponent9.CustomTheme = null;
            mComponent9.Outdated = true;
            mComponent9.ParentForm = this;
            mComponent9.SourceTheme = theme1;
            this.lbUsage.Component = mComponent9;
            this.lbUsage.CustomTheme = null;
            this.lbUsage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsage.Location = new System.Drawing.Point(39, 747);
            this.lbUsage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsage.Name = "lbUsage";
            this.lbUsage.Size = new System.Drawing.Size(93, 65);
            this.lbUsage.TabIndex = 10;
            this.lbUsage.Text = "0%";
            this.lbUsage.Type = Minimal.LabelType.Standard;
            // 
            // mLabel1
            // 
            this.mLabel1.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.mLabel1.AutoSize = true;
            mComponent8.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            mComponent8.CustomTheme = null;
            mComponent8.Outdated = true;
            mComponent8.ParentForm = this;
            mComponent8.SourceTheme = theme1;
            this.mLabel1.Component = mComponent8;
            this.mLabel1.CustomTheme = null;
            this.mLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mLabel1.Location = new System.Drawing.Point(39, 714);
            this.mLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(80, 32);
            this.mLabel1.TabIndex = 11;
            this.mLabel1.Text = "Usage";
            this.mLabel1.Type = Minimal.LabelType.Alternate;
            // 
            // mLabel2
            // 
            this.mLabel2.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.mLabel2.AutoSize = true;
            mComponent7.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            mComponent7.CustomTheme = null;
            mComponent7.Outdated = true;
            mComponent7.ParentForm = this;
            mComponent7.SourceTheme = theme1;
            this.mLabel2.Component = mComponent7;
            this.mLabel2.CustomTheme = null;
            this.mLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mLabel2.Location = new System.Drawing.Point(177, 714);
            this.mLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(117, 32);
            this.mLabel2.TabIndex = 12;
            this.mLabel2.Text = "Processes";
            this.mLabel2.Type = Minimal.LabelType.Alternate;
            // 
            // lbProcesses
            // 
            this.lbProcesses.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.lbProcesses.AutoSize = true;
            mComponent6.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            mComponent6.CustomTheme = null;
            mComponent6.Outdated = true;
            mComponent6.ParentForm = this;
            mComponent6.SourceTheme = theme1;
            this.lbProcesses.Component = mComponent6;
            this.lbProcesses.CustomTheme = null;
            this.lbProcesses.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcesses.Location = new System.Drawing.Point(177, 745);
            this.lbProcesses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProcesses.Name = "lbProcesses";
            this.lbProcesses.Size = new System.Drawing.Size(54, 65);
            this.lbProcesses.TabIndex = 13;
            this.lbProcesses.Text = "0";
            this.lbProcesses.Type = Minimal.LabelType.Standard;
            // 
            // lbThreads
            // 
            this.lbThreads.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.lbThreads.AutoSize = true;
            mComponent4.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            mComponent4.CustomTheme = null;
            mComponent4.Outdated = true;
            mComponent4.ParentForm = this;
            mComponent4.SourceTheme = theme1;
            this.lbThreads.Component = mComponent4;
            this.lbThreads.CustomTheme = null;
            this.lbThreads.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThreads.Location = new System.Drawing.Point(312, 745);
            this.lbThreads.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(54, 65);
            this.lbThreads.TabIndex = 15;
            this.lbThreads.Text = "0";
            this.lbThreads.Type = Minimal.LabelType.Standard;
            // 
            // mLabel4
            // 
            this.mLabel4.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.mLabel4.AutoSize = true;
            mComponent5.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            mComponent5.CustomTheme = null;
            mComponent5.Outdated = true;
            mComponent5.ParentForm = this;
            mComponent5.SourceTheme = theme1;
            this.mLabel4.Component = mComponent5;
            this.mLabel4.CustomTheme = null;
            this.mLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mLabel4.Location = new System.Drawing.Point(312, 714);
            this.mLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabel4.Name = "mLabel4";
            this.mLabel4.Size = new System.Drawing.Size(99, 32);
            this.mLabel4.TabIndex = 14;
            this.mLabel4.Text = "Threads";
            this.mLabel4.Type = Minimal.LabelType.Alternate;
            // 
            // mLabel3
            // 
            this.mLabel3.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.mLabel3.AutoSize = true;
            mComponent3.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            mComponent3.CustomTheme = null;
            mComponent3.Outdated = true;
            mComponent3.ParentForm = this;
            mComponent3.SourceTheme = theme1;
            this.mLabel3.Component = mComponent3;
            this.mLabel3.CustomTheme = null;
            this.mLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mLabel3.Location = new System.Drawing.Point(33, 131);
            this.mLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabel3.Name = "mLabel3";
            this.mLabel3.Size = new System.Drawing.Size(134, 32);
            this.mLabel3.TabIndex = 16;
            this.mLabel3.Text = "Usage in %";
            this.mLabel3.Type = Minimal.LabelType.Alternate;
            // 
            // mLabel5
            // 
            this.mLabel5.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.mLabel5.AutoSize = true;
            mComponent2.Accent = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            mComponent2.CustomTheme = null;
            mComponent2.Outdated = true;
            mComponent2.ParentForm = this;
            theme1.COMPONENT_BACKGROUND = themeColor1;
            theme1.COMPONENT_BORDER = themeColor2;
            theme1.COMPONENT_FILL = themeColor3;
            theme1.COMPONENT_FOREGROUND = themeColor4;
            theme1.COMPONENT_HIGHLIGHT = themeColor5;
            theme1.DARK_BASED = false;
            theme1.FORM_BACKGROUND = themeColor6;
            mComponent2.SourceTheme = theme1;
            this.mLabel5.Component = mComponent2;
            this.mLabel5.CustomTheme = null;
            this.mLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mLabel5.Location = new System.Drawing.Point(32, 636);
            this.mLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabel5.Name = "mLabel5";
            this.mLabel5.Size = new System.Drawing.Size(92, 32);
            this.mLabel5.TabIndex = 17;
            this.mLabel5.Text = "250 ms";
            this.mLabel5.Type = Minimal.LabelType.Alternate;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 841);
            this.Controls.Add(this.mLabel5);
            this.Controls.Add(this.mLabel3);
            this.Controls.Add(this.lbThreads);
            this.Controls.Add(this.mLabel4);
            this.Controls.Add(this.lbProcesses);
            this.Controls.Add(this.mLabel2);
            this.Controls.Add(this.mLabel1);
            this.Controls.Add(this.lbUsage);
            this.Controls.Add(this.lbCpu);
            this.Controls.Add(this.cpuChart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Main";
            this.SizeChanged += new System.EventHandler(this.OnResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Minimal.Components.MChart cpuChart;
        private Minimal.Components.MLabel lbCpu;
        private Minimal.Components.MLabel lbUsage;
        private Minimal.Components.MLabel mLabel1;
        private Minimal.Components.MLabel lbProcesses;
        private Minimal.Components.MLabel mLabel2;
        private Minimal.Components.MLabel lbThreads;
        private Minimal.Components.MLabel mLabel4;
        private Minimal.Components.MLabel mLabel3;
        private Minimal.Components.MLabel mLabel5;
    }
}