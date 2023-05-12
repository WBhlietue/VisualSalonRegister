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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.stateSelect = new System.Windows.Forms.ComboBox();
            this.customerSelect = new System.Windows.Forms.ComboBox();
            this.viewCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addBtn.Location = new System.Drawing.Point(25, 18);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(167, 36);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add order";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // flow
            // 
            this.flow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flow.AutoScroll = true;
            this.flow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flow.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flow.Location = new System.Drawing.Point(123, 132);
            this.flow.Name = "flow";
            this.flow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flow.Size = new System.Drawing.Size(1061, 468);
            this.flow.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datePicker.Location = new System.Drawing.Point(585, 18);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(292, 36);
            this.datePicker.TabIndex = 3;
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewAllBtn.Location = new System.Drawing.Point(954, 16);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(248, 36);
            this.viewAllBtn.TabIndex = 5;
            this.viewAllBtn.Text = "View all Time";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            // 
            // stateSelect
            // 
            this.stateSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stateSelect.FormattingEnabled = true;
            this.stateSelect.Items.AddRange(new object[] {
            "All",
            "OnGoing",
            "Completed"});
            this.stateSelect.Location = new System.Drawing.Point(266, 17);
            this.stateSelect.Name = "stateSelect";
            this.stateSelect.Size = new System.Drawing.Size(213, 37);
            this.stateSelect.TabIndex = 6;
            // 
            // customerSelect
            // 
            this.customerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customerSelect.FormattingEnabled = true;
            this.customerSelect.Items.AddRange(new object[] {
            "All",
            "OnGoing",
            "Completed"});
            this.customerSelect.Location = new System.Drawing.Point(585, 69);
            this.customerSelect.Name = "customerSelect";
            this.customerSelect.Size = new System.Drawing.Size(292, 37);
            this.customerSelect.TabIndex = 7;
            // 
            // viewCustomerBtn
            // 
            this.viewCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewCustomerBtn.Location = new System.Drawing.Point(954, 68);
            this.viewCustomerBtn.Name = "viewCustomerBtn";
            this.viewCustomerBtn.Size = new System.Drawing.Size(248, 36);
            this.viewCustomerBtn.TabIndex = 8;
            this.viewCustomerBtn.Text = "View all Customer";
            this.viewCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewCustomerBtn);
            this.Controls.Add(this.customerSelect);
            this.Controls.Add(this.stateSelect);
            this.Controls.Add(this.viewAllBtn);
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
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.ComboBox stateSelect;
        private System.Windows.Forms.ComboBox customerSelect;
        private System.Windows.Forms.Button viewCustomerBtn;
    }
}
