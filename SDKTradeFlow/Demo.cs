//----------------------------------------------------------------------------------------
// AddFlow for .NET: Demo sample
// Copyright (c) 2003-2006 Lassalle Technologies. All Rights Reserved
// http://www.lassalle.com
// Author: Patrick Lassalle    
// THIS CODE IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND EITHER EXPRESSED OR IMPLIED.
//----------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Lassalle.Flow;

namespace Demo
{
    public partial class Demo : Form
    {
        const int linkHorzOffset = 27;
        const int fieldHeight = 20;

        public Demo()
        {
            InitializeComponent();
        }
        
        private void Demo_Load(object sender, EventArgs e)
        {
            FlowchartExample();
            NetworkExample();
            InternetTrafficExample();
            WorkFlowExample();
            StateDiagramExample();
            CauseEffectExample();
            DatabaseExample();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AddFlow for .NET Demo\r\nCopyright ?2003-2006 Lassalle Technologies");
        }

        private void MenuItemProperties_Click(object sender, EventArgs e)
        {
            Lassalle.Flow.AddFlow addflow = (Lassalle.Flow.AddFlow)TabControl1.SelectedTab.Controls[0];
            PropertiesDlg p = new PropertiesDlg();
            p.PropertyGrid1.SelectedObject = addflow;
            p.ShowDialog();
        }

        void FlowchartExample()
        {
            AddFlow1.Dock = DockStyle.Fill;
            AddFlow1.AutoScroll = true;
            AddFlow1.BackColor = SystemColors.Window;
            AddFlow1.PageUnit = GraphicsUnit.Point;
            AddFlow1.Grid.Draw = true;
            AddFlow1.Grid.Snap = true;
            AddFlow1.Grid.Style = GridStyle.DottedLines;
            AddFlow1.Grid.Color = Color.Silver;

            AddFlow1.DefNodeProp.Shadow.Style = ShadowStyle.RightBottom;
            AddFlow1.DefNodeProp.Shadow.Color = Color.Silver;
            AddFlow1.DefNodeProp.Shadow.Size = new Size(4, 4);

            AddFlow1.DefLinkProp.Line.RoundedCorner = true;
            AddFlow1.DefLinkProp.ArrowDst.Style = ArrowStyle.Arrow;
            AddFlow1.DefLinkProp.ArrowDst.Angle = ArrowAngle.deg30;
            AddFlow1.DefLinkProp.ArrowMid.Angle = ArrowAngle.deg30;
            AddFlow1.DefLinkProp.BackMode = BackMode.Opaque;
            AddFlow1.DefLinkProp.Shadow.Style = ShadowStyle.RightBottom;
            AddFlow1.DefLinkProp.Shadow.Color = Color.Silver;
            AddFlow1.DefLinkProp.Shadow.Size = new Size(4, 4);

            AddFlow1.BeginUpdate(); // Optimize speed

            Node node0 = AddFlow1.Nodes.Add(40, 16, 174, 16, "Encoding Application Flowchart");
            node0.Transparent = true;
            node0.DrawColor = Color.Transparent;
            node0.TextColor = Color.Blue;
            node0.Shape.Style = ShapeStyle.Rectangle;
            node0.Selectable = false;
            node0.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, (Byte)0);

            Node node1 = AddFlow1.Nodes.Add(60, 48, 112, 32);
            node1.Text = "Timer1:" + "\r\n" + "called(every)" + "\r\n" + "2 seconds)";
            node1.Shape.Style = ShapeStyle.PredefinedProcess;
            node1.FillColor = Color.LightYellow;

            Node node2 = AddFlow1.Nodes.Add(76, 112, 80, 32);
            node2.Text = "Timer1" + "\r\n" + "= true ?";
            node2.Shape.Style = ShapeStyle.Losange;

            Node node3 = AddFlow1.Nodes.Add(60, 186, 112, 48);
            node3.Text = "Check if a" + "\r\n" + "previous(encoding)" + "\r\n" + "session failed";
            node3.Shape.Style = ShapeStyle.Losange;

            Node node4  = AddFlow1.Nodes.Add(60, 276, 112, 48);
            node4.Text = "Check if newly" + "\r\n" + "updated files";
            node4.Shape.Style = ShapeStyle.Losange;

            Node node5 = AddFlow1.Nodes.Add(60, 366, 112, 48);
            node5.Text = "Encoding" + "\r\n" + "Step1" + "\r\n" + "..." + "\r\n" + "Step5";
            node5.Shape.Style = ShapeStyle.Rectangle;

            Node node6 = AddFlow1.Nodes.Add(220, 112, 80, 32, "Exit Timer1");
            node6.Shape.Style = ShapeStyle.Termination;

            Node node7 = AddFlow1.Nodes.Add(220, 286, 80, 32, "Exit Timer1");
            node7.Shape.Style = ShapeStyle.Termination;

            Node node8 = AddFlow1.Nodes.Add(74, 436, 80, 32, "Exit Timer1");
            node8.Shape.Style = ShapeStyle.Termination;

            node1.OutLinks.Add(node2);

            node2.OutLinks.Add(node3, "no");

            node3.OutLinks.Add(node4, "no");

            node4.OutLinks.Add(node5, "yes");

            node5.OutLinks.Add(node8);

            node2.OutLinks.Add(node6, "yes");

            node4.OutLinks.Add(node7, "no");

            Link link = node3.OutLinks.Add(node5, "yes");
            link.Line = new Line(LineStyle.HVH, false, true);
            link.Points[1] = new PointF(16, 210);
            link.Points[2] = new PointF(16, 390);

            AddFlow1.EndUpdate();
        }

        void NetworkExample()
        {
            AddFlow5.Dock = DockStyle.Fill;
            AddFlow5.AutoScroll = true;
            AddFlow5.BackColor = Color.AliceBlue;

            AddFlow5.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;
            AddFlow5.DefNodeProp.Transparent = true;
            AddFlow5.DefNodeProp.DrawColor = Color.Transparent;
            AddFlow5.DefNodeProp.Alignment = Alignment.CenterBOTTOM;
            AddFlow5.DefNodeProp.TextColor = Color.Orange;

            AddFlow5.DefLinkProp.Jump = Jump.Arc;
            AddFlow5.DefLinkProp.ArrowDst.Style = ArrowStyle.None;
            AddFlow5.DefLinkProp.DrawColor = Color.SlateBlue;
            AddFlow5.DefLinkProp.Line.DoubleLine = true;
            AddFlow5.DefLinkProp.Jump = Jump.None;

            AddFlow5.Images.Add(ImageList1.Images[0]);
            AddFlow5.Images.Add(ImageList1.Images[1]);
            AddFlow5.Images.Add(ImageList1.Images[2]);

            AddFlow5.BeginUpdate(); // Optimize speed

            Node node = null;
            Link link = null;

            node = AddFlow5.Nodes.Add(20, 90, 40, 50, "John");
            node.ImageIndex = 0;

            node = AddFlow5.Nodes.Add(120, 20, 40, 50, "Paul");
            node.ImageIndex = 0;

            node = AddFlow5.Nodes.Add(290, 70, 40, 50, "Tony");
            node.ImageIndex = 2;
            node.TextColor = Color.Lime;

            node = AddFlow5.Nodes.Add(250, 170, 50, 60, "George");
            node.ImageIndex = 0;

            node = AddFlow5.Nodes.Add(90, 180, 40, 50, "Lisa");
            node.ImageIndex = 1;

            link = AddFlow5.Nodes[0].OutLinks.Add(AddFlow5.Nodes[1]);
            link = AddFlow5.Nodes[1].OutLinks.Add(AddFlow5.Nodes[2]);
            link = AddFlow5.Nodes[2].OutLinks.Add(AddFlow5.Nodes[3]);
            link = AddFlow5.Nodes[3].OutLinks.Add(AddFlow5.Nodes[4]);
            link = AddFlow5.Nodes[4].OutLinks.Add(AddFlow5.Nodes[0]);

            AddFlow5.EndUpdate();
        }

        void InternetTrafficExample()
        {
            AddFlow4.Dock = DockStyle.Fill;
            AddFlow4.AutoScroll = true;
            AddFlow4.BackColor = Color.LightYellow;
            AddFlow4.Grid.Draw = false;
            AddFlow4.PageUnit = GraphicsUnit.Point;

            AddFlow4.DefLinkProp.Jump = Jump.Arc;
            AddFlow4.DefLinkProp.ArrowDst.Style = ArrowStyle.Circle;
            AddFlow4.DefLinkProp.ArrowDst.Filled = true;
            AddFlow4.DefLinkProp.AdjustDst = true;
            AddFlow4.DefLinkProp.AdjustOrg = true;

            AddFlow4.BeginUpdate(); // Optimize speed

            // Create the nodes
            Node node = null;
            node = AddFlow4.Nodes.Add(268, 6, 48, 32, "Stub Network");
            node = AddFlow4.Nodes.Add(150, 6, 48, 32, "Stub Network");
            node = AddFlow4.Nodes.Add(241, 244, 48, 32, "Stub Network");
            node = AddFlow4.Nodes.Add(370, 234, 48, 32, "Stub Network");
            node = AddFlow4.Nodes.Add(300, 260, 48, 32, "Stub Network");
            node = AddFlow4.Nodes.Add(92, 198, 80, 32, "Regional Network");
            node.DrawWidth = 4;
            node.DrawColor = Color.Maroon;
            node = AddFlow4.Nodes.Add(284, 198, 80, 32, "Regional Network");
            node.DrawWidth = 4;
            node.DrawColor = Color.Maroon;
            node = AddFlow4.Nodes.Add(156, 118, 144, 48, "Backbone Network");
            node.DrawWidth = 5;
            node.DrawColor = Color.DarkBlue;
            node = AddFlow4.Nodes.Add(188, 54, 80, 32, "Regional Network");
            node.DrawWidth = 4;
            node.DrawColor = Color.Maroon;
            node = AddFlow4.Nodes.Add(30, 241, 48, 32, "Stub Network");
            node = AddFlow4.Nodes.Add(98, 263, 48, 32, "Stub Network");
            node = AddFlow4.Nodes.Add(172, 250, 48, 32, "Stub Network");

            // Create the links
            Link link = null;

            link = AddFlow4.CreateLink(AddFlow4.Nodes[8], AddFlow4.Nodes[7]);
            link.Points[0] = new PointF(228, 86);
            link.Points[1] = new PointF(228, 118);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[6], AddFlow4.Nodes[7]);
            link.Points[0] = new PointF(305, 199);
            link.Points[1] = new PointF(257, 163);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[5], AddFlow4.Nodes[7]);
            link.Points[0] = new PointF(150, 199);
            link.Points[1] = new PointF(198, 163);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[9], AddFlow4.Nodes[5]);
            link.Points[0] = new PointF(69, 245);
            link.Points[1] = new PointF(97, 223);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[10], AddFlow4.Nodes[5]);
            link.Points[0] = new PointF(124, 263);
            link.Points[1] = new PointF(129, 230);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[11], AddFlow4.Nodes[5]);
            link.Points[0] = new PointF(185, 252);
            link.Points[1] = new PointF(164, 224);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[3], AddFlow4.Nodes[6]);
            link.Points[0] = new PointF(375, 240);
            link.Points[1] = new PointF(348, 226);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[4], AddFlow4.Nodes[6]);
            link.Points[0] = new PointF(324, 260);
            link.Points[1] = new PointF(324, 229);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[2], AddFlow4.Nodes[6]);
            link.Points[0] = new PointF(280, 248);
            link.Points[1] = new PointF(305, 230);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[1], AddFlow4.Nodes[8]);
            link.Points[0] = new PointF(188, 35);
            link.Points[1] = new PointF(211, 55);

            link = AddFlow4.CreateLink(AddFlow4.Nodes[0], AddFlow4.Nodes[8]);
            link.Points[0] = new PointF(276, 34);
            link.Points[1] = new PointF(247, 55);

            AddFlow4.EndUpdate();
        }

        void WorkFlowExample()
        {
            AddFlow3.Dock = DockStyle.Fill;
            AddFlow3.AutoScroll = true;
            AddFlow3.BackColor = SystemColors.Window;
            AddFlow3.PageUnit = GraphicsUnit.Point;
            AddFlow3.Grid.Draw = true;
            AddFlow3.Grid.Snap = true;
            AddFlow3.Grid.Style = GridStyle.DottedLines;
            AddFlow3.Grid.Color = Color.Silver;

            // Save the default property values for nodes and links
            DefNode dn = (DefNode)AddFlow3.DefNodeProp.Clone();
            DefLink dl = (DefLink)AddFlow3.DefLinkProp.Clone();

            AddFlow3.DefNodeProp.Shape.Style = ShapeStyle.RoundRect;
            AddFlow3.DefNodeProp.DrawColor = Color.Red;

            AddFlow3.DefLinkProp.Jump = Jump.Arc;
            AddFlow3.DefLinkProp.ArrowDst.Filled = true;

            AddFlow3.Images.Add(ImageList2.Images[0]);
            AddFlow3.Images.Add(ImageList2.Images[1]);
            AddFlow3.Images.Add(ImageList2.Images[2]);

            AddFlow3.BeginUpdate(); // Optimize speed

            Node node = null;
            Link link = null;

            // Create nodes
            node = AddFlow3.Nodes.Add(70, 4, 87, 64, "Order Entry");
            node.Shape.Style = ShapeStyle.Ellipse;
            node.FillColor = Color.LightYellow;
            node.TextMargin = new Size(5, 5);
            node.Alignment = Alignment.CenterBOTTOM;
            node.ImageIndex = 1;

            node = AddFlow3.Nodes.Add(98, 105, 30, 30, "and");
            node.Shape.Style = ShapeStyle.Ellipse;
            node.FillColor = Color.White;

            node = AddFlow3.Nodes.Add(95, 321, 28, 32, "and");
            node.Shape.Style = ShapeStyle.Ellipse;
            node.FillColor = Color.White;
        
            node = AddFlow3.Nodes.Add(7, 219, 74, 35, "Inventory Check");
            node.FillColor = Color.Gold;

            node = AddFlow3.Nodes.Add(138, 180, 85, 31, "Compile Reference");
            node.FillColor = Color.Gold;

            node = AddFlow3.Nodes.Add(138, 264, 85, 29, "Evaluate Reference");
            node.FillColor = Color.Gold;

            node = AddFlow3.Nodes.Add(164, 320, 32, 32, "or");
            node.Shape.Style = ShapeStyle.Losange;
            node.FillColor = Color.LightSkyBlue;

            node = AddFlow3.Nodes.Add(92, 426, 32, 32, "or");
            node.Shape.Style = ShapeStyle.Losange;
            node.FillColor = Color.LightSkyBlue;

            node = AddFlow3.Nodes.Add(70, 375, 77, 35, "Order Evaluation");
            node.FillColor = Color.Gold;

            node = AddFlow3.Nodes.Add(2, 485, 91, 50, "Letter of regret");
            node.FillColor = Color.Gold;
            node.TextMargin = new Size(5, 5);
            node.Alignment = Alignment.CenterBOTTOM;
            node.ImageIndex = 0;

            node = AddFlow3.Nodes.Add(134, 495, 79, 26, "Billing");
            node.FillColor = Color.Gold;

            node = AddFlow3.Nodes.Add(135, 554, 78, 25, "Shipping");
            node.FillColor = Color.Gold;

            node = AddFlow3.Nodes.Add(92, 667, 74, 61, "Archive");
            node.Shape.Style = ShapeStyle.Ellipse;
            node.DrawColor = Color.DarkGreen;
            node.FillColor = Color.LightYellow;
            node.TextMargin = new Size(5, 5);
            node.Alignment = Alignment.CenterBOTTOM;
            node.ImageIndex = 2;

            AddFlow3.DefNodeProp.DrawColor = Color.Black;
            AddFlow3.DefNodeProp.Transparent = true;
            AddFlow3.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;

            node = AddFlow3.Nodes.Add(10, 80, 70, 40, "Jane" + "\r\n" + "INVENTORY MANAGER");

            node = AddFlow3.Nodes.Add(200, 41, 72, 35, "Paul" + "\r\n" + "SECRETARY");

            node = AddFlow3.Nodes.Add(200, 376, 73, 32, "Lydia" + "\r\n" + "SECRETARY");

            node = AddFlow3.Nodes.Add(367, 518, 40, 36, "Bill");
            node.DashStyle = DashStyle.Dot;

            node = AddFlow3.Nodes.Add(7, 602, 63, 40, "Jack" + "\r\n" + "ARCHIVER");

            // Create links

            AddFlow3.DefLinkProp.DrawColor = Color.DarkGreen;

            link = AddFlow3.Nodes[0].OutLinks.Add(AddFlow3.Nodes[1]);

            link = AddFlow3.Nodes[1].OutLinks.Add(AddFlow3.Nodes[3]);
            link.Points.Add(new PointF(53, 142));

            link = AddFlow3.Nodes[4].OutLinks.Add(AddFlow3.Nodes[5]);

            link = AddFlow3.Nodes[3].OutLinks.Add(AddFlow3.Nodes[2]);
            link.Points.Add(new PointF(53, 336));
        
            link = AddFlow3.Nodes[5].OutLinks.Add(AddFlow3.Nodes[6]);

            link = AddFlow3.Nodes[6].OutLinks.Add(AddFlow3.Nodes[2], "Yes");

            link = AddFlow3.Nodes[2].OutLinks.Add(AddFlow3.Nodes[8]);

            link = AddFlow3.Nodes[8].OutLinks.Add(AddFlow3.Nodes[7]);

            link = AddFlow3.Nodes[7].OutLinks.Add(AddFlow3.Nodes[9], "Reject");
            link.Points.Add(new PointF(47, 453));

            link = AddFlow3.Nodes[7].OutLinks.Add(AddFlow3.Nodes[10], "Accept");
            link.Points.Add(new PointF(173, 453));

            link = AddFlow3.Nodes[10].OutLinks.Add(AddFlow3.Nodes[11]);

            link = AddFlow3.Nodes[11].OutLinks.Add(AddFlow3.Nodes[12]);
            link.DrawColor = Color.DarkGreen;

            link = AddFlow3.Nodes[9].OutLinks.Add(AddFlow3.Nodes[12]);
            link.DrawColor = Color.DarkGreen;

            link = AddFlow3.Nodes[1].OutLinks.Add(AddFlow3.Nodes[4]);
            link.Points.Add(new PointF(180, 141));

            link = AddFlow3.Nodes[6].OutLinks.Add(AddFlow3.Nodes[4], "No");
            link.Points.Add(new PointF(268, 336));
            link.Points.Add(new PointF(268, 195));

            // Default properties for the end
            AddFlow3.DefLinkProp.DrawColor = Color.Black;
            AddFlow3.DefLinkProp.ArrowDst.Style = ArrowStyle.Circle;
            AddFlow3.DefLinkProp.ArrowDst.Filled = false;
            AddFlow3.DefLinkProp.Line.Style = LineStyle.Bezier;

            // Now continue

            link = AddFlow3.Nodes[13].OutLinks.Add(AddFlow3.Nodes[0]);

            link = AddFlow3.Nodes[14].OutLinks.Add(AddFlow3.Nodes[4]);

            link = AddFlow3.Nodes[14].OutLinks.Add(AddFlow3.Nodes[5]);
            link.Points[1] = new PointF(301, 171);
            link.Points[2] = new PointF(280, 200);

            link = AddFlow3.Nodes[13].OutLinks.Add(AddFlow3.Nodes[3]);
            link.Points[2] = new PointF(5, 164);

            link = AddFlow3.Nodes[15].OutLinks.Add(AddFlow3.Nodes[8]);

            link = AddFlow3.Nodes[16].OutLinks.Add(AddFlow3.Nodes[10]);
            link.DashStyle = DashStyle.Dot;

            link = AddFlow3.Nodes[16].OutLinks.Add(AddFlow3.Nodes[11]);
            link.DashStyle = DashStyle.Dot;

            link = AddFlow3.Nodes[17].OutLinks.Add(AddFlow3.Nodes[9]);

            link = AddFlow3.Nodes[17].OutLinks.Add(AddFlow3.Nodes[12]);

            AddFlow3.EndUpdate();

                // Restore the default property values for nodes and links
            AddFlow3.DefNodeProp = dn;
            AddFlow3.DefLinkProp = dl;
        }

        void StateDiagramExample()
        {
            AddFlow2.Dock = DockStyle.Fill;
            AddFlow2.AutoScroll = true;
            AddFlow2.BackColor = SystemColors.Window;
            AddFlow2.PageUnit = GraphicsUnit.Point;

            AddFlow2.DefNodeProp.Gradient = true;
            AddFlow2.DefNodeProp.GradientColor = Color.LightBlue;
            AddFlow2.DefNodeProp.GradientMode = LinearGradientMode.Horizontal;

            AddFlow2.DefLinkProp.Jump = Jump.Arc;
            AddFlow2.DefLinkProp.ArrowDst.Angle = ArrowAngle.deg30;
            AddFlow2.DefLinkProp.ArrowDst.Filled = true;
            AddFlow2.DefLinkProp.Line.Style = LineStyle.Spline;

            AddFlow2.BeginUpdate(); // Optimize speed

            Node node = null;
            Link link = null;

            node = AddFlow2.Nodes.Add(24, 166, 71, 32, "Development");
            node = AddFlow2.Nodes.Add(206, 167, 64, 32, "Alpha tests");
            node = AddFlow2.Nodes.Add(134, 41, 54, 43, "Design phase");
            node = AddFlow2.Nodes.Add(207, 288, 75, 33, "Beta tests");
            node = AddFlow2.Nodes.Add(29, 302, 74, 30, "Release");

            link = AddFlow2.Nodes[0].OutLinks.Add(AddFlow2.Nodes[1], "End");
            link.Points.Add(new PointF(118, 152));

            link = AddFlow2.Nodes[2].OutLinks.Add(AddFlow2.Nodes[2], "Test");
            link.Line.Style = LineStyle.Bezier;
            link.Points[1] = new PointF(221, 14);
            link.Points[2] = new PointF(130, 5);

            link = AddFlow2.Nodes[1].OutLinks.Add(AddFlow2.Nodes[0], "Problem");
            link.Points.Add(new PointF(142, 201));

            link = AddFlow2.Nodes[1].OutLinks.Add(AddFlow2.Nodes[3], "Stable");
            link.Points.Add(new PointF(234, 223));
            link.Points.Add(new PointF(216, 259));

            link = AddFlow2.Nodes[3].OutLinks.Add(AddFlow2.Nodes[4], "Work");
            link.Points.Add(new PointF(162, 336));

            link = AddFlow2.Nodes[4].OutLinks.Add(AddFlow2.Nodes[0], "new features");
            link.Points.Add(new PointF(54, 257));

            link = AddFlow2.Nodes[4].OutLinks.Add(AddFlow2.Nodes[4], "bug");
            link.Line.Style = LineStyle.Bezier;
            link.Points[1] = new PointF(117, 376);
            link.Points[2] = new PointF(39, 391);

            link = AddFlow2.Nodes[2].OutLinks.Add(AddFlow2.Nodes[0], "Development decision");
            link.Points.Add(new PointF(84, 102));

            link = AddFlow2.Nodes[1].OutLinks.Add(AddFlow2.Nodes[1], "bug");
            link.Points[1] = new PointF(300, 148);
            link.Points[2] = new PointF(260, 127);

            link = AddFlow2.Nodes[3].OutLinks.Add(AddFlow2.Nodes[0], "Design problem");
            link.DashStyle = DashStyle.Dot;
            link.Points.Add(new PointF(170, 264));
            link.Points.Add(new PointF(113, 238));

            link = AddFlow2.Nodes[3].OutLinks.Add(AddFlow2.Nodes[3], "bug");
            link.Points[1] = new PointF(320, 272);
            link.Points[2] = new PointF(273, 244);

            link = AddFlow2.Nodes[1].OutLinks.Add(AddFlow2.Nodes[0], "new ideas");
            link.Points.Add(new PointF(182, 220));
            link.Points.Add(new PointF(133, 223));

            AddFlow2.EndUpdate(); // Optimize speed
        }

        void CauseEffectExample()
        {
            AddFlow6.Dock = DockStyle.Fill;
            AddFlow6.AutoScroll = true;
            AddFlow6.BackColor = SystemColors.Window;
            AddFlow6.PageUnit = GraphicsUnit.Point;
            AddFlow6.OwnerDraw = true;
            AddFlow6.Grid.Draw = false;
            AddFlow6.Grid.Snap = false;

            AddFlow6.DefNodeProp.FillColor = Color.LightYellow;
            AddFlow6.DefNodeProp.DrawColor = Color.Transparent;
            AddFlow6.DefNodeProp.Alignment = Alignment.CenterBOTTOM;
            AddFlow6.DefNodeProp.TextMargin = new Size(0, 10);
            AddFlow6.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;
            AddFlow6.DefNodeProp.DrawWidth = 1;
            AddFlow6.DefNodeProp.Font = new System.Drawing.Font("Verdana", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, 0);
            AddFlow6.DefNodeProp.YMoveable = false;
            AddFlow6.DefNodeProp.YSizeable = false;
            AddFlow6.DefNodeProp.OutLinkable = false;
            AddFlow6.DefNodeProp.InLinkable = false;
            AddFlow6.DefNodeProp.LabelEdit = false;
            AddFlow6.DefNodeProp.HighlightChildren = false;

            AddFlow6.DefLinkProp.ArrowDst.Style = ArrowStyle.None;
            AddFlow6.DefLinkProp.Jump = Jump.Arc;
            AddFlow6.DefLinkProp.EndCap = LineCap.ArrowAnchor;
            AddFlow6.DefLinkProp.DrawWidth = 3;
            AddFlow6.DefLinkProp.AdjustOrg = true;
            AddFlow6.DefLinkProp.AdjustDst = true;

            AddFlow6.BeginUpdate(); // Optimize speed

            Node node0 = AddFlow6.Nodes.Add(432, 16, 128, 48);
            node0.Properties["swimline"].Value = "Financial";
            AddChildren(node0, "Control expenditure growth");

            Node node1 = AddFlow6.Nodes.Add(224, 16, 128, 48);
            node1.Properties["swimline"].Value = "Financial";
            AddChildren(node1, "Improve product contribution");

            Node node2 = AddFlow6.Nodes.Add(16, 16, 128, 48);
            node2.Properties["swimline"].Value = "Financial";
            AddChildren(node2, "Maintain profitable growth");

            Node node3 = AddFlow6.Nodes.Add(16, 128, 128, 48);
            node3.Properties["swimline"].Value = "Customer";
            AddChildren(node3, "Achieve 95% customer satisfaction");

            Node node4 = AddFlow6.Nodes.Add(16, 352, 128, 48);
            node4.Properties["swimline"].Value = "Learning";
            AddChildren(node4, "Recruit Management internally");

            Node node5 = AddFlow6.Nodes.Add(224, 352, 144, 48);
            node5.Properties["swimline"].Value = "Learning";
            AddChildren(node5, "Retain the best people");

            Node node6 = AddFlow6.Nodes.Add(16, 240, 128, 48);
            node6.Properties["swimline"].Value = "Internal";
            AddChildren(node6, "Improve Product Quality");

            Node node7 = AddFlow6.Nodes.Add(224, 240, 144, 48);
            node7.Properties["swimline"].Value = "Internal";
            AddChildren(node7, "Improve sales lead generation");

            Node node8 = AddFlow6.Nodes.Add(224, 128, 144, 48);
            node8.Properties["swimline"].Value = "Customer";
            AddChildren(node8, "Improve customer loyalty");

            Link link = null;

            link = node4.OutLinks.Add(node5);
            link.Points[0] = new PointF(144, 376);
            link.Points[1] = new PointF(224, 376);

            link = node5.OutLinks.Add(node6);
            link.Points[0] = new PointF(242, 352);
            link.Points[1] = new PointF(128, 288);

            link = node5.OutLinks.Add(node7);
            link.Points[0] = new PointF(314, 352);
            link.Points[1] = new PointF(278, 288);

            link = node6.OutLinks.Add(node3);
            link.Points[0] = new PointF(48, 240);
            link.Points[1] = new PointF(96, 176);

            link = node3.OutLinks.Add(node2);
            link.Points[0] = new PointF(112, 128);
            link.Points[1] = new PointF(64, 64);

            link = node7.OutLinks.Add(node0);
            link.Points[0] = new PointF(350, 240);
            link.Points[1] = new PointF(464, 64);

            link = node3.OutLinks.Add(node8);
            link.Points[0] = new PointF(144, 152);
            link.Points[1] = new PointF(224, 152);

            link = node0.OutLinks.Add(node1);
            link.Points[0] = new PointF(432, 32);
            link.Points[1] = new PointF(352, 32);

            link = node1.OutLinks.Add(node2);
            link.Points[0] = new PointF(224, 32);
            link.Points[1] = new PointF(144, 32);

            link = node0.OutLinks.Add(node2);
            link.Points[0] = new PointF(432, 48);
            link.Points[1] = new PointF(144, 48);
            link.Points.Add(new PointF(272, 96));

            AddFlow6.EndUpdate();

            AddFlow6.CanDrawNode = false;
        }
        
        private void AddChildren(Node parent, string text)
        {
            // The location and width given in the following line are not important
            // since the node will be docked at the top of the parent node.
            Node node1 = new Node(0, 0, 20, 10, AddFlow6.DefNodeProp);

            string s = (string)parent.Properties["swimline"].Value;
            switch (s)
            {
                case "Financial":
                    node1.FillColor = Color.Gold;
                    break;
                case "Internal":
                    node1.FillColor = Color.LimeGreen;
                    break;
                case "Learning":
                    node1.FillColor = Color.SteelBlue;
                    break;
                case "Customer":
                    node1.FillColor = Color.LightSalmon;
                    break;
            }
            node1.DrawColor = Color.Transparent;
            node1.Selectable = false;
            node1.Logical = false;
            node1.LabelEdit = false;
            node1.Dock = DockStyle.Top;
            AddFlow6.Nodes.Add(node1);
            node1.Parent = parent;

            Node node2 = new Node(0, 0, 20, 10, AddFlow6.DefNodeProp);
            node2.FillColor = Color.White;
            node2.GradientColor = Color.Silver;
            node2.DrawColor = Color.Transparent;
            node2.Selectable = false;
            node2.Logical = false;
            node2.LabelEdit = false;
            node2.Dock = DockStyle.Fill;
            node2.Gradient = true;
            node2.GradientMode = LinearGradientMode.Vertical;
            node2.Text = text;
            AddFlow6.Nodes.Add(node2);
            node2.Parent = parent;
        }

        private void AddFlow6_DiagramOwnerDraw(object sender, Lassalle.Flow.DiagramOwnerDrawEventArgs e)
        {
            Graphics grfx = e.Graphics;

            // Save the graphics state because it does not belong to us
            // (although in this case, it not necessary because we do not alter the Graphics state)
            GraphicsState gs = grfx.Save();

            float swimLinesWidth = AddFlow6.ClientRectangle.Size.Width + AddFlow6.Extent.Width;
            Pen pen = new Pen(Color.OrangeRed, 2);
            grfx.DrawLine(pen, 0, 84, swimLinesWidth, 84);
            grfx.DrawLine(pen, 0, 196, swimLinesWidth, 196);
            grfx.DrawLine(pen, 0, 308, swimLinesWidth, 308);
            grfx.DrawLine(pen, 0, 420, swimLinesWidth, 420);

            Font font = new Font("Times New Roman", 15);
            grfx.DrawString("Financial", font, Brushes.Navy, 470, 69);
            grfx.DrawString("Customer", font, Brushes.Navy, 470, 181);
            grfx.DrawString("Internal", font, Brushes.Navy, 470, 293);
            grfx.DrawString("Learning", font, Brushes.Navy, 470, 405);

            // Restore the graphics state
            grfx.Restore(gs);
        }

        void DatabaseExample()
        {
            AddFlow7.Dock = DockStyle.Fill;
            AddFlow7.BackColor = Color.White;
            AddFlow7.AutoScroll = true;
            AddFlow7.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;
            AddFlow7.DefNodeProp.FillColor = Color.LightYellow;
            AddFlow7.DefNodeProp.Dock = DockStyle.Top;
            AddFlow7.DefNodeProp.InLinkable = false;
            AddFlow7.DefNodeProp.DrawWidth = 2;
            AddFlow7.DefNodeProp.Alignment = Alignment.CenterTOP;
            AddFlow7.DefNodeProp.LabelEdit = false;
            AddFlow7.DefNodeProp.OutLinkable = false;
            AddFlow7.DefNodeProp.HighlightChildren = false;
            AddFlow7.DefLinkProp.AdjustOrg = true;
            AddFlow7.DefLinkProp.AdjustDst = true;

            AddFlow7.BeginUpdate(); // Optimize speed

            Node tableNode1 = AddTable("Table1", 33, 20, 100, 133);
            Node tableNode2 = AddTable("Table2", 367, 33, 100, 113);
            Node tableNode3 = AddTable("Table3", 200, 167, 100, 133);

            // Add fields in each table
            AddField(tableNode1, "field11");
            AddField(tableNode1, "field12");
            AddField(tableNode1, "field13");
            AddField(tableNode1, "field14");
            AddField(tableNode1, "field15");

            AddField(tableNode2, "field21");
            AddField(tableNode2, "field22");
            AddField(tableNode2, "field23");
            AddField(tableNode2, "field24");

            AddField(tableNode3, "field31");
            AddField(tableNode3, "field32");
            AddField(tableNode3, "field33");
            AddField(tableNode3, "field34");
            AddField(tableNode3, "field35");

            Link link = null;
            link = tableNode1.Children[1].OutLinks.Add(tableNode3.Children[4]);
            link.ArrowDst.Style = ArrowStyle.Many;
            link.ArrowDst.Angle = ArrowAngle.deg30;
            AdjustLinkSegment(link);

            link = tableNode1.Children[4].OutLinks.Add(tableNode2.Children[2]);
            link.ArrowDst.Style = ArrowStyle.Many;
            link.ArrowDst.Angle = ArrowAngle.deg30;
            AdjustLinkSegment(link);

            link = tableNode2.Children[3].OutLinks.Add(tableNode3.Children[1]);
            link.ArrowDst.Style = ArrowStyle.Many;
            link.ArrowDst.Angle = ArrowAngle.deg30;
            AdjustLinkSegment(link);

            AddFlow7.EndUpdate();
        }

        private Node AddTable(string header, float x, float y, float cx, float cy)
        {
            Node tableNode = new Node(x, y, cx, cy, AddFlow7.DefNodeProp);
            tableNode.Properties["Type"].Value = "Table";
            AddFlow7.Nodes.Add(tableNode);
            AddHeader(tableNode, header);
            return tableNode;
        }

        private Node AddHeader(Node tableNode, string headerName)
        {
            // The location and width given in the following line are not important
            // since the node will be docked at the top of the parent node.
            Node headerNode = new Node(0, 0, 20, fieldHeight, headerName, AddFlow7.DefNodeProp);
            headerNode.FillColor = Color.LightGreen;
            headerNode.DrawColor = Color.Transparent;
            headerNode.Selectable = false;
            headerNode.Logical = false;
            headerNode.LabelEdit = false;
            headerNode.Properties["Type"].Value = "Header";
            AddFlow7.Nodes.Add(headerNode);
            headerNode.Parent = tableNode;
            return headerNode;
        }

        private Node AddField(Node tableNode, string fieldName)
        {
            Node fieldNode = new Node(0, 0, 20, 20, fieldName, AddFlow7.DefNodeProp);
            fieldNode.DrawColor = Color.Transparent;
            fieldNode.Alignment = Alignment.LeftJustifyMIDDLE; // The field text is left justified
            fieldNode.Logical = false;
            fieldNode.InLinkable = true;
            fieldNode.OutLinkable = true;
            fieldNode.LabelEdit = false;
            fieldNode.Properties["Type"].Value = "Field";
            AddFlow7.Nodes.Add(fieldNode);
            fieldNode.Parent = tableNode;
            return fieldNode;
        }

        private void AdjustLinkSegment(Link link)
        {
            if (link == null)
                return;

            link.Points.Clear();

            PointF pt1 = link.Points[0];
            PointF pt2 = link.Points[1];
            RectangleF rcOrg = link.Org.Rect;
            RectangleF rcDst = link.Dst.Rect;

            float x4, x3, y3, y4;
            if (rcOrg.Left + rcOrg.Width / 2 < rcDst.Left + rcDst.Width / 2)
            {
                pt1.X = rcOrg.Left + rcOrg.Width;
                pt1.Y = rcOrg.Top + rcOrg.Height / 2;
                pt2.X = rcDst.Left;
                pt2.Y = rcDst.Top + rcDst.Height / 2;
                x3 = Math.Max(pt1.X + linkHorzOffset, 0);
                y3 = pt1.Y;
                x4 = Math.Max(pt2.X - linkHorzOffset, 0);
                y4 = pt2.Y;
            }
            else
            {
                pt1.X = rcOrg.Left;
                pt1.Y = rcOrg.Top + rcOrg.Height / 2;
                pt2.X = rcDst.Left + rcDst.Width;
                pt2.Y = rcDst.Top + rcDst.Height / 2;
                x3 = Math.Max(pt1.X - linkHorzOffset, 0);
                y3 = pt1.Y;
                x4 = Math.Max(pt2.X + linkHorzOffset, 0);
                y4 = pt2.Y;
            }

            link.Points[0] = pt1;
            link.Points[1] = pt2;
            link.Points.Add(new PointF(x3, y3));
            link.Points.Add(new PointF(x4, y4));
        }

        private bool IsTableNode(Node node)
        {
            return ((string)(node.Properties["Type"].Value) == "Table");
        }

        private bool IsField(Node node)
        {
            return ((string)(node.Properties["Type"].Value) == "Field");
        }

        private bool IsSameTable(Node node1, Node node2)
        {
            return (node1.Parent == node2.Parent && node2.Parent != null);
        }

        private void AdjustAllLinkSegments(Node tableNode)
        {
            if (tableNode == null)
                return;
            foreach (Node fieldNode in tableNode.Children)
                foreach (Link link in fieldNode.Links)
                    AdjustLinkSegment(link);
        }

        private void AddFlow7_AfterMove(object sender, EventArgs e)
        {
            Item item = AddFlow7.SelectedItem;
            if (item != null && item is Node)
            {
                Node node = (Node)item;
                if (IsTableNode(node))
                    AdjustAllLinkSegments(node);
            }
        }

        private void AddFlow7_AfterResize(object sender, EventArgs e)
        {
            Item item = AddFlow7.SelectedItem;
            if (item != null && item is Node)
            {
                Node node = (Node)item;
                if (IsTableNode(node))
                {
                    // We are resizing a "table" node (field nodes are not resizable)
                    // First, we ensure that the height of this node is greater
                    // than the sum of the heights of its "field" nodes.
                    if (node.Rect.Height < node.Children.Count * fieldHeight)
                    {
                        RectangleF rect = new RectangleF(node.Rect.Location, node.Rect.Size);
                        rect.Height = node.Children.Count * fieldHeight + fieldHeight / 2;
                        node.Rect = rect;
                    }
                    AdjustAllLinkSegments(node);
                }
            }
        }

        private void AddFlow7_AfterAddLink(object sender, AfterAddLinkEventArgs e)
        {
            AdjustLinkSegment(e.Link);
        }

        private void AddFlow7_BeforeAddLink(object sender, BeforeAddLinkEventArgs e)
        {
            // If the origin and the destination nodes belong to the same table then
            // cancel this link creation. 
            if (IsSameTable(e.Org, e.Dst))
                e.Cancel.Cancel = true;
        }
    }
}