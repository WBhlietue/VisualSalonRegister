namespace BDSalon.Components
{
    partial class HeaderLogin
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.timeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logoutBtn.BackColor = System.Drawing.Color.Khaki;
            this.logoutBtn.Location = new System.Drawing.Point(1113, 16);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(154, 41);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.homeBtn.BackColor = System.Drawing.Color.Khaki;
            this.homeBtn.Location = new System.Drawing.Point(338, 16);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(154, 41);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // orderBtn
            // 
            this.orderBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderBtn.BackColor = System.Drawing.Color.Khaki;
            this.orderBtn.Location = new System.Drawing.Point(536, 16);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(154, 41);
            this.orderBtn.TabIndex = 3;
            this.orderBtn.Text = "Orders";
            this.orderBtn.UseVisualStyleBackColor = false;
            // 
            // timeBtn
            // 
            this.timeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeBtn.BackColor = System.Drawing.Color.Khaki;
            this.timeBtn.Location = new System.Drawing.Point(726, 16);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(154, 41);
            this.timeBtn.TabIndex = 4;
            this.timeBtn.Text = "TimeTable";
            this.timeBtn.UseVisualStyleBackColor = false;
            // 
            // HeaderBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.logoutBtn);
            this.Name = "HeaderBar";
            this.Size = new System.Drawing.Size(1280, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button timeBtn;
    }
}
