using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

                
                var Client = ServiceProvider.Instance.CreateRouterClient();

                var Domain = Client.GetDomainForInstall(Auth.Install);

                var Instance = new RocketMatterInstance(Domain, Auth.Install);

                var AuthService = ServiceProvider.Instance.CreateAuthenticationClient(Instance);
                var Grant = AuthService.GrantToken(new Authentication.GrantTokenRequest() {
                    grant_type = "code",
                    code = Auth.Code,
                    client_secret = App.Secret,
                });


                var HttpClient = new HttpClient();
                HttpClient.DefaultRequestHeaders.Add("Authorization", Grant.access_token);

                var ClientToAdd = new {
                    Client = new AddClientRequest {
                        Code = "1234",
                        Name = "Added Via API"
                    }
                };

                var Content = JsonConvert.SerializeObject(ClientToAdd);
                

                var Request = new HttpRequestMessage(HttpMethod.Post, Instance.UrlPrefix("Clients.svc/json/Save"));
                Request.Content = new StringContent(Content, Encoding.UTF8, "text/xml");
                //Request.Content = new StringContent(Content, Encoding.UTF8, "application/json");

                var Response = await HttpClient.SendAsync(Request);



            }

            
        }
    }

    public class AddClientRequest {
        public string Code { get; set; } = "";

        public string Name { get; set; } = "";
        public string FullName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string LastName { get; set; } = "";
        public bool IsCompany { get; set; } = false;



        public string HomeEmail { get; set; } = "";
        public string HomePhone { get; set; } = "";
        public Address HomeAddress { get; set; } = new Address();

        public string WorkEmail { get; set; } = "";
        public Address WorkAddress { get; set; } = new Address();
        public string WorkPhone { get; set; } = "";
        public string WorkPhoneExt { get; set; } = "";

        public string MobilePhone { get; set; } = "";
        public string Notes { get; set; } = "";
        public string PreferredDisplayName { get; set; } = "";
        public string Salutation { get; set; } = "";
        public string Title { get; set; } = "";
    }

    public class Address {
        public string AddressLine1 { get; set; } = "";
        public string AddressLine2 { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Country { get; set; } = "";
        public bool IsEmpty { get; set; } = false;
    }

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

        }

        public string Domain { get; private set; }
        public string Install { get; private set; }
        private string __UrlPrefix { get; set; }

        public string UrlPrefix(string UrlSuffix) {
            var ret = $@"{__UrlPrefix}{UrlSuffix}";
            return ret;
        }


    }

    public class ServiceProvider {
        public static ServiceProvider Instance { get; private set; } = new ServiceProvider();


        public Authentication.AuthenticationClient CreateAuthenticationClient(RocketMatterInstance Instance) {
            return CreateService<Authentication.AuthenticationClient>("Authentication.svc", Instance);
        }

        public Router.RouterClient CreateRouterClient() {
            return CreateService<Router.RouterClient>("http://rocketmatter.net/router/Router.svc");
        }

        public T CreateService<T>(string UrlSuffix, RocketMatterInstance RocketMatter) where T : class, ICommunicationObject {

            var UrlTemplate = RocketMatter.UrlPrefix(UrlSuffix);

            return CreateService<T>( UrlTemplate);
        }

        public T CreateService<T>(string Url) where T : class, ICommunicationObject {
            var Binding = new BasicHttpBinding();
            var Endpoint = new EndpointAddress(Url);
            var Args = new object[] { Binding, Endpoint };

            var ret = Activator.CreateInstance(typeof(T), Args) as T;

            return ret;
        }

    }

}
