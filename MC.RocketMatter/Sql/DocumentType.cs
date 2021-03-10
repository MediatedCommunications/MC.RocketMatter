namespace MC.RocketMatter.Sql {
    public class DocumentType {
        public byte ID { get; set; }
        public string Name { get; set; }

        public static class Legacy {

            //The legacy values are no longer used
            public static byte Note => 1;
            public static byte UploadedDocument => 2;
            public static byte WebAddress => 3;
            public static byte DropboxFile => 4;
            public static byte DropboxDirectory => 5;
            public static byte EvernoteNote => 6;
            public static byte EvernoteNotebook => 7;
            public static byte MergedDocument => 8;
            public static byte BoxFile => 9;
            public static byte BoxDirectory => 10;
            public static byte UploadedDirectory => 11;
        }


        public static byte Folder => 1;
        public static byte File => 2;
        public static byte Url => 3;
        public static byte Note => 4;

    }


}
