using Lassalle.Flow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKTradeFlow
{
    class CombinedSignal
    {
        SimpleSignal _signal1;

        internal SimpleSignal Signal1
        {
            get { return _signal1; }
            set { _signal1 = value; }
        }
        SimpleSignal _signal2;

        internal SimpleSignal Signal2
        {
            get { return _signal2; }
            set { _signal2 = value; }
        }
        public CombinedSignal()
        {
 
        }

        //public CombinedSignal(Node node, String name, SimpleAction action, SimpleSignal signal1, SimpleSignal signal2)
        //    : base(node, name, action)
        //{
        //    _signal1 = signal1;
        //    _signal2 = signal2;
        //}
    }
}
