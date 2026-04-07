namespace BDSalon.Components
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ageText = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.Location = new System.Drawing.Point(50, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "label1";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailLabel.Location = new System.Drawing.Point(288, 33);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(81, 29);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "label2";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.delBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delBtn.BackgroundImage")));
            this.delBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delBtn.Location = new System.Drawing.Point(975, 12);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(61, 70);
            this.delBtn.TabIndex = 2;
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.phoneText);
            this.panel1.Controls.Add(this.ageText);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 88);
            this.panel1.TabIndex = 3;
            // 
            // ageText
            // 
            this.ageText.AutoSize = true;
            this.ageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageText.Location = new System.Drawing.Point(560, 33);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(81, 29);
            this.ageText.TabIndex = 3;
            this.ageText.Text = "label2";
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneText.Location = new System.Drawing.Point(720, 33);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(81, 29);
            this.phoneText.TabIndex = 4;
            this.phoneText.Text = "label2";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "CustomerView";
            this.Size = new System.Drawing.Size(1073, 94);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label phoneText;
        public System.Windows.Forms.Label ageText;
    }
}
