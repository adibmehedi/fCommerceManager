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
    public partial class InventoryAddForm : MetroFramework.Forms.MetroForm 
    {
        InventoryClass invnobj = new InventoryClass();
        Form HomeForm;
        public InventoryAddForm(Form form)
        {
            InitializeComponent();
            initializingCatagoryComboBox();
            HomeForm = form;
        }

        private void InventoryAddForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            HomeForm.Visible = true;
        }

        public void initializingCatagoryComboBox()
        {
            DataSet ds = invnobj.getAllCatagory();
            DataTable dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                ComboboxItem combobj = new ComboboxItem();
                combobj.Value = item[0].ToString();
                combobj.Text = item[1].ToString();
                //Adding Items in Combobox
                //combo.Items.Add(combobj);
                ComboInventoryCatagory.Items.Add(combobj);
            }

        }

        private void btnInventoryAdd_Click(object sender, EventArgs e)
        {
            string pName = txtInventoryName.Text.ToString();
            int cId = ComboInventoryCatagory.SelectedIndex + 1;
            double pBasePrice = Convert.ToDouble(txtIInventoryPrice.Text.ToString());
            double pSellingPrice = Convert.ToInt32(txtInventorySellingPrice.Text.ToString());
            int pUnit = Convert.ToInt32(txtInventoryQuantity.Text.ToString());
            Boolean result=invnobj.addNewProduct(pName, cId, pBasePrice, pSellingPrice, pUnit);
            if (result) {
                MessageBox.Show("Item Added");
                this.Visible = false;
                HomeForm.Visible = true;
            }
        }

        private void btnInventoryAdd_Click_1(object sender, EventArgs e)
        {
            string pName = txtInventoryName.Text.ToString();
            int cId = ComboInventoryCatagory.SelectedIndex + 1;
            double pBasePrice = Convert.ToDouble(txtIInventoryPrice.Text.ToString());
            double pSellingPrice = Convert.ToInt32(txtInventorySellingPrice.Text.ToString());
            int pUnit = Convert.ToInt32(txtInventoryQuantity.Text.ToString());
            Boolean result = invnobj.addNewProduct(pName, cId, pBasePrice, pSellingPrice, pUnit);
            if (result)
            {
                MessageBox.Show("Item Added");
                this.Visible = false;
                HomeForm.Visible = true;
            }
        }
    }
}
