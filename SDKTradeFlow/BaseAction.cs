using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lassalle.Flow;

namespace SDKTradeFlow
{
    class BaseAction
    {
        private Node _node;

        public Node Node
        {
            get { return _node; }
            set { _node = value; }
        }
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private List<BaseSignal> _signals = new List<BaseSignal>();

        internal List<BaseSignal> Signals
        {
            get { return _signals; }
            set { _signals = value; }
        }

        private Global.ActionOption _option;

        internal Global.ActionOption Option
        {
            get { return _option; }
            set { _option = value; }
        }
        private String _stockId;

        public String StockId
        {
            get { return _stockId; }
            set { _stockId = value; }
        }
        private float _amount;

        public float Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public BaseAction(Node node,String name, BaseSignal signal, Global.ActionOption option, String stockId, float amount)
        {
            _node = node;
            _name = name;
            if (signal != null)
                _signals.Add(signal);
            _option = option;
            _stockId = stockId;
            _amount = amount;
        }

        public void run()
        {
            //TODO action
        }

    }
}
