namespace MC.RocketMatter.Sql {
    public class MatterPermissionType {
        public int ID { get; set; }
        public string Name { get; set; }

        public static int Everyone => 1;
        public static int JustMe => 2;
        public static int SpecifiedUsers => 3;


    }


}
