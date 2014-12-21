using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeLink.Common;
using TradeLink.API;
using System.Data;
using System.Reflection;

namespace SDKTradeFlow
{
    class TestSim
    {
        static HistSim h;
        private Model _model = Model.getInstance();
        static Queue<Order> orders = new Queue<Order>();
        static Broker SimBroker = new Broker();
        private List<SimpleSignal> _signals;
        private List<SimpleAction> _actions;
        static private int count = 1;
        static private DataTable tickTable = new DataTable("Tick");
        public TestSim()
        {
            h = new MultiSimImpl(@"C:\WorkSpace\vs\git_SDKTradeFlow\SDKTradeFlow\bin\Debug");
            // handle events, each events is correspond to a process, or the event cannot be handled
            SimBroker.GotFill += new FillDelegate(SimBroker_GotOrderFill);
            h.GotTick += new TickDelegate(SimBroker_GotTick);
            SimBroker.GotOrderCancel += new OrderCancelDelegate(SimBroker_GotOrderCancel);

            // start simulation，再点击测试之前先保存action列表
            _actions = _model.getActions();
            _signals = _model.getSignals();
            foreach (SimpleAction action in _actions)
            {
                action.triggeredDel += new ActionTriggeredDelegate(SimBroker_GotAction); ;
            }

            //h.PlayTo(MultiSimImpl.ENDSIM);
            ////gotfill 没有被执行

            //// write trades to CSV file for reading by another program
            //Util.ClosedPLToText(fills, ',', "trades.csv");
            count = 1;
            tickTable = new DataTable("Tick");
            Type type1 = typeof(Tick);
            
            // 反射字体的所有属性
            PropertyInfo[] ProList = type1.GetProperties();
                            
            //枚举每一个属性比较
            tickTable.Columns.Add("LineNum", 123.GetType());
            foreach (PropertyInfo Pro in ProList)
            {
                tickTable.Columns.Add(Pro.Name, Pro.PropertyType);
            }
            
        }
        public void run()
        {
            h.PlayTo(MultiSimImpl.ENDSIM);
            //gotfill 没有被执行
            // write trades to CSV file for reading by another program

            Console.WriteLine("Done :{0}", fills.Count);
            //Global.mainFormInstance
            DataTable dt = new DataTable("Result");
            string[] headers = Enum.GetNames(typeof(TradePLField));
            foreach (string header in headers)
            {
                dt.Columns.Add(header, System.Type.GetType("System.String"));
            }
            string[] results = Util.TradesToClosedPL(fills, ',');
            for (int i = 0; i < results.Length; i++)
            {
                DataRow dr = dt.NewRow();
                string []tmp = results[i].Split(',');
                dr["Date"] = tmp[0];
                dr["Time"] = tmp[1];
                dr["Symbol"] = tmp[2];
                dr["Side"] = tmp[3];
                dr["xSize"] = tmp[4];
                dr["xPrice"] = tmp[5];
                dr["Comment"] = tmp[6];
                dr["OpenPL"] = tmp[7];
                dr["ClosedPL"] = tmp[8];
                dr["OpenSize"] = tmp[9];
                dr["ClosedSize"] = tmp[10];
                dr["AvgPrice"] = tmp[11];
                dt.Rows.Add(dr);
            }
            Console.WriteLine(dt.Columns.Count);
            Global.mainFormInstance.showResult(tickTable);
            //Global.mainFormInstance.showTicks(tickTable);
            Util.ClosedPLToText(fills, ',', "trades.csv");
        }
        void SimBroker_GotAction(SimpleAction action)
        {
            //Console.WriteLine("SimBroker_GotAction typ: {0}", action.Type);
            switch (action.Type)
            {
                //send limit
                case Global.ActionType.send_limit:
                    Order sendLimit = new OrderImpl();
                    sendLimit.side = action.Side;
                    sendLimit.price = action.CauseSignal.Value;
                    sendLimit.size = Decimal.ToInt32(action.Amount);
                    sendLimit.symbol = action.StockId;
                    //Console.WriteLine("SendOrder");
                    SimBroker.SendOrder(sendLimit);
                    break;
            }
        }

        void SimBroker_GotTick(Tick k)
        {
            //打出tick数据
            //Console.WriteLine(String.Format("tick symbol: {0}, date: {1}, count: {2}", k.symbol, k.date, count++));

           // Console.WriteLine(String.Format("tcount: {0}", count++));
            //经过signal的各种操作，调用Common中calc文件
            //对于每一个流程，先遍历每一个action，对每一个action，执行完所有的signal，判断是否触发该action
            Type type1 = typeof(Tick);

            // 反射字体的所有属性
            PropertyInfo[] ProList = type1.GetProperties();

            //枚举每一个属性比较
            DataRow dr = tickTable.NewRow();
            dr["LineNum"] = count++;
            foreach (PropertyInfo Pro in ProList)
            {
                dr[Pro.Name] = Pro.GetValue(k);
                
            }
            tickTable.Rows.Add(dr);
            //遍历所有action
           TraverseAction(k);

            // execute any pending orders
            // broker中有一个account，需要比较account中order的symbol和提交order的symbol，现在不知道account中的order是什么
            //必须定义order book才能进行下面的操作，masterorders的初始化问题
            //执行在order book中的订单，所以经过signal的操作应该都需要在execute之前执行
            SimBroker.Execute(k);
            // send any new orders from our application
        }
        static List<Trade> fills = new List<Trade>();

        void SimBroker_SendOrder(Order f)
        {

        }
        void SimBroker_GotOrderFill(Trade f)
        {
            // save fills so we can generate stats later
            fills.Add(f);
        }

        void SimBroker_GotOrderCancel(string sym, bool side, long id)
        {


        }

        void TraverseAction(Tick k)
        {
            _signals = _model.getSignals();
            for (int i = 0; i < _signals.Count; i++)
            {
                _signals[i].gotTick(k);

            }
        }
    }
}
