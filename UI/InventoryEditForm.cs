using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FComManager
{
    public partial class InventoryEditForm : MetroFramework.Forms.MetroForm 
    {
        int productId;
        int catagoryID;
        Form previousHomeForm;
        InventoryClass invnobj = new InventoryClass();

        public InventoryEditForm(string id, Form previousForm)
        { 
            InitializeComponent();
            productId = Convert.ToInt32(id);
            previousHomeForm = previousForm;
            initializingForm();
            initializingCatagoryComboBox();
        }

        private void InventoryEditForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            previousHomeForm.Visible = true;
        }

        public void initializingForm() {
            //Fillup up theform with database value.
            DataSet ds=invnobj.showDetails(productId);
            txtInventoryName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtIInventoryPrice.Text= ds.Tables[0].Rows[0][3].ToString();
            txtInventorySellingPrice.Text= ds.Tables[0].Rows[0][4].ToString();
            txtInventoryQuantity.Text= ds.Tables[0].Rows[0][5].ToString();
            catagoryID = Convert.ToInt32(ds.Tables[0].Rows[0][6].ToString());
        }
        public void initializingCatagoryComboBox() {
            DataSet ds = invnobj.getAllCatagory();
            DataTable dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows) {
                ComboboxItem combobj = new ComboboxItem();
                combobj.Value = item[0].ToString();
                combobj.Text = item[1].ToString();
                //Adding Items in Combobox
                ComboInventoryCatagory.Items.Add(combobj);
            }
            //Default value selecting for comboboX;
            ComboInventoryCatagory.SelectedIndex = catagoryID-1;
        }

        public void loadHomeForm() {
            this.Visible = false;
            //HomeForm obj = (HomeForm)Application.OpenForms["HomeFor
            previousHomeForm.Visible = true;
        }

        private void btnInventorySave_Click(object sender, EventArgs e)
        {
            int pID = productId;
            string pName = txtInventoryName.Text.ToString();
            int cId = ComboInventoryCatagory.SelectedIndex + 1;
            double pBasePrice = Convert.ToDouble(txtIInventoryPrice.Text.ToString());
            double pSellingPrice = Convert.ToInt32(txtInventorySellingPrice.Text.ToString());
            int pUnit = Convert.ToInt32(txtInventoryQuantity.Text.ToString());

            Boolean result=invnobj.updateProductDetails(pID, pName, cId, pBasePrice, pSellingPrice, pUnit);
            if (result) {
                MessageBox.Show("Changed");
                loadHomeForm();
            }
        }

        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            Boolean result = invnobj.deleteProduct(productId);
            if (result) {
                MessageBox.Show("Deleted");
                loadHomeForm();
            }
        }

        private void btnInventoryDelete_Click_1(object sender, EventArgs e)
        {
            Boolean result = invnobj.deleteProduct(productId);
            if (result)
            {
                MessageBox.Show("Deleted");
                loadHomeForm();
            }
        }

        private void btnInventorySave_Click_1(object sender, EventArgs e)
        {
            int pID = productId;
            string pName = txtInventoryName.Text.ToString();
            int cId = ComboInventoryCatagory.SelectedIndex + 1;
            double pBasePrice = Convert.ToDouble(txtIInventoryPrice.Text.ToString());
            double pSellingPrice = Convert.ToInt32(txtInventorySellingPrice.Text.ToString());
            int pUnit = Convert.ToInt32(txtInventoryQuantity.Text.ToString());

            Boolean result = invnobj.updateProductDetails(pID, pName, cId, pBasePrice, pSellingPrice, pUnit);
            if (result)
            {
                MessageBox.Show("Changed");
                loadHomeForm();
            }
        }
    }
}
