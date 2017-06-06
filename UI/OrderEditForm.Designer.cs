namespace FComManager
{
    partial class OrderEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOrderConfirm = new MetroFramework.Controls.MetroButton();
            this.gridProductGridView = new MetroFramework.Controls.MetroGrid();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txtOrderAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtOrderMob = new MetroFramework.Controls.MetroTextBox();
            this.txtOrderUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnOrderEditDelete = new MetroFramework.Controls.MetroButton();
            this.lblOrderDeliveryStatus = new MetroFramework.Controls.MetroLabel();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderConfirm
            // 
            this.btnOrderConfirm.Location = new System.Drawing.Point(766, 344);
            this.btnOrderConfirm.Name = "btnOrderConfirm";
            this.btnOrderConfirm.Size = new System.Drawing.Size(82, 23);
            this.btnOrderConfirm.TabIndex = 67;
            this.btnOrderConfirm.Text = "Save Change";
            this.btnOrderConfirm.UseSelectable = true;
            this.btnOrderConfirm.Click += new System.EventHandler(this.btnOrderConfirm_Click);
            // 
            // gridProductGridView
            // 
            this.gridProductGridView.AllowUserToAddRows = false;
            this.gridProductGridView.AllowUserToDeleteRows = false;
            this.gridProductGridView.AllowUserToResizeRows = false;
            this.gridProductGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProductGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProductGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.gridProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._name,
            this._quantity,
            this._unitprice,
            this.Delete});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductGridView.DefaultCellStyle = dataGridViewCellStyle38;
            this.gridProductGridView.EnableHeadersVisualStyles = false;
            this.gridProductGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProductGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProductGridView.Location = new System.Drawing.Point(306, 119);
            this.gridProductGridView.Name = "gridProductGridView";
            this.gridProductGridView.ReadOnly = true;
            this.gridProductGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.gridProductGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductGridView.Size = new System.Drawing.Size(542, 120);
            this.gridProductGridView.TabIndex = 66;
            this.gridProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductGridView_CellContentClick);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(15, 235);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(59, 19);
            this.metroLabel18.TabIndex = 61;
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
            this.txtOrderAddress.Location = new System.Drawing.Point(106, 231);
            this.txtOrderAddress.MaxLength = 32767;
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.PasswordChar = '\0';
            this.txtOrderAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderAddress.SelectedText = "";
            this.txtOrderAddress.SelectionLength = 0;
            this.txtOrderAddress.SelectionStart = 0;
            this.txtOrderAddress.Size = new System.Drawing.Size(186, 23);
            this.txtOrderAddress.TabIndex = 60;
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
            this.txtOrderMob.Location = new System.Drawing.Point(106, 174);
            this.txtOrderMob.MaxLength = 32767;
            this.txtOrderMob.Name = "txtOrderMob";
            this.txtOrderMob.PasswordChar = '\0';
            this.txtOrderMob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderMob.SelectedText = "";
            this.txtOrderMob.SelectionLength = 0;
            this.txtOrderMob.SelectionStart = 0;
            this.txtOrderMob.Size = new System.Drawing.Size(186, 23);
            this.txtOrderMob.TabIndex = 59;
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
            this.txtOrderUsername.Location = new System.Drawing.Point(106, 119);
            this.txtOrderUsername.MaxLength = 32767;
            this.txtOrderUsername.Name = "txtOrderUsername";
            this.txtOrderUsername.PasswordChar = '\0';
            this.txtOrderUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderUsername.SelectedText = "";
            this.txtOrderUsername.SelectionLength = 0;
            this.txtOrderUsername.SelectionStart = 0;
            this.txtOrderUsername.Size = new System.Drawing.Size(186, 23);
            this.txtOrderUsername.TabIndex = 58;
            this.txtOrderUsername.UseSelectable = true;
            this.txtOrderUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(15, 178);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(78, 19);
            this.metroLabel20.TabIndex = 56;
            this.metroLabel20.Text = "Mobile No.:";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(15, 119);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(71, 19);
            this.metroLabel21.TabIndex = 55;
            this.metroLabel21.Text = "Username:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 348);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 68;
            this.metroLabel1.Text = "Status:";
            // 
            // btnOrderEditDelete
            // 
            this.btnOrderEditDelete.Location = new System.Drawing.Point(685, 344);
            this.btnOrderEditDelete.Name = "btnOrderEditDelete";
            this.btnOrderEditDelete.Size = new System.Drawing.Size(75, 23);
            this.btnOrderEditDelete.TabIndex = 69;
            this.btnOrderEditDelete.Text = "Delete";
            this.btnOrderEditDelete.UseSelectable = true;
            this.btnOrderEditDelete.Click += new System.EventHandler(this.btnOrderEditDelete_Click);
            // 
            // lblOrderDeliveryStatus
            // 
            this.lblOrderDeliveryStatus.AutoSize = true;
            this.lblOrderDeliveryStatus.Location = new System.Drawing.Point(106, 348);
            this.lblOrderDeliveryStatus.Name = "lblOrderDeliveryStatus";
            this.lblOrderDeliveryStatus.Size = new System.Drawing.Size(23, 19);
            this.lblOrderDeliveryStatus.TabIndex = 70;
            this.lblOrderDeliveryStatus.Text = "lbl";
            // 
            // _id
            // 
            this._id.HeaderText = "ProductID";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            // 
            // _name
            // 
            this._name.HeaderText = "Product Name";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            // 
            // _quantity
            // 
            this._quantity.HeaderText = "Quantity";
            this._quantity.Name = "_quantity";
            this._quantity.ReadOnly = true;
            // 
            // _unitprice
            // 
            this._unitprice.HeaderText = "UnitPrice";
            this._unitprice.Name = "_unitprice";
            this._unitprice.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FComManager.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 79);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOrderDeliveryStatus);
            this.Controls.Add(this.btnOrderEditDelete);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnOrderConfirm);
            this.Controls.Add(this.gridProductGridView);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.txtOrderAddress);
            this.Controls.Add(this.txtOrderMob);
            this.Controls.Add(this.txtOrderUsername);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "OrderEditForm";
            this.Text = "OrderEditForm";
            this.Load += new System.EventHandler(this.OrderEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnOrderConfirm;
        private MetroFramework.Controls.MetroGrid gridProductGridView;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox txtOrderAddress;
        private MetroFramework.Controls.MetroTextBox txtOrderMob;
        private MetroFramework.Controls.MetroTextBox txtOrderUsername;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnOrderEditDelete;
        private MetroFramework.Controls.MetroLabel lblOrderDeliveryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _unitprice;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}