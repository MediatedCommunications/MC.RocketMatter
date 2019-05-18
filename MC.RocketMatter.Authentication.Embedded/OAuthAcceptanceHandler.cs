using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MC.RocketMatter.Authentication.Embedded {
    [Route(OAuthAcceptanceHandler.ImplementationRoute)]
    public class OAuthAcceptanceHandler : Microsoft.AspNetCore.Mvc.Controller {
        public const string ImplementationRoute = "OAuth/Complete";

        [HttpGet()]
        [Route("")]
        public Task<bool> Invoke(string code = "", string install = "") {
            var args = new OAuthAcceptanceEventArgs() {
                Code = code,
                Install = install
            };

            Invoked?.Invoke(this, args);


            return Task.FromResult(true);
        }

        public event EventHandler<OAuthAcceptanceEventArgs> Invoked;


    }

}
