using System;
using System.ServiceModel;

namespace MC.RocketMatter {
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
