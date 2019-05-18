using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Builder;

namespace MC.RocketMatter.Authentication.Embedded {
    public class ListenerAuthenticationProvider : AuthenticationProvider {
        private ListenerAuthenticationProviderOptions Options { get; set; }

        public ListenerAuthenticationProviderState State { get; private set; }

        public ListenerAuthenticationProvider(ListenerAuthenticationProviderOptions Options) {
            //Snapshot the info.
            this.Options = Options.DeepClone();
        }


        public async Task StartListening() {

            if (State == ListenerAuthenticationProviderState.Stopped) {
                await StartListeningInternal();
            }

        }

        public async Task StopListening() {
            if (State == ListenerAuthenticationProviderState.Listening) {
                await StopListeningInternal();
            }

        }


        private IWebHost Host;
        private Task HostTask;
        public OAuthAcceptanceHandler Implementation { get; private set; } = new OAuthAcceptanceHandler();
        public string EndpointRootUrl { get; private set; } = null;
        public string EndpointAcceptanceUrl { get; private set; } = null;
        public string EndpointAuthorizationUrl { get; private set; } = null;

        private Task StartListeningInternal() {
            Implementation = Implementation ?? new OAuthAcceptanceHandler();

            Host = WebHost.CreateDefaultBuilder()
                .UseKestrel(o => {
                    o.Listen(System.Net.IPAddress.Loopback, 0);
                })
            .ConfigureServices(x => x.AddMvc())
            .ConfigureServices(s => s
                .AddSingleton<OAuthAcceptanceHandler>(Implementation)
                .AddMvc()
                .AddApplicationPart(typeof(OAuthAcceptanceHandler).Assembly)
                .AddControllersAsServices()
            )

            .Configure(x => {
                x.UseMvc();
            })
            .Build()
            ;

            HostTask = Host.RunAsync();

            EndpointRootUrl = Host.ServerFeatures.Get<IServerAddressesFeature>().Addresses.FirstOrDefault();
            EndpointAcceptanceUrl = $@"{EndpointRootUrl}/{OAuthAcceptanceHandler.ImplementationRoute}";

            EndpointAuthorizationUrl = ApiClientApplicationInfo.DefaultAuthorizationUrl(Options.Application.Key, EndpointAcceptanceUrl);


            State = ListenerAuthenticationProviderState.Listening;

            return Task.CompletedTask;
        }

        private async Task StopListeningInternal() {
            await Host.StopAsync();
            await HostTask;
            Host = null;
            HostTask = null;
            EndpointRootUrl = null;
            EndpointRootUrl = null;

        }


    }

}
