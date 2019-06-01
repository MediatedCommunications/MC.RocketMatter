using System;

namespace MC.RocketMatter {
    public class RocketMatterInstance {
        public RocketMatterInstance(string Domain, string Install) {
            try {
                var Url = new Uri(Domain);
                Domain = Url.Host;
            } catch {

            }

            this.Domain = Domain;
            this.Install = Install;
            this.__UrlPrefix = $@"http://{Domain}/{Install}/API_V2/";
            this.__UrlPrefixSecure = $@"https://{Domain}/{Install}/API_V2/";

        }

        public string Domain { get; private set; }
        public string Install { get; private set; }
        private string __UrlPrefix { get; set; }
        private string __UrlPrefixSecure { get; set; }

        public string UrlPrefix(string UrlSuffix) {
            var ret = $@"{__UrlPrefix}{UrlSuffix}";
            return ret;
        }

        public string UrlPrefixSecure(string UrlSuffix) {
            var ret = $@"{__UrlPrefixSecure}{UrlSuffix}";
            return ret;
        }


    }

}
