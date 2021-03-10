namespace MC.RocketMatter.Sql {
    public class MatterType {
        public byte ID { get; set; }
        public string Name { get; set; }

        public static byte Hourly => 0;
        public static byte Contingency => 1;
        public static byte FlatFee => 2;

    }


}
