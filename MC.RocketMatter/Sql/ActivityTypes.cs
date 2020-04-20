namespace MC.RocketMatter.Sql {
    public class ActivityType {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public static int None => 0;
        public static int Activity => 1;
        public static int Timer => 2;
        public static int TodoItem => 3;
        public static int CalendarEntry => 4;
        public static int Expense => 5;
        public static int BilledTime => 6;
        public static int PhoneMessage => 7;
        public static int Document => 8;
        public static int Note => 9;
        public static int EMail => 10;
        public static int FlatFee => 11;

    }


}
