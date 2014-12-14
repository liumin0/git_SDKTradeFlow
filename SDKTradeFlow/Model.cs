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
        private Dictionary<string, BaseSignal> _signals = new Dictionary<string, BaseSignal>();

        internal Dictionary<string, BaseSignal> Signals
        {
            get { return _signals; }
            set { _signals = value; }
        }
        private Dictionary<string, BaseAction> _actions = new Dictionary<string, BaseAction>();

        internal Dictionary<string, BaseAction> Actions
        {
            get { return _actions; }
            set { _actions = value; }
        }
        private static Model _instance = null;

        public static Model getInstance()
        {
            if (_instance == null)
            {
                _instance = new Model();
            }
            return _instance;
        }
    }
}
