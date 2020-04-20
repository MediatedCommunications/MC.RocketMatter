namespace MC.RocketMatter.Sql {
    public class ContactType {
        public byte ID { get; set; }
        public string Name { get; set; }

        public static byte None => 0;
        public static byte Person => 1;
        public static byte Company => 2;
            

    }




}
