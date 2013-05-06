using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWP8Lib.Windows.Network
{
    /// <summary>
    /// 网络状态查询接口类
    /// </summary>
    interface INetworkUtil
    {
        /// <summary>
        /// 当前是否连接了网络
        /// </summary>
        /// <returns></returns>
        public bool IsExistNetwork();
        /// <summary>
        /// 当前是否处于WiFi网络
        /// </summary>
        /// <returns></returns>
        public bool IsWifiNetwork();
    }
}
