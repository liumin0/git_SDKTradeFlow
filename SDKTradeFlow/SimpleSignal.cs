using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lassalle.Flow;
using TradeLink.API;

namespace SDKTradeFlow
{
    public class SimpleSignal : BaseObject
    {
        private decimal _value;

        public decimal Value
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

        public SimpleSignal(Node node, String name, String indicator, decimal value, SimpleAction action)
            : base(node, name)
        {
            _indicator = indicator;
            _value = value;
            if (action != null)
                _actions.Add(action);
        }

        private List<SimpleAction> _actions = new List<SimpleAction>();

        internal List<SimpleAction> Actions
        {
            get { return _actions; }
            set { _actions = value; }
        }

        public void triggered()
        {
            for(int i = 0; i < _actions.Count; i++)
            {
                
                SimpleAction action = _actions[i];
                //Console.WriteLine("triggered action {0}", action.Name);
                action.triggered(this);
            }
        }

        public void gotTick(Tick tick)
        {
            //Console.WriteLine("indicator: {0} value: {1}, tick.bid: {2}", _indicator, _value, tick.bid);
            if (_indicator == "bid" && tick.bid == _value)
            {
                //Console.WriteLine("tick {0}, sym: {1}", tick.bid, tick.symbol);
                triggered();
            }
            else if (_indicator == "ask" && tick.ask == _value)
            {
                triggered();
            }

        }

        public override void edit()
        {
            SimpleSignalEdit simpleSignalEdit = new SimpleSignalEdit(this);
            simpleSignalEdit.ShowDialog();
        }

    }
}
