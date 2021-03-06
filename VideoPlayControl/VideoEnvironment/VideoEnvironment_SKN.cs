﻿using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using VideoPlayControl.SDKInterface;

namespace VideoPlayControl.VideoEnvironment
{
    public class VideoEnvironment_SKN
    {
        public static Enum_SDKState s_SKVNVideoSDKState = Enum_SDKState.SDK_Null;
        public static Enum_SDKState SKVNVideoSDKState
        {
            get { return s_SKVNVideoSDKState; }
            private set
            {
                s_SKVNVideoSDKState = value;
                SDKState.SDKStateChange(Enum_VideoType.SKNVideo, s_SKVNVideoSDKState);
            }
        }
        /// <summary>
        /// 时刻H265
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState SKNVideoSDK_Init(string server_addr, int server_port, string client_guid, string sdk_xml_cfg_full_path, string default_save_dir)
        {
            string str = Environment.CurrentDirectory;
            SDK_SKNVideo.SDK_NSK_CLIENT_init(server_addr, server_port, client_guid, sdk_xml_cfg_full_path, default_save_dir);
            callbackvalue = new SDK_SKNVideo.CallBack(callback);
            SDK_SKNVideo.SDK_NSK_ALL_regeist_msg_callback(callbackvalue);
            SKVNVideoSDKState = Enum_SDKState.SDK_Init;
            return SKVNVideoSDKState;
        }

        /// <summary>
        /// 时刻H265 释放
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState SKNVideoSDK_Release()
        {
            SKVNVideoSDKState = Enum_SDKState.SDK_Release;
            return SKVNVideoSDKState;
        }

        private static SDK_SKNVideo.CallBack callbackvalue;

        public static void callback(int msg_id, string msg_info, int arg1, int arg2, IntPtr data1, int data1_len, IntPtr data2, int data2_len)
        {
            switch (msg_info)
            {
                case "Download progress.":
                    string strFilePath1 = Marshal.PtrToStringAnsi(data1);
                    callback_downloadprocess(new DownLoadProcessValue { FilePath = strFilePath1, Percent = arg1 });
                    break;

                case "Download done.":
                    string strFilePath = Marshal.PtrToStringAnsi(data1);
                    callback_downloaddone(strFilePath);
                    break;

                case "Device event":
                    //string strGuid = Marshal.PtrToStringAnsi(data1);
                    //string streventdata= Marshal.PtrToStringAnsi(data2);
                    break;

            }
        }

        #region 回调相关信息

        #region 文件下载完成回调

        /// <summary>
        /// 文件下载完成路径
        /// </summary>
        /// <param name="strFilePath">文件相对路径</param>
        public static void callback_downloaddone(string strFilePath)
        {
            DownLoadDone(strFilePath);
        }

        public delegate void DownLoadDoneDelegate(object sender, object value);


        public static event DownLoadDoneDelegate DownLoadDoneEvent;

        private static void DownLoadDone(object value)
        {
            if (DownLoadDoneEvent != null)
            {
                DownLoadDoneEvent(null, value);
            }
        }
        #endregion

        #region 下载进度回调


        public struct DownLoadProcessValue
        {
            /// <summary>
            /// 文件名
            /// </summary>
            public string FilePath
            {
                get;
                set;
            }

            /// <summary>
            /// 百分比
            /// </summary>
            public int Percent
            {
                get;
                set;
            }
        }


        /// <summary>
        /// 文件下载完成路径
        /// </summary>
        /// <param name="strFilePath">文件相对路径</param>
        public static void callback_downloadprocess(DownLoadProcessValue value)
        {
            DownLoadProcess(value);
        }

        public delegate void DownLoadProcessDelegate(object sender, DownLoadProcessValue value);


        public static event DownLoadProcessDelegate DownLoadProcessEvent;

        private static void DownLoadProcess(DownLoadProcessValue value)
        {
            if (DownLoadProcessEvent != null)
            {
                DownLoadProcessEvent(null, value);
            }
        }
        #endregion


        #endregion

    }
}
