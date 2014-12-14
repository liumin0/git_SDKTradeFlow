using Lassalle.Flow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDKTradeFlow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WorkFlowExample();
            typeCombo.SelectedIndex = 0;
            toolStripContainer1.Dock = DockStyle.Fill;
            splitContainer1.Dock = DockStyle.Fill;
            tabControl1.Dock = DockStyle.Fill;

        }
        void WorkFlowExample()
        {
            addFlow1.Dock = DockStyle.Fill;
            addFlow1.AutoScroll = true;
            addFlow1.BackColor = SystemColors.Window;
            addFlow1.PageUnit = GraphicsUnit.Point;
            addFlow1.AutoSize = true;
            addFlow1.CanDrawLink = false;
            addFlow1.AntiAliasing = true;
            addFlow1.DoubleClick += new System.EventHandler(this.testDoubleClick);
            addFlow1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.testKeyDown);
            addFlow1.AfterAddNode += new Lassalle.Flow.AddFlow.AfterAddNodeEventHandler(this.afterAddNode);
            //addFlow1.Grid.Draw = true;
            //addFlow1.Grid.Snap = true;
            //addFlow1.Grid.Style = GridStyle.DottedLines;
            //addFlow1.Grid.Color = Color.Silver;

            // Save the default property values for nodes and links
            //DefNode dn = (DefNode)addFlow1.DefNodeProp.Clone();
            //DefLink dl = (DefLink)addFlow1.DefLinkProp.Clone();

            addFlow1.DefNodeProp.Shape.Style = ShapeStyle.RoundRect;
            addFlow1.DefNodeProp.DrawColor = Color.Red;

            addFlow1.DefLinkProp.Jump = Jump.Arc;
            addFlow1.DefLinkProp.ArrowDst.Filled = true;

            //Node node = null;
            //Link link = null;
            ////node = addFlow1.Nodes.Add(98, 105, 30, 30, "and");
            ////node.Shape.Style = ShapeStyle.Ellipse;
            ////node.FillColor = Color.White;

            //node = addFlow1.Nodes.Add(138, 264, 85, 29, "Evaluate Reference");
            //node.FillColor = Color.Gold;

        }

        private void testDoubleClick(object sender, EventArgs e)
        {
            Node n = (Node)addFlow1.SelectedItem;
            Console.WriteLine("text: {0}", n.Text);
            Console.WriteLine("Hello world");
        }

        private void testKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Node n = (Node)addFlow1.SelectedItem;
            if (n != null)
            {
                Console.WriteLine("text: {0}", n.Text);
                if (e.KeyValue == 46) 
                {
                    n.Remove();
                }
                Console.WriteLine("key: {0}", e.KeyValue);
            }
            
        }


        private void changeDrawType()
        {
            switch (typeCombo.SelectedIndex)
            {
                case 0:
                    switch(subTypeCombo.SelectedIndex)
                    {
                        case 0:
                            addFlow1.DefNodeProp.DrawColor = Color.Red;
                            addFlow1.DefNodeProp.Shape.Style = ShapeStyle.Ellipse;
                            break;
                        case 1:
                            addFlow1.DefNodeProp.DrawColor = Color.Gold;
                            addFlow1.DefNodeProp.Shape.Style = ShapeStyle.Ellipse;
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    addFlow1.DefNodeProp.DrawColor = Color.Green;
                    addFlow1.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;
                    break;
                default:
                    break;
            }
        }
        private void afterAddNode(object sender, AfterAddNodeEventArgs e)
        {
            switch (typeCombo.SelectedIndex)
            {
                case 0://signal
                    switch (subTypeCombo.SelectedIndex)
                    {
                        case 0: //编辑simple signal
                            SimpleSignalEdit simpleSignalEdit = new SimpleSignalEdit(e.Node);
                            simpleSignalEdit.ShowDialog();
                            break;
                        case 1:
                            CombinedSignalEdit combinedSignalEdit = new CombinedSignalEdit();
                            combinedSignalEdit.ShowDialog();
                            break;
                        default:
                            break;
                    }
                    break;
                case 1://action
                    switch (subTypeCombo.SelectedIndex)
                    {
                        case 0: //编辑simple signal
                            SimpleActionEdit simpleActionEdit = new SimpleActionEdit(e.Node);
                            simpleActionEdit.ShowDialog();
                            break;
                        case 1:
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            
        }

        private void subTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeDrawType();
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeCombo.SelectedIndex)
            {
                case 0:
                    subTypeCombo.Items.Clear();
                    subTypeCombo.Items.Add("SimpleSignal");
                    subTypeCombo.Items.Add("CombineSignal");
                    break;
                case 1:
                    subTypeCombo.Items.Clear();
                    subTypeCombo.Items.Add("SimpleAction");
                    break;
                default:
                    break;
            }
            subTypeCombo.SelectedIndex = 0;
            changeDrawType();
        }
    }

    
}
