namespace BDSalon.Components
{
    partial class OrderPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBtn = new System.Windows.Forms.Button();
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.selectDateBtn = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(106, 43);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "button1";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // flow
            // 
            this.flow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flow.AutoScroll = true;
            this.flow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flow.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flow.Location = new System.Drawing.Point(123, 122);
            this.flow.Name = "flow";
            this.flow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flow.Size = new System.Drawing.Size(1061, 468);
            this.flow.TabIndex = 1;
            // 
            // selectDateBtn
            // 
            this.selectDateBtn.Location = new System.Drawing.Point(905, 43);
            this.selectDateBtn.Name = "selectDateBtn";
            this.selectDateBtn.Size = new System.Drawing.Size(75, 23);
            this.selectDateBtn.TabIndex = 4;
            this.selectDateBtn.Text = "button1";
            this.selectDateBtn.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(656, 44);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 3;
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Location = new System.Drawing.Point(1025, 43);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(75, 23);
            this.viewAllBtn.TabIndex = 5;
            this.viewAllBtn.Text = "button1";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.selectDateBtn);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.flow);
            this.Controls.Add(this.addBtn);
            this.Name = "OrderPage";
            this.Size = new System.Drawing.Size(1280, 645);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.FlowLayoutPanel flow;
        private System.Windows.Forms.Button selectDateBtn;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button viewAllBtn;
    }
}
