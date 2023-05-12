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
            this.orderProgressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderDateLabel.Location = new System.Drawing.Point(31, 16);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(139, 29);
            this.orderDateLabel.TabIndex = 0;
            this.orderDateLabel.Text = "2023.05.05";
            // 
            // orderTimeLabel
            // 
            this.orderTimeLabel.AutoSize = true;
            this.orderTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderTimeLabel.Location = new System.Drawing.Point(220, 16);
            this.orderTimeLabel.Name = "orderTimeLabel";
            this.orderTimeLabel.Size = new System.Drawing.Size(27, 29);
            this.orderTimeLabel.TabIndex = 1;
            this.orderTimeLabel.Text = "6";
            // 
            // orderTypeLabel
            // 
            this.orderTypeLabel.AutoSize = true;
            this.orderTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderTypeLabel.Location = new System.Drawing.Point(401, 16);
            this.orderTypeLabel.Name = "orderTypeLabel";
            this.orderTypeLabel.Size = new System.Drawing.Size(256, 29);
            this.orderTypeLabel.TabIndex = 2;
            this.orderTypeLabel.Text = "USEE BUDMAARAIN";
            // 
            // orderPriceLabel
            // 
            this.orderPriceLabel.AutoSize = true;
            this.orderPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderPriceLabel.Location = new System.Drawing.Point(268, 16);
            this.orderPriceLabel.Name = "orderPriceLabel";
            this.orderPriceLabel.Size = new System.Drawing.Size(83, 29);
            this.orderPriceLabel.TabIndex = 3;
            this.orderPriceLabel.Text = "10000";
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
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteBtn.Location = new System.Drawing.Point(864, 11);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(123, 39);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Remove";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // orderProgressLabel
            // 
            this.orderProgressLabel.AutoSize = true;
            this.orderProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderProgressLabel.Location = new System.Drawing.Point(681, 16);
            this.orderProgressLabel.Name = "orderProgressLabel";
            this.orderProgressLabel.Size = new System.Drawing.Size(152, 29);
            this.orderProgressLabel.TabIndex = 6;
            this.orderProgressLabel.Text = "ONGOYING\'";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailLabel.Location = new System.Drawing.Point(174, 63);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(256, 29);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "USEE BUDMAARAIN";
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editBtn.Location = new System.Drawing.Point(864, 63);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(123, 39);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.orderProgressLabel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.orderPriceLabel);
            this.Controls.Add(this.orderTypeLabel);
            this.Controls.Add(this.orderTimeLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(1000, 120);
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
        public System.Windows.Forms.Label orderProgressLabel;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Button editBtn;
    }
}
