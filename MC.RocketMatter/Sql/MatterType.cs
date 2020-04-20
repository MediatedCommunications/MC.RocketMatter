namespace MC.RocketMatter.Sql {
    public class MatterType {
        public int ID { get; set; }
        public string Name { get; set; }

        public static int Hourly => 0;
        public static int Contingency => 1;
        public static int FlatFee => 2;

    }


}
