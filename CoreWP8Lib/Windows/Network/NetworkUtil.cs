using CoreWP8Lib.Windows.Network;
using Microsoft.Phone.Net.NetworkInformation;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CoreWP8Lib.Windows.Network
{
    public class NetworkUtil : INetworkUtil
    {
        private static NetworkUtil util;
        public NetworkUtil CreateInstance()
        {
            if (null == util) util = new NetworkUtil();
            return util;
        }

        public bool IsExistNetwork()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        public bool IsWifiNetwork()
        {
            NetworkInterfaceType type = NetworkInterface.NetworkInterfaceType;
            return type == NetworkInterfaceType.Wireless80211;
        }
    }
}
