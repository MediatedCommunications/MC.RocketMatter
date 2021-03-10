using System.Linq;

namespace MC.RocketMatter.Sql {
    public static class RmContextExtensions {

        public static void EnableDocumentVersions(this RmContext This) {
            This = This.Clone();

            var SettingName = "EnableDocumentVersions";
            var TrueValue = "true";

            var Setting = (
                from x in This.SystemProps
                where x.TheName == SettingName
                select x
                ).FirstOrDefault();

            if(Setting == default) {
                Setting = new SystemProp() {
                    TheName = SettingName,
                    TheValue = TrueValue,
                };
                This.Add(Setting);
            }

            Setting.TheValue = TrueValue;


            This.SaveChanges();

        }

    }


}
