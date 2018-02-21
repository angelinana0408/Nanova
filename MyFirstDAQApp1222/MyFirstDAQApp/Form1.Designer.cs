namespace MyFirstDAQApp
{
    partial class Form1
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
            this.Graph1D = new ZhengJuyin.UI.ZGraph();
            this.timerDrawSignal = new System.Windows.Forms.Timer(this.components);
            this.pumpingTime = new System.Windows.Forms.TextBox();
            this.waitingTime = new System.Windows.Forms.TextBox();
            this.preconHighTime = new System.Windows.Forms.TextBox();
            this.preconLowTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.overallStart = new System.Windows.Forms.Button();
            this.pump = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.timeUsed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pumpProgress = new System.Windows.Forms.ProgressBar();
            this.analyzeProgress = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TempGraph = new ZhengJuyin.UI.ZGraph();
            this.ExperienceName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TempProfile = new System.Windows.Forms.GroupBox();
            this.rampSpeed = new System.Windows.Forms.TextBox();
            this.highestHold = new System.Windows.Forms.TextBox();
            this.highestTemp = new System.Windows.Forms.TextBox();
            this.lowestHold = new System.Windows.Forms.TextBox();
            this.lowestTemp = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PIDGains = new System.Windows.Forms.GroupBox();
            this.derivativeTime = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.integralTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.proportionalGain = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cleaningPreconTime = new System.Windows.Forms.TextBox();
            this.HeartCutting = new System.Windows.Forms.GroupBox();
            this.End5 = new System.Windows.Forms.TextBox();
            this.End4 = new System.Windows.Forms.TextBox();
            this.End3 = new System.Windows.Forms.TextBox();
            this.End2 = new System.Windows.Forms.TextBox();
            this.End1 = new System.Windows.Forms.TextBox();
            this.Start5 = new System.Windows.Forms.TextBox();
            this.Start4 = new System.Windows.Forms.TextBox();
            this.Start3 = new System.Windows.Forms.TextBox();
            this.Start2 = new System.Windows.Forms.TextBox();
            this.Start1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.timerDrawTemp = new System.Windows.Forms.Timer(this.components);
            this.cleaningProcess = new System.Windows.Forms.ProgressBar();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cleaningTotalTime = new System.Windows.Forms.TextBox();
            this.preconHighIndicator2 = new System.Windows.Forms.PictureBox();
            this.preconOnIndicator2 = new System.Windows.Forms.PictureBox();
            this.valvaIndicator2 = new System.Windows.Forms.PictureBox();
            this.columnIndicator = new System.Windows.Forms.PictureBox();
            this.preconHighIndicator1 = new System.Windows.Forms.PictureBox();
            this.preconOnIndicator1 = new System.Windows.Forms.PictureBox();
            this.valveIndicator1 = new System.Windows.Forms.PictureBox();
            this.pumpIndicator = new System.Windows.Forms.PictureBox();
            this.TempProfile.SuspendLayout();
            this.PIDGains.SuspendLayout();
            this.HeartCutting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preconHighIndicator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preconOnIndicator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valvaIndicator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preconHighIndicator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preconOnIndicator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valveIndicator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph1D
            // 
            this.Graph1D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph1D.BackColor = System.Drawing.Color.White;
            this.Graph1D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Graph1D.Location = new System.Drawing.Point(485, 9);
            this.Graph1D.m_backColorH = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Graph1D.m_backColorL = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Graph1D.m_BigXYBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Graph1D.m_BigXYButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Graph1D.m_BigXYButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Graph1D.m_ControlButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Graph1D.m_ControlButtonForeColorH = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Graph1D.m_ControlButtonForeColorL = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Graph1D.m_ControlItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Graph1D.m_coordinateLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Graph1D.m_coordinateStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Graph1D.m_coordinateStringTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Graph1D.m_DirectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Graph1D.m_DirectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Graph1D.m_fXBeginSYS = 0F;
            this.Graph1D.m_fXEndSYS = 60F;
            this.Graph1D.m_fYBeginSYS = 0F;
            this.Graph1D.m_fYEndSYS = 1F;
            this.Graph1D.m_GraphBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Graph1D.m_iLineShowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Graph1D.m_iLineShowColorAlpha = 100;
            this.Graph1D.m_SySnameX = "X";
            this.Graph1D.m_SySnameY = "Y";
            this.Graph1D.m_SyStitle = "PID signals";
            this.Graph1D.m_titleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Graph1D.m_titleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Graph1D.m_titlePosition = 0.4F;
            this.Graph1D.m_titleSize = 14;
            this.Graph1D.Margin = new System.Windows.Forms.Padding(0);
            this.Graph1D.MinimumSize = new System.Drawing.Size(390, 292);
            this.Graph1D.Name = "Graph1D";
            this.Graph1D.Size = new System.Drawing.Size(453, 337);
            this.Graph1D.TabIndex = 6;
            this.Graph1D.Load += new System.EventHandler(this.zGraphTest_Load);
            // 
            // timerDrawSignal
            // 
            this.timerDrawSignal.Interval = 250;
            this.timerDrawSignal.Tick += new System.EventHandler(this.timerDrawSignal_Tick);
            // 
            // pumpingTime
            // 
            this.pumpingTime.Location = new System.Drawing.Point(38, 85);
            this.pumpingTime.Name = "pumpingTime";
            this.pumpingTime.Size = new System.Drawing.Size(100, 20);
            this.pumpingTime.TabIndex = 7;
            this.pumpingTime.Text = "180";
            // 
            // waitingTime
            // 
            this.waitingTime.Location = new System.Drawing.Point(38, 134);
            this.waitingTime.Name = "waitingTime";
            this.waitingTime.Size = new System.Drawing.Size(100, 20);
            this.waitingTime.TabIndex = 8;
            this.waitingTime.Text = "0";
            // 
            // preconHighTime
            // 
            this.preconHighTime.Location = new System.Drawing.Point(38, 181);
            this.preconHighTime.Name = "preconHighTime";
            this.preconHighTime.Size = new System.Drawing.Size(100, 20);
            this.preconHighTime.TabIndex = 9;
            this.preconHighTime.Text = "0.6";
            // 
            // preconLowTime
            // 
            this.preconLowTime.Location = new System.Drawing.Point(38, 224);
            this.preconLowTime.Name = "preconLowTime";
            this.preconLowTime.Size = new System.Drawing.Size(100, 20);
            this.preconLowTime.TabIndex = 10;
            this.preconLowTime.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sampling time(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Waiting time(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "precon high time(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "precon low time(s)";
            // 
            // overallStart
            // 
            this.overallStart.Location = new System.Drawing.Point(280, 643);
            this.overallStart.Name = "overallStart";
            this.overallStart.Size = new System.Drawing.Size(75, 23);
            this.overallStart.TabIndex = 15;
            this.overallStart.Text = "start";
            this.overallStart.UseVisualStyleBackColor = true;
            this.overallStart.Click += new System.EventHandler(this.overallStart_Click);
            // 
            // pump
            // 
            this.pump.AutoSize = true;
            this.pump.Location = new System.Drawing.Point(276, 502);
            this.pump.Name = "pump";
            this.pump.Size = new System.Drawing.Size(33, 13);
            this.pump.TabIndex = 20;
            this.pump.Text = "pump";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "valve1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "precon1on";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "precon1H";
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 250;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // timeUsed
            // 
            this.timeUsed.Location = new System.Drawing.Point(21, 515);
            this.timeUsed.Name = "timeUsed";
            this.timeUsed.Size = new System.Drawing.Size(83, 20);
            this.timeUsed.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "time used (s)";
            // 
            // pumpProgress
            // 
            this.pumpProgress.Location = new System.Drawing.Point(21, 561);
            this.pumpProgress.Name = "pumpProgress";
            this.pumpProgress.Size = new System.Drawing.Size(237, 25);
            this.pumpProgress.TabIndex = 26;
            // 
            // analyzeProgress
            // 
            this.analyzeProgress.Location = new System.Drawing.Point(21, 611);
            this.analyzeProgress.Name = "analyzeProgress";
            this.analyzeProgress.Size = new System.Drawing.Size(237, 25);
            this.analyzeProgress.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "pumping process";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 593);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "analyzing process";
            // 
            // TempGraph
            // 
            this.TempGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TempGraph.BackColor = System.Drawing.Color.White;
            this.TempGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TempGraph.Location = new System.Drawing.Point(485, 372);
            this.TempGraph.m_backColorH = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TempGraph.m_backColorL = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TempGraph.m_BigXYBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TempGraph.m_BigXYButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TempGraph.m_BigXYButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempGraph.m_ControlButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempGraph.m_ControlButtonForeColorH = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TempGraph.m_ControlButtonForeColorL = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TempGraph.m_ControlItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempGraph.m_coordinateLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempGraph.m_coordinateStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempGraph.m_coordinateStringTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempGraph.m_DirectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TempGraph.m_DirectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TempGraph.m_fXBeginSYS = 0F;
            this.TempGraph.m_fXEndSYS = 60F;
            this.TempGraph.m_fYBeginSYS = 0F;
            this.TempGraph.m_fYEndSYS = 1F;
            this.TempGraph.m_GraphBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempGraph.m_iLineShowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TempGraph.m_iLineShowColorAlpha = 100;
            this.TempGraph.m_SySnameX = "X";
            this.TempGraph.m_SySnameY = "Y";
            this.TempGraph.m_SyStitle = "Column  Temperature";
            this.TempGraph.m_titleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TempGraph.m_titleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempGraph.m_titlePosition = 0.4F;
            this.TempGraph.m_titleSize = 14;
            this.TempGraph.Margin = new System.Windows.Forms.Padding(0);
            this.TempGraph.MinimumSize = new System.Drawing.Size(390, 292);
            this.TempGraph.Name = "TempGraph";
            this.TempGraph.Size = new System.Drawing.Size(453, 323);
            this.TempGraph.TabIndex = 30;
            this.TempGraph.Load += new System.EventHandler(this.zGraph1_Load);
            // 
            // ExperienceName
            // 
            this.ExperienceName.Location = new System.Drawing.Point(38, 43);
            this.ExperienceName.Name = "ExperienceName";
            this.ExperienceName.Size = new System.Drawing.Size(100, 20);
            this.ExperienceName.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Experience Name";
            // 
            // TempProfile
            // 
            this.TempProfile.Controls.Add(this.rampSpeed);
            this.TempProfile.Controls.Add(this.highestHold);
            this.TempProfile.Controls.Add(this.highestTemp);
            this.TempProfile.Controls.Add(this.lowestHold);
            this.TempProfile.Controls.Add(this.lowestTemp);
            this.TempProfile.Controls.Add(this.label16);
            this.TempProfile.Controls.Add(this.label15);
            this.TempProfile.Controls.Add(this.label14);
            this.TempProfile.Controls.Add(this.label13);
            this.TempProfile.Controls.Add(this.label12);
            this.TempProfile.Location = new System.Drawing.Point(173, 57);
            this.TempProfile.Name = "TempProfile";
            this.TempProfile.Size = new System.Drawing.Size(156, 237);
            this.TempProfile.TabIndex = 35;
            this.TempProfile.TabStop = false;
            this.TempProfile.Text = "Temperature Profile";
            // 
            // rampSpeed
            // 
            this.rampSpeed.Location = new System.Drawing.Point(19, 210);
            this.rampSpeed.Name = "rampSpeed";
            this.rampSpeed.Size = new System.Drawing.Size(100, 20);
            this.rampSpeed.TabIndex = 13;
            this.rampSpeed.Text = "10";
            // 
            // highestHold
            // 
            this.highestHold.Location = new System.Drawing.Point(19, 166);
            this.highestHold.Name = "highestHold";
            this.highestHold.Size = new System.Drawing.Size(100, 20);
            this.highestHold.TabIndex = 12;
            this.highestHold.Text = "3";
            // 
            // highestTemp
            // 
            this.highestTemp.Location = new System.Drawing.Point(19, 121);
            this.highestTemp.Name = "highestTemp";
            this.highestTemp.Size = new System.Drawing.Size(100, 20);
            this.highestTemp.TabIndex = 11;
            this.highestTemp.Text = "80";
            // 
            // lowestHold
            // 
            this.lowestHold.Location = new System.Drawing.Point(19, 78);
            this.lowestHold.Name = "lowestHold";
            this.lowestHold.Size = new System.Drawing.Size(100, 20);
            this.lowestHold.TabIndex = 10;
            this.lowestHold.Text = "1";
            // 
            // lowestTemp
            // 
            this.lowestTemp.Location = new System.Drawing.Point(19, 33);
            this.lowestTemp.Name = "lowestTemp";
            this.lowestTemp.Size = new System.Drawing.Size(100, 20);
            this.lowestTemp.TabIndex = 9;
            this.lowestTemp.Text = "30";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Ramp speed(ºC/min)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Highest holding time(mins)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Highest Temp(ºC)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Lowest holding(mins)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Lowest Temp(ºC)";
            // 
            // PIDGains
            // 
            this.PIDGains.Controls.Add(this.derivativeTime);
            this.PIDGains.Controls.Add(this.label19);
            this.PIDGains.Controls.Add(this.integralTime);
            this.PIDGains.Controls.Add(this.label18);
            this.PIDGains.Controls.Add(this.proportionalGain);
            this.PIDGains.Controls.Add(this.label17);
            this.PIDGains.Location = new System.Drawing.Point(335, 57);
            this.PIDGains.Name = "PIDGains";
            this.PIDGains.Size = new System.Drawing.Size(137, 144);
            this.PIDGains.TabIndex = 36;
            this.PIDGains.TabStop = false;
            this.PIDGains.Text = "PID gains";
            // 
            // derivativeTime
            // 
            this.derivativeTime.Location = new System.Drawing.Point(14, 121);
            this.derivativeTime.Name = "derivativeTime";
            this.derivativeTime.Size = new System.Drawing.Size(100, 20);
            this.derivativeTime.TabIndex = 5;
            this.derivativeTime.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "derivative time(Td,min)";
            // 
            // integralTime
            // 
            this.integralTime.Location = new System.Drawing.Point(14, 78);
            this.integralTime.Name = "integralTime";
            this.integralTime.Size = new System.Drawing.Size(100, 20);
            this.integralTime.TabIndex = 3;
            this.integralTime.Text = "0.01";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "integral time(Ti, min)";
            // 
            // proportionalGain
            // 
            this.proportionalGain.Location = new System.Drawing.Point(14, 33);
            this.proportionalGain.Name = "proportionalGain";
            this.proportionalGain.Size = new System.Drawing.Size(100, 20);
            this.proportionalGain.TabIndex = 1;
            this.proportionalGain.Text = "0.3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "proportional gain (Kc)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(38, 251);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Cleaning precon time(s)";
            // 
            // cleaningPreconTime
            // 
            this.cleaningPreconTime.Location = new System.Drawing.Point(38, 268);
            this.cleaningPreconTime.Name = "cleaningPreconTime";
            this.cleaningPreconTime.Size = new System.Drawing.Size(100, 20);
            this.cleaningPreconTime.TabIndex = 38;
            this.cleaningPreconTime.Text = "15";
            // 
            // HeartCutting
            // 
            this.HeartCutting.Controls.Add(this.End5);
            this.HeartCutting.Controls.Add(this.End4);
            this.HeartCutting.Controls.Add(this.End3);
            this.HeartCutting.Controls.Add(this.End2);
            this.HeartCutting.Controls.Add(this.End1);
            this.HeartCutting.Controls.Add(this.Start5);
            this.HeartCutting.Controls.Add(this.Start4);
            this.HeartCutting.Controls.Add(this.Start3);
            this.HeartCutting.Controls.Add(this.Start2);
            this.HeartCutting.Controls.Add(this.Start1);
            this.HeartCutting.Controls.Add(this.label22);
            this.HeartCutting.Controls.Add(this.label21);
            this.HeartCutting.Location = new System.Drawing.Point(145, 300);
            this.HeartCutting.Name = "HeartCutting";
            this.HeartCutting.Size = new System.Drawing.Size(200, 180);
            this.HeartCutting.TabIndex = 39;
            this.HeartCutting.TabStop = false;
            this.HeartCutting.Text = "Heart-cutting";
            // 
            // End5
            // 
            this.End5.Location = new System.Drawing.Point(113, 148);
            this.End5.Name = "End5";
            this.End5.Size = new System.Drawing.Size(70, 20);
            this.End5.TabIndex = 11;
            // 
            // End4
            // 
            this.End4.Location = new System.Drawing.Point(113, 121);
            this.End4.Name = "End4";
            this.End4.Size = new System.Drawing.Size(70, 20);
            this.End4.TabIndex = 10;
            // 
            // End3
            // 
            this.End3.Location = new System.Drawing.Point(113, 95);
            this.End3.Name = "End3";
            this.End3.Size = new System.Drawing.Size(70, 20);
            this.End3.TabIndex = 9;
            // 
            // End2
            // 
            this.End2.Location = new System.Drawing.Point(113, 69);
            this.End2.Name = "End2";
            this.End2.Size = new System.Drawing.Size(70, 20);
            this.End2.TabIndex = 8;
            // 
            // End1
            // 
            this.End1.Location = new System.Drawing.Point(113, 42);
            this.End1.Name = "End1";
            this.End1.Size = new System.Drawing.Size(70, 20);
            this.End1.TabIndex = 7;
            // 
            // Start5
            // 
            this.Start5.Location = new System.Drawing.Point(15, 148);
            this.Start5.Name = "Start5";
            this.Start5.Size = new System.Drawing.Size(68, 20);
            this.Start5.TabIndex = 6;
            // 
            // Start4
            // 
            this.Start4.Location = new System.Drawing.Point(15, 122);
            this.Start4.Name = "Start4";
            this.Start4.Size = new System.Drawing.Size(68, 20);
            this.Start4.TabIndex = 5;
            // 
            // Start3
            // 
            this.Start3.Location = new System.Drawing.Point(15, 96);
            this.Start3.Name = "Start3";
            this.Start3.Size = new System.Drawing.Size(68, 20);
            this.Start3.TabIndex = 4;
            // 
            // Start2
            // 
            this.Start2.Location = new System.Drawing.Point(15, 70);
            this.Start2.Name = "Start2";
            this.Start2.Size = new System.Drawing.Size(68, 20);
            this.Start2.TabIndex = 3;
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(15, 44);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(68, 20);
            this.Start1.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(114, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "End time(s)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Start time(s)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(271, 573);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "column";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(315, 573);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "valve 2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(414, 573);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "precon2on";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(360, 573);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "precon2H";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(376, 643);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 48;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(277, 519);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(164, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "P12         P00         P13         P01";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(277, 588);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(164, 13);
            this.label28.TabIndex = 50;
            this.label28.Text = "P04         P10         P06         P07";
            // 
            // timerDrawTemp
            // 
            this.timerDrawTemp.Interval = 250;
            this.timerDrawTemp.Tick += new System.EventHandler(this.timerDrawTemp_Tick);
            // 
            // cleaningProcess
            // 
            this.cleaningProcess.Location = new System.Drawing.Point(21, 659);
            this.cleaningProcess.Name = "cleaningProcess";
            this.cleaningProcess.Size = new System.Drawing.Size(237, 25);
            this.cleaningProcess.TabIndex = 51;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(21, 643);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 13);
            this.label29.TabIndex = 52;
            this.label29.Text = "cleaning process";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(342, 208);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(120, 13);
            this.label30.TabIndex = 53;
            this.label30.Text = "Cleaning total time(mins)";
            // 
            // cleaningTotalTime
            // 
            this.cleaningTotalTime.Location = new System.Drawing.Point(349, 224);
            this.cleaningTotalTime.Name = "cleaningTotalTime";
            this.cleaningTotalTime.Size = new System.Drawing.Size(100, 20);
            this.cleaningTotalTime.TabIndex = 54;
            this.cleaningTotalTime.Text = "3";
            // 
            // preconHighIndicator2
            // 
            this.preconHighIndicator2.Location = new System.Drawing.Point(373, 604);
            this.preconHighIndicator2.Name = "preconHighIndicator2";
            this.preconHighIndicator2.Size = new System.Drawing.Size(21, 24);
            this.preconHighIndicator2.TabIndex = 43;
            this.preconHighIndicator2.TabStop = false;
            // 
            // preconOnIndicator2
            // 
            this.preconOnIndicator2.Location = new System.Drawing.Point(419, 604);
            this.preconOnIndicator2.Name = "preconOnIndicator2";
            this.preconOnIndicator2.Size = new System.Drawing.Size(20, 24);
            this.preconOnIndicator2.TabIndex = 42;
            this.preconOnIndicator2.TabStop = false;
            // 
            // valvaIndicator2
            // 
            this.valvaIndicator2.Location = new System.Drawing.Point(325, 604);
            this.valvaIndicator2.Name = "valvaIndicator2";
            this.valvaIndicator2.Size = new System.Drawing.Size(20, 24);
            this.valvaIndicator2.TabIndex = 41;
            this.valvaIndicator2.TabStop = false;
            // 
            // columnIndicator
            // 
            this.columnIndicator.Location = new System.Drawing.Point(280, 604);
            this.columnIndicator.Name = "columnIndicator";
            this.columnIndicator.Size = new System.Drawing.Size(20, 24);
            this.columnIndicator.TabIndex = 40;
            this.columnIndicator.TabStop = false;
            // 
            // preconHighIndicator1
            // 
            this.preconHighIndicator1.Location = new System.Drawing.Point(373, 535);
            this.preconHighIndicator1.Name = "preconHighIndicator1";
            this.preconHighIndicator1.Size = new System.Drawing.Size(20, 22);
            this.preconHighIndicator1.TabIndex = 19;
            this.preconHighIndicator1.TabStop = false;
            // 
            // preconOnIndicator1
            // 
            this.preconOnIndicator1.Location = new System.Drawing.Point(419, 535);
            this.preconOnIndicator1.Name = "preconOnIndicator1";
            this.preconOnIndicator1.Size = new System.Drawing.Size(20, 22);
            this.preconOnIndicator1.TabIndex = 18;
            this.preconOnIndicator1.TabStop = false;
            // 
            // valveIndicator1
            // 
            this.valveIndicator1.Location = new System.Drawing.Point(325, 535);
            this.valveIndicator1.Name = "valveIndicator1";
            this.valveIndicator1.Size = new System.Drawing.Size(20, 22);
            this.valveIndicator1.TabIndex = 17;
            this.valveIndicator1.TabStop = false;
            // 
            // pumpIndicator
            // 
            this.pumpIndicator.Location = new System.Drawing.Point(280, 535);
            this.pumpIndicator.Name = "pumpIndicator";
            this.pumpIndicator.Size = new System.Drawing.Size(20, 22);
            this.pumpIndicator.TabIndex = 16;
            this.pumpIndicator.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 704);
            this.Controls.Add(this.cleaningTotalTime);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.cleaningProcess);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.preconHighIndicator2);
            this.Controls.Add(this.preconOnIndicator2);
            this.Controls.Add(this.valvaIndicator2);
            this.Controls.Add(this.columnIndicator);
            this.Controls.Add(this.HeartCutting);
            this.Controls.Add(this.cleaningPreconTime);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.PIDGains);
            this.Controls.Add(this.TempProfile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ExperienceName);
            this.Controls.Add(this.TempGraph);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.analyzeProgress);
            this.Controls.Add(this.pumpProgress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeUsed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pump);
            this.Controls.Add(this.preconHighIndicator1);
            this.Controls.Add(this.preconOnIndicator1);
            this.Controls.Add(this.valveIndicator1);
            this.Controls.Add(this.pumpIndicator);
            this.Controls.Add(this.overallStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preconLowTime);
            this.Controls.Add(this.preconHighTime);
            this.Controls.Add(this.waitingTime);
            this.Controls.Add(this.pumpingTime);
            this.Controls.Add(this.Graph1D);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TempProfile.ResumeLayout(false);
            this.TempProfile.PerformLayout();
            this.PIDGains.ResumeLayout(false);
            this.PIDGains.PerformLayout();
            this.HeartCutting.ResumeLayout(false);
            this.HeartCutting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preconHighIndicator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preconOnIndicator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valvaIndicator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preconHighIndicator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preconOnIndicator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valveIndicator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZhengJuyin.UI.ZGraph Graph1D;
        private System.Windows.Forms.Timer timerDrawSignal;
        private System.Windows.Forms.TextBox pumpingTime;
        private System.Windows.Forms.TextBox waitingTime;
        private System.Windows.Forms.TextBox preconHighTime;
        private System.Windows.Forms.TextBox preconLowTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pumpIndicator;
        private System.Windows.Forms.PictureBox valveIndicator1;
        private System.Windows.Forms.PictureBox preconOnIndicator1;
        private System.Windows.Forms.PictureBox preconHighIndicator1;
        private System.Windows.Forms.Label pump;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Button overallStart;
        private System.Windows.Forms.TextBox timeUsed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pumpProgress;
        private System.Windows.Forms.ProgressBar analyzeProgress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ZhengJuyin.UI.ZGraph TempGraph;
        private System.Windows.Forms.TextBox ExperienceName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox TempProfile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox PIDGains;
        private System.Windows.Forms.TextBox derivativeTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox integralTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox proportionalGain;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox cleaningPreconTime;
        private System.Windows.Forms.TextBox rampSpeed;
        private System.Windows.Forms.TextBox highestHold;
        private System.Windows.Forms.TextBox highestTemp;
        private System.Windows.Forms.TextBox lowestHold;
        private System.Windows.Forms.TextBox lowestTemp;
        private System.Windows.Forms.GroupBox HeartCutting;
        private System.Windows.Forms.TextBox Start4;
        private System.Windows.Forms.TextBox Start3;
        private System.Windows.Forms.TextBox Start2;
        private System.Windows.Forms.TextBox Start1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox End5;
        private System.Windows.Forms.TextBox End4;
        private System.Windows.Forms.TextBox End3;
        private System.Windows.Forms.TextBox End2;
        private System.Windows.Forms.TextBox End1;
        private System.Windows.Forms.TextBox Start5;
        private System.Windows.Forms.PictureBox columnIndicator;
        private System.Windows.Forms.PictureBox valvaIndicator2;
        private System.Windows.Forms.PictureBox preconOnIndicator2;
        private System.Windows.Forms.PictureBox preconHighIndicator2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Timer timerDrawTemp;
        private System.Windows.Forms.ProgressBar cleaningProcess;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox cleaningTotalTime;
    }
}

