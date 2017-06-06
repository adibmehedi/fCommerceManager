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
    public partial class CatagoryForm : MetroFramework.Forms.MetroForm
    {
        InventoryClass ivnobj = new InventoryClass();
        Form HomeForm;

        public CatagoryForm(Form form)
        {
            InitializeComponent();
            HomeForm = form;
            InitializeGridView();
        }

        private void CatagoryForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            HomeForm.Visible = true;
        }

        public void InitializeGridView()
        {
            DataSet ds = ivnobj.getAllCatagory();
            DataTable dt = ds.Tables[0];


            foreach (DataRow item in dt.Rows)
            {
                int n = gridCatagoryGridView.Rows.Add();
                gridCatagoryGridView.Rows[n].Cells[0].Value = item[1].ToString();

            }
        }

        private void btnAddNewCatagory_Click(object sender, EventArgs e)
        {
            string catagoryName = txtCatagoryName.Text.ToString();
            if (ivnobj.addNewCatagory(catagoryName)) {
                MessageBox.Show("Catagory Added");
            }

            gridCatagoryGridView.Rows.Clear();
            InitializeGridView();
        }
    }
}
