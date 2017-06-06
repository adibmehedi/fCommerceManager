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
    
    public partial class HomeForm : MetroFramework.Forms.MetroForm
    {
        InventoryClass invnobj = new InventoryClass();
        OrderClass ordrobj = new OrderClass();
        DeliveryClass delobj = new DeliveryClass();
        ReportClass repobj = new ReportClass();
        Form LoginForm;

        int oGroupId;

        public HomeForm(Form previousLoginForm)
        {
            InitializeComponent();
            InitializingForm();
            LoginForm = previousLoginForm;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            LoginForm.Visible = true;
        }


        private void gridInventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //essageBox.Show("Clicked" + gridInventoryGridView.SelectedRows[0].Cells[0].ToString());
            InventoryEditForm ivf = new InventoryEditForm(gridInventoryGridView.SelectedRows[0].Cells[0].Value.ToString(),this);
            ivf.Visible = true;
            this.Visible = false;
        }

       

        public void InitializingForm()
        {
            InitializingInventoryGrid();
            InitializingOrderGrid();
            InitializingDeliveryGridView();

        }

        public void InitializingInventoryGrid() {
            DataSet ds = invnobj.AllItem();
            DataTable dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                int n = gridInventoryGridView.Rows.Add();

                gridInventoryGridView.Rows[n].Cells[0].Value = item[0].ToString();
                gridInventoryGridView.Rows[n].Cells[1].Value = item[1].ToString();
                gridInventoryGridView.Rows[n].Cells[2].Value = item[2].ToString();
                gridInventoryGridView.Rows[n].Cells[3].Value = item[5].ToString();
                gridInventoryGridView.Rows[n].Cells[4].Value = item[3].ToString();
                gridInventoryGridView.Rows[n].Cells[5].Value = item[4].ToString();

            }
        }

        public void InitializingOrderGrid() {
            DataSet ds = ordrobj.getOrderOverView();
            DataTable dt = ds.Tables[0];
            string status;
            foreach (DataRow item in dt.Rows)
            {
                int n = gridOrderGridView.Rows.Add();

                gridOrderGridView.Rows[n].Cells[0].Value = item[0].ToString();
                gridOrderGridView.Rows[n].Cells[1].Value = item[1].ToString();
                gridOrderGridView.Rows[n].Cells[2].Value = item[5].ToString();
                gridOrderGridView.Rows[n].Cells[3].Value = item[3].ToString();
               // gridOrderGridView.Rows[n].Cells[4].Value = item[4].ToString();

                if (item[4].ToString() == "0") {
                    status = "Not Delivered";
                } else{
                    status = "Delivered";
                }
                gridOrderGridView.Rows[n].Cells[4].Value = status;
              //  gridOrderGridView.Rows[n].Cells[5].Value = item[4].ToString();



            }
        }


        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnInventoryAddNewForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form addform = new InventoryAddForm(this);
            addform.Visible = true;
        }

        private void btnInventoryReload_Click(object sender, EventArgs e)
        {
            gridInventoryGridView.Rows.Clear();
            InitializingInventoryGrid();
        }

        private void gridOrderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderIDString = gridOrderGridView.SelectedRows[0].Cells[0].Value.ToString();
            OrderEditForm ivf = new OrderEditForm(orderIDString, this);
            ivf.Visible = true;
            this.Visible = false;
        }

        private void btnOrderAddNewForm_Click(object sender, EventArgs e)
        {
            OrderAddForm oaf = new OrderAddForm(this);
            this.Visible = false;
            oaf.Visible = true;
            
        }

        private void btnOrderReload_Click(object sender, EventArgs e)
        {
            gridOrderGridView .Rows.Clear();
            InitializingOrderGrid();
        }

        public void InitializingDeliveryGridView()
        {
            DataSet ds = delobj.getNotDeliveredAll();
            DataTable dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                int n =gridDeliveryGridView.Rows.Add();

                gridDeliveryGridView.Rows[n].Cells[0].Value = item[0].ToString();
                gridDeliveryGridView.Rows[n].Cells[1].Value = item[6].ToString();
                gridDeliveryGridView.Rows[n].Cells[2].Value = item[4].ToString();
                gridDeliveryGridView.Rows[n].Cells[3].Value = item[5].ToString();
                gridDeliveryGridView.Rows[n].Cells[4].Value = item[2].ToString();

                oGroupId = Convert.ToInt32(item[1].ToString());
                gridDeliveryGridView.Rows[n].Cells[5].Value = ordrobj.totalCostofOGroup(oGroupId).ToString();

            }
        }

        private void gridDeliveryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int oId = Convert.ToInt32(gridDeliveryGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (delobj.confirmDelivered(oId)) {
                    MessageBox.Show("Delivery Confirmed");
                    gridDeliveryGridView.Rows.Clear();
                    InitializingDeliveryGridView();
                }
            }  
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void orderStatementBtn_Click(object sender, EventArgs e)
        {
            //GET date values from FROM
            string formDate=txtorderStatementDtFrom.Value.ToString("yyyy-MM-dd");
            string toDate= txtorderStatementDtTo.Value.ToString("yyyy-MM-dd");
            int orderGroupID;
            double basePrice;
            double sellingPrice;
            string date;
            double balance;
            double _totalBalance=0;
            double _totalSellingPrice = 0;
            double _totalBasePrice = 0;
            int n=0;
            DataSet ds = repobj.getOrderReport(formDate,toDate);

            DataTable dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                n = gridReportGridView.Rows.Add();

                orderGroupID = Convert.ToInt32(item[1].ToString());
                basePrice = repobj.getBasePriceByOrderGroup(orderGroupID);
                sellingPrice = Convert.ToDouble(ordrobj.totalCostofOGroup(orderGroupID).ToString());
                balance = sellingPrice - basePrice;

                _totalBalance += balance;
                _totalBasePrice += basePrice;
                _totalSellingPrice += sellingPrice;


                gridReportGridView.Rows[n].Cells[0].Value = item[2].ToString();
                gridReportGridView.Rows[n].Cells[1].Value = item[0].ToString();
                gridReportGridView.Rows[n].Cells[2].Value = basePrice;
                gridReportGridView.Rows[n].Cells[3].Value = sellingPrice;
                gridReportGridView.Rows[n].Cells[4].Value = balance;

            }
            this.gridReportGridView.Rows.Add("","","","",""); //extra space including
            this.gridReportGridView.Rows.Add("", "Total:",_totalBasePrice,_totalSellingPrice,_totalBalance); //total

        }

        private void btnCatagoryFormOpen_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form form = new CatagoryForm(this);
            form.Visible = true;
        }
    }
}
