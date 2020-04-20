namespace MC.RocketMatter.Sql {
    public class MatterStatusType {
        public int ID { get; set; }
        public string Name { get; set; }

        public static int Open => 0;
        public static int Closed => 1;
        public static int Completed => 2;

    }


}
