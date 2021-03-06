﻿using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoEnvironment;

namespace VideoPlayControl
{
    /// <summary>
    /// SDK状态
    /// </summary>
    public static class SDKState
    {

        #region 关于SDK状态描述
        /*****************
         * SDK状态改变模式
         *  触发流程：
         *  1.调用SDK释放方法
         *  2.SDK状态值改变
         *  3.触发SDK状态改变回调
         * ***************/



        #endregion

        #region 委托事件

        #region SDK状态改变
        /// <summary>
        /// SDK状态变化回调 委托
        /// </summary>
        /// <param name="sdkType"></param>
        /// <param name="sdkState"></param>
        public delegate void SDKStateChangeDelegate(PublicClassCurrency.Enum_VideoType sdkType, Enum_SDKState sdkState);

        /// <summary>
        /// SDK状态变化回调 事件
        /// </summary>
        public static event SDKStateChangeDelegate SDKStateChangeEvent;

        /// <summary>
        /// SDK状态变化
        /// </summary>
        public static void SDKStateChange(PublicClassCurrency.Enum_VideoType sdkType, Enum_SDKState sdkState)
        {
            if (SDKStateChangeEvent != null)
            {
                SDKStateChangeEvent(sdkType, sdkState);
            }
        }

        #endregion

        #region SDK状态改变事件

        /// <summary>
        /// SDK事件回调 委托
        /// </summary>
        /// <param name="sdkType"></param>
        /// <param name="sdkState"></param>
        public delegate void SDKEventStateDelegate(PublicClassCurrency.Enum_VideoType sdkType, Enum_SDKStateEventType sdkState);

        /// <summary>
        /// SDK事件回调 事件
        /// </summary>
        public static event SDKEventStateDelegate SDKEventStateEvent;

        /// <summary>
        /// SDK事件回调
        /// </summary>
        public static void SDKEventCallBack(PublicClassCurrency.Enum_VideoType sdkType, Enum_SDKStateEventType sdkStateEvent)
        {
            if (SDKEventStateEvent != null)
            {
                SDKEventStateEvent(sdkType, sdkStateEvent);
            }
        }

        #endregion

        #endregion

        #region 云视通SDK 
        /// <summary>
        /// 云视通SDK状态
        /// </summary>
        private static Enum_SDKState s_CloundSeeSDKState = Enum_SDKState.SDK_Null;
        /// <summary>
        /// 云视通SDK状态
        /// </summary>
        public static Enum_SDKState CloundSeeSDKState
        {
            get { return s_CloundSeeSDKState; }
            set
            {
                s_CloundSeeSDKState = value;
                SDKStateChange(PublicClassCurrency.Enum_VideoType.CloundSee, s_CloundSeeSDKState);
            }
        }


        /// <summary>
        /// 云视通_初始化SDK
        /// </summary>
        public static void CloundSee_SDKInit(int intLocStartPort = -1, string strTempFileDicPath = "")
        {
            if (SDKState.CloundSeeSDKState != Enum_SDKState.SDK_Init)
            {
                SDKEventCallBack(Enum_VideoType.CloundSee, Enum_SDKStateEventType.SDKInitStart);
                // 不属于初始化状态
                ProgParameter.intCloundSee_intLocStartPort = intLocStartPort;
                if (string.IsNullOrEmpty(strTempFileDicPath.Trim()))
                {
                    ProgParameter.strCloundSee_TempDicPath = ProgConstants.ro_strCloundSee_TempDicPath;
                }
                else
                {
                    ProgParameter.strCloundSee_TempDicPath = strTempFileDicPath;
                }

                //初始化
                if (SDK_JCSDK.JCSDK_InitSDK(ProgParameter.intCloundSee_intLocStartPort, ProgParameter.strCloundSee_TempDicPath))
                {
                    SDKState.CloundSeeSDKState = Enum_SDKState.SDK_Init;
                }
                else
                {
                    SDKState.CloundSeeSDKState = Enum_SDKState.SDK_InitFail;
                    return;
                }
                SDKEventCallBack(Enum_VideoType.CloundSee, Enum_SDKStateEventType.SDKInitEnd);
            }
        }

        /// <summary>
        /// 云视通_SDK释放
        /// </summary>
        public static void ColundSee_SDKRelease()
        {
            SDKEventCallBack(Enum_VideoType.CloundSee, Enum_SDKStateEventType.SDKReleaseStart);
            SDK_JCSDK.JCSDK_ReleaseSDK();
            SDKState.CloundSeeSDKState = Enum_SDKState.SDK_Release;
            SDKEventCallBack(Enum_VideoType.CloundSee, Enum_SDKStateEventType.SDKReleaseEnd);

        }

        #endregion

        #region  普顺达 IPCWA
        /// <summary>
        /// 普顺达SDK 
        /// </summary>
        private static Enum_SDKState s_IPCWASDKState = Enum_SDKState.SDK_Null;
        /// <summary>
        /// 普顺达SDK
        /// </summary>
        public static Enum_SDKState IPCWASDKState
        {
            get { return s_IPCWASDKState; }
            set
            {
                s_IPCWASDKState = value;
                SDKStateChange(PublicClassCurrency.Enum_VideoType.IPCWA, s_IPCWASDKState);
            }
        }
        #endregion

        #region 萤石云EzvizSDK 
        /// <summary>
        /// 萤石云SDK状态
        /// </summary>
        private static Enum_SDKState s_EzvizSDKState = Enum_SDKState.SDK_Null;
        /// <summary>
        /// 萤石云SDK状态
        /// </summary>
        public static Enum_SDKState EzvizSDKState
        {
            get { return s_EzvizSDKState; }
            set
            {
                s_EzvizSDKState = value;
                SDKStateChange(Enum_VideoType.Ezviz, s_EzvizSDKState);
            }
        }


        /// <summary>
        /// 萤石云_初始化SDK
        /// </summary>
        public static void Ezviz_SDKInit_Old()
        {
            if (EzvizSDKState != Enum_SDKState.SDK_Init)
            {
                if (SDK_EzvizSDK_Old.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID) == 0)
                {
                    EzvizSDKState = Enum_SDKState.SDK_Init;

                }
                else
                {
                    EzvizSDKState = Enum_SDKState.SDK_InitFail;
                }
            }
        }


        /// <summary>
        /// 萤石云_SDK释放
        /// </summary>
        public static void Ezviz_SDKRelease_Old()
        {
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseStart);
            SDK_EzvizSDK_Old.OpenSDK_FiniLib();
            SDKState.EzvizSDKState = Enum_SDKState.SDK_Release;
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseEnd);
        }


        /// <summary>
        /// 萤石云_初始化SDK
        /// 初始化完成后需要获取Token
        /// </summary>
        public static Enum_SDKState Ezviz_SDKInit()
        {
            //int intResult=
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitStart);
            if (EzvizSDKState != Enum_SDKState.SDK_Init)
            {
                if (SDK_EzvizSDK.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID) == 0)
                {
                    EzvizSDKState = Enum_SDKState.SDK_Init;
                    SDK_EzvizSDK.GetAccessToken();
                    IntPtr intptrToken = Marshal.StringToHGlobalAnsi(ProgParameter.strEzviz_AccessToken);
                    SDK_EzvizSDK.OpenSDK_SetAccessToken(intptrToken);
                    SDK_EzvizSDK.OpenSDK_SetConfigInfo(SDK_EzvizSDK.ConfigKey.CONFIG_OPEN_STREAMTRANS, 1);
                }
                else
                {
                    EzvizSDKState = Enum_SDKState.SDK_InitFail;
                }
            }
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitEnd);
            return EzvizSDKState;
        }

        /// <summary>
        /// 萤石云_SDK释放
        /// </summary>
        public static Enum_SDKState Ezviz_SDKRelease()
        {
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseStart);
            SDK_EzvizSDK.OpenSDK_FiniLib();
            EzvizSDKState = Enum_SDKState.SDK_Release;
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseEnd);
            return EzvizSDKState;
        }


        #endregion

        #region 时刻视频设备 SKVideoSDK

        /// <summary>
        /// 时刻视频SDK状态
        /// </summary>
        private static Enum_SDKState s_SKVideoSDKState = Enum_SDKState.SDK_Null;

        public static Enum_SDKState SKVideoSDKState
        {
            get { return VIdeoEnvironment_Shike.SKVideoSDKState; }
            set
            {
                VIdeoEnvironment_Shike.SKVideoSDKState = value;
            }
        }
        /// <summary>
        /// 时刻视频设备初始化
        /// </summary>
        /// <param name="intAvPort"></param>
        /// <param name="strClientGUID"></param>
        /// <param name="strServerIP"></param>
        /// <param name="uintControlPort"></param>
        /// <param name="uintVideoPort"></param>
        /// <param name="uintAudioPort"></param>
        /// <param name="strRecordDic"></param>
        /// <returns></returns>
        public static Enum_SDKState SKVideoSDKInit()
        {
            VIdeoEnvironment_Shike.SKVideoSDKInit();
            return SKVideoSDKState;
        }

        /// <summary>
        /// 时刻视频设备初始化
        /// </summary>
        /// <param name="intAvPort"></param>
        /// <param name="strClientGUID"></param>
        /// <param name="strServerIP"></param>
        /// <param name="uintControlPort"></param>
        /// <param name="uintVideoPort"></param>
        /// <param name="uintAudioPort"></param>
        /// <param name="strRecordDic"></param>
        /// <returns></returns>
        public static Enum_SDKState SKVideoSDKInit(string strGUId, string strServerIP)
        {
            VIdeoEnvironment_Shike.SKVideoSDKInit(strGUId, strServerIP);
            return SKVideoSDKState;
        }

        /// <summary>
        /// 时刻视频设备初始化
        /// </summary>
        /// <param name="strGUId"></param>
        /// <param name="strServerIP"></param>
        /// <param name="uintControlPort"></param>
        /// <param name="uintVideoPort"></param>
        /// <param name="uintAudioPort"></param>
        /// <param name="uintStreamPort"></param>
        /// <returns></returns>
        public static Enum_SDKState SKVideoSDKInit(string strGUId,string strServerIP, int uintControlPort, int uintVideoPort, int uintAudioPort,int uintStreamPort,string strRecordDirectory="")
        {
            VIdeoEnvironment_Shike.SKVideoSDKInit(strGUId, strServerIP, uintControlPort, uintVideoPort, uintAudioPort, uintStreamPort, strRecordDirectory);
            return SKVideoSDKState;
        }

        /// <summary>
        /// 获取客户端SDK网络状态
        /// 0，客户端不在线，1，客户端在线
        /// </summary>
        /// <returns></returns>
        public static int GetSKSDKClientOlineStatus()
        {
            return VIdeoEnvironment_Shike.GetSKSDKClientOlineStatus();
        }
        #endregion

        #region 华迈云SDK
        /// <summary>
        /// 华迈云SDK状态
        /// </summary>
        private static Enum_SDKState s_HuaMaiSDKState = Enum_SDKState.SDK_Null;

        /// <summary>
        /// 华迈云SDK状态
        /// </summary>
        public static Enum_SDKState HuaMaiSDKState
        {
            get { return s_HuaMaiSDKState; }
            set
            {
                s_HuaMaiSDKState = value;
                SDKStateChange(Enum_VideoType.Ezviz, s_HuaMaiSDKState);
            }
        }

        /// <summary>
        /// 华迈平台初始化
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState HuaMai_Init()
        {
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitStart);
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0; 
            #region 基本信息初始化
            Temp_iResult = SDK_HuaMai.hm_sdk_init();
            if (Temp_iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitException);
                HuaMaiSDKState = Enum_SDKState.SDK_InitFail;
                return HuaMaiSDKState;
            }
            SDK_HuaMai._LOGIN_SERVER_INFO loginInfo = new SDK_HuaMai._LOGIN_SERVER_INFO();
            loginInfo.ip = ProgConstants.c_strHuaMaiSDK_LoginInfo_IP;
            loginInfo.port = ProgConstants.c_strHuaMaiSDK_LoginInfo_Port;
            loginInfo.user = ProgParameter.strHuaMaiLoginInfo_LoginName;
            loginInfo.password = ProgParameter.strHuaMaiLoginInfo_LoginPwd;
            loginInfo.plat_type = "pc";
            loginInfo.hard_ver = "Pentium4";
            loginInfo.soft_ver = "v1.1.0.1789";
            IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SDK_HuaMai._LOGIN_SERVER_INFO)));
            Marshal.StructureToPtr(loginInfo, iServerInfo, false);
            Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref ProgParameter.HuaMai_iServer, 0, 0);
            if (Temp_iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKConnectException);
                HuaMaiSDKState = Enum_SDKState.SDK_InitFail;
                return HuaMaiSDKState;
            }
            #endregion
            Temp_iResult = SDK_HuaMai.hm_server_get_device_list(ProgParameter.HuaMai_iServer);
            if (Temp_iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitException);
                HuaMaiSDKState = Enum_SDKState.SDK_InitFail;
                return HuaMaiSDKState;
            }
            Temp_iResult = SDK_HuaMai.hm_server_get_transfer_info(ProgParameter.HuaMai_iServer);
            if (Temp_iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitException);
                HuaMaiSDKState = Enum_SDKState.SDK_InitFail;
                return HuaMaiSDKState;
            }
            Temp_iResult = SDK_HuaMai.hm_server_get_tree(ProgParameter.HuaMai_iServer, ref ProgParameter.HuaMai_iTree);
            if (Temp_iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitException);
                HuaMaiSDKState = Enum_SDKState.SDK_InitFail;
                return HuaMaiSDKState;
            }
            HuaMaiSDKState = Enum_SDKState.SDK_Init;
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitEnd);
            return HuaMaiSDKState;
        }

        /// <summary>
        /// 华迈平台释放
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState Huamai_Release()
        {
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseStart);
            UInt32 Temp_iResult = 0;
            Temp_iResult = SDK_HuaMai.hm_server_release_tree(ProgParameter.HuaMai_iServer);
            Temp_iResult = SDK_HuaMai.hm_server_disconnect(ProgParameter.HuaMai_iServer);
            HuaMaiSDKState = Enum_SDKState.SDK_Release;
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseEnd);
            return HuaMaiSDKState;
        }

        
        #endregion

        #region HikDVR 海康DVR直连模式
        public static Enum_SDKState s_HikDVRSDKState = Enum_SDKState.SDK_Null;

        public static Enum_SDKState HikDVRSDKState
        {
            get { return s_HikDVRSDKState; }
            private set
            {
                s_HikDVRSDKState = value;
                SDKStateChange(Enum_VideoType.HikDVR, s_HikDVRSDKState);
            }
        }

        /// <summary>
        /// 海康SDK初始化
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState HikDVRSDK_Init()
        {
            HikDVRSDKState = SDK_HikClientSDK.NET_DVR_Init() ? Enum_SDKState.SDK_Init : Enum_SDKState.SDK_InitFail;
            return HikDVRSDKState;
        }
        /// <summary>
        /// 海康SDK 释放
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState HikDVRSDK_Release()
        {
            HikDVRSDKState = SDK_HikClientSDK.NET_DVR_Cleanup() ? Enum_SDKState.SDK_Release : Enum_SDKState.SDK_ReleaseFail;
            return HikDVRSDKState;
        }
        #endregion

        

        #region 雄迈SDK 
        
        public static Enum_SDKState s_XMSDKState = Enum_SDKState.SDK_Null;
        private static SDK_XMSDK.fDisConnect disCallback;
        public static Enum_SDKState XMSDKState
        {
            get { return s_XMSDKState; }
            private set
            {
                s_XMSDKState = value;
                SDKStateChange(Enum_VideoType.XMaiVideo, s_XMSDKState);
            }
        }

        /// <summary>
        /// 雄迈SDK初始化
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState XMSDK_Init()
        {
            disCallback = new SDK_XMSDK.fDisConnect(DisConnectBackCallFunc);
            XMSDKState = SDK_XMSDK.H264_DVR_Init(disCallback, IntPtr.Zero) == 1 ? Enum_SDKState.SDK_Init : Enum_SDKState.SDK_InitFail;
            SDK_XMSDK.H264_DVR_SetConnectTime(2000, 3);
            return XMSDKState;
        }

        private static void DisConnectBackCallFunc(int lLoginID, string pchDVRIP, int nDVRPort, IntPtr dwUser)
        {
            int Temp_intResult = -1;
            foreach (VideoInfo v in SDK_XMSDK.dicXMVideoList.Values)
            {
                if (v.LoginHandle == lLoginID)
                {
                    //释放登陆信息句柄
                    Temp_intResult = SDK_XMSDK.H264_DVR_Logout(v.LoginHandle);
                    v.LoginHandle = -1;
                    v.LoginState = 0;
                }
            }
        }
        /// <summary>
        /// 雄迈SDK 释放
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState XMSDK_Release()
        {
            XMSDKState = SDK_XMSDK.H264_DVR_Cleanup() ? Enum_SDKState.SDK_Release : Enum_SDKState.SDK_ReleaseFail;
            foreach (VideoInfo v in SDK_XMSDK.dicXMVideoList.Values)
            {
                v.LoginHandle = -1;
                v.LoginState = 0;
            }
            return XMSDKState;
        }
        #endregion

        #region 蓝色星际 SDK
        public static Enum_SDKState s_BlueState = Enum_SDKState.SDK_Null;
        public static Enum_SDKState BlueSkySDKState
        {
            get { return s_BlueState; }
            private set
            {
                s_BlueState = value;
                SDKStateChange(Enum_VideoType.BlueSky, s_BlueState);
            }
        }
        public static Enum_SDKState BlueSkySDK_Init()
        {
            BlueSkySDKState = SDK_BlueSDK.dvxSdkInit() == 0 ? Enum_SDKState.SDK_Init : Enum_SDKState.SDK_InitFail;
            return BlueSkySDKState;
        }

        public static Enum_SDKState BlueSkySDK_UnInit()
        {
            BlueSkySDKState = SDK_BlueSDK.dvxSdkDeInit() == 0 ? Enum_SDKState.SDK_Release : Enum_SDKState.SDK_ReleaseFail;
            return BlueSkySDKState;
        }
        #endregion

        #region  宇视视频SDK IMOS
        public static SDK_IMOSSDK.LOGIN_INFO_S IMOSLoginInfo ;


        public static Enum_SDKState s_IMOSSDKState = Enum_SDKState.SDK_Null;
        public static Enum_SDKState IMOSSDKState
        {
            get { return s_IMOSSDKState; }
            private set
            {
                s_IMOSSDKState = value;
                SDKStateChange(Enum_VideoType.IMOS, s_IMOSSDKState);
            }
        }

        /// <summary>
        /// 宇视SDK初始化
        /// 需要注意：宇视支持多个服务器登陆，当前仅考虑单个服务器情况
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState IMOSSDK_Init(string ServerAddress,string CltAddress,string LoginName,string LoginPwd)
        {
            UInt32 ulRet = 0;
            uint srvPort = 8800;

            //1.初始化
            ulRet = SDK_IMOSSDK.IMOS_Initiate("N/A", srvPort, 1, 1);
            //2.加密密码
            IntPtr ptr_MD_Pwd = Marshal.AllocHGlobal(sizeof(char) * SDK_IMOSSDK.IMOS_PASSWD_ENCRYPT_LEN);
            ulRet = SDK_IMOSSDK.IMOS_Encrypt(LoginPwd, (UInt32)LoginPwd.Length, ptr_MD_Pwd);
            String MD_PWD = Marshal.PtrToStringAnsi(ptr_MD_Pwd);
            Marshal.FreeHGlobal(ptr_MD_Pwd);
            //3.登录方法
            IntPtr ptrLoginInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SDK_IMOSSDK.LOGIN_INFO_S)));
            ulRet = SDK_IMOSSDK.IMOS_LoginEx(LoginName, MD_PWD, ServerAddress, CltAddress, ptrLoginInfo);
            IMOSLoginInfo = (SDK_IMOSSDK.LOGIN_INFO_S)Marshal.PtrToStructure(ptrLoginInfo, typeof(SDK_IMOSSDK.LOGIN_INFO_S));
            Marshal.FreeHGlobal(ptrLoginInfo);
            return IMOSSDKState;
        }
        /// <summary>
        /// 宇视SDK 释放
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState IMOSSDK_Release()
        {
            SDK_IMOSSDK.IMOS_LogoutEx(ref IMOSLoginInfo.stUserLoginIDInfo);
            SDK_IMOSSDK.IMOS_CleanUp(IntPtr.Zero);
            return IMOSSDKState;
        }

        #endregion

        #region 时刻H265
        public static Enum_SDKState s_SKVNVideoSDKState = Enum_SDKState.SDK_Null;
        public static Enum_SDKState SKVNVideoSDKState
        {
            get { return s_SKVNVideoSDKState; }
            private set
            {
                s_SKVNVideoSDKState = value;
                SDKStateChange(Enum_VideoType.SKNVideo, s_SKVNVideoSDKState);
            }
        }
        /// <summary>
        /// 时刻H265
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState SKNVideoSDK_Init(string server_addr, int server_port, string client_guid, string sdk_xml_cfg_full_path, string default_save_dir)
        {
            string str = Environment.CurrentDirectory;
            try
            {
                SDK_SKNVideo.SDK_NSK_CLIENT_init(server_addr, server_port, client_guid, sdk_xml_cfg_full_path, default_save_dir);
            }
            catch
            {

                string stssr = Environment.CurrentDirectory;
            }
            //SDK_SKNVideo.SDK_NSK_ALL_open_console();
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

        #endregion


        #region 智诺设备
        private static SDK_ZLNetSDK.fZLDisConnect ZLDisConnect = null;
        public static Enum_SDKState s_ZLVideoSDKState = Enum_SDKState.SDK_Null;
        public static Enum_SDKState ZLVideoSDKState
        {
            get { return s_ZLVideoSDKState; }
            private set
            {
                s_ZLVideoSDKState = value;
                SDKStateChange(Enum_VideoType.ZLVideo, s_ZLVideoSDKState);
            }
        }

        public static void OnDisconnect(int loginHandle, string pchDVRIP, int nDVRPort, IntPtr dwUser)
        {
            //loginHandle 对应的设备已经断线
            //m_nDeviceID = 0;
            return;
        }
        /// <summary>
        /// 智诺视频SDK初始化
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState ZLVideoSDK_Init()
        {
            ZLDisConnect = new SDK_ZLNetSDK.fZLDisConnect(OnDisconnect);
            IntPtr lpUser = IntPtr.Zero;
            SDK_ZLNetSDK.ZLNET_Init(ZLDisConnect, lpUser);
            ZLVideoSDKState = Enum_SDKState.SDK_Init;
            return ZLVideoSDKState;
        }
        /// <summary>
        /// 智诺视频SDK释放
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState ZLVideoSDK_Release()
        {
            ZLVideoSDKState = Enum_SDKState.SDK_Release;
            SDK_ZLNetSDK.ZLNET_Cleanup();
            return ZLVideoSDKState;
        }
        #endregion

        #region 大华设备

        public static Enum_SDKState s_DHVideoSDKState = Enum_SDKState.SDK_Null;
        public static Enum_SDKState DHVideoSDKState
        {
            get { return s_DHVideoSDKState; }
            private set
            {
                s_DHVideoSDKState = value;
                SDKStateChange(Enum_VideoType.DaHuaVideo, s_DHVideoSDKState);
            }
        }
        /// <summary>
        /// 大华SDK初始化
        /// </summary>
        /// <returns></returns>
        public static bool DHVideoSDK_Init()
        {
            bool bolResult = false;
            SDK_DaHua.CLIENT_Init(null, IntPtr.Zero);
            DHVideoSDKState = Enum_SDKState.SDK_Init;
            return bolResult;
        }

        /// <summary>
        /// 大华SDK释放
        /// </summary>
        /// <returns></returns>
        public static bool DHVideoSDK_Release()
        {
            bool bolResult = false;
            SDK_DaHua.CLIENT_Cleanup();
            DHVideoSDKState = Enum_SDKState.SDK_Release;
            return bolResult;
        }
        #endregion
        public static void VideoSDKRelease()
        {
            ColundSee_SDKRelease(); //云视通SDK 
            Ezviz_SDKRelease();     //萤石云SDK 
            if (HuaMaiSDKState != Enum_SDKState.SDK_Null || HuaMaiSDKState != Enum_SDKState.SDK_Release)
            {
                Huamai_Release();
            }
        }
    }
}
