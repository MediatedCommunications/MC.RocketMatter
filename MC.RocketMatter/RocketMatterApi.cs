using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter {

    public class RocketMatterApi {
        private HttpClient HttpClient = new HttpClient();
        private RocketMatterInstance Instance;

        private const long FETCH_MAX = 9999999;

        public static async Task<string> GetDomainForInstall(string Install) {
            var Client = new HttpClient();
            var Response = await Client.Send<string>("https://rocketmatter.net/router/Router.svc/json/GetDomainForInstall", new {
                InstallName = Install,
            }).DefaultAwait();

            //var ret = await Response.Content.ReadAsStringAsync();
            var ret = Response;

            return ret;

        }

        public static async Task<GrantTokenResponse> GrantToken(RocketMatterInstance Instance, string AuthCode, string AppSecret) {
            var Client = new HttpClient();
            var Response = await Client.Send<GrantTokenResponse>(Instance.UrlPrefixSecure("/Authentication.svc/json/GrantToken"), new {
                grant_type = "code",
                code = AuthCode,
                client_secret = AppSecret,
            }).DefaultAwait();


            return Response;
        }


        public RocketMatterApi(RocketMatterInstance Instance, string Authorization) {
            this.Instance = Instance;

            HttpClient.DefaultRequestHeaders.Add("Authorization", Authorization);
        }

        public async Task<TaskWrapper> Task_Add(CreateTaskCommand Task) {
            var Data = new TaskWrapper<CreateTaskCommand> {
                Task = Task
            };

            var ret = await Send<TaskWrapper>("tasks.svc/json/Save", Data)
                .DefaultAwait()
                ;

            return ret;

        }

        public async Task<TimeEntryWrapper> TimeEntry_Add(TimeEntryData Value) {
            var Data = new TimeEntryWrapper {
                BillableTime = Value
            };

            var ret = await Send<TimeEntryWrapper>("/BillableActivity.svc/json/SaveBillableTime", Data)
                .DefaultAwait()
                ;

            return ret;
        }


        public async Task<ClientData> Clients_Add(ClientData Client) {
            var Data = new ClientWrapper {
                Client = Client
            };

            var ret = await Send<ClientData>("Clients.svc/json/Save", Data)
                .DefaultAwait()
                ;

            return ret;
        }


        public Task<ContactWrapper<ContactAddResponse>> Contacts_Add(Object Data) {
            var ret = Send<ContactWrapper<ContactAddResponse>>("Contacts.svc/json/Save", Data);

            return ret;
        }

        public Task<ContactWrapper<ContactAddResponse>> Contacts_Add(ClientData Client) {
            var Data = new ContactWrapper {
                Contact = Client,
            };

            var ret = Contacts_Add(Data);

            return ret;
        }

        public async Task<LinkedList<ContactListResponse>> Contacts_List() {

            var Data = new {
                ClientsOnly = false,
                PageSize = FETCH_MAX,
                RecordIndex = 0,
                Search = "",
                Sort = "LastName",
                StartsWith = ""
            };
            var ret = await Send<ContactsWrapper<LinkedList<ContactListResponse>>>("Contacts.svc/json/GetContactPage", Data)
                .DefaultAwait()
                ;

            return ret.Contacts;
        }

        public async Task<LinkedList<MatterData>> Matters_List() {
            var Data = new {
                SearchText = "",
                ExcludeClosed = false,
                Offset = 0,
                Fetch = FETCH_MAX
            };

            var ret = await Send<MattersWrapper>("Matters.svc/json/GetMattersBySearch", Data)
                .DefaultAwait()
                ;

            return ret.Matters;
        }

        public async Task<MatterWrapper> Matters_Add(CreateMatterCommand Command) {
            var Data = new MatterWrapper<CreateMatterCommand> {
                Matter = Command
            };

            var ret = await Send<MatterWrapper>("Matters.svc/json/Save", Data);

            return ret;
        }

        public Task<DataWrapper> Matters_Delete(long ID) {
            var Data = new {
                MatterId = ID
            };

            return Matters_Delete(Data);
        }

        public async Task<DataWrapper> Matters_Delete(object Data) {
            var ret = await Send<DataWrapper>("Matters.svc/json/DeleteMatter", Data)
                .DefaultAwait()
                ;

            return ret;
        }

        public Task<DataWrapper> Contacts_Delete(long ID) {
            var Data = new {
                Id = ID
            };

            return Contacts_Delete(Data);
        }

        public async Task<DataWrapper> Contacts_Delete(object Data) {
            var ret = await Send<DataWrapper>("Contacts.svc/json/DeleteContact", Data)
                .DefaultAwait()
                ;

            return ret;
        }


        public class InvoiceData {

        }


        public async Task<LinkedList<InvoiceData>> Invoices_List() {
            var Data = new {
                Filter = new {
                    Fetch = FETCH_MAX
                }
            };

            var ret = await Send<Object>("Invoices.svc/json/GetInvoiceDetail", Data)
                .DefaultAwait()
                ;

            return null;
        }


        private Task<T> Send<T>(string Endpoint, object Data) {
            Endpoint = Instance.UrlPrefixSecure(Endpoint);
            return HttpClient.Send<T>(Endpoint, Data);
        }
    }

    internal static class HttpClientExtensions {

        public static async Task<HttpResponseMessage> Send(this HttpClient This, string Url, object Data) {
            var Content = Serializer.Serialize(Data);

            var Request = new HttpRequestMessage(HttpMethod.Post, Url);
            Request.Content = new StringContent(Content, Encoding.UTF8, "application/json");
            var Response = default(HttpResponseMessage);
            try {

                Response = await This.SendAsync(Request)
                    .DefaultAwait()
                    ;
            } catch (Exception ex) {
                ex.Equals(ex);   
            }
            return Response;
        }

        public static async Task<T> Send<T>(this HttpClient This, string Url, object Data) {
            var Response = await This.Send(Url, Data)
                .DefaultAwait()
                ;
            
            var ResponseContent = await Response.Content.ReadAsStreamAsync()
                .DefaultAwait()
                ;

            var ret = Serializer.Deserialize<T>(ResponseContent);

            return ret;
        }
    }

}
