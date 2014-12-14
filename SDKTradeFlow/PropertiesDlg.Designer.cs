namespace SDKTradeFlow
{
    partial class PropertiesDlg
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
            this.OK_Button = new System.Windows.Forms.Button();
            this.PropertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(351, 376);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(62, 22);
            this.OK_Button.TabIndex = 2;
            this.OK_Button.Text = "&Close";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // PropertyGrid1
            // 
            this.PropertyGrid1.Location = new System.Drawing.Point(11, 11);
            this.PropertyGrid1.Name = "PropertyGrid1";
            this.PropertyGrid1.Size = new System.Drawing.Size(306, 384);
            this.PropertyGrid1.TabIndex = 3;
            // 
            // PropertiesDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 409);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.PropertyGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertiesDlg";
            this.Text = "Properties";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.PropertyGrid PropertyGrid1;

    }
}