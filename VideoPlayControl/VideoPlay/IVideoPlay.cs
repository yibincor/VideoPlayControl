﻿using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    public interface IVideoPlay
    {


        /// <summary>
        /// 当前视频视频设备信息
        /// </summary>
        VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 当前摄像头信息
        /// </summary>
        CameraInfo CurrentCameraInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 当前播放设置
        /// </summary>
        VideoPlaySetting CurrentVideoPlaySet
        {
            get;
            set;
        }

        IntPtr intptrPlayMain
        {
            get;
            set;
        }

        /// <summary>
        /// 当前视频播放状态
        /// </summary>
        Enum_VideoPlayState VideoPlayState
        {
            get;
            set;
        }

        /// <summary>
        /// 视频播放窗口宽度
        /// </summary>
        int VideoplayWindowWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 视频播放窗口高度
        /// </summary>
        int VideoplayWindowHeight
        {
            get;
            set;
        }
        event VideoPlayEventCallBackDelegate VideoPlayEventCallBackEvent;
        
        /// <summary>
        /// 视频播放事件
        /// </summary>
        event VideoPlayCallbackDelegate VideoPlayCallbackEvent;

        bool VideoPlayCallback(VideoPlayCallbackValue value);


        bool VideoPlay();

        bool VideoClose();


        bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart);
        bool VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom);
    }
}
