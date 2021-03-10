using System;
using System.Collections.Generic;

namespace MC.RocketMatter.Sql {
    public static class StringExtensions {

        public static bool IsHome(this string This) {
            This = This.ToLower();
            return This.Contains("home");
        }

        public static bool IsWork(this string This) {
            This = This.ToLower();
            return This.Contains("work") || This.Contains("business");
        }


    }


}
