﻿using Hubery.Sqless.Demo.Common;

namespace Hubery.Sqless.Demo.Wpf
{
    public class WpfGlobal
    {
        public static User LoginUser { get; set; } = null;

        public static string ApiUrl { get; } = "http://localhost:6688/api";
    }
}
