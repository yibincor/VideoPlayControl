﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;
using System.Threading;

namespace VideoPlayControl_RemotePlayback
{
    public partial class RemoteBackplayControl : UserControl
    {
        public RemoteBackplayControl()
        {
            InitializeComponent();
        }

        

        private DateTime currentPositionDateTime;

        public DateTime CurrentPositionDateTime
        {
            get
            {
                return currentPositionDateTime;
            }
            set
            {
                SetCurrentPositionDateTime(value);
            }
        }

        private void SetCurrentPositionDateTime(DateTime value)
        {
            if (currentPositionDateTime != value)
            {
                currentPositionDateTime = value;
                Console.WriteLine("SetCurrentPositionDateTime:" + currentPositionDateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                if (PositionDateTimeChangedEvent != null)
                {
                    PositionDateTimeChangedEvent(this, null);
                }
            }
        }

        public delegate void PositionDateTimeChangedDelegate (object sender ,object PositionDateTimeChangedDelegateValue);

        public event PositionDateTimeChangedDelegate PositionDateTimeChangedEvent;






        private VideoChannelRemoteBackplayInfo currentRemoteBackplayInfo;

        public VideoChannelRemoteBackplayInfo CurrentRemoteBackplayInfo
        {
            get { return currentRemoteBackplayInfo; }
            set
            {
                SetRemoteBackplayInfo(value);
            }
        }

        public void SetRemoteBackplayInfo(VideoChannelRemoteBackplayInfo value)
        {
            if (currentRemoteBackplayInfo != value)
            {
                proportionInfo.SetRemoteBackplayInfo_Scale(this.Width / 6);
            }
            currentRemoteBackplayInfo = value;
            proportionInfo.SetRemoteBackplayInfo(value);
        }

        int intInitialWidth = 0;

        public int MaxWitdh
        {
            get
            {
                return (intInitialWidth * 10);
            }
        }
        private void RemoteBackplayControl_Load(object sender, EventArgs e)
        {
            proportionInfo.Width = this.Width;
            proportionInfo.Height = this.Height - 12;
            intInitialWidth = proportionInfo.Width;
            proportionInfo.MouseWheel += RemoteBackplayProportionControl1_MouseWheel;
        }


        bool bolFlag1 = false;
        int Temp_intX = 0;
        private void RemoteBackplayProportionControl1_MouseDown(object sender, MouseEventArgs e)
        {
            bolFlag1 = true;
            Temp_intX = e.X;

            //StringBuilder sbDisplayInfo = new StringBuilder();
            //sbDisplayInfo.Append("MouseDown" + DateTime.Now.ToString("mm:ss:fff"));
            //sbDisplayInfo.Append("e.X:" + e.X + ";e.Y：" + e.Y);
            //Console.WriteLine(sbDisplayInfo.ToString());
        }

        private void RemoteBackplayProportionControl1_MouseUp(object sender, MouseEventArgs e)
        {
            bolFlag1 = false;
            //如果文件头尾超过中间，复位
            if (proportionInfo.Location.X > pnlFlag.Location.X)
            {
                //起始事件超过中间线
                proportionInfo.Location = new Point { X = pnlFlag.Location.X, Y = proportionInfo.Location.Y };

            }
            else if ((proportionInfo.Location.X + proportionInfo.Width) < pnlFlag.Location.X)
            {
                //终止事件小于中间线
                proportionInfo.Location = new Point { X = (pnlFlag.Location.X - proportionInfo.Width) + 10, Y = proportionInfo.Location.Y };
            }
            CommonMethod.Common.Delay_Millisecond(10);
            SetRemoteBackplayInfo(currentRemoteBackplayInfo);

            //当前中间的时间值
            SetCurrentPositionDateTime(GetFlagDateTime());
        }

        private void RemoteBackplayProportionControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bolFlag1)
            {
                int Temp_intxxx = e.X - Temp_intX;
                proportionInfo.Location = new Point { X = proportionInfo.Location.X + Temp_intxxx, Y = proportionInfo.Location.Y };
                SetRemoteBackplayInfo(currentRemoteBackplayInfo);
            }
        }

        private void RemoteBackplayProportionControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (proportionInfo.Width < MaxWitdh)
                {
                    proportionInfo.Width = proportionInfo.Width * 2;
                    proportionInfo.SetRemoteBackplayInfo_Scale(this.Width / 6);
                }
                
            }
            else
            {
                if (proportionInfo.Width > intInitialWidth)
                {
                    proportionInfo.Width = proportionInfo.Width / 2;
                    proportionInfo.SetRemoteBackplayInfo_Scale(this.Width / 6);
                }
            }
            SetRemoteBackplayInfo(currentRemoteBackplayInfo);
        }

        private void ProportionInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Temp_int = pnlFlag.Location.X - e.X;
            proportionInfo.Location = new Point { X = Temp_int, Y = proportionInfo.Location.Y };
            SetCurrentPositionDateTime(GetFlagDateTime());
        }


        public DateTime GetFlagDateTime()
        {
            int Temp_value = pnlFlag.Location.X - proportionInfo.Location.X;
            long lResult = proportionInfo.Get(Temp_value);
            DateTime tim = VideoCurrencyModule.PubMethod.UnixMillisecondsTimestampToDateTime(lResult);
            return tim;
        }
        public void Teset()
        {
            return;
            int Temp_int = this.Width / 6;

            int Temp_inti = (Temp_int + 5) / 5;
            for (int i = 0; i <= 506; i++)
            {
                int Temp_intxxx = (i * Temp_int);
                if (Temp_intxxx > proportionInfo.Width)
                {
                    return;
                }
                Console.WriteLine("Big " + (i + 1) + " :" + Temp_intxxx);
                Panel p = new Panel();
                p.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                p.Location = new System.Drawing.Point(Temp_intxxx, 15);
                p.Name = "panel1";
                p.Size = new System.Drawing.Size(1, 65);
                proportionInfo.ControlsAdd(p);
                for (int j = 1; j < 5; j++)
                {
                    int Temp_intyyyy = (j * Temp_inti);
                    Console.WriteLine("Min " + (j + 1) + " :" + Temp_intyyyy);
                    Panel pp = new Panel();
                    pp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                    pp.Location = new System.Drawing.Point(Temp_intxxx + Temp_intyyyy, 35);
                    pp.Name = "panel2";
                    pp.Size = new System.Drawing.Size(1, 35);
                    proportionInfo.ControlsAdd(pp);
                }
            }
        }

    }
}