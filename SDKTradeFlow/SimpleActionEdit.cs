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

        private List<SimpleSignal> _signals;
        private SimpleAction _action;
        private bool _isEdit = false;
        private bool _addNode = false;
        private Model _model = Model.getInstance();
        public SimpleActionEdit(Node node)
        {
            _node = node;
            InitializeComponent();
            _signals = _model.getSignals();
            for (int i = 0; i < _signals.Count; i++)
            {
                SimpleSignal sig = _signals[i];
                signalBox.Items.Add(sig.Name);
            }
        }
        public SimpleActionEdit(SimpleAction action)
        {
            _action = action;
            _isEdit = true;
            _node = _action.Node;
            InitializeComponent();
            actionNameEdit.Text = _action.Name;
            stockIdCombo.Text = _action.StockId;
            amoutEdit.Text = _action.Amount.ToString();
            if (_action.Side)
            {
                optionBtn.Text = "卖";
                _isBuy = false;
            }
            _signals = _model.getSignals();
            for (int i = 0; i < _signals.Count; i++)
            {
                SimpleSignal sig = _signals[i];
                signalBox.Items.Add(sig.Name);
                if (_action.Signals.Contains(sig))
                    signalBox.SetSelected(i, true);
            }
            if (_action.Type == Global.ActionType.send_market)
                radioButton1.Checked = true;
            else if (_action.Type == Global.ActionType.send_limit)
                radioButton2.Checked = true;
            else if (_action.Type == Global.ActionType.send_stop)
                radioButton3.Checked = true;
            else if (_action.Type == Global.ActionType.send_cancel)
                radioButton4.Checked = true;
            else if (_action.Type == Global.ActionType.signal_set)
                radioButton5.Checked = true;
            else if (_action.Type == Global.ActionType.skip)
                radioButton6.Checked = true;
            else
                radioButton7.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = actionNameEdit.Text;
            if (name.Trim().Length == 0)
                MessageBox.Show("名称不能为空");
            String stockId = stockIdCombo.Text;
            decimal amount = decimal.Parse(amoutEdit.Text);
            
            String optionStr = "买";
            if (!_isBuy)
            {
                optionStr = "卖";
            }
            String toolTipStr = String.Format("option: {0}\nstockId: {1}\namount: {2}", optionStr, stockId, amount);
            _node.Tooltip = toolTipStr;
            if (!_isEdit)
            {
                _action = new SimpleAction(_node, name, null, _isBuy, stockId, amount);
                _model.Objects.Add(_action);
            }
            else
            {
                _action.Name = name;
                _action.StockId = stockId;
                _action.Amount = amount;
                _action.Signals.Clear();
            }
            if (radioButton1.Checked)
                _action.Type = Global.ActionType.send_market;
            else if (radioButton2.Checked)
                _action.Type = Global.ActionType.send_limit;
            else if (radioButton3.Checked)
                _action.Type = Global.ActionType.send_stop;
            else if (radioButton4.Checked)
                _action.Type = Global.ActionType.send_cancel;
            else if (radioButton5.Checked)
                _action.Type = Global.ActionType.signal_set;
            else if (radioButton6.Checked)
                _action.Type = Global.ActionType.skip;
            else
                _action.Type = Global.ActionType.none;
            for (int i = 0; i < signalBox.SelectedIndices.Count; i++)
            {
                //String sigName = signalBox.SelectedItems[i].ToString();
                int index = signalBox.SelectedIndices[i];
                SimpleSignal signal = _signals[index];
                _action.Signals.Add(signal);
                signal.Actions.Add(_action);
                signal.Node.OutLinks.Add(_node);
            }
            
            _node.Text = name;
            _addNode = true;
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
                optionBtn.Text = "买";
                _isBuy = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {  
            this.Close();
        }

        private void SimpleActionEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_addNode && !_isEdit)
                _node.Remove();
        }


    }
}
