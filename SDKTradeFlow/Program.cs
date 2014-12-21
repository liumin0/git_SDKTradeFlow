using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDKTradeFlow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TestSim t = new TestSim();
            //t.run();
            Application.EnableVisualStyles();
            Application.Run(new Form2());
        }
    }
}