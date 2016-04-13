﻿namespace LEDControl
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
            this.powerOn = new System.Windows.Forms.Button();
            this.powerOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.powerBlink = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dotBlink = new System.Windows.Forms.Button();
            this.dotOff = new System.Windows.Forms.Button();
            this.dotOn = new System.Windows.Forms.Button();
            this.microphoneBlink = new System.Windows.Forms.Button();
            this.microphoneOff = new System.Windows.Forms.Button();
            this.microphoneOn = new System.Windows.Forms.Button();
            this.sleepBlink = new System.Windows.Forms.Button();
            this.sleepOff = new System.Windows.Forms.Button();
            this.sleepOn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkHDDReadPower = new System.Windows.Forms.CheckBox();
            this.checkHDDReadDot = new System.Windows.Forms.CheckBox();
            this.checkHDDReadMicrophone = new System.Windows.Forms.CheckBox();
            this.checkHDDReadSleep = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.workerHDD = new System.ComponentModel.BackgroundWorker();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkHDDWriteSleep = new System.Windows.Forms.CheckBox();
            this.checkHDDWriteMicrophone = new System.Windows.Forms.CheckBox();
            this.checkHDDWriteDot = new System.Windows.Forms.CheckBox();
            this.checkHDDWritePower = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkHDDSleep = new System.Windows.Forms.CheckBox();
            this.checkHDDMicrophone = new System.Windows.Forms.CheckBox();
            this.checkHDDDot = new System.Windows.Forms.CheckBox();
            this.checkHDDPower = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkCLSleep = new System.Windows.Forms.CheckBox();
            this.checkCLMicrophone = new System.Windows.Forms.CheckBox();
            this.checkCLDot = new System.Windows.Forms.CheckBox();
            this.checkCLPower = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkHDD = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.checkNLSleep = new System.Windows.Forms.CheckBox();
            this.checkNLMicrophone = new System.Windows.Forms.CheckBox();
            this.checkNLDot = new System.Windows.Forms.CheckBox();
            this.checkNLPower = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.rememberKBD = new System.Windows.Forms.CheckBox();
            this.lightTimer = new System.Windows.Forms.Timer(this.components);
            this.checkTurnKBLightOff = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // powerOn
            // 
            this.powerOn.Location = new System.Drawing.Point(123, 10);
            this.powerOn.Margin = new System.Windows.Forms.Padding(4);
            this.powerOn.Name = "powerOn";
            this.powerOn.Size = new System.Drawing.Size(100, 28);
            this.powerOn.TabIndex = 0;
            this.powerOn.Text = "ON";
            this.powerOn.UseVisualStyleBackColor = true;
            this.powerOn.Click += new System.EventHandler(this.powerOn_Click);
            // 
            // powerOff
            // 
            this.powerOff.Location = new System.Drawing.Point(231, 10);
            this.powerOff.Margin = new System.Windows.Forms.Padding(4);
            this.powerOff.Name = "powerOff";
            this.powerOff.Size = new System.Drawing.Size(100, 28);
            this.powerOff.TabIndex = 1;
            this.powerOff.Text = "OFF";
            this.powerOff.UseVisualStyleBackColor = true;
            this.powerOff.Click += new System.EventHandler(this.powerOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Power button:";
            // 
            // powerBlink
            // 
            this.powerBlink.Location = new System.Drawing.Point(339, 10);
            this.powerBlink.Margin = new System.Windows.Forms.Padding(4);
            this.powerBlink.Name = "powerBlink";
            this.powerBlink.Size = new System.Drawing.Size(100, 28);
            this.powerBlink.TabIndex = 3;
            this.powerBlink.Text = "Third state";
            this.powerBlink.UseVisualStyleBackColor = true;
            this.powerBlink.Click += new System.EventHandler(this.powerBlink_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Red Dot:";
            // 
            // dotBlink
            // 
            this.dotBlink.Location = new System.Drawing.Point(339, 46);
            this.dotBlink.Margin = new System.Windows.Forms.Padding(4);
            this.dotBlink.Name = "dotBlink";
            this.dotBlink.Size = new System.Drawing.Size(100, 28);
            this.dotBlink.TabIndex = 7;
            this.dotBlink.Text = "Third state";
            this.dotBlink.UseVisualStyleBackColor = true;
            this.dotBlink.Click += new System.EventHandler(this.dotBlink_Click);
            // 
            // dotOff
            // 
            this.dotOff.Location = new System.Drawing.Point(231, 46);
            this.dotOff.Margin = new System.Windows.Forms.Padding(4);
            this.dotOff.Name = "dotOff";
            this.dotOff.Size = new System.Drawing.Size(100, 28);
            this.dotOff.TabIndex = 6;
            this.dotOff.Text = "OFF";
            this.dotOff.UseVisualStyleBackColor = true;
            this.dotOff.Click += new System.EventHandler(this.dotOff_Click);
            // 
            // dotOn
            // 
            this.dotOn.Location = new System.Drawing.Point(123, 46);
            this.dotOn.Margin = new System.Windows.Forms.Padding(4);
            this.dotOn.Name = "dotOn";
            this.dotOn.Size = new System.Drawing.Size(100, 28);
            this.dotOn.TabIndex = 5;
            this.dotOn.Text = "ON";
            this.dotOn.UseVisualStyleBackColor = true;
            this.dotOn.Click += new System.EventHandler(this.dotOn_Click);
            // 
            // microphoneBlink
            // 
            this.microphoneBlink.Location = new System.Drawing.Point(339, 81);
            this.microphoneBlink.Margin = new System.Windows.Forms.Padding(4);
            this.microphoneBlink.Name = "microphoneBlink";
            this.microphoneBlink.Size = new System.Drawing.Size(100, 28);
            this.microphoneBlink.TabIndex = 10;
            this.microphoneBlink.Text = "Third state";
            this.microphoneBlink.UseVisualStyleBackColor = true;
            this.microphoneBlink.Click += new System.EventHandler(this.microphoneBlink_Click);
            // 
            // microphoneOff
            // 
            this.microphoneOff.Location = new System.Drawing.Point(231, 81);
            this.microphoneOff.Margin = new System.Windows.Forms.Padding(4);
            this.microphoneOff.Name = "microphoneOff";
            this.microphoneOff.Size = new System.Drawing.Size(100, 28);
            this.microphoneOff.TabIndex = 9;
            this.microphoneOff.Text = "OFF";
            this.microphoneOff.UseVisualStyleBackColor = true;
            this.microphoneOff.Click += new System.EventHandler(this.microphoneOff_Click);
            // 
            // microphoneOn
            // 
            this.microphoneOn.Location = new System.Drawing.Point(123, 81);
            this.microphoneOn.Margin = new System.Windows.Forms.Padding(4);
            this.microphoneOn.Name = "microphoneOn";
            this.microphoneOn.Size = new System.Drawing.Size(100, 28);
            this.microphoneOn.TabIndex = 8;
            this.microphoneOn.Text = "ON";
            this.microphoneOn.UseVisualStyleBackColor = true;
            this.microphoneOn.Click += new System.EventHandler(this.microphoneOn_Click);
            // 
            // sleepBlink
            // 
            this.sleepBlink.Location = new System.Drawing.Point(339, 117);
            this.sleepBlink.Margin = new System.Windows.Forms.Padding(4);
            this.sleepBlink.Name = "sleepBlink";
            this.sleepBlink.Size = new System.Drawing.Size(100, 28);
            this.sleepBlink.TabIndex = 13;
            this.sleepBlink.Text = "Third state";
            this.sleepBlink.UseVisualStyleBackColor = true;
            this.sleepBlink.Click += new System.EventHandler(this.sleepBlink_Click);
            // 
            // sleepOff
            // 
            this.sleepOff.Location = new System.Drawing.Point(231, 117);
            this.sleepOff.Margin = new System.Windows.Forms.Padding(4);
            this.sleepOff.Name = "sleepOff";
            this.sleepOff.Size = new System.Drawing.Size(100, 28);
            this.sleepOff.TabIndex = 12;
            this.sleepOff.Text = "OFF";
            this.sleepOff.UseVisualStyleBackColor = true;
            this.sleepOff.Click += new System.EventHandler(this.sleepOff_Click);
            // 
            // sleepOn
            // 
            this.sleepOn.Location = new System.Drawing.Point(123, 117);
            this.sleepOn.Margin = new System.Windows.Forms.Padding(4);
            this.sleepOn.Name = "sleepOn";
            this.sleepOn.Size = new System.Drawing.Size(100, 28);
            this.sleepOn.TabIndex = 11;
            this.sleepOn.Text = "ON";
            this.sleepOn.UseVisualStyleBackColor = true;
            this.sleepOn.Click += new System.EventHandler(this.sleepOn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Microphone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sleep moon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "____________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Disks read activity:";
            // 
            // checkHDDReadPower
            // 
            this.checkHDDReadPower.AutoSize = true;
            this.checkHDDReadPower.Location = new System.Drawing.Point(21, 202);
            this.checkHDDReadPower.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDReadPower.Name = "checkHDDReadPower";
            this.checkHDDReadPower.Size = new System.Drawing.Size(113, 21);
            this.checkHDDReadPower.TabIndex = 18;
            this.checkHDDReadPower.Text = "Power button";
            this.checkHDDReadPower.UseVisualStyleBackColor = true;
            this.checkHDDReadPower.CheckedChanged += new System.EventHandler(this.checkHDDReadPower_CheckedChanged);
            // 
            // checkHDDReadDot
            // 
            this.checkHDDReadDot.AutoSize = true;
            this.checkHDDReadDot.Location = new System.Drawing.Point(21, 230);
            this.checkHDDReadDot.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDReadDot.Name = "checkHDDReadDot";
            this.checkHDDReadDot.Size = new System.Drawing.Size(82, 21);
            this.checkHDDReadDot.TabIndex = 19;
            this.checkHDDReadDot.Text = "Red Dot";
            this.checkHDDReadDot.UseVisualStyleBackColor = true;
            this.checkHDDReadDot.CheckedChanged += new System.EventHandler(this.checkHDDReadDot_CheckedChanged);
            // 
            // checkHDDReadMicrophone
            // 
            this.checkHDDReadMicrophone.AutoSize = true;
            this.checkHDDReadMicrophone.Location = new System.Drawing.Point(21, 258);
            this.checkHDDReadMicrophone.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDReadMicrophone.Name = "checkHDDReadMicrophone";
            this.checkHDDReadMicrophone.Size = new System.Drawing.Size(104, 21);
            this.checkHDDReadMicrophone.TabIndex = 20;
            this.checkHDDReadMicrophone.Text = "Microphone";
            this.checkHDDReadMicrophone.UseVisualStyleBackColor = true;
            this.checkHDDReadMicrophone.CheckedChanged += new System.EventHandler(this.checkHDDReadMicrophone_CheckedChanged);
            // 
            // checkHDDReadSleep
            // 
            this.checkHDDReadSleep.AutoSize = true;
            this.checkHDDReadSleep.Location = new System.Drawing.Point(21, 287);
            this.checkHDDReadSleep.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDReadSleep.Name = "checkHDDReadSleep";
            this.checkHDDReadSleep.Size = new System.Drawing.Size(105, 21);
            this.checkHDDReadSleep.TabIndex = 21;
            this.checkHDDReadSleep.Text = "Sleep moon";
            this.checkHDDReadSleep.UseVisualStyleBackColor = true;
            this.checkHDDReadSleep.CheckedChanged += new System.EventHandler(this.checkHDDReadSleep_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 660);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(424, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "____________________________________________________";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 683);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workerHDD
            // 
            this.workerHDD.WorkerSupportsCancellation = true;
            this.workerHDD.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerHDD_DoWork);
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.NotifyIcon1.Text = "notifyIcon1";
            this.NotifyIcon1.Visible = true;
            this.NotifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 62);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItem1.Text = "Show application";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItem2.Text = "Quit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // checkHDDWriteSleep
            // 
            this.checkHDDWriteSleep.AutoSize = true;
            this.checkHDDWriteSleep.Location = new System.Drawing.Point(164, 287);
            this.checkHDDWriteSleep.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDWriteSleep.Name = "checkHDDWriteSleep";
            this.checkHDDWriteSleep.Size = new System.Drawing.Size(105, 21);
            this.checkHDDWriteSleep.TabIndex = 28;
            this.checkHDDWriteSleep.Text = "Sleep moon";
            this.checkHDDWriteSleep.UseVisualStyleBackColor = true;
            this.checkHDDWriteSleep.CheckedChanged += new System.EventHandler(this.checkHDDWriteSleep_CheckedChanged);
            // 
            // checkHDDWriteMicrophone
            // 
            this.checkHDDWriteMicrophone.AutoSize = true;
            this.checkHDDWriteMicrophone.Location = new System.Drawing.Point(164, 258);
            this.checkHDDWriteMicrophone.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDWriteMicrophone.Name = "checkHDDWriteMicrophone";
            this.checkHDDWriteMicrophone.Size = new System.Drawing.Size(104, 21);
            this.checkHDDWriteMicrophone.TabIndex = 27;
            this.checkHDDWriteMicrophone.Text = "Microphone";
            this.checkHDDWriteMicrophone.UseVisualStyleBackColor = true;
            this.checkHDDWriteMicrophone.CheckedChanged += new System.EventHandler(this.checkHDDWriteMicrophone_CheckedChanged);
            // 
            // checkHDDWriteDot
            // 
            this.checkHDDWriteDot.AutoSize = true;
            this.checkHDDWriteDot.Location = new System.Drawing.Point(164, 230);
            this.checkHDDWriteDot.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDWriteDot.Name = "checkHDDWriteDot";
            this.checkHDDWriteDot.Size = new System.Drawing.Size(82, 21);
            this.checkHDDWriteDot.TabIndex = 26;
            this.checkHDDWriteDot.Text = "Red Dot";
            this.checkHDDWriteDot.UseVisualStyleBackColor = true;
            this.checkHDDWriteDot.CheckedChanged += new System.EventHandler(this.checkHDDWriteDot_CheckedChanged);
            // 
            // checkHDDWritePower
            // 
            this.checkHDDWritePower.AutoSize = true;
            this.checkHDDWritePower.Location = new System.Drawing.Point(164, 202);
            this.checkHDDWritePower.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDWritePower.Name = "checkHDDWritePower";
            this.checkHDDWritePower.Size = new System.Drawing.Size(113, 21);
            this.checkHDDWritePower.TabIndex = 25;
            this.checkHDDWritePower.Text = "Power button";
            this.checkHDDWritePower.UseVisualStyleBackColor = true;
            this.checkHDDWritePower.CheckedChanged += new System.EventHandler(this.checkHDDWritePower_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Disks write activity:";
            // 
            // checkHDDSleep
            // 
            this.checkHDDSleep.AutoSize = true;
            this.checkHDDSleep.Enabled = false;
            this.checkHDDSleep.Location = new System.Drawing.Point(313, 287);
            this.checkHDDSleep.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDSleep.Name = "checkHDDSleep";
            this.checkHDDSleep.Size = new System.Drawing.Size(105, 21);
            this.checkHDDSleep.TabIndex = 33;
            this.checkHDDSleep.Text = "Sleep moon";
            this.checkHDDSleep.UseVisualStyleBackColor = true;
            // 
            // checkHDDMicrophone
            // 
            this.checkHDDMicrophone.AutoSize = true;
            this.checkHDDMicrophone.Enabled = false;
            this.checkHDDMicrophone.Location = new System.Drawing.Point(313, 258);
            this.checkHDDMicrophone.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDMicrophone.Name = "checkHDDMicrophone";
            this.checkHDDMicrophone.Size = new System.Drawing.Size(104, 21);
            this.checkHDDMicrophone.TabIndex = 32;
            this.checkHDDMicrophone.Text = "Microphone";
            this.checkHDDMicrophone.UseVisualStyleBackColor = true;
            // 
            // checkHDDDot
            // 
            this.checkHDDDot.AutoSize = true;
            this.checkHDDDot.Enabled = false;
            this.checkHDDDot.Location = new System.Drawing.Point(313, 230);
            this.checkHDDDot.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDDot.Name = "checkHDDDot";
            this.checkHDDDot.Size = new System.Drawing.Size(82, 21);
            this.checkHDDDot.TabIndex = 31;
            this.checkHDDDot.Text = "Red Dot";
            this.checkHDDDot.UseVisualStyleBackColor = true;
            // 
            // checkHDDPower
            // 
            this.checkHDDPower.AutoSize = true;
            this.checkHDDPower.Enabled = false;
            this.checkHDDPower.Location = new System.Drawing.Point(313, 202);
            this.checkHDDPower.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDDPower.Name = "checkHDDPower";
            this.checkHDDPower.Size = new System.Drawing.Size(113, 21);
            this.checkHDDPower.TabIndex = 30;
            this.checkHDDPower.Text = "Power button";
            this.checkHDDPower.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Disks activity:";
            // 
            // checkCLSleep
            // 
            this.checkCLSleep.AutoSize = true;
            this.checkCLSleep.Location = new System.Drawing.Point(21, 494);
            this.checkCLSleep.Margin = new System.Windows.Forms.Padding(4);
            this.checkCLSleep.Name = "checkCLSleep";
            this.checkCLSleep.Size = new System.Drawing.Size(105, 21);
            this.checkCLSleep.TabIndex = 38;
            this.checkCLSleep.Text = "Sleep moon";
            this.checkCLSleep.UseVisualStyleBackColor = true;
            // 
            // checkCLMicrophone
            // 
            this.checkCLMicrophone.AutoSize = true;
            this.checkCLMicrophone.Location = new System.Drawing.Point(21, 465);
            this.checkCLMicrophone.Margin = new System.Windows.Forms.Padding(4);
            this.checkCLMicrophone.Name = "checkCLMicrophone";
            this.checkCLMicrophone.Size = new System.Drawing.Size(104, 21);
            this.checkCLMicrophone.TabIndex = 37;
            this.checkCLMicrophone.Text = "Microphone";
            this.checkCLMicrophone.UseVisualStyleBackColor = true;
            // 
            // checkCLDot
            // 
            this.checkCLDot.AutoSize = true;
            this.checkCLDot.Location = new System.Drawing.Point(21, 437);
            this.checkCLDot.Margin = new System.Windows.Forms.Padding(4);
            this.checkCLDot.Name = "checkCLDot";
            this.checkCLDot.Size = new System.Drawing.Size(82, 21);
            this.checkCLDot.TabIndex = 36;
            this.checkCLDot.Text = "Red Dot";
            this.checkCLDot.UseVisualStyleBackColor = true;
            // 
            // checkCLPower
            // 
            this.checkCLPower.AutoSize = true;
            this.checkCLPower.Location = new System.Drawing.Point(21, 409);
            this.checkCLPower.Margin = new System.Windows.Forms.Padding(4);
            this.checkCLPower.Name = "checkCLPower";
            this.checkCLPower.Size = new System.Drawing.Size(113, 21);
            this.checkCLPower.TabIndex = 35;
            this.checkCLPower.Text = "Power button";
            this.checkCLPower.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 384);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Caps Lock status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 555);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Delay:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(63, 553);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown1.TabIndex = 40;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // checkHDD
            // 
            this.checkHDD.AutoSize = true;
            this.checkHDD.Location = new System.Drawing.Point(21, 316);
            this.checkHDD.Margin = new System.Windows.Forms.Padding(4);
            this.checkHDD.Name = "checkHDD";
            this.checkHDD.Size = new System.Drawing.Size(265, 21);
            this.checkHDD.TabIndex = 41;
            this.checkHDD.Text = "Disable disk drives activity monitoring";
            this.checkHDD.UseVisualStyleBackColor = true;
            this.checkHDD.CheckedChanged += new System.EventHandler(this.checkHDD_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 28);
            this.button2.TabIndex = 42;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 550);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 28);
            this.button3.TabIndex = 43;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(123, 683);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(316, 28);
            this.button4.TabIndex = 44;
            this.button4.Text = "Register to run at system startup as admin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(139, 345);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 28);
            this.button5.TabIndex = 47;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(63, 347);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown2.TabIndex = 46;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 350);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Delay:";
            // 
            // checkNLSleep
            // 
            this.checkNLSleep.AutoSize = true;
            this.checkNLSleep.Location = new System.Drawing.Point(164, 494);
            this.checkNLSleep.Margin = new System.Windows.Forms.Padding(4);
            this.checkNLSleep.Name = "checkNLSleep";
            this.checkNLSleep.Size = new System.Drawing.Size(105, 21);
            this.checkNLSleep.TabIndex = 52;
            this.checkNLSleep.Text = "Sleep moon";
            this.checkNLSleep.UseVisualStyleBackColor = true;
            // 
            // checkNLMicrophone
            // 
            this.checkNLMicrophone.AutoSize = true;
            this.checkNLMicrophone.Location = new System.Drawing.Point(164, 465);
            this.checkNLMicrophone.Margin = new System.Windows.Forms.Padding(4);
            this.checkNLMicrophone.Name = "checkNLMicrophone";
            this.checkNLMicrophone.Size = new System.Drawing.Size(104, 21);
            this.checkNLMicrophone.TabIndex = 51;
            this.checkNLMicrophone.Text = "Microphone";
            this.checkNLMicrophone.UseVisualStyleBackColor = true;
            // 
            // checkNLDot
            // 
            this.checkNLDot.AutoSize = true;
            this.checkNLDot.Location = new System.Drawing.Point(164, 437);
            this.checkNLDot.Margin = new System.Windows.Forms.Padding(4);
            this.checkNLDot.Name = "checkNLDot";
            this.checkNLDot.Size = new System.Drawing.Size(82, 21);
            this.checkNLDot.TabIndex = 50;
            this.checkNLDot.Text = "Red Dot";
            this.checkNLDot.UseVisualStyleBackColor = true;
            // 
            // checkNLPower
            // 
            this.checkNLPower.AutoSize = true;
            this.checkNLPower.Location = new System.Drawing.Point(164, 409);
            this.checkNLPower.Margin = new System.Windows.Forms.Padding(4);
            this.checkNLPower.Name = "checkNLPower";
            this.checkNLPower.Size = new System.Drawing.Size(113, 21);
            this.checkNLPower.TabIndex = 49;
            this.checkNLPower.Text = "Power button";
            this.checkNLPower.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 384);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "NumLock status:";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(21, 523);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(180, 21);
            this.checkBox5.TabIndex = 53;
            this.checkBox5.Text = "Disable keys monitoring";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(212, 518);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 28);
            this.button6.TabIndex = 54;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 719);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 28);
            this.button7.TabIndex = 55;
            this.button7.Text = "Debug LEDs (advanced)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(231, 719);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 56;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // rememberKBD
            // 
            this.rememberKBD.Location = new System.Drawing.Point(21, 586);
            this.rememberKBD.Margin = new System.Windows.Forms.Padding(4);
            this.rememberKBD.Name = "rememberKBD";
            this.rememberKBD.Size = new System.Drawing.Size(436, 40);
            this.rememberKBD.TabIndex = 57;
            this.rememberKBD.Text = "Remember keyboard illumination level after restart, sleep, and other power events" +
    "";
            this.rememberKBD.UseVisualStyleBackColor = true;
            this.rememberKBD.CheckedChanged += new System.EventHandler(this.rememberKBD_CheckedChanged);
            // 
            // lightTimer
            // 
            this.lightTimer.Interval = 1000;
            this.lightTimer.Tick += new System.EventHandler(this.lightTimer_Tick);
            // 
            // checkTurnKBLightOff
            // 
            this.checkTurnKBLightOff.Location = new System.Drawing.Point(21, 634);
            this.checkTurnKBLightOff.Margin = new System.Windows.Forms.Padding(4);
            this.checkTurnKBLightOff.Name = "checkTurnKBLightOff";
            this.checkTurnKBLightOff.Size = new System.Drawing.Size(436, 40);
            this.checkTurnKBLightOff.TabIndex = 58;
            this.checkTurnKBLightOff.Text = "Turn keyboard light off when applications go full screen (ideal for movie watchin" +
    "g)";
            this.checkTurnKBLightOff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 755);
            this.Controls.Add(this.checkTurnKBLightOff);
            this.Controls.Add(this.rememberKBD);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkNLSleep);
            this.Controls.Add(this.checkNLMicrophone);
            this.Controls.Add(this.checkNLDot);
            this.Controls.Add(this.checkNLPower);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkHDD);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkCLSleep);
            this.Controls.Add(this.checkCLMicrophone);
            this.Controls.Add(this.checkCLDot);
            this.Controls.Add(this.checkCLPower);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkHDDSleep);
            this.Controls.Add(this.checkHDDMicrophone);
            this.Controls.Add(this.checkHDDDot);
            this.Controls.Add(this.checkHDDPower);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkHDDWriteSleep);
            this.Controls.Add(this.checkHDDWriteMicrophone);
            this.Controls.Add(this.checkHDDWriteDot);
            this.Controls.Add(this.checkHDDWritePower);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkHDDReadSleep);
            this.Controls.Add(this.checkHDDReadMicrophone);
            this.Controls.Add(this.checkHDDReadDot);
            this.Controls.Add(this.checkHDDReadPower);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sleepBlink);
            this.Controls.Add(this.sleepOff);
            this.Controls.Add(this.sleepOn);
            this.Controls.Add(this.microphoneBlink);
            this.Controls.Add(this.microphoneOff);
            this.Controls.Add(this.microphoneOn);
            this.Controls.Add(this.dotBlink);
            this.Controls.Add(this.dotOff);
            this.Controls.Add(this.dotOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.powerBlink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powerOff);
            this.Controls.Add(this.powerOn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThinkPad LEDs Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerOn;
        private System.Windows.Forms.Button powerOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button powerBlink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dotBlink;
        private System.Windows.Forms.Button dotOff;
        private System.Windows.Forms.Button dotOn;
        private System.Windows.Forms.Button microphoneBlink;
        private System.Windows.Forms.Button microphoneOff;
        private System.Windows.Forms.Button microphoneOn;
        private System.Windows.Forms.Button sleepBlink;
        private System.Windows.Forms.Button sleepOff;
        private System.Windows.Forms.Button sleepOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkHDDReadPower;
        private System.Windows.Forms.CheckBox checkHDDReadDot;
        private System.Windows.Forms.CheckBox checkHDDReadMicrophone;
        private System.Windows.Forms.CheckBox checkHDDReadSleep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker workerHDD;
        private System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.Windows.Forms.CheckBox checkHDDWriteSleep;
        private System.Windows.Forms.CheckBox checkHDDWriteMicrophone;
        private System.Windows.Forms.CheckBox checkHDDWriteDot;
        private System.Windows.Forms.CheckBox checkHDDWritePower;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkHDDSleep;
        private System.Windows.Forms.CheckBox checkHDDMicrophone;
        private System.Windows.Forms.CheckBox checkHDDDot;
        private System.Windows.Forms.CheckBox checkHDDPower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.CheckBox checkCLSleep;
        private System.Windows.Forms.CheckBox checkCLMicrophone;
        private System.Windows.Forms.CheckBox checkCLDot;
        private System.Windows.Forms.CheckBox checkCLPower;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkHDD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkNLSleep;
        private System.Windows.Forms.CheckBox checkNLMicrophone;
        private System.Windows.Forms.CheckBox checkNLDot;
        private System.Windows.Forms.CheckBox checkNLPower;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox rememberKBD;
        private System.Windows.Forms.Timer lightTimer;
        private System.Windows.Forms.CheckBox checkTurnKBLightOff;
    }
}

