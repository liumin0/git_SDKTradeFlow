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
    public partial class SimpleActionEdit : Form
    {
        private Node _node;
        private bool _isBuy = true;
        public SimpleActionEdit(Node node)
        {
            _node = node;
            InitializeComponent();
            signalBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            signalBox.MultiColumn = true;
            Model model = Model.getInstance();
            for(int i = 0; i < model.Signals.Count; i++)
            {
                String name = model.Signals.Keys.ElementAt(i);
                signalBox.Items.Add(name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = actionNameEdit.Text;
            if (name.Trim().Length == 0)
                MessageBox.Show("名称不能为空");
            String stockId = stockIdCombo.Text;
            float amount = float.Parse(amoutEdit.Text);
            Model model = Model.getInstance();
            Global.ActionOption option = Global.ActionOption.buy;
            _node.Tooltip = "option: buy\n stockId:000001\namount: 123";
            String optionStr = "买";
            if (!_isBuy)
            {
                option = Global.ActionOption.sell;
                optionStr = "卖";
            }
            String toolTipStr = String.Format("option: {0}\nstockId: {1}\namount: {2}", optionStr, stockId, amount);
            _node.Tooltip = toolTipStr;
            BaseAction action = new BaseAction(_node, name, null, option, stockId, amount);
            for(int i = 0; i < signalBox.SelectedItems.Count; i++)
            {
                String sigName = signalBox.SelectedItems[i].ToString();
                BaseSignal sig = model.Signals[sigName];
                action.Signals.Add(sig);
                sig.Node.OutLinks.Add(_node);
            }
            _node.Text = name;
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_isBuy)
            {
                optionBtn.Text = "卖";
                _isBuy = false;
            }
            else
            {
                optionBtn.Text = "卖";
                _isBuy = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _node.Remove();
            this.Close();
        }


    }
}
