﻿using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.Enum;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.VideoEnvironment;
using static VideoPlayControl.SDKInterface.SDK_ZHSRSDK;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 珠海三润
    /// </summary>
    public class VideoPlay_ZHSR : IVideoPlay_Basic
    {

        public string Monitor_Guid = "";


        /// <summary>
        /// 呼叫会话号
        /// </summary>
        public string Tsk_Guid { get; set; } = "";

        public VideoPlay_ZHSR(CameraInfo cInfo)
        {
            this.CurrentCameraInfo = cInfo;
            this.CurrentVideoInfo = cInfo.VideoInfo;
        }

        public override bool VideoPlay()
        {
            VideoEnvironment_ZHSR.ZHSR_Main_Callback_Event -= VideoEnvironment_ZHSR_ZHSR_Main_Callback_Event;
            VideoEnvironment_ZHSR.ZHSR_Main_Callback_Event += VideoEnvironment_ZHSR_ZHSR_Main_Callback_Event;
            int intChannel = CurrentCameraInfo.Channel - 1;
            int md_tp = 1;
            int iRet = -1;
            if (CurrentVideoPlaySet.VideoTalkEnable)
            {
                md_tp = 3;
                iRet = SDK_ZHSRSDK.win_sta_usr_call_req(VideoEnvironment_ZHSR.Session, CurrentVideoInfo.DVSAddress, intChannel, 0, md_tp, 1, (int)intptrPlayMain);
            }
            else if (CurrentVideoPlaySet.VideoMonitorEnable)
            {
                iRet = SDK_ZHSRSDK.win_sta_start_monitor(VideoEnvironment_ZHSR.Session, CurrentVideoInfo.DVSAddress, intChannel, 0, 3, 1, (int)intptrPlayMain);
            }
            else
            {
                iRet = SDK_ZHSRSDK.win_sta_start_monitor(VideoEnvironment_ZHSR.Session, CurrentVideoInfo.DVSAddress, intChannel, 0, 1, 1, (int)intptrPlayMain);
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.RequestConn });
            if (iRet < 0)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.ConnFailed });
                return false;
            }
            return true;

        }

        private void VideoEnvironment_ZHSR_ZHSR_Main_Callback_Event(string messageID, Dictionary<string, string> data)
        {
            string status = "";
            switch (messageID)
            {
                case Main_Callback_Type.monitor_tsk_status:
                case Main_Callback_Type.tk_tsk_status:  //对讲
                    status = data["status"];
                    if (status == "0") //会话状态0为 未监视，其他为 正在监视
                    {
                        Monitor_Guid = "";
                    }
                    else
                    {
                        Monitor_Guid = data["tsk_guid"]; //正在监视，赋值为会话号
                        VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
                    }   
                    break;
            }
        }

        public override bool VideoClose()
        {
            VideoEnvironment_ZHSR.ZHSR_Main_Callback_Event -= VideoEnvironment_ZHSR_ZHSR_Main_Callback_Event;
            SDK_ZHSRSDK.win_sta_stop_task(VideoEnvironment_ZHSR.Session, Monitor_Guid);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            CommonMethod.Common.Delay_Millisecond(300);
            PicPlayMain.Refresh();
            return true;
        }
    }
}
