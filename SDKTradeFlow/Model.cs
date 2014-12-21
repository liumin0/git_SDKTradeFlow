using Lassalle.Flow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKTradeFlow
{
    class Model
    {
        //private const int MASK = 10000;
        //private List<BaseSignal> _signals = new List<BaseSignal>();

        //internal List<BaseSignal> Signals
        //{
        //    get { return _signals; }
        //}
        //private List<SimpleAction> _actions = new List<SimpleAction>();

        //internal List<SimpleAction> Actions
        //{
        //    get { return _actions; }
        //}
        private static Model _instance = null;

        public static Model getInstance()
        {
            if (_instance == null)
            {
                _instance = new Model();
            }
            return _instance;
        }

        //private List<int> _map = new List<int>();

        //public BaseSignal getSignal(int index)
        //{
        //    index = _map[index];
        //    if (index >= MASK)
        //        return null;
        //    else
        //        return _signals[index];
        //}
        //public BaseAction getAction(int index)
        //{
        //    index = _map[index];
        //    if (index < MASK)
        //        return null;
        //    else
        //        return _actions[index];
        //}
        private List<BaseObject> objects = new List<BaseObject>();

        public List<BaseObject> Objects
        {
            get { return objects; }
            set { objects = value; }
        }

        public List<SimpleSignal> getSignals()
        {
            List<SimpleSignal> signals = new List<SimpleSignal>();
            foreach (object obj in objects) 
            {
                if (obj.GetType().ToString() == "SDKTradeFlow.SimpleSignal")
                {
                    signals.Add((SimpleSignal)obj);
                }
            }
            return signals;
        }
        public List<SimpleAction> getActions()
        {
            List<SimpleAction> actions = new List<SimpleAction>();
            foreach (object obj in objects)
            {
                if (obj.GetType().ToString() == "SDKTradeFlow.SimpleAction")
                {
                    actions.Add((SimpleAction)obj);
                }
            }
            return actions;
        }
        //public void removeNode(Node node)
        //{
            
        //    for (int i = 0; i < _signals.Count; i++)
        //    {
        //        BaseSignal sig = _signals.ElementAt(i);
        //        Node n;
        //    }
        //}
    }
}
