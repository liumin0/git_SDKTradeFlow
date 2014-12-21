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
        private SimpleSignal _signal;
        private bool _isEdit = false;
        private bool _addNode = false;
        private Model _model = Model.getInstance();
        public SimpleSignalEdit(Node node)
        {
            _node = node;
            InitializeComponent();
        }
        public SimpleSignalEdit(SimpleSignal signal)
        {
            _signal = signal;
            _isEdit = true;
            _node = signal.Node;
            InitializeComponent();
            indicatorCombo.Text = signal.Indicator;
            nameEdit.Text = signal.Name;
            valueEdit.Text = signal.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String indicator = indicatorCombo.Text;
            String name = nameEdit.Text;
            String valueText = valueEdit.Text;
            if (name.Trim().Length == 0 || indicator.Trim().Length == 0 || valueText.Trim().Length == 0)
            {
                MessageBox.Show("名称,指标，值不能为空");
                return;
            }
            decimal value;
            if (!decimal.TryParse(valueText, out value))
            {
                MessageBox.Show("非法的输入值");
                return;
            }
            Console.WriteLine("name {0}", name);
            Console.WriteLine("indicator {0}", indicator);
            Console.WriteLine("value {0}", value);
            if (!_isEdit)
            {
                SimpleSignal simpleSignal = new SimpleSignal(_node, name, indicator, value, null);

                _model.Objects.Add(simpleSignal);  
            }
            else
            {
                _signal.Name = name;
                _signal.Indicator = indicator;
                _signal.Value = value;
            }
            _node.Text = name;
            //SimpleSignal simpleSignal = new SimpleSignal(_node, name, indicator, value, null);
            //Model model = Model.getInstance();
            //model.Signals.Add(simpleSignal);
            //_node.Text = name;
            String toolTipStr = String.Format("indicator: {0}\nvalue: {1}", indicator, value);
            _node.Tooltip = toolTipStr;
            //AddNode(name, indicator, value);
            
            _addNode = true;
            this.Close();
        }

        private void  button2_Click(object sender, EventArgs e)
        {
            //Model model = Model.getInstance();
            //Console.WriteLine("index {0}", model.Signals[1].Node.Index);
            
            this.Close();
        }

        private void SimpleSignalEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_addNode && !_isEdit)
                _node.Remove();
        }

        private void valueEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

        }

    }
}
