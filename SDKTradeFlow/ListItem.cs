using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lassalle.Flow;

namespace SDKTradeFlow
{
    class ListItem : Node
    {
        private int _index;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }


    }
}
