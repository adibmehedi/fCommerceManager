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
    public partial class OrderAddForm : MetroFramework.Forms.MetroForm
    {
        InventoryClass invnobj = new InventoryClass();
        OrderClass ordrobj = new OrderClass();
        DataTable table=new DataTable();
        int orderID;
        int oGroupID;
        int isDelivered;
        string username=null;
        string phone=null;
        string address=null;
        string productId=null;
        string productName=null;
        int unit=0;
        double sellingPrice;
        Form HomeForm;

        public OrderAddForm(Form form)
        {
            InitializeComponent();
            InitializingCombo();
            initializingProdutGrid();
            HomeForm = form;
        }

        private void OrderAddForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            HomeForm.Visible = true;
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {

            productId = ((ComboboxItem)comboOrderProduct.SelectedItem).Value.ToString();
            productName= ((ComboboxItem)comboOrderProduct.SelectedItem).Text.ToString();
            unit = Convert.ToInt32(txtOrderQuantity.Text.ToString());
            sellingPrice = invnobj.getProductSellingPrice(productId);
            //MessageBox.Show("" + sellingPrice);
             
            if (productId != null && unit!=null)
            {
                //NEED TO CHECK DI if item available
                table.Rows.Add(productId, productName, unit, sellingPrice);
            }

            UpdateOrderProductGrid();
        }

        public void UpdateOrderProductGrid() {
            gridProductGridView.Rows.Clear();
            foreach (DataRow item in table.Rows)
            {
                int n = gridProductGridView.Rows.Add();

                gridProductGridView.Rows[n].Cells[0].Value = item[0].ToString();
                gridProductGridView.Rows[n].Cells[1].Value = item[1].ToString();
                gridProductGridView.Rows[n].Cells[2].Value = item[2].ToString();
                gridProductGridView.Rows[n].Cells[3].Value = item[3].ToString();

            }
        }

        public void InitializingCombo() {
            DataSet ds = invnobj.AllItem();
            DataTable dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                ComboboxItem combobj = new ComboboxItem();
                combobj.Value = item[0].ToString();
                combobj.Text = item[1].ToString();
                //Adding Items in Combobox
                comboOrderProduct.Items.Add(combobj);
            }
        }

        public void initializingProdutGrid() {
            table.Columns.Add("productId", typeof(string));
            table.Columns.Add("productName", typeof(string));
            table.Columns.Add("unit", typeof(int));
            table.Columns.Add("Price", typeof(double));
        }

        private void comboOrderProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrderConfirm_Click(object sender, EventArgs e)
        {
            //CRETING ORDERGROUP
            username = txtOrderUsername.Text.ToString();
            phone = txtOrderMob.Text.ToString();
            address = txtOrderAddress.Text.ToString();
            oGroupID = ordrobj.getLaregestOrderGroupId() + 1;

            //INSERTING into Database All product
            Boolean result=false;
            foreach (DataRow item in table.Rows)
            {
                //  MessageBox.Show(table.ToString());
                string temp = item[0].ToString();
                int _productID = Convert.ToInt32(""+temp);
                int _productUnit = Convert.ToInt32(item[2].ToString());
                double _sellingPrice =Convert.ToDouble(item[3].ToString());

                result = ordrobj.addOrderGroupItem(oGroupID, _productID, _productUnit, _sellingPrice);
            }
            if (result) {
                //ITEM ADDED TO OrderGROUp confirm 

                //INSERT into Database with oGroupID
                ordrobj.addNewOrder(oGroupID, phone, address, username);
               
            }

            this.Visible = false; //hiding current form
            HomeForm.Visible = true; //showing Home form

        }
    }
}
