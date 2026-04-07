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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderView));
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderTimeLabel = new System.Windows.Forms.Label();
            this.orderTypeLabel = new System.Windows.Forms.Label();
            this.orderPriceLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.orderProgressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderDateLabel.Location = new System.Drawing.Point(3, 14);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(139, 29);
            this.orderDateLabel.TabIndex = 0;
            this.orderDateLabel.Text = "2023.05.05";
            // 
            // orderTimeLabel
            // 
            this.orderTimeLabel.AutoSize = true;
            this.orderTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderTimeLabel.Location = new System.Drawing.Point(81, 57);
            this.orderTimeLabel.Name = "orderTimeLabel";
            this.orderTimeLabel.Size = new System.Drawing.Size(27, 29);
            this.orderTimeLabel.TabIndex = 1;
            this.orderTimeLabel.Text = "6";
            // 
            // orderTypeLabel
            // 
            this.orderTypeLabel.AutoSize = true;
            this.orderTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderTypeLabel.Location = new System.Drawing.Point(411, 14);
            this.orderTypeLabel.Name = "orderTypeLabel";
            this.orderTypeLabel.Size = new System.Drawing.Size(256, 29);
            this.orderTypeLabel.TabIndex = 2;
            this.orderTypeLabel.Text = "USEE BUDMAARAIN";
            this.orderTypeLabel.Click += new System.EventHandler(this.orderTypeLabel_Click);
            // 
            // orderPriceLabel
            // 
            this.orderPriceLabel.AutoSize = true;
            this.orderPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderPriceLabel.Location = new System.Drawing.Point(213, 14);
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
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteBtn.Location = new System.Drawing.Point(900, 28);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(58, 58);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // orderProgressLabel
            // 
            this.orderProgressLabel.AutoSize = true;
            this.orderProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderProgressLabel.Location = new System.Drawing.Point(713, 14);
            this.orderProgressLabel.Name = "orderProgressLabel";
            this.orderProgressLabel.Size = new System.Drawing.Size(131, 29);
            this.orderProgressLabel.TabIndex = 6;
            this.orderProgressLabel.Text = "ONGOING";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailLabel.Location = new System.Drawing.Point(275, 57);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(256, 29);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "USEE BUDMAARAIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.changeBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.orderDateLabel);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.orderTimeLabel);
            this.panel1.Controls.Add(this.orderProgressLabel);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.orderPriceLabel);
            this.panel1.Controls.Add(this.orderTypeLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 114);
            this.panel1.TabIndex = 10;
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.Chocolate;
            this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changeBtn.Location = new System.Drawing.Point(718, 57);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(147, 36);
            this.changeBtn.TabIndex = 10;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(1000, 120);
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button changeBtn;
    }
}
