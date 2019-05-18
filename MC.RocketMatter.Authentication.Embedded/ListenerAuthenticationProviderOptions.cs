namespace MC.RocketMatter.Authentication.Embedded {
    public class ListenerAuthenticationProviderOptions {
        public ApiClientApplicationInfo Application { get; set; }


        public virtual ListenerAuthenticationProviderOptions DeepClone() {
            var ret = new ListenerAuthenticationProviderOptions() {
                //PortMin = PortMin,
                //PortMax = PortMax,
                Application = new ApiClientApplicationInfo() {
                    FriendlyName = Application.FriendlyName,
                    Key = Application.Key,
                    Secret = Application.Secret,
                    RedirectUrl = Application.RedirectUrl,
                }
            };

            return ret;
        }

    }

}
