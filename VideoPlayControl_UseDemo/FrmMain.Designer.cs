﻿namespace VideoPlayControl_UseDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.grpVideoInfo = new System.Windows.Forms.GroupBox();
            this.cmbOperAtVideo = new System.Windows.Forms.ComboBox();
            this.cmbPresetCall = new System.Windows.Forms.ComboBox();
            this.cmbVideoType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPTZRight = new System.Windows.Forms.Button();
            this.btnVideoPlay = new System.Windows.Forms.Button();
            this.btnPTZLeft = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPTZDown = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPTZUp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContactPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.pnlBottom_Left = new System.Windows.Forms.Panel();
            this.videoWindowTest = new VideoPlayControl.VideoPlayWindow();
            this.grp_PTZControl = new System.Windows.Forms.GroupBox();
            this.cmbPlayVideoWindowSet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlpPlayVIdeoWindows = new System.Windows.Forms.TableLayoutPanel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvReocrd = new System.Windows.Forms.DataGridView();
            this.dgvReocrd_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReocrd_Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReocrd_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssrTip = new System.Windows.Forms.StatusStrip();
            this.tsslblPrompt = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmbDVSAddress = new System.Windows.Forms.ComboBox();
            this.btnVideoPlayClose = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.grpVideoInfo.SuspendLayout();
            this.pnlBottom_Left.SuspendLayout();
            this.grp_PTZControl.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReocrd)).BeginInit();
            this.ssrTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.grpVideoInfo);
            this.pnlBottom.Controls.Add(this.pnlBottom_Left);
            this.pnlBottom.Controls.Add(this.grp_PTZControl);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 379);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(909, 136);
            this.pnlBottom.TabIndex = 0;
            // 
            // grpVideoInfo
            // 
            this.grpVideoInfo.Controls.Add(this.cmbDVSAddress);
            this.grpVideoInfo.Controls.Add(this.cmbOperAtVideo);
            this.grpVideoInfo.Controls.Add(this.cmbPresetCall);
            this.grpVideoInfo.Controls.Add(this.cmbVideoType);
            this.grpVideoInfo.Controls.Add(this.label1);
            this.grpVideoInfo.Controls.Add(this.btnPTZRight);
            this.grpVideoInfo.Controls.Add(this.btnVideoPlayClose);
            this.grpVideoInfo.Controls.Add(this.btnVideoPlay);
            this.grpVideoInfo.Controls.Add(this.btnPTZLeft);
            this.grpVideoInfo.Controls.Add(this.label5);
            this.grpVideoInfo.Controls.Add(this.btnPTZDown);
            this.grpVideoInfo.Controls.Add(this.label7);
            this.grpVideoInfo.Controls.Add(this.btnPTZUp);
            this.grpVideoInfo.Controls.Add(this.label6);
            this.grpVideoInfo.Controls.Add(this.label4);
            this.grpVideoInfo.Controls.Add(this.txtPassword);
            this.grpVideoInfo.Controls.Add(this.label2);
            this.grpVideoInfo.Controls.Add(this.txtContactPort);
            this.grpVideoInfo.Controls.Add(this.label3);
            this.grpVideoInfo.Controls.Add(this.txtUserName);
            this.grpVideoInfo.Controls.Add(this.txtChannel);
            this.grpVideoInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVideoInfo.Location = new System.Drawing.Point(219, 0);
            this.grpVideoInfo.Name = "grpVideoInfo";
            this.grpVideoInfo.Size = new System.Drawing.Size(557, 136);
            this.grpVideoInfo.TabIndex = 5;
            this.grpVideoInfo.TabStop = false;
            this.grpVideoInfo.Text = "主机信息";
            // 
            // cmbOperAtVideo
            // 
            this.cmbOperAtVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperAtVideo.FormattingEnabled = true;
            this.cmbOperAtVideo.Location = new System.Drawing.Point(221, 15);
            this.cmbOperAtVideo.Name = "cmbOperAtVideo";
            this.cmbOperAtVideo.Size = new System.Drawing.Size(132, 20);
            this.cmbOperAtVideo.TabIndex = 3;
            // 
            // cmbPresetCall
            // 
            this.cmbPresetCall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresetCall.FormattingEnabled = true;
            this.cmbPresetCall.Location = new System.Drawing.Point(304, 110);
            this.cmbPresetCall.Name = "cmbPresetCall";
            this.cmbPresetCall.Size = new System.Drawing.Size(49, 20);
            this.cmbPresetCall.TabIndex = 2;
            // 
            // cmbVideoType
            // 
            this.cmbVideoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoType.FormattingEnabled = true;
            this.cmbVideoType.Location = new System.Drawing.Point(71, 14);
            this.cmbVideoType.Name = "cmbVideoType";
            this.cmbVideoType.Size = new System.Drawing.Size(144, 20);
            this.cmbVideoType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "预置点";
            // 
            // btnPTZRight
            // 
            this.btnPTZRight.Location = new System.Drawing.Point(304, 84);
            this.btnPTZRight.Name = "btnPTZRight";
            this.btnPTZRight.Size = new System.Drawing.Size(49, 23);
            this.btnPTZRight.TabIndex = 0;
            this.btnPTZRight.Text = "右";
            this.btnPTZRight.UseVisualStyleBackColor = true;
            // 
            // btnVideoPlay
            // 
            this.btnVideoPlay.Location = new System.Drawing.Point(221, 35);
            this.btnVideoPlay.Name = "btnVideoPlay";
            this.btnVideoPlay.Size = new System.Drawing.Size(63, 23);
            this.btnVideoPlay.TabIndex = 0;
            this.btnVideoPlay.Text = "播放";
            this.btnVideoPlay.UseVisualStyleBackColor = true;
            this.btnVideoPlay.Click += new System.EventHandler(this.btnVideoPly_Click);
            // 
            // btnPTZLeft
            // 
            this.btnPTZLeft.Location = new System.Drawing.Point(221, 84);
            this.btnPTZLeft.Name = "btnPTZLeft";
            this.btnPTZLeft.Size = new System.Drawing.Size(49, 23);
            this.btnPTZLeft.TabIndex = 0;
            this.btnPTZLeft.Text = "左";
            this.btnPTZLeft.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "密    码:";
            // 
            // btnPTZDown
            // 
            this.btnPTZDown.Location = new System.Drawing.Point(304, 59);
            this.btnPTZDown.Name = "btnPTZDown";
            this.btnPTZDown.Size = new System.Drawing.Size(49, 23);
            this.btnPTZDown.TabIndex = 0;
            this.btnPTZDown.Text = "下";
            this.btnPTZDown.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "设备类型:";
            // 
            // btnPTZUp
            // 
            this.btnPTZUp.Location = new System.Drawing.Point(221, 59);
            this.btnPTZUp.Name = "btnPTZUp";
            this.btnPTZUp.Size = new System.Drawing.Size(49, 23);
            this.btnPTZUp.TabIndex = 0;
            this.btnPTZUp.Text = "上";
            this.btnPTZUp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "连接端口:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "用 户 名:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "12345";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "设备地址:";
            // 
            // txtContactPort
            // 
            this.txtContactPort.Location = new System.Drawing.Point(71, 61);
            this.txtContactPort.Name = "txtContactPort";
            this.txtContactPort.Size = new System.Drawing.Size(54, 21);
            this.txtContactPort.TabIndex = 1;
            this.txtContactPort.Text = "9010";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "通道号:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(71, 84);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "admin";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(184, 61);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(31, 21);
            this.txtChannel.TabIndex = 1;
            this.txtChannel.Text = "01";
            // 
            // pnlBottom_Left
            // 
            this.pnlBottom_Left.Controls.Add(this.videoWindowTest);
            this.pnlBottom_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottom_Left.Location = new System.Drawing.Point(0, 0);
            this.pnlBottom_Left.Name = "pnlBottom_Left";
            this.pnlBottom_Left.Size = new System.Drawing.Size(219, 136);
            this.pnlBottom_Left.TabIndex = 7;
            // 
            // videoWindowTest
            // 
            this.videoWindowTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoWindowTest.Location = new System.Drawing.Point(0, 0);
            this.videoWindowTest.Name = "videoWindowTest";
            this.videoWindowTest.Size = new System.Drawing.Size(219, 136);
            this.videoWindowTest.TabIndex = 0;
            // 
            // grp_PTZControl
            // 
            this.grp_PTZControl.Controls.Add(this.cmbPlayVideoWindowSet);
            this.grp_PTZControl.Controls.Add(this.label8);
            this.grp_PTZControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_PTZControl.Location = new System.Drawing.Point(776, 0);
            this.grp_PTZControl.Name = "grp_PTZControl";
            this.grp_PTZControl.Size = new System.Drawing.Size(133, 136);
            this.grp_PTZControl.TabIndex = 6;
            this.grp_PTZControl.TabStop = false;
            this.grp_PTZControl.Text = "云台控制";
            // 
            // cmbPlayVideoWindowSet
            // 
            this.cmbPlayVideoWindowSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayVideoWindowSet.FormattingEnabled = true;
            this.cmbPlayVideoWindowSet.Location = new System.Drawing.Point(44, 15);
            this.cmbPlayVideoWindowSet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPlayVideoWindowSet.Name = "cmbPlayVideoWindowSet";
            this.cmbPlayVideoWindowSet.Size = new System.Drawing.Size(75, 20);
            this.cmbPlayVideoWindowSet.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "画面:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 376);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(909, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tlpPlayVIdeoWindows);
            this.pnlMain.Controls.Add(this.splitter2);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(909, 376);
            this.pnlMain.TabIndex = 2;
            // 
            // tlpPlayVIdeoWindows
            // 
            this.tlpPlayVIdeoWindows.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tlpPlayVIdeoWindows.ColumnCount = 1;
            this.tlpPlayVIdeoWindows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlayVIdeoWindows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlayVIdeoWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlayVIdeoWindows.Location = new System.Drawing.Point(0, 0);
            this.tlpPlayVIdeoWindows.Name = "tlpPlayVIdeoWindows";
            this.tlpPlayVIdeoWindows.RowCount = 1;
            this.tlpPlayVIdeoWindows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlayVIdeoWindows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 376F));
            this.tlpPlayVIdeoWindows.Size = new System.Drawing.Size(580, 376);
            this.tlpPlayVIdeoWindows.TabIndex = 9;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(580, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 376);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvReocrd);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(583, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(326, 376);
            this.pnlRight.TabIndex = 7;
            // 
            // dgvReocrd
            // 
            this.dgvReocrd.AllowUserToAddRows = false;
            this.dgvReocrd.AllowUserToDeleteRows = false;
            this.dgvReocrd.AllowUserToResizeRows = false;
            this.dgvReocrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReocrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvReocrd_Time,
            this.dgvReocrd_Tag,
            this.dgvReocrd_Content});
            this.dgvReocrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReocrd.Location = new System.Drawing.Point(0, 0);
            this.dgvReocrd.Name = "dgvReocrd";
            this.dgvReocrd.ReadOnly = true;
            this.dgvReocrd.RowHeadersVisible = false;
            this.dgvReocrd.RowTemplate.Height = 23;
            this.dgvReocrd.Size = new System.Drawing.Size(326, 376);
            this.dgvReocrd.TabIndex = 1;
            // 
            // dgvReocrd_Time
            // 
            this.dgvReocrd_Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvReocrd_Time.HeaderText = "记录事件";
            this.dgvReocrd_Time.Name = "dgvReocrd_Time";
            this.dgvReocrd_Time.ReadOnly = true;
            this.dgvReocrd_Time.Width = 78;
            // 
            // dgvReocrd_Tag
            // 
            this.dgvReocrd_Tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvReocrd_Tag.HeaderText = "记录标签";
            this.dgvReocrd_Tag.Name = "dgvReocrd_Tag";
            this.dgvReocrd_Tag.ReadOnly = true;
            this.dgvReocrd_Tag.Width = 78;
            // 
            // dgvReocrd_Content
            // 
            this.dgvReocrd_Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvReocrd_Content.HeaderText = "记录内容";
            this.dgvReocrd_Content.Name = "dgvReocrd_Content";
            this.dgvReocrd_Content.ReadOnly = true;
            this.dgvReocrd_Content.Width = 78;
            // 
            // ssrTip
            // 
            this.ssrTip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblPrompt});
            this.ssrTip.Location = new System.Drawing.Point(0, 515);
            this.ssrTip.Name = "ssrTip";
            this.ssrTip.Size = new System.Drawing.Size(909, 22);
            this.ssrTip.TabIndex = 7;
            this.ssrTip.Text = "statusStrip1";
            // 
            // tsslblPrompt
            // 
            this.tsslblPrompt.Name = "tsslblPrompt";
            this.tsslblPrompt.Size = new System.Drawing.Size(32, 17);
            this.tsslblPrompt.Text = "提示";
            // 
            // cmbDVSAddress
            // 
            this.cmbDVSAddress.FormattingEnabled = true;
            this.cmbDVSAddress.Items.AddRange(new object[] {
            "X5014851",
            "X6937816",
            "X7438372",
            "X5796224",
            "X4659975",
            "X6227077",
            "X6944415",
            "X7325728",
            "X12041891",
            "X7635198"});
            this.cmbDVSAddress.Location = new System.Drawing.Point(71, 37);
            this.cmbDVSAddress.Name = "cmbDVSAddress";
            this.cmbDVSAddress.Size = new System.Drawing.Size(144, 20);
            this.cmbDVSAddress.TabIndex = 4;
            this.cmbDVSAddress.Text = "X5014851";
            // 
            // btnVideoPlayClose
            // 
            this.btnVideoPlayClose.Location = new System.Drawing.Point(290, 35);
            this.btnVideoPlayClose.Name = "btnVideoPlayClose";
            this.btnVideoPlayClose.Size = new System.Drawing.Size(63, 23);
            this.btnVideoPlayClose.TabIndex = 0;
            this.btnVideoPlayClose.Text = "关闭";
            this.btnVideoPlayClose.UseVisualStyleBackColor = true;
            this.btnVideoPlayClose.Click += new System.EventHandler(this.btnVideoPlayClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 537);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.ssrTip);
            this.Name = "FrmMain";
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Move += new System.EventHandler(this.FrmMain_Move);
            this.pnlBottom.ResumeLayout(false);
            this.grpVideoInfo.ResumeLayout(false);
            this.grpVideoInfo.PerformLayout();
            this.pnlBottom_Left.ResumeLayout(false);
            this.grp_PTZControl.ResumeLayout(false);
            this.grp_PTZControl.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReocrd)).EndInit();
            this.ssrTip.ResumeLayout(false);
            this.ssrTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnVideoPlay;
        private System.Windows.Forms.GroupBox grp_PTZControl;
        private System.Windows.Forms.ComboBox cmbPresetCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPTZRight;
        private System.Windows.Forms.Button btnPTZLeft;
        private System.Windows.Forms.Button btnPTZDown;
        private System.Windows.Forms.Button btnPTZUp;
        private System.Windows.Forms.GroupBox grpVideoInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContactPort;
        private System.Windows.Forms.ComboBox cmbVideoType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip ssrTip;
        private System.Windows.Forms.ToolStripStatusLabel tsslblPrompt;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvReocrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReocrd_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReocrd_Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReocrd_Content;
        private System.Windows.Forms.Panel pnlBottom_Left;
        private System.Windows.Forms.TableLayoutPanel tlpPlayVIdeoWindows;
        private VideoPlayControl.VideoPlayWindow videoWindowTest;
        private System.Windows.Forms.ComboBox cmbPlayVideoWindowSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOperAtVideo;
        private System.Windows.Forms.ComboBox cmbDVSAddress;
        private System.Windows.Forms.Button btnVideoPlayClose;
    }
}

