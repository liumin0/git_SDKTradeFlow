using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lassalle.Flow;

namespace SDKTradeFlow
{
    class BaseSignal
    {
        protected Node _node;

        public Node Node
        {
            get { return _node; }
            set { _node = value; }
        }
        protected String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public BaseSignal(Node node, String name, BaseAction action)
        {
            _node = node;
            _name = name;
            if (action != null)
                _actions.Add(action);
        }

        List<BaseAction> _actions = new List<BaseAction>();

        internal List<BaseAction> Actions
        {
            get { return _actions; }
            set { _actions = value; }
        }

        void triggered()
        {
            for(int i = 0; i < _actions.Count; i++)
            {
                BaseAction action = _actions[i];
                action.run();
            }
        }
    }
}
