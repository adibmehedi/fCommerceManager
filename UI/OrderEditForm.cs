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
    public partial class OrderEditForm : MetroFramework.Forms.MetroForm
    {
        InventoryClass invnobj = new InventoryClass();
        OrderClass ordrobj = new OrderClass();
        int orderID;
        int oGroupID;
        int isDelivered=0;
        string username = null;
        string phone = null;
        string address = null;
        string productId = null;
        string productName = null;
        int unit = 0;
        double sellingPrice;
        int orderCatagoryID;
        Form HomeForm;
        DataSet ds;
        DataTable dt;


        public OrderEditForm(string id,Form form)
        {
            InitializeComponent();
            orderID = Convert.ToInt32(id);
            HomeForm = form;
            InitializingForm();
        }

        private void OrderEditForm_Load(object sender, EventArgs e)
        {
           
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            HomeForm.Visible = true;
        }

        private void gridProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==4)
            {
                 // MessageBox.Show(gridProductGridView.);
                // Convert the row index stored in the CommandArgument
                // property to an Integer.
                //int index = Convert.ToInt32(e.CommandArgument);

                // Get the last name of the selected author from the appropriate
                // cell in the GridView control.
                //GridViewRow selectedRow = CustomersGridView.Rows[index];
            }
        }

        public void InitializingForm() {
            //GET ALL VALUES regarding odrer
            DataSet ds = ordrobj.getOrderDetails(orderID);
            DataTable dt= ds.Tables[0];
            //fillup the txt box
            txtOrderUsername.Text = dt.Rows[0][5].ToString();
            txtOrderAddress.Text = dt.Rows[0][5].ToString();
            txtOrderMob.Text = dt.Rows[0][4].ToString();
            isDelivered=Convert.ToInt32(dt.Rows[0][3].ToString());
            oGroupID = Convert.ToInt32(dt.Rows[0][1].ToString());
            if (isDelivered == 1)
            {
                lblOrderDeliveryStatus.Text = "Delivered";
                btnOrderEditDelete.Visible = false;
            }
            else {
                lblOrderDeliveryStatus.Text = "Not Delivered";
            }
            //get ALL values with oGroup

            InitializeGridView();
            InitializingCombo();
          
        }

        public void InitializingCombo()
        {
           /* DataSet ds = invnobj.AllItem();
            DataTable dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                ComboboxItem combobj = new ComboboxItem();
                combobj.Value = item[0].ToString();
                combobj.Text = item[1].ToString();
                //Adding Items in Combobox
                comboOrderProduct.Items.Add(combobj);
             //   comboOrderProduct.SelectedIndex = comboOrderProduct.Items.IndexOf("New");
            } */
        }

       
 
        public void InitializeGridView() {
             ds = ordrobj.getOrderGroupDetails(oGroupID);
             dt = ds.Tables[0];


            foreach (DataRow item in dt.Rows)
            {
                int n = gridProductGridView.Rows.Add();

                int pID = Convert.ToInt32(item[1].ToString());
                gridProductGridView.Rows[n].Cells[0].Value = item[1].ToString();
                gridProductGridView.Rows[n].Cells[1].Value = ordrobj.getProductName(pID);
                gridProductGridView.Rows[n].Cells[2].Value = item[2].ToString();
                gridProductGridView.Rows[n].Cells[3].Value = item[3].ToString();
                //  gridOrderGridView.Rows[n].Cells[5].Value = item[4].ToString();

            }
        }

        private void comboOrderProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            /*
            productId = ((ComboboxItem)comboOrderProduct.SelectedItem).Value.ToString();
            productName = ((ComboboxItem)comboOrderProduct.SelectedItem).Text.ToString();
            unit = Convert.ToInt32(txtOrderQuantity.Text.ToString());
            sellingPrice = invnobj.getProductSellingPrice(productId);
            //MessageBox.Show("" + sellingPrice);

            if (productId != null && unit != null)
            {
                //NEED TO CHECK DI if item available
                dt.Rows.Add(Convert.ToInt32(productId), productName, unit, sellingPrice);
            }

            UpdateOrderProductGrid(); */
        }

        public void UpdateOrderProductGrid()
        {
          /*  gridProductGridView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = gridProductGridView.Rows.Add();

                gridProductGridView.Rows[n].Cells[0].Value = item[0].ToString();
                gridProductGridView.Rows[n].Cells[1].Value = item[1].ToString();
                gridProductGridView.Rows[n].Cells[2].Value = item[2].ToString();
                gridProductGridView.Rows[n].Cells[3].Value = item[3].ToString();

            } */
        }

        private void btnOrderEditDelete_Click(object sender, EventArgs e)
        {
            //get orderID from form
            if (ordrobj.deleteFromOrder(orderID)) {
                MessageBox.Show("Deleted");
                this.Visible = false;
                HomeForm.Visible = true;
            }

        }

        private void btnOrderConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved Change");
            this.Visible = false;
            HomeForm.Visible = true;
        }
    }
}
