namespace FComManager
{
    partial class OrderAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtOrderQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.btnOrderAdd = new MetroFramework.Controls.MetroButton();
            this.comboOrderProduct = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txtOrderAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtOrderMob = new MetroFramework.Controls.MetroTextBox();
            this.txtOrderUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.gridProductGridView = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrderConfirm = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderQuantity
            // 
            // 
            // 
            // 
            this.txtOrderQuantity.CustomButton.Image = null;
            this.txtOrderQuantity.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtOrderQuantity.CustomButton.Name = "";
            this.txtOrderQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrderQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderQuantity.CustomButton.TabIndex = 1;
            this.txtOrderQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderQuantity.CustomButton.UseSelectable = true;
            this.txtOrderQuantity.CustomButton.Visible = false;
            this.txtOrderQuantity.Lines = new string[0];
            this.txtOrderQuantity.Location = new System.Drawing.Point(374, 309);
            this.txtOrderQuantity.MaxLength = 32767;
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.PasswordChar = '\0';
            this.txtOrderQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderQuantity.SelectedText = "";
            this.txtOrderQuantity.SelectionLength = 0;
            this.txtOrderQuantity.SelectionStart = 0;
            this.txtOrderQuantity.Size = new System.Drawing.Size(74, 23);
            this.txtOrderQuantity.TabIndex = 52;
            this.txtOrderQuantity.UseSelectable = true;
            this.txtOrderQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(307, 309);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(61, 19);
            this.metroLabel17.TabIndex = 51;
            this.metroLabel17.Text = "Quantity:";
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Location = new System.Drawing.Point(463, 309);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(75, 23);
            this.btnOrderAdd.TabIndex = 50;
            this.btnOrderAdd.Text = "Add";
            this.btnOrderAdd.UseSelectable = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // comboOrderProduct
            // 
            this.comboOrderProduct.FormattingEnabled = true;
            this.comboOrderProduct.ItemHeight = 23;
            this.comboOrderProduct.Location = new System.Drawing.Point(107, 309);
            this.comboOrderProduct.Name = "comboOrderProduct";
            this.comboOrderProduct.Size = new System.Drawing.Size(186, 29);
            this.comboOrderProduct.TabIndex = 49;
            this.comboOrderProduct.UseSelectable = true;
            this.comboOrderProduct.SelectedIndexChanged += new System.EventHandler(this.comboOrderProduct_SelectedIndexChanged);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(16, 252);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(59, 19);
            this.metroLabel18.TabIndex = 48;
            this.metroLabel18.Text = "Address:";
            // 
            // txtOrderAddress
            // 
            // 
            // 
            // 
            this.txtOrderAddress.CustomButton.Image = null;
            this.txtOrderAddress.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtOrderAddress.CustomButton.Name = "";
            this.txtOrderAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrderAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderAddress.CustomButton.TabIndex = 1;
            this.txtOrderAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderAddress.CustomButton.UseSelectable = true;
            this.txtOrderAddress.CustomButton.Visible = false;
            this.txtOrderAddress.Lines = new string[0];
            this.txtOrderAddress.Location = new System.Drawing.Point(107, 248);
            this.txtOrderAddress.MaxLength = 32767;
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.PasswordChar = '\0';
            this.txtOrderAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderAddress.SelectedText = "";
            this.txtOrderAddress.SelectionLength = 0;
            this.txtOrderAddress.SelectionStart = 0;
            this.txtOrderAddress.Size = new System.Drawing.Size(186, 23);
            this.txtOrderAddress.TabIndex = 47;
            this.txtOrderAddress.UseSelectable = true;
            this.txtOrderAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOrderMob
            // 
            // 
            // 
            // 
            this.txtOrderMob.CustomButton.Image = null;
            this.txtOrderMob.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtOrderMob.CustomButton.Name = "";
            this.txtOrderMob.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrderMob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderMob.CustomButton.TabIndex = 1;
            this.txtOrderMob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderMob.CustomButton.UseSelectable = true;
            this.txtOrderMob.CustomButton.Visible = false;
            this.txtOrderMob.Lines = new string[0];
            this.txtOrderMob.Location = new System.Drawing.Point(107, 191);
            this.txtOrderMob.MaxLength = 32767;
            this.txtOrderMob.Name = "txtOrderMob";
            this.txtOrderMob.PasswordChar = '\0';
            this.txtOrderMob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderMob.SelectedText = "";
            this.txtOrderMob.SelectionLength = 0;
            this.txtOrderMob.SelectionStart = 0;
            this.txtOrderMob.Size = new System.Drawing.Size(186, 23);
            this.txtOrderMob.TabIndex = 46;
            this.txtOrderMob.UseSelectable = true;
            this.txtOrderMob.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderMob.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOrderUsername
            // 
            // 
            // 
            // 
            this.txtOrderUsername.CustomButton.Image = null;
            this.txtOrderUsername.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtOrderUsername.CustomButton.Name = "";
            this.txtOrderUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrderUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderUsername.CustomButton.TabIndex = 1;
            this.txtOrderUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderUsername.CustomButton.UseSelectable = true;
            this.txtOrderUsername.CustomButton.Visible = false;
            this.txtOrderUsername.Lines = new string[0];
            this.txtOrderUsername.Location = new System.Drawing.Point(107, 136);
            this.txtOrderUsername.MaxLength = 32767;
            this.txtOrderUsername.Name = "txtOrderUsername";
            this.txtOrderUsername.PasswordChar = '\0';
            this.txtOrderUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderUsername.SelectedText = "";
            this.txtOrderUsername.SelectionLength = 0;
            this.txtOrderUsername.SelectionStart = 0;
            this.txtOrderUsername.Size = new System.Drawing.Size(186, 23);
            this.txtOrderUsername.TabIndex = 45;
            this.txtOrderUsername.UseSelectable = true;
            this.txtOrderUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(23, 313);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(74, 19);
            this.metroLabel19.TabIndex = 44;
            this.metroLabel19.Text = "Product ID:";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(16, 195);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(78, 19);
            this.metroLabel20.TabIndex = 43;
            this.metroLabel20.Text = "Mobile No.:";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(16, 136);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(71, 19);
            this.metroLabel21.TabIndex = 42;
            this.metroLabel21.Text = "Username:";
            // 
            // gridProductGridView
            // 
            this.gridProductGridView.AllowUserToResizeRows = false;
            this.gridProductGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProductGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProductGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.quantity,
            this.unitprice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridProductGridView.EnableHeadersVisualStyles = false;
            this.gridProductGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProductGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProductGridView.Location = new System.Drawing.Point(324, 136);
            this.gridProductGridView.Name = "gridProductGridView";
            this.gridProductGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridProductGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductGridView.Size = new System.Drawing.Size(443, 120);
            this.gridProductGridView.TabIndex = 53;
            // 
            // id
            // 
            this.id.HeaderText = "ProductID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Product Name";
            this.name.Name = "name";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // unitprice
            // 
            this.unitprice.HeaderText = "UnitPrice";
            this.unitprice.Name = "unitprice";
            // 
            // btnOrderConfirm
            // 
            this.btnOrderConfirm.Location = new System.Drawing.Point(685, 309);
            this.btnOrderConfirm.Name = "btnOrderConfirm";
            this.btnOrderConfirm.Size = new System.Drawing.Size(82, 23);
            this.btnOrderConfirm.TabIndex = 54;
            this.btnOrderConfirm.Text = "Confirm Order";
            this.btnOrderConfirm.UseSelectable = true;
            this.btnOrderConfirm.Click += new System.EventHandler(this.btnOrderConfirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FComManager.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 79);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // OrderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOrderConfirm);
            this.Controls.Add(this.gridProductGridView);
            this.Controls.Add(this.txtOrderQuantity);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.btnOrderAdd);
            this.Controls.Add(this.comboOrderProduct);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.txtOrderAddress);
            this.Controls.Add(this.txtOrderMob);
            this.Controls.Add(this.txtOrderUsername);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.metroLabel21);
            this.MaximizeBox = false;
            this.Name = "OrderAddForm";
            this.Text = "OrderAddForm";
            this.Load += new System.EventHandler(this.OrderAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtOrderQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroButton btnOrderAdd;
        private MetroFramework.Controls.MetroComboBox comboOrderProduct;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox txtOrderAddress;
        private MetroFramework.Controls.MetroTextBox txtOrderMob;
        private MetroFramework.Controls.MetroTextBox txtOrderUsername;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroGrid gridProductGridView;
        private MetroFramework.Controls.MetroButton btnOrderConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}