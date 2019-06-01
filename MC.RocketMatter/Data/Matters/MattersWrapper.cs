using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.RocketMatter {
    public class MatterWrapper : MatterWrapper<MatterData> {

    }

    public class MatterWrapper<T> : DataWrapper {
        public T Matter { get; set; }
    }


    public class MattersWrapper : MattersWrapper<LinkedList<MatterData>> {

    }

    public class MattersWrapper<T> : DataWrapper {
        public T Matters { get; set; }
    }


    public enum MatterStatusTypeId {
        Open = 0,
        Closed = 1,
        Completed = 2,
    }

}
