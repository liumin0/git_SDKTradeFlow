using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lassalle.Flow;

namespace SDKTradeFlow
{
    public abstract class BaseObject
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
        public abstract void edit();
        public BaseObject(Node node, String name)
        {
            _node = node;
            _name = name;
        }

    }
}
