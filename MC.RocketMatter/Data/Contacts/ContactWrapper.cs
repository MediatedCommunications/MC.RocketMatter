using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter {
    public class ContactWrapper : ContactWrapper<ClientData> {

    }

    public class ContactWrapper<T> : DataWrapper {
        public T Contact { get; set; }
    }


}
