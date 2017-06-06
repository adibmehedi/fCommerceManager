﻿namespace FComManager
{
    partial class InventoryEditForm
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
            this.btnInventoryDelete = new MetroFramework.Controls.MetroButton();
            this.txtInventorySellingPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnInventorySave = new MetroFramework.Controls.MetroButton();
            this.ComboInventoryCatagory = new MetroFramework.Controls.MetroComboBox();
            this.txtInventoryQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtInventoryName = new MetroFramework.Controls.MetroTextBox();
            this.txtIInventoryPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.Location = new System.Drawing.Point(264, 342);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.Size = new System.Drawing.Size(75, 23);
            this.btnInventoryDelete.TabIndex = 82;
            this.btnInventoryDelete.Text = "Delete";
            this.btnInventoryDelete.UseSelectable = true;
            this.btnInventoryDelete.Click += new System.EventHandler(this.btnInventoryDelete_Click_1);
            // 
            // txtInventorySellingPrice
            // 
            // 
            // 
            // 
            this.txtInventorySellingPrice.CustomButton.Image = null;
            this.txtInventorySellingPrice.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtInventorySellingPrice.CustomButton.Name = "";
            this.txtInventorySellingPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventorySellingPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventorySellingPrice.CustomButton.TabIndex = 1;
            this.txtInventorySellingPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventorySellingPrice.CustomButton.UseSelectable = true;
            this.txtInventorySellingPrice.CustomButton.Visible = false;
            this.txtInventorySellingPrice.Lines = new string[0];
            this.txtInventorySellingPrice.Location = new System.Drawing.Point(264, 205);
            this.txtInventorySellingPrice.MaxLength = 32767;
            this.txtInventorySellingPrice.Name = "txtInventorySellingPrice";
            this.txtInventorySellingPrice.PasswordChar = '\0';
            this.txtInventorySellingPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventorySellingPrice.SelectedText = "";
            this.txtInventorySellingPrice.SelectionLength = 0;
            this.txtInventorySellingPrice.SelectionStart = 0;
            this.txtInventorySellingPrice.Size = new System.Drawing.Size(186, 23);
            this.txtInventorySellingPrice.TabIndex = 81;
            this.txtInventorySellingPrice.UseSelectable = true;
            this.txtInventorySellingPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventorySellingPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(127, 210);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 80;
            this.metroLabel1.Text = "Selling Price:";
            // 
            // btnInventorySave
            // 
            this.btnInventorySave.Location = new System.Drawing.Point(375, 342);
            this.btnInventorySave.Name = "btnInventorySave";
            this.btnInventorySave.Size = new System.Drawing.Size(75, 23);
            this.btnInventorySave.TabIndex = 79;
            this.btnInventorySave.Text = "Save Change";
            this.btnInventorySave.UseSelectable = true;
            this.btnInventorySave.Click += new System.EventHandler(this.btnInventorySave_Click_1);
            // 
            // ComboInventoryCatagory
            // 
            this.ComboInventoryCatagory.FormattingEnabled = true;
            this.ComboInventoryCatagory.ItemHeight = 23;
            this.ComboInventoryCatagory.Location = new System.Drawing.Point(264, 294);
            this.ComboInventoryCatagory.Name = "ComboInventoryCatagory";
            this.ComboInventoryCatagory.Size = new System.Drawing.Size(186, 29);
            this.ComboInventoryCatagory.TabIndex = 78;
            this.ComboInventoryCatagory.UseSelectable = true;
            // 
            // txtInventoryQuantity
            // 
            // 
            // 
            // 
            this.txtInventoryQuantity.CustomButton.Image = null;
            this.txtInventoryQuantity.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtInventoryQuantity.CustomButton.Name = "";
            this.txtInventoryQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryQuantity.CustomButton.TabIndex = 1;
            this.txtInventoryQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryQuantity.CustomButton.UseSelectable = true;
            this.txtInventoryQuantity.CustomButton.Visible = false;
            this.txtInventoryQuantity.Lines = new string[0];
            this.txtInventoryQuantity.Location = new System.Drawing.Point(264, 249);
            this.txtInventoryQuantity.MaxLength = 32767;
            this.txtInventoryQuantity.Name = "txtInventoryQuantity";
            this.txtInventoryQuantity.PasswordChar = '\0';
            this.txtInventoryQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryQuantity.SelectedText = "";
            this.txtInventoryQuantity.SelectionLength = 0;
            this.txtInventoryQuantity.SelectionStart = 0;
            this.txtInventoryQuantity.Size = new System.Drawing.Size(186, 23);
            this.txtInventoryQuantity.TabIndex = 77;
            this.txtInventoryQuantity.UseSelectable = true;
            this.txtInventoryQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInventoryName
            // 
            // 
            // 
            // 
            this.txtInventoryName.CustomButton.Image = null;
            this.txtInventoryName.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtInventoryName.CustomButton.Name = "";
            this.txtInventoryName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryName.CustomButton.TabIndex = 1;
            this.txtInventoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryName.CustomButton.UseSelectable = true;
            this.txtInventoryName.CustomButton.Visible = false;
            this.txtInventoryName.Lines = new string[0];
            this.txtInventoryName.Location = new System.Drawing.Point(264, 112);
            this.txtInventoryName.MaxLength = 32767;
            this.txtInventoryName.Name = "txtInventoryName";
            this.txtInventoryName.PasswordChar = '\0';
            this.txtInventoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryName.SelectedText = "";
            this.txtInventoryName.SelectionLength = 0;
            this.txtInventoryName.SelectionStart = 0;
            this.txtInventoryName.Size = new System.Drawing.Size(186, 23);
            this.txtInventoryName.TabIndex = 76;
            this.txtInventoryName.UseSelectable = true;
            this.txtInventoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIInventoryPrice
            // 
            // 
            // 
            // 
            this.txtIInventoryPrice.CustomButton.Image = null;
            this.txtIInventoryPrice.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtIInventoryPrice.CustomButton.Name = "";
            this.txtIInventoryPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIInventoryPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIInventoryPrice.CustomButton.TabIndex = 1;
            this.txtIInventoryPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIInventoryPrice.CustomButton.UseSelectable = true;
            this.txtIInventoryPrice.CustomButton.Visible = false;
            this.txtIInventoryPrice.Lines = new string[0];
            this.txtIInventoryPrice.Location = new System.Drawing.Point(264, 166);
            this.txtIInventoryPrice.MaxLength = 32767;
            this.txtIInventoryPrice.Name = "txtIInventoryPrice";
            this.txtIInventoryPrice.PasswordChar = '\0';
            this.txtIInventoryPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIInventoryPrice.SelectedText = "";
            this.txtIInventoryPrice.SelectionLength = 0;
            this.txtIInventoryPrice.SelectionStart = 0;
            this.txtIInventoryPrice.Size = new System.Drawing.Size(186, 23);
            this.txtIInventoryPrice.TabIndex = 75;
            this.txtIInventoryPrice.UseSelectable = true;
            this.txtIInventoryPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIInventoryPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(127, 294);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 19);
            this.metroLabel11.TabIndex = 74;
            this.metroLabel11.Text = "Catagory:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(127, 249);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(61, 19);
            this.metroLabel10.TabIndex = 73;
            this.metroLabel10.Text = "Quantity:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(127, 166);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(72, 19);
            this.metroLabel9.TabIndex = 72;
            this.metroLabel9.Text = "Base Price:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(127, 116);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(78, 19);
            this.metroLabel8.TabIndex = 71;
            this.metroLabel8.Text = "Item Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FComManager.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 79);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // InventoryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInventoryDelete);
            this.Controls.Add(this.txtInventorySellingPrice);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnInventorySave);
            this.Controls.Add(this.ComboInventoryCatagory);
            this.Controls.Add(this.txtInventoryQuantity);
            this.Controls.Add(this.txtInventoryName);
            this.Controls.Add(this.txtIInventoryPrice);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.MaximizeBox = false;
            this.Name = "InventoryEditForm";
            this.Text = "InventoryEditForm";
            this.Load += new System.EventHandler(this.InventoryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnInventoryDelete;
        private MetroFramework.Controls.MetroTextBox txtInventorySellingPrice;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnInventorySave;
        private MetroFramework.Controls.MetroComboBox ComboInventoryCatagory;
        private MetroFramework.Controls.MetroTextBox txtInventoryQuantity;
        private MetroFramework.Controls.MetroTextBox txtInventoryName;
        private MetroFramework.Controls.MetroTextBox txtIInventoryPrice;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}