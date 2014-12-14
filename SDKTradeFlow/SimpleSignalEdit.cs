using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lassalle.Flow;

namespace SDKTradeFlow
{
    public partial class SimpleSignalEdit : Form
    {
        private Node _node;
        public SimpleSignalEdit(Node node)
        {
            _node = node;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String indicator = indicatorCombo.Text;
            String name = nameEdit.Text;
            float value = float.Parse(valueEdit.Text);
            Console.WriteLine("name {0}", name);
            Console.WriteLine("indicator {0}", indicator);
            Console.WriteLine("value {0}", value);
            SimpleSignal simpleSignal = new SimpleSignal(_node, name, indicator, value, null);
            Model model = Model.getInstance();
            model.Signals.Add(name, simpleSignal);
            _node.Text = name;
            String toolTipStr = String.Format("indicator: {0}\nvalue: {1}", indicator, value);
            _node.Tooltip = toolTipStr;
            //AddNode(name, indicator, value);
            this.Close();
        }

        private void  button2_Click(object sender, EventArgs e)
        {
            _node.Remove();
            this.Close();
        }

    }
}
