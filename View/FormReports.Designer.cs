﻿namespace RMS.View
{
    partial class FormReports
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
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaleCat = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reports";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoRoundedCorners = true;
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnMenu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenu.CheckedState.Image = global::RMS.Properties.Resources.home_icon_silhouette;
            this.btnMenu.CustomizableEdges.BottomLeft = false;
            this.btnMenu.CustomizableEdges.BottomRight = false;
            this.btnMenu.CustomizableEdges.TopLeft = false;
            this.btnMenu.CustomizableEdges.TopRight = false;
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::RMS.Properties.Resources.receipt02;
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnMenu.Location = new System.Drawing.Point(68, 100);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(155, 111);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Menu List";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.TextOffset = new System.Drawing.Point(20, 0);
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.AutoRoundedCorners = true;
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnStaff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStaff.CheckedState.Image = global::RMS.Properties.Resources.home_icon_silhouette;
            this.btnStaff.CustomizableEdges.BottomLeft = false;
            this.btnStaff.CustomizableEdges.BottomRight = false;
            this.btnStaff.CustomizableEdges.TopLeft = false;
            this.btnStaff.CustomizableEdges.TopRight = false;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.Transparent;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::RMS.Properties.Resources.receipt02;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnStaff.Location = new System.Drawing.Point(260, 100);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(155, 111);
            this.btnStaff.TabIndex = 15;
            this.btnStaff.Text = "Staff List";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.TextOffset = new System.Drawing.Point(20, 0);
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnSaleCat
            // 
            this.btnSaleCat.AutoRoundedCorners = true;
            this.btnSaleCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnSaleCat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaleCat.CheckedState.Image = global::RMS.Properties.Resources.home_icon_silhouette;
            this.btnSaleCat.CustomizableEdges.BottomLeft = false;
            this.btnSaleCat.CustomizableEdges.BottomRight = false;
            this.btnSaleCat.CustomizableEdges.TopLeft = false;
            this.btnSaleCat.CustomizableEdges.TopRight = false;
            this.btnSaleCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaleCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaleCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaleCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaleCat.FillColor = System.Drawing.Color.Transparent;
            this.btnSaleCat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaleCat.ForeColor = System.Drawing.Color.White;
            this.btnSaleCat.Image = global::RMS.Properties.Resources.receipt02;
            this.btnSaleCat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaleCat.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSaleCat.Location = new System.Drawing.Point(446, 100);
            this.btnSaleCat.Name = "btnSaleCat";
            this.btnSaleCat.Size = new System.Drawing.Size(155, 111);
            this.btnSaleCat.TabIndex = 16;
            this.btnSaleCat.Text = "Sale by Category";
            this.btnSaleCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaleCat.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSaleCat.Click += new System.EventHandler(this.btnSaleCat_Click);
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.btnSaleCat);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReports";
            this.Text = "FormReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnSaleCat;
    }
}