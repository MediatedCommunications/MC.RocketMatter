namespace MC.RocketMatter.Sql {
    public class ContactType {
        public byte ID { get; set; }
        public string Name { get; set; }

        public static byte None => 0;
        public static byte Person => 1;
        public static byte Company => 2;
            

    }


    public class SystemProps {
        public string TheName { get; set; }
        public string TheValue { get; set; }

        public static string EnableDocumentVersions => "EnableDocumentVersions";
        public static string EnableDocumentVersions_True = "true";
        public static string EnableDocumentVersions_False = "false";


    }

}
