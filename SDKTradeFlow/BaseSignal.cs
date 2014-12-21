using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lassalle.Flow;

namespace SDKTradeFlow
{
    public class BaseSignal : BaseObject
    {
        private List<SimpleAction> _actions = new List<SimpleAction>();

        internal List<SimpleAction> Actions
        {
            get { return _actions; }
            set { _actions = value; }
        }

        public BaseSignal(Node node, String name, SimpleAction action):base(node, name)
        {
            if (action != null)
                _actions.Add(action);
        }

        void triggered()
        {
            for(int i = 0; i < _actions.Count; i++)
            {
                SimpleAction action = _actions[i];
                action.run();
            }
        }

        public override void edit()
        {
            //SimpleSignalEdit simpleSignalEdit = new SimpleSignalEdit(this);
            //simpleSignalEdit.ShowDialog();
        }
    }
}
