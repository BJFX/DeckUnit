﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoonieBear.DeckUnit.CommLib
{
    public enum SerialServiceMode
    {
        LoaderMode = 0,
        HexMode = 1,
    }
    /// <summary>
    /// 调用模式：NoneMode,无模式：用于UDP调试接收，TCPshell接收
    /// AnsMode，应答模式：用于串口命令应答接收，TCP数据应答接收
    /// DataMode，数据模式：用于串口数据接收，TCP数据接收，UDP数据接收
    /// LoaderMode，loader模式：用于串口loader模式通信
    /// </summary>
    public enum CallMode
    {
        NoneMode =0,
        AnsMode = 1,
        DataMode =2,
        LoaderMode =3,
    }

    public enum ACNCommandMode
    {
        CmdCharMode=0,
        CmdIDMode =1,
        CmdWithData = 2,
        LoaderDataMode=3,
        
    }
}