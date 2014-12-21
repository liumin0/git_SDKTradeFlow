using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SDKTradeFlow
{

    public class Global
    {
        public enum ActionType
        {
            send_market,
            send_limit,
            send_stop,
            send_cancel,
            signal_set,
            skip,
            none
        }

        public static Form2 mainFormInstance = null;
    }
}
