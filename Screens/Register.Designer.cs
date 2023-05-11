namespace BDSalon.Screens
{
    partial class Register
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
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.firstInpupt = new System.Windows.Forms.TextBox();
            this.lastInput = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.errorLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(328, 31);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(100, 22);
            this.emailInput.TabIndex = 0;
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(328, 80);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(100, 22);
            this.passInput.TabIndex = 1;
            // 
            // firstInpupt
            // 
            this.firstInpupt.Location = new System.Drawing.Point(328, 130);
            this.firstInpupt.Name = "firstInpupt";
            this.firstInpupt.Size = new System.Drawing.Size(100, 22);
            this.firstInpupt.TabIndex = 2;
            // 
            // lastInput
            // 
            this.lastInput.Location = new System.Drawing.Point(328, 187);
            this.lastInput.Name = "lastInput";
            this.lastInput.Size = new System.Drawing.Size(100, 22);
            this.lastInput.TabIndex = 3;
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(328, 236);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(100, 22);
            this.ageInput.TabIndex = 4;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(328, 288);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(100, 22);
            this.phoneInput.TabIndex = 5;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(509, 376);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(350, 375);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(90, 387);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 8;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            // 
            // errorLable
            // 
            this.errorLable.AutoSize = true;
            this.errorLable.Location = new System.Drawing.Point(539, 241);
            this.errorLable.Name = "errorLable";
            this.errorLable.Size = new System.Drawing.Size(44, 16);
            this.errorLable.TabIndex = 9;
            this.errorLable.Text = "label1";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLable);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.lastInput);
            this.Controls.Add(this.firstInpupt);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.emailInput);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.TextBox firstInpupt;
        private System.Windows.Forms.TextBox lastInput;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label errorLable;
    }
}