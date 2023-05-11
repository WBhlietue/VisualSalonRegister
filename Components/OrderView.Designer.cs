namespace BDSalon.Components
{
    partial class OrderView
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
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderTimeLabel = new System.Windows.Forms.Label();
            this.orderTypeLabel = new System.Windows.Forms.Label();
            this.orderPriceLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(24, 19);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(44, 16);
            this.orderDateLabel.TabIndex = 0;
            this.orderDateLabel.Text = "label1";
            // 
            // orderTimeLabel
            // 
            this.orderTimeLabel.AutoSize = true;
            this.orderTimeLabel.Location = new System.Drawing.Point(129, 19);
            this.orderTimeLabel.Name = "orderTimeLabel";
            this.orderTimeLabel.Size = new System.Drawing.Size(44, 16);
            this.orderTimeLabel.TabIndex = 1;
            this.orderTimeLabel.Text = "label2";
            // 
            // orderTypeLabel
            // 
            this.orderTypeLabel.AutoSize = true;
            this.orderTypeLabel.Location = new System.Drawing.Point(406, 19);
            this.orderTypeLabel.Name = "orderTypeLabel";
            this.orderTypeLabel.Size = new System.Drawing.Size(44, 16);
            this.orderTypeLabel.TabIndex = 2;
            this.orderTypeLabel.Text = "label3";
            // 
            // orderPriceLabel
            // 
            this.orderPriceLabel.AutoSize = true;
            this.orderPriceLabel.Location = new System.Drawing.Point(258, 19);
            this.orderPriceLabel.Name = "orderPriceLabel";
            this.orderPriceLabel.Size = new System.Drawing.Size(44, 16);
            this.orderPriceLabel.TabIndex = 3;
            this.orderPriceLabel.Text = "label4";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(935, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(886, 19);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "button1";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.orderPriceLabel);
            this.Controls.Add(this.orderTypeLabel);
            this.Controls.Add(this.orderTimeLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(1000, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label orderDateLabel;
        public System.Windows.Forms.Label orderTimeLabel;
        public System.Windows.Forms.Label orderTypeLabel;
        public System.Windows.Forms.Label orderPriceLabel;
        public System.Windows.Forms.Button deleteBtn;
    }
}
