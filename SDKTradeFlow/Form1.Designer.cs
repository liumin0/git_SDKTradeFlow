namespace SDKTradeFlow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuFile = new System.Windows.Forms.MenuItem();
            this.MenuExit = new System.Windows.Forms.MenuItem();
            this.MenuItemView = new System.Windows.Forms.MenuItem();
            this.MenuItemProperties = new System.Windows.Forms.MenuItem();
            this.MenuHelp = new System.Windows.Forms.MenuItem();
            this.MenuAbout = new System.Windows.Forms.MenuItem();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.AddFlow2 = new Lassalle.Flow.AddFlow();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.AddFlow1 = new Lassalle.Flow.AddFlow();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.AddFlow3 = new Lassalle.Flow.AddFlow();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.AddFlow4 = new Lassalle.Flow.AddFlow();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.AddFlow5 = new Lassalle.Flow.AddFlow();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.AddFlow6 = new Lassalle.Flow.AddFlow();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.AddFlow7 = new Lassalle.Flow.AddFlow();
            this.TabControl1.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuFile,
            this.MenuItemView,
            this.MenuHelp});
            // 
            // MenuFile
            // 
            this.MenuFile.Index = 0;
            this.MenuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuExit});
            this.MenuFile.Text = "&File";
            // 
            // MenuExit
            // 
            this.MenuExit.Index = 0;
            this.MenuExit.Text = "E&xit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuItemView
            // 
            this.MenuItemView.Index = 1;
            this.MenuItemView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItemProperties});
            this.MenuItemView.Text = "&View";
            // 
            // MenuItemProperties
            // 
            this.MenuItemProperties.Index = 0;
            this.MenuItemProperties.Text = "&Properties...";
            this.MenuItemProperties.Click += new System.EventHandler(this.MenuItemProperties_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.Index = 2;
            this.MenuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuAbout});
            this.MenuHelp.Text = "&?";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Index = 0;
            this.MenuAbout.Text = "&About...";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "");
            this.ImageList2.Images.SetKeyName(1, "");
            this.ImageList2.Images.SetKeyName(2, "");
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Controls.Add(this.tabPage7);
            this.TabControl1.Location = new System.Drawing.Point(12, 7);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(784, 561);
            this.TabControl1.TabIndex = 2;
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.AddFlow2);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(776, 535);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "State Diagram";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // AddFlow2
            // 
            this.AddFlow2.Location = new System.Drawing.Point(21, 18);
            this.AddFlow2.Name = "AddFlow2";
            this.AddFlow2.Size = new System.Drawing.Size(235, 168);
            this.AddFlow2.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.AddFlow1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(776, 535);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Flowchart";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // AddFlow1
            // 
            this.AddFlow1.Location = new System.Drawing.Point(41, 37);
            this.AddFlow1.Name = "AddFlow1";
            this.AddFlow1.Size = new System.Drawing.Size(320, 162);
            this.AddFlow1.TabIndex = 0;
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.AddFlow3);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(776, 535);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "WorkFlow";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // AddFlow3
            // 
            this.AddFlow3.Location = new System.Drawing.Point(37, 28);
            this.AddFlow3.Name = "AddFlow3";
            this.AddFlow3.Size = new System.Drawing.Size(305, 185);
            this.AddFlow3.TabIndex = 0;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.AddFlow4);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(776, 535);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Internet Traffic";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // AddFlow4
            // 
            this.AddFlow4.Location = new System.Drawing.Point(36, 26);
            this.AddFlow4.Name = "AddFlow4";
            this.AddFlow4.Size = new System.Drawing.Size(307, 180);
            this.AddFlow4.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.AddFlow5);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(776, 535);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Network";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // AddFlow5
            // 
            this.AddFlow5.Location = new System.Drawing.Point(31, 30);
            this.AddFlow5.Name = "AddFlow5";
            this.AddFlow5.Size = new System.Drawing.Size(409, 205);
            this.AddFlow5.TabIndex = 0;
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.AddFlow6);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new System.Drawing.Size(776, 535);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "Cause and Effect";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // AddFlow6
            // 
            this.AddFlow6.Location = new System.Drawing.Point(20, 29);
            this.AddFlow6.Name = "AddFlow6";
            this.AddFlow6.Size = new System.Drawing.Size(282, 171);
            this.AddFlow6.TabIndex = 0;
            this.AddFlow6.DiagramOwnerDraw += new Lassalle.Flow.AddFlow.DiagramOwnerDrawEventHandler(this.AddFlow6_DiagramOwnerDraw);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.AddFlow7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(776, 535);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Database";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // AddFlow7
            // 
            this.AddFlow7.Location = new System.Drawing.Point(33, 23);
            this.AddFlow7.Name = "AddFlow7";
            this.AddFlow7.Size = new System.Drawing.Size(233, 205);
            this.AddFlow7.TabIndex = 0;
            this.AddFlow7.AfterMove += new Lassalle.Flow.AddFlow.AfterMoveEventHandler(this.AddFlow7_AfterMove);
            this.AddFlow7.AfterResize += new Lassalle.Flow.AddFlow.AfterResizeEventHandler(this.AddFlow7_AfterResize);
            this.AddFlow7.AfterAddLink += new Lassalle.Flow.AddFlow.AfterAddLinkEventHandler(this.AddFlow7_AfterAddLink);
            this.AddFlow7.BeforeAddLink += new Lassalle.Flow.AddFlow.BeforeAddLinkEventHandler(this.AddFlow7_BeforeAddLink);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 577);
            this.Controls.Add(this.TabControl1);
            this.Menu = this.MainMenu1;
            this.Name = "Form1";
            this.Text = "AddFlow Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu MainMenu1;
        private System.Windows.Forms.MenuItem MenuFile;
        private System.Windows.Forms.MenuItem MenuExit;
        private System.Windows.Forms.MenuItem MenuItemView;
        private System.Windows.Forms.MenuItem MenuItemProperties;
        private System.Windows.Forms.MenuItem MenuHelp;
        private System.Windows.Forms.MenuItem MenuAbout;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.ImageList ImageList2;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private Lassalle.Flow.AddFlow AddFlow1;
        private System.Windows.Forms.TabPage TabPage5;
        private Lassalle.Flow.AddFlow AddFlow2;
        private System.Windows.Forms.TabPage TabPage4;
        private Lassalle.Flow.AddFlow AddFlow3;
        private System.Windows.Forms.TabPage TabPage3;
        private Lassalle.Flow.AddFlow AddFlow4;
        private System.Windows.Forms.TabPage TabPage2;
        private Lassalle.Flow.AddFlow AddFlow5;
        private System.Windows.Forms.TabPage TabPage6;
        private Lassalle.Flow.AddFlow AddFlow6;
        private System.Windows.Forms.TabPage tabPage7;
        private Lassalle.Flow.AddFlow AddFlow7;
    }
}

