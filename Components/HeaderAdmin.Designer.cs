namespace BDSalon.Components
{
    partial class HeaderAdmin
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.timeBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(926, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 29);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "label1";
            // 
            // timeBtn
            // 
            this.timeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeBtn.BackColor = System.Drawing.Color.Khaki;
            this.timeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeBtn.Location = new System.Drawing.Point(718, 17);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(154, 41);
            this.timeBtn.TabIndex = 9;
            this.timeBtn.Text = "TimeTable";
            this.timeBtn.UseVisualStyleBackColor = false;
            // 
            // orderBtn
            // 
            this.orderBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderBtn.BackColor = System.Drawing.Color.Khaki;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderBtn.Location = new System.Drawing.Point(528, 17);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(154, 41);
            this.orderBtn.TabIndex = 8;
            this.orderBtn.Text = "Orders";
            this.orderBtn.UseVisualStyleBackColor = false;
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.homeBtn.BackColor = System.Drawing.Color.Khaki;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.homeBtn.Location = new System.Drawing.Point(151, 17);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(154, 41);
            this.homeBtn.TabIndex = 7;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logoutBtn.BackColor = System.Drawing.Color.Khaki;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logoutBtn.Location = new System.Drawing.Point(1105, 17);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(154, 41);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // customersBtn
            // 
            this.customersBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customersBtn.BackColor = System.Drawing.Color.Khaki;
            this.customersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customersBtn.Location = new System.Drawing.Point(340, 17);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(154, 41);
            this.customersBtn.TabIndex = 11;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = false;
            // 
            // HeaderAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.logoutBtn);
            this.Name = "HeaderAdmin";
            this.Size = new System.Drawing.Size(1280, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button timeBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button customersBtn;
    }
}
