using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MC.RocketMatter.Authentication.Embedded {
    public class EasyListenerAuthenticationProvider : AuthenticationProvider {

        private ListenerAuthenticationProviderOptions Options;
        public EasyListenerAuthenticationProvider(ListenerAuthenticationProviderOptions Options) {
            this.Options = Options.DeepClone();
        }

        public async Task<AuthenticateOnceResult> AuthenticateOnce(CancellationToken? CancelToken = null) {
            var ret = new AuthenticateOnceResult();


            var Result = default(OAuthAcceptanceEventArgs);

            var TokenCancel = CancelToken ?? CancellationToken.None;

            var TokenAccepted = new CancellationTokenSource();

            var Linked = CancellationTokenSource.CreateLinkedTokenSource(TokenCancel, TokenAccepted.Token);

            var Provider = new ListenerAuthenticationProvider(Options);
            Provider.Implementation.Invoked += (x, y) => {
                Result = y;
                TokenAccepted.Cancel();
            };

            await Provider.StartListening();


            ret.Provider = Provider;
            ret.Result = Task.Run(async () => {
                try {
                    await System.Threading.Tasks.Task.Delay(-1, Linked.Token);
                } catch {

                }
                await Provider.StopListening();

                return Result;
            });

           

            return ret;
        }

    }

    public class AuthenticateOnceResult {
        public ListenerAuthenticationProvider Provider { get; set; }
        public Task<OAuthAcceptanceEventArgs> Result { get; set; }
    }

}
