using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter {
    public class ApiClientApplicationInfo {
        public string FriendlyName { get; set; }
        public string Key { get; set; }
        public string Secret { get; set; }
        public string RedirectUrl { get; set; } = "https://www.Example.com";

        public string AuthorizationUrl {
            get {
                var ret = DefaultAuthorizationUrl(Key, RedirectUrl);
                return ret;
            }
        }

        public static string DefaultAuthorizationUrl(string Key, string RedirectUrl) {
            var ret = $@"http://www.rocketmatter.net/public/AuthenticationStart.aspx?client_id={Key}&response_type=code&redirect_uri={RedirectUrl}";

            return ret;
        }

        private string DebuggerDisplay {
            get {
                var ret = $@"{FriendlyName}";
                return ret;
            }
        }

    }
}
