﻿using System;
using BoonieBear.DeckUnit.Mov4500UI.ViewModel;
using log4net;
namespace BoonieBear.DeckUnit.Mov4500UI.Helpers
{
    /// <summary>
    /// 使用Log4net的log帮助类
    /// </summary>
    public class LogHelper
    {
        public static readonly ILog loginfo = LogManager.GetLogger("info");

        public static readonly ILog logerror = LogManager.GetLogger("error");

        public static void WriteLog(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
                App.Current.Dispatcher.Invoke(new Action(() =>
                {
                    if (MainFrameViewModel.pMainFrame != null)
                        MainFrameViewModel.pMainFrame.MsgLog.Add(DateTime.Now.ToLongTimeString() + ":" + info);
                }));
            }
        }
        /// <summary>
        /// 错误记录
        /// </summary>
        /// <param name="info">附加信息</param>
        /// <param name="ex">错误</param>
        public static void ErrorLog(string info, Exception ex)
        {
            if (!string.IsNullOrEmpty(info) && ex == null)
            {
                logerror.ErrorFormat("附加信息 : {0}<br>", new object[] { info });
            }
            else if (!string.IsNullOrEmpty(info) && ex != null)
            {
                string errorMsg = BeautyErrorMsg(ex);
                logerror.ErrorFormat("附加信息 : {0}<br>{1}", new object[] { info, errorMsg });
            }
            else if (string.IsNullOrEmpty(info) && ex != null)
            {
                string errorMsg = BeautyErrorMsg(ex);
                logerror.Error(errorMsg);
            }
            App.Current.Dispatcher.Invoke(new Action(() =>
            {
                if (MainFrameViewModel.pMainFrame != null)
                {
                    MainFrameViewModel.pMainFrame.MsgLog.Add(DateTime.Now.ToLongTimeString() + ":" + info);
                    if (MainFrameViewModel.pMainFrame.MsgLog.Count > 200)
                        MainFrameViewModel.pMainFrame.MsgLog.RemoveAt(0);
                }
            }));
        }
        /// <summary>
        /// 美化错误信息
        /// </summary>
        /// <param name="ex">异常</param>
        /// <returns>错误信息</returns>
        private static string BeautyErrorMsg(Exception ex)
        {
            string errorMsg = string.Format("异常类型：{0} <br>异常信息：{1} <br>堆栈调用：{2}", new object[] { ex.GetType().Name, ex.Message, ex.StackTrace });
            errorMsg = errorMsg.Replace("\r\n", "<br>");
            errorMsg = errorMsg.Replace("位置", "<strong style=\"color:red\">位置</strong>");
            return errorMsg;
        }
    }
}
