using System;

namespace MC.RocketMatter {
    public class GrantTokenResponse {
        public string Access_Token { get; set; }
        public DateTimeOffset Expires_At { get; set; }
        public string Refresh_Token { get; set; }
    }

}
