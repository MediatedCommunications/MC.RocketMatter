namespace MC.RocketMatter.Sql {
    public class DocumentType {
        public int ID { get; set; }
        public string Name { get; set; }

        public static int Note => 1;
        public static int UploadedDocument => 2;
        public static int WebAddress => 3;
        public static int DropboxFile => 4;
        public static int DropboxDirectory => 5;
        public static int EvernoteNote => 6;
        public static int EvernoteNotebook => 7;
        public static int MergedDocument => 8;
        public static int BoxFile => 9;
        public static int BoxDirectory => 10;
        public static int UploadedDirectory => 11;
    }


}
