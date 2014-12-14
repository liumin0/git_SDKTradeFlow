using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lassalle.Flow;

namespace SDKTradeFlow
{
    class SimpleSignal : BaseSignal
    {
        private float _value;

        public float Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private String _indicator;

        public String Indicator
        {
            get { return _indicator; }
            set { _indicator = value; }
        }

        public SimpleSignal(Node node, String name, String indicator, float value, BaseAction action):base(node, name, action)
        {
            _indicator = indicator;
            _value = value;
        }
    }
}
