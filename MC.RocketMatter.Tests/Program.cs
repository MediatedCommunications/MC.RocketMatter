using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MC.RocketMatter {
    class Program {
        public static async Task Main(string[] args) {

            var App = new FasterLawApiClientApplicationInfo();


            var Listener = new MC.RocketMatter.Authentication.Embedded.EasyListenerAuthenticationProvider(new Authentication.Embedded.ListenerAuthenticationProviderOptions() {
                Application = App
            });

            var Provider = await Listener.AuthenticateOnce();
            System.Diagnostics.Process.Start(Provider.Provider.EndpointAuthorizationUrl);
            var Auth = await Provider.Result;


            if (Auth == null) {
                Console.WriteLine("Unable to Authenticate");
            } else {

                
                var Domain = await RocketMatterApi.GetDomainForInstall(Auth.Install);

                var Instance = new RocketMatterInstance(Domain, Auth.Install);

                var Grant = await RocketMatterApi.GrantToken(Instance, Auth.Code, App.Secret);
                
                var ApiClient = new MC.RocketMatter.RocketMatterApi(Instance, Grant.Access_Token);


                var AllContacts = await ApiClient.Contacts_List();
                var AllMatters = await ApiClient.Matters_List();
                var AllInvoices = await ApiClient.Invoices_List();


                var ClientData = new ClientData {
                    Code = "1234",
                    Name = "Added Via API",
                    LastName = "Last Name1",
                };
                




            }

            
        }
    }

}
