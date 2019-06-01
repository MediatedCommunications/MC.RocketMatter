using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter {
    public class ContactsWrapper : ContactsWrapper<LinkedList<ClientData>> {
        
    }

    public class ContactsWrapper<T> : DataWrapper {
        public T Contacts { get; set; }
    }

}
