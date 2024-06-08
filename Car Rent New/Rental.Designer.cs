namespace Car_Rent_New
{
    partial class Rental
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.txtDriverID = new System.Windows.Forms.TextBox();
            this.txtTotalDays = new System.Windows.Forms.TextBox();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.checkBoxDriver = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.siButton5 = new Car_Rent_New.SIButton();
            this.siButton1 = new Car_Rent_New.SIButton();
            this.siButton3 = new Car_Rent_New.SIButton();
            this.siButton4 = new Car_Rent_New.SIButton();
            this.siButton2 = new Car_Rent_New.SIButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(154, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Rent ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(154, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Driver ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(154, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Vehicle Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(154, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Rent Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(154, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Return Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(100, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Total Days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(100, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Total Charge";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(278, 269);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 39;
            // 
            // txtRentID
            // 
            this.txtRentID.Enabled = false;
            this.txtRentID.Location = new System.Drawing.Point(278, 144);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(121, 20);
            this.txtRentID.TabIndex = 40;
            // 
            // txtDriverID
            // 
            this.txtDriverID.Location = new System.Drawing.Point(278, 190);
            this.txtDriverID.Name = "txtDriverID";
            this.txtDriverID.Size = new System.Drawing.Size(121, 20);
            this.txtDriverID.TabIndex = 41;
            // 
            // txtTotalDays
            // 
            this.txtTotalDays.Location = new System.Drawing.Point(224, 14);
            this.txtTotalDays.Name = "txtTotalDays";
            this.txtTotalDays.Size = new System.Drawing.Size(121, 20);
            this.txtTotalDays.TabIndex = 42;
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCharge.Location = new System.Drawing.Point(224, 50);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.Size = new System.Drawing.Size(121, 20);
            this.txtTotalCharge.TabIndex = 43;
            this.txtTotalCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxVehicleType
            // 
            this.comboBoxVehicleType.FormattingEnabled = true;
            this.comboBoxVehicleType.Location = new System.Drawing.Point(278, 216);
            this.comboBoxVehicleType.Name = "comboBoxVehicleType";
            this.comboBoxVehicleType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehicleType.TabIndex = 44;
            // 
            // checkBoxDriver
            // 
            this.checkBoxDriver.AutoSize = true;
            this.checkBoxDriver.Location = new System.Drawing.Point(278, 170);
            this.checkBoxDriver.Name = "checkBoxDriver";
            this.checkBoxDriver.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDriver.TabIndex = 52;
            this.checkBoxDriver.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(154, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Driver";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.label19.Location = new System.Drawing.Point(54, 489);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 21);
            this.label19.TabIndex = 87;
            this.label19.Text = "--Rent--";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.siButton5);
            this.panel1.Controls.Add(this.siButton1);
            this.panel1.Controls.Add(this.siButton3);
            this.panel1.Controls.Add(this.siButton4);
            this.panel1.Controls.Add(this.txtTotalCharge);
            this.panel1.Controls.Add(this.txtTotalDays);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(54, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 149);
            this.panel1.TabIndex = 88;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.labelTime.Location = new System.Drawing.Point(685, 577);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(34, 13);
            this.labelTime.TabIndex = 90;
            this.labelTime.Text = "Time";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.labelDate.Location = new System.Drawing.Point(685, 555);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(34, 13);
            this.labelDate.TabIndex = 89;
            this.labelDate.Text = "Date";
            // 
            // siButton5
            // 
            this.siButton5.BackColor = System.Drawing.Color.Peru;
            this.siButton5.BackgroundColor = System.Drawing.Color.Peru;
            this.siButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siButton5.BorderRadius = 0;
            this.siButton5.BorderSize = 0;
            this.siButton5.FlatAppearance.BorderSize = 0;
            this.siButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.siButton5.ForeColor = System.Drawing.Color.White;
            this.siButton5.Location = new System.Drawing.Point(322, 101);
            this.siButton5.Name = "siButton5";
            this.siButton5.Size = new System.Drawing.Size(79, 23);
            this.siButton5.TabIndex = 59;
            this.siButton5.Text = "RECORDS";
            this.siButton5.TextColor = System.Drawing.Color.White;
            this.siButton5.UseVisualStyleBackColor = false;
            this.siButton5.Click += new System.EventHandler(this.siButton5_Click);
            // 
            // siButton1
            // 
            this.siButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.siButton1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.siButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siButton1.BorderRadius = 0;
            this.siButton1.BorderSize = 0;
            this.siButton1.FlatAppearance.BorderSize = 0;
            this.siButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siButton1.ForeColor = System.Drawing.Color.White;
            this.siButton1.Location = new System.Drawing.Point(53, 101);
            this.siButton1.Name = "siButton1";
            this.siButton1.Size = new System.Drawing.Size(92, 23);
            this.siButton1.TabIndex = 56;
            this.siButton1.Text = "CALCULATE";
            this.siButton1.TextColor = System.Drawing.Color.White;
            this.siButton1.UseVisualStyleBackColor = false;
            this.siButton1.Click += new System.EventHandler(this.siButton1_Click);
            // 
            // siButton3
            // 
            this.siButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.siButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.siButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siButton3.BorderRadius = 0;
            this.siButton3.BorderSize = 0;
            this.siButton3.FlatAppearance.BorderSize = 0;
            this.siButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siButton3.ForeColor = System.Drawing.Color.White;
            this.siButton3.Location = new System.Drawing.Point(241, 101);
            this.siButton3.Name = "siButton3";
            this.siButton3.Size = new System.Drawing.Size(65, 23);
            this.siButton3.TabIndex = 51;
            this.siButton3.Text = "CLEAR";
            this.siButton3.TextColor = System.Drawing.Color.White;
            this.siButton3.UseVisualStyleBackColor = false;
            this.siButton3.Click += new System.EventHandler(this.siButton3_Click);
            // 
            // siButton4
            // 
            this.siButton4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.siButton4.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.siButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siButton4.BorderRadius = 0;
            this.siButton4.BorderSize = 0;
            this.siButton4.FlatAppearance.BorderSize = 0;
            this.siButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siButton4.ForeColor = System.Drawing.Color.White;
            this.siButton4.Location = new System.Drawing.Point(160, 101);
            this.siButton4.Name = "siButton4";
            this.siButton4.Size = new System.Drawing.Size(65, 23);
            this.siButton4.TabIndex = 50;
            this.siButton4.Text = "PAY";
            this.siButton4.TextColor = System.Drawing.Color.White;
            this.siButton4.UseVisualStyleBackColor = false;
            this.siButton4.Click += new System.EventHandler(this.siButton4_Click);
            // 
            // siButton2
            // 
            this.siButton2.BackColor = System.Drawing.Color.DarkRed;
            this.siButton2.BackgroundColor = System.Drawing.Color.DarkRed;
            this.siButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siButton2.BorderRadius = 0;
            this.siButton2.BorderSize = 0;
            this.siButton2.FlatAppearance.BorderSize = 0;
            this.siButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.siButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siButton2.ForeColor = System.Drawing.Color.White;
            this.siButton2.Location = new System.Drawing.Point(719, 513);
            this.siButton2.Name = "siButton2";
            this.siButton2.Size = new System.Drawing.Size(65, 23);
            this.siButton2.TabIndex = 57;
            this.siButton2.Text = "EXIT";
            this.siButton2.TextColor = System.Drawing.Color.White;
            this.siButton2.UseVisualStyleBackColor = false;
            this.siButton2.Click += new System.EventHandler(this.siButton2_Click);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Car_Rent_New.Properties.Resources.tourfinal4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(796, 603);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.siButton2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxDriver);
            this.Controls.Add(this.comboBoxVehicleType);
            this.Controls.Add(this.txtDriverID);
            this.Controls.Add(this.txtRentID);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.TextBox txtDriverID;
        private System.Windows.Forms.TextBox txtTotalDays;
        private System.Windows.Forms.TextBox txtTotalCharge;
        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private SIButton siButton3;
        private SIButton siButton4;
        private System.Windows.Forms.CheckBox checkBoxDriver;
        private System.Windows.Forms.Label label8;
        private SIButton siButton1;
        private SIButton siButton2;
        private SIButton siButton5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
    }
}