namespace SDKTradeFlow
{
    partial class CombinedSignalEdit
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
            this.signalNameLable = new System.Windows.Forms.Label();
            this.combinedSingalName = new System.Windows.Forms.TextBox();
            this.combineLabel = new System.Windows.Forms.Label();
            this.combineBox = new System.Windows.Forms.ListBox();
            this.signal1 = new System.Windows.Forms.Label();
            this.signal1Box = new System.Windows.Forms.ListBox();
            this.signal2Box = new System.Windows.Forms.ListBox();
            this.signal2 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signalNameLable
            // 
            this.signalNameLable.AutoSize = true;
            this.signalNameLable.Location = new System.Drawing.Point(34, 41);
            this.signalNameLable.Name = "signalNameLable";
            this.signalNameLable.Size = new System.Drawing.Size(41, 12);
            this.signalNameLable.TabIndex = 0;
            this.signalNameLable.Text = "名称：";
            this.signalNameLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // combinedSingalName
            // 
            this.combinedSingalName.Location = new System.Drawing.Point(84, 37);
            this.combinedSingalName.Name = "combinedSingalName";
            this.combinedSingalName.Size = new System.Drawing.Size(100, 21);
            this.combinedSingalName.TabIndex = 1;
            // 
            // combineLabel
            // 
            this.combineLabel.AutoSize = true;
            this.combineLabel.Location = new System.Drawing.Point(36, 92);
            this.combineLabel.Name = "combineLabel";
            this.combineLabel.Size = new System.Drawing.Size(53, 12);
            this.combineLabel.TabIndex = 2;
            this.combineLabel.Text = "链接符号";
            // 
            // combineBox
            // 
            this.combineBox.FormattingEnabled = true;
            this.combineBox.ItemHeight = 12;
            this.combineBox.Items.AddRange(new object[] {
            "-",
            "*",
            "/",
            "+",
            "<",
            "<=",
            ">",
            ">=",
            "abs",
            "ceiling",
            "equals",
            "exp",
            "floor",
            "log",
            "mod",
            "power",
            "round",
            "set",
            "sine",
            "truncate"});
            this.combineBox.Location = new System.Drawing.Point(20, 115);
            this.combineBox.Name = "combineBox";
            this.combineBox.Size = new System.Drawing.Size(87, 148);
            this.combineBox.TabIndex = 3;
            // 
            // signal1
            // 
            this.signal1.AutoSize = true;
            this.signal1.Location = new System.Drawing.Point(160, 92);
            this.signal1.Name = "signal1";
            this.signal1.Size = new System.Drawing.Size(35, 12);
            this.signal1.TabIndex = 4;
            this.signal1.Text = "信号1";
            // 
            // signal1Box
            // 
            this.signal1Box.FormattingEnabled = true;
            this.signal1Box.ItemHeight = 12;
            this.signal1Box.Items.AddRange(new object[] {
            "abcdef",
            "qwerty"});
            this.signal1Box.Location = new System.Drawing.Point(120, 115);
            this.signal1Box.Name = "signal1Box";
            this.signal1Box.Size = new System.Drawing.Size(184, 148);
            this.signal1Box.TabIndex = 5;
            // 
            // signal2Box
            // 
            this.signal2Box.FormattingEnabled = true;
            this.signal2Box.ItemHeight = 12;
            this.signal2Box.Items.AddRange(new object[] {
            "ABCDEFG",
            "QWERTY"});
            this.signal2Box.Location = new System.Drawing.Point(315, 115);
            this.signal2Box.Name = "signal2Box";
            this.signal2Box.Size = new System.Drawing.Size(153, 148);
            this.signal2Box.TabIndex = 7;
            // 
            // signal2
            // 
            this.signal2.AutoSize = true;
            this.signal2.Location = new System.Drawing.Point(313, 98);
            this.signal2.Name = "signal2";
            this.signal2.Size = new System.Drawing.Size(35, 12);
            this.signal2.TabIndex = 6;
            this.signal2.Text = "信号2";
            this.signal2.Click += new System.EventHandler(this.label4_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(114, 316);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "确定";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(277, 315);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CombinedSignalEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 399);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.signal2Box);
            this.Controls.Add(this.signal2);
            this.Controls.Add(this.signal1Box);
            this.Controls.Add(this.signal1);
            this.Controls.Add(this.combineBox);
            this.Controls.Add(this.combineLabel);
            this.Controls.Add(this.combinedSingalName);
            this.Controls.Add(this.signalNameLable);
            this.Name = "CombinedSignalEdit";
            this.Text = "组合信号编辑框";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signalNameLable;
        private System.Windows.Forms.TextBox combinedSingalName;
        private System.Windows.Forms.Label combineLabel;
        private System.Windows.Forms.ListBox combineBox;
        private System.Windows.Forms.Label signal1;
        private System.Windows.Forms.ListBox signal1Box;
        private System.Windows.Forms.ListBox signal2Box;
        private System.Windows.Forms.Label signal2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}