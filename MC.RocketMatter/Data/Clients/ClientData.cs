namespace MC.RocketMatter {
    public class ClientData {

        public long? ID { get; set; }

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

}
