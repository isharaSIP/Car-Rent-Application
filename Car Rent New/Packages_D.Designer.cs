﻿namespace Car_Rent_New
{
    partial class Packages_D
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
            this.siButton7 = new Car_Rent_New.SIButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // siButton7
            // 
            this.siButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siButton7.BorderRadius = 0;
            this.siButton7.BorderSize = 0;
            this.siButton7.FlatAppearance.BorderSize = 0;
            this.siButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.siButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siButton7.ForeColor = System.Drawing.Color.White;
            this.siButton7.Location = new System.Drawing.Point(1060, 503);
            this.siButton7.Name = "siButton7";
            this.siButton7.Size = new System.Drawing.Size(74, 33);
            this.siButton7.TabIndex = 17;
            this.siButton7.Text = "EXIT";
            this.siButton7.TextColor = System.Drawing.Color.White;
            this.siButton7.UseVisualStyleBackColor = false;
            this.siButton7.Click += new System.EventHandler(this.siButton7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1028, 396);
            this.dataGridView1.TabIndex = 18;
            // 
            // Packages_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Rent_New.Properties.Resources.detail7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1146, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.siButton7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Packages_D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packages_D";
            this.Load += new System.EventHandler(this.Packages_D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SIButton siButton7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}