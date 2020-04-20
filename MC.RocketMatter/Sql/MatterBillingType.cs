namespace MC.RocketMatter.Sql {
    public class MatterBillingType {
        public int ID { get; set; }
        public string BillingType { get; set; }

        public static int Billable => 1;
        public static int NonBillable => 2;
        public static int NoCharge => 3;

    }

}
