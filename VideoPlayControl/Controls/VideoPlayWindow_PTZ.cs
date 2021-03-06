﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;

namespace VideoPlayControl.Controls
{
    public partial class VideoPlayWindow_PTZ : VideoPlayWindow
    {
        public VideoPlayWindow_PTZ()
        {
            InitializeComponent();
        }

        private void VideoPlayWindow_PTZ_Load(object sender, EventArgs e)
        {
            videoPTZControl1.PTZControlEvent += VideoPTZControl1_PTZControlEvent;
            this.Click += VideoPlayWindow_PTZ_Click;
        }

        private void VideoPlayWindow_PTZ_Click(object sender, EventArgs e)
        {
            SetPTZControl(false);
        }

        private void VideoPTZControl1_PTZControlEvent(Enum_VideoPTZControl PTZControlCmd, bool bolStart)
        {
            VideoPTZControl(PTZControlCmd, bolStart);
        }

        public override void Init_VideoInfo(VideoInfo vInfo) 
        {
            base.Init_VideoInfo(vInfo);
            SetPTZControl(false);
        }

        /// <summary>
        /// 设置云台控制 
        /// </summary>
        /// <param name="bolValue">true 打开云台控制  false 关闭云台控制</param>
        public void SetPTZControl(bool bolValue)
        {
            if (CurrentVideoInfo != null && CurrentVideoInfo.PTZControlEnable)
            {
                picPTZCOntrol.Visible = !bolValue;
                videoPTZControl1.Visible = bolValue;
            }
            else
            {
                picPTZCOntrol.Visible = false;
                videoPTZControl1.Visible = false;
            }
        }

        private void picPTZCOntrol_Click(object sender, EventArgs e)
        {
            SetPTZControl(true);
        }
    }
}
