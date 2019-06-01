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

        public RocketMatterApi(RocketMatterInstance Instance, string Authorization) {
            this.Instance = Instance;

            HttpClient.DefaultRequestHeaders.Add("Authorization", Authorization);
        }

        public async Task<ClientData> Clients_Add(ClientData Client) {
            var Data = new ClientWrapper {
                Client = Client
            };

            var ret = await Send<ClientData>(Data, "Clients.svc/json/Save");

            return ret;
        }


        public Task<ContactWrapper<ContactAddResponse>> Contacts_Add(Object Data) {
            var ret = Send<ContactWrapper<ContactAddResponse>>(Data, "Contacts.svc/json/Save");

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
            var ret = await Send<ContactsWrapper<LinkedList<ContactListResponse>>>(Data, "Contacts.svc/json/GetContactPage");

            return ret.Contacts;
        }

        public async Task<LinkedList<MatterData>> Matters_List() {
            var Data = new {
                SearchText = "",
                ExcludeClosed = false,
                Offset = 0,
                Fetch = FETCH_MAX
            };

            var ret = await Send<MattersWrapper>(Data, "Matters.svc/json/GetMattersBySearch");

            return ret.Matters;
        }

        public async Task<MatterWrapper> Matters_Add(CreateMatterCommand Command) {
            var Data = new MatterWrapper<CreateMatterCommand> {
                Matter = Command
            };

            var ret = await Send<MatterWrapper>(Data, "Matters.svc/json/Save");

            return ret;
        }

        public Task<DataWrapper> Matters_Delete(long ID) {
            var Data = new {
                MatterId = ID
            };

            return Matters_Delete(Data);
        }

        public async Task<DataWrapper> Matters_Delete(object Data) {
            var ret = await Send<DataWrapper>(Data, "Matters.svc/json/DeleteMatter");

            return ret;
        }

        public Task<DataWrapper> Contacts_Delete(long ID) {
            var Data = new {
                Id = ID
            };

            return Contacts_Delete(Data);
        }

        public async Task<DataWrapper> Contacts_Delete(object Data) {
            var ret = await Send<DataWrapper>(Data, "Contacts.svc/json/DeleteContact");

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

            var ret = await Send<Object>(Data, "Invoices.svc/json/GetInvoiceDetail");

            return null;
        }


        private async Task<T> Send<T>(object Data, string Endpoint) {
            var Content = Serializer.Serialize(Data);

            var Request = new HttpRequestMessage(HttpMethod.Post, Instance.UrlPrefixSecure(Endpoint));
            Request.Content = new StringContent(Content, Encoding.UTF8, "application/json");

            var Response = await HttpClient.SendAsync(Request);
            var ResponseContent = await Response.Content.ReadAsStreamAsync();

            var ret = Serializer.Deserialize<T>(ResponseContent);

            return ret;
        }

    }
}
