namespace Car_Rent_New
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siButton1 = new Car_Rent_New.SIButton();
            this.siButton2 = new Car_Rent_New.SIButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.siButton1);
            this.panel1.Controls.Add(this.siButton2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(470, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 224);
            this.panel1.TabIndex = 3;
            // 
            // siButton1
            // 
            this.siButton1.BackColor = System.Drawing.Color.DarkRed;
            this.siButton1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.siButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siButton1.BorderRadius = 0;
            this.siButton1.BorderSize = 0;
            this.siButton1.FlatAppearance.BorderSize = 0;
            this.siButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.siButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siButton1.ForeColor = System.Drawing.Color.White;
            this.siButton1.Location = new System.Drawing.Point(141, 129);
            this.siButton1.Name = "siButton1";
            this.siButton1.Size = new System.Drawing.Size(92, 32);
            this.siButton1.TabIndex = 0;
            this.siButton1.Text = "EXIT";
            this.siButton1.TextColor = System.Drawing.Color.White;
            this.siButton1.UseVisualStyleBackColor = false;
            this.siButton1.Click += new System.EventHandler(this.siButton1_Click_1);
            // 
            // siButton2
            // 
            this.siButton2.BackColor = System.Drawing.Color.MidnightBlue;
            this.siButton2.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.siButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siButton2.BorderRadius = 0;
            this.siButton2.BorderSize = 0;
            this.siButton2.FlatAppearance.BorderSize = 0;
            this.siButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.siButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.siButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.siButton2.ForeColor = System.Drawing.Color.White;
            this.siButton2.Location = new System.Drawing.Point(33, 129);
            this.siButton2.Name = "siButton2";
            this.siButton2.Size = new System.Drawing.Size(92, 32);
            this.siButton2.TabIndex = 5;
            this.siButton2.Text = "LOGIN";
            this.siButton2.TextColor = System.Drawing.Color.White;
            this.siButton2.UseVisualStyleBackColor = false;
            this.siButton2.Click += new System.EventHandler(this.siButton2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(133, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(134, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 21);
            this.txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Car Rental System";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Car_Rent_New.Properties.Resources.nwnwlogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(797, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SIButton siButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private SIButton siButton2;
        private System.Windows.Forms.Label label3;
    }
}

