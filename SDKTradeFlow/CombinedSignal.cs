using Lassalle.Flow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKTradeFlow
{
    class CombinedSignal : BaseSignal
    {
        BaseSignal _signal1;

        internal BaseSignal Signal1
        {
            get { return _signal1; }
            set { _signal1 = value; }
        }
        BaseSignal _signal2;

        internal BaseSignal Signal2
        {
            get { return _signal2; }
            set { _signal2 = value; }
        }

        public CombinedSignal(Node node, String name, BaseAction action, BaseSignal signal1, BaseSignal signal2):base(node, name, action)
        {
            _signal1 = signal1;
            _signal2 = signal2;
        }
    }
}
