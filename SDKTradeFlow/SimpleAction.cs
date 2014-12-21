using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lassalle.Flow;

namespace SDKTradeFlow
{
    public class SimpleAction : BaseObject
    {
        private SimpleSignal _causeSignal;

        public SimpleSignal CauseSignal
        {
            get { return _causeSignal; }
            set { _causeSignal = value; }
        }
        private List<SimpleSignal> _signals = new List<SimpleSignal>();

        internal List<SimpleSignal> Signals
        {
            get { return _signals; }
            set { _signals = value; }
        }

        private Global.ActionType _type;

        public Global.ActionType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private bool _side;

        public bool Side
        {
            get { return _side; }
            set { _side = value; }
        }

        private String _stockId;

        public String StockId
        {
            get { return _stockId; }
            set { _stockId = value; }
        }
        private decimal _amount;

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public SimpleAction(Node node, String name, SimpleSignal signal, bool side, String stockId, decimal amount)
            : base(node, name)
        {
            if (signal != null)
                _signals.Add(signal);
            _side = side;
            _stockId = stockId;
            _amount = amount;
        }
        public event ActionTriggeredDelegate triggeredDel;
        public void triggered(SimpleSignal signal)
        {
            //TODO action
            Console.WriteLine("triggered {0}", signal.Name);
            _causeSignal = signal;
            if (triggeredDel!=null)
                triggeredDel(this);
        }

        public override void edit()
        {
            SimpleActionEdit simpleActionEdit = new SimpleActionEdit(this);
            simpleActionEdit.ShowDialog();
        }

    }
}
