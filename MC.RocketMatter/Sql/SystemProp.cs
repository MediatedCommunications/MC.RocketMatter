using System.ComponentModel.DataAnnotations;

namespace MC.RocketMatter.Sql {
    public class SystemProp {

        [Key]
        public string TheName { get; set; }
        public string TheValue { get; set; }
    }


}
