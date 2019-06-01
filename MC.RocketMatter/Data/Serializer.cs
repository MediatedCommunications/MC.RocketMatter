using Newtonsoft.Json;
using System.IO;

namespace MC.RocketMatter {
    public static class Serializer {
        static JsonSerializer Internal = new JsonSerializer();

        public static T Deserialize<T>(Stream Reader) {
            using (var R = new StreamReader(Reader)) {
                return Deserialize<T>(R);
            }
        }

        public static T Deserialize<T>(TextReader Reader) {
            using (var R = new JsonTextReader(Reader)) {
                return Deserialize<T>(R);
            }
        }


        public static T Deserialize<T>(JsonTextReader Reader) {
            return Internal.Deserialize<T>(Reader);
        }


        public static string Serialize(object O) {
            var ret = JsonConvert.SerializeObject(O);

            return ret;
        }




    }

}
