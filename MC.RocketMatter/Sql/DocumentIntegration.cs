namespace MC.RocketMatter.Sql {
    public class DocumentIntegration {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ServiceNameSpace { get; set; }
        public bool? AutomaticallyCreateFolders { get; set; }
        public string AuthUrl { get; set; }
        public string ImageFileName { get; set; }
        public bool? IsFolderModel { get; set; }
        public bool? IsWorkSpaceModel { get; set; }
        public int? ParentAttribute { get; set; }
        public int? ChildAttribute { get; set; }

        public static int RocketMatter => 1;

    }


}
