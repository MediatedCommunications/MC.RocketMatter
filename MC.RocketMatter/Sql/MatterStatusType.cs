namespace MC.RocketMatter.Sql {
    public class MatterStatusType {
        public byte ID { get; set; }
        public string Name { get; set; }

        public static byte Open => 0;
        public static byte Closed => 1;
        public static byte Completed => 2;

    }


}
