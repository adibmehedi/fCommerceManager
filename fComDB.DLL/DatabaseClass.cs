using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FComManager
{
    public class DatabaseClass
    {
        string connectionstring = @"Data Source=DESKTOP-IGUUUFF; Database =fCom_db; trusted_connection=true";
        SqlConnection cnn;
        SqlCommand cmd;
        string sql = null;
        DataSet ds=null;
        SqlDataReader reader;

        public Boolean isUserValid(string username, string password)
        {
            sql = "SELECT * FROM tbl_user WHERE username='"+username+"' AND password = '"+password+"';";
            cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public DataSet getAllProduct()
        {
            string frstSql = "SELECT pId,pName,tbl_catagory.cName,pBasePrice,pSellingPrice,punit FROM tbl_product, tbl_catagory WHERE tbl_product.pCatagoryID=tbl_catagory.cId";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getProductDEtails(int productId)
        {

            String connectionString = @"Data Source=DESKTOP-IGUUUFF; Database =fCom_db; trusted_connection=true";
            string frstSql = "SELECT pId,pName,tbl_catagory.cName,pBasePrice,pSellingPrice,punit,cId FROM tbl_product, tbl_catagory WHERE tbl_product.pCatagoryID=tbl_catagory.cId AND pID="+productId+"";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet getAllCatagory() {

            string frstSql = "SELECT cID, cName FROM tbl_catagory";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;

        }

        public Boolean updateProductDetails(int pID,string pName, int cId, double pBasePrice,double pSellingPrice,int pUnit) {
            sql = "UPDATE tbl_product SET pName='" + pName + "',pCatagoryID=" + cId + ",pBasePrice="+pBasePrice+",pSellingPrice="+pSellingPrice+",pUnit="+pUnit+" WHERE pId="+pID+"";
            cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                int status = cmd.ExecuteNonQuery();
                if (status!=0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public Boolean deleteProduct(int pId) {
            //DELETE FROM tbl_product WHERE pid=2
            sql = "DELETE FROM tbl_product WHERE pid="+pId+"";
            cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                int status = cmd.ExecuteNonQuery();
                if (status != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public Boolean addNewProduct(string pName, int cId, double pBasePrice, double pSellingPrice, int pUnit) {
            // INSERT INTO tbl_product(pName, pCatagoryID, pBasePrice, pSellingPrice, pUnit) VALUES('Redmi', 4, 1200, 1500, 200);
            sql = "INSERT INTO tbl_product(pName, pCatagoryID, pBasePrice, pSellingPrice, pUnit) VALUES('"+pName+"',"+cId+","+pBasePrice+", "+pSellingPrice+", "+pUnit+");";
            cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                int status = cmd.ExecuteNonQuery();
                if (status != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public DataSet getOrderOverView() {
            string frstSql = "SELECT oID, oUsername, oGroupId, oDate, oIsDelivered, oAddress FROM tbl_order;";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public int getLaregentOrdergroupID() {
            //SELECT MAX(oGroupId) FROM tbl_oGroup
            int id = 0;
            string frstSql = "SELECT MAX(oGroupId) FROM tbl_oGroup";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
 
                id = Convert.ToInt32(item[0].ToString());
               
            }
            return id;
        }

        public Boolean addOrderGroupItem(int oGroupId, int productId, int unit, double sellingPrice)
        {
            //INSERT into tbl_oGroup(oGroupId,productId,unit,sellingPrice) VALUES (2,3,2,1600);
            sql = "INSERT into tbl_oGroup(oGroupId,productId,unit,sellingPrice) VALUES ("+oGroupId+","+productId+","+unit+","+sellingPrice+");";
            cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                int status = cmd.ExecuteNonQuery();
                if (status != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public double getProductSellingPrice(string productID){
            //SELECT pSellingPrice FROM tbl_product WHERE pID=3
            double id = 0;
            string frstSql = "SELECT pSellingPrice FROM tbl_product WHERE pID="+productID+"";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                id = Convert.ToInt32(item[0].ToString());
            }
            return id;
        }

        public Boolean addNewOrder(int orGroupId, string oDate, int OIsDelivered,string oMob, string oAddress, string username)
        {
            //INSERT INTO tbl_order(oGroupId,oDate,oIsDelivered,oPhone,oAddress,oUsername)VALUES(2,'2016-05-07',0,'19216843130','Bonani,Dhaka','Mehedi');
            sql = "INSERT INTO tbl_order(oGroupId,oDate,oIsDelivered,oPhone,oAddress,oUsername)VALUES("+orGroupId+",'"+oDate+"',"+OIsDelivered+",'"+oMob+"','"+oAddress+"','"+username+"');";
            cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                int status = cmd.ExecuteNonQuery();
                if (status != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public DataSet getOrderDetails(int orderID) {
            //SELECT oId,oGroupId,oDate, oIsDelivered, oPhone, oAddress, oUsername FROM tbl_order WHERE oID =2
            string frstSql = "SELECT oId,oGroupId,oDate, oIsDelivered, oPhone, oAddress, oUsername FROM tbl_order WHERE oID ="+orderID+"";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getOrderGroupDetails(int oGroupId) {
            //SELECT oGroupID, productid,unit, sellingPrice FROM tbl_oGroup WHERE oGroupId=6
            string frstSql = "SELECT oGroupID, productid,unit, sellingPrice FROM tbl_oGroup WHERE oGroupId="+oGroupId+"";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public string getProductName(int productId) {
            string frstSql = "SELECT pName From tbl_product WHere pID="+productId+"";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dt=ds.Tables[0];
            string name=null;
            foreach (DataRow item in dt.Rows)
            {
                name= item[0].ToString();
            }
            return name;
        }

        public DataSet getNotDeliveredOrders() {
            //SELECT oid, oGroupId, oDate, oIsDelivered, oPhone, oAddress, oUsername FROM tbl_order WHERE oIsDelivered=0
            string frstSql = "SELECT oid, oGroupId, oDate, oIsDelivered, oPhone, oAddress, oUsername FROM tbl_order WHERE oIsDelivered=0";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public double totalCostofOGroup(int oGroupId) {
            //SELECT SUM(sellingPrice*unit) FROM tbl_oGroup WHERE oGroupId=2
            string frstSql = "SELECT SUM(sellingPrice*unit) FROM tbl_oGroup WHERE oGroupId=" + oGroupId+"";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dt = ds.Tables[0];
            string temp = null;
            foreach (DataRow item in dt.Rows)
            {
                temp = item[0].ToString();
            }

            int total = Convert.ToInt32(temp);
            return total;
        }

        public Boolean confirmDelivered(int orderId) {
            //UPDATE tbl_order SET oIsDelivered=1 WHERE oID=12
            sql = "UPDATE tbl_order SET oIsDelivered=1 WHERE oID="+orderId+"";
            cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                int status = cmd.ExecuteNonQuery();
                if (status != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public DataSet getOrderBetweenTime(string fromDate, string toDate) {
            //SELECT oid, oGroupId, oDate, oIsDelivered, oPhone, oAddress, oUsername FROM tbl_order WHERE oDate BETWEEN '2016-05-01' AND '2016-05-30'
            string frstSql = "SELECT oid, oGroupId, oDate, oIsDelivered, oPhone, oAddress, oUsername FROM tbl_order WHERE oDate BETWEEN '"+fromDate+"' AND '"+toDate+"'";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public double getBasePriceByOrderGroup(int oGroupID) {
            //SELECT SUM(pBasePrice) FROM tbl_product, tbl_oGroup WHERE tbl_product.pId=tbl_oGroup.productid AND oGroupID=4
            string frstSql = "SELECT SUM(pBasePrice*unit) FROM tbl_product, tbl_oGroup WHERE tbl_product.pId=tbl_oGroup.productid AND oGroupID="+ oGroupID + "";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(frstSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(frstSql, conn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dt = ds.Tables[0];
            string temp = null;
            foreach (DataRow item in dt.Rows)
            {
                temp = item[0].ToString();
            }

            int total = Convert.ToInt32(temp);
            return total;
        }

        public Boolean addNewCatagory(string catagoryName) {
            //INSERT INTO tbl_catagory(cName) VALUES ('Housing'); 
            sql = "INSERT INTO tbl_catagory(cName) VALUES ('"+catagoryName+"');";
            cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                int status = cmd.ExecuteNonQuery();
                if (status != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public Boolean deleteFromOrder(int orderID) {
            //DELETE FROM tbl_order WHERE oId=12
            sql = "DELETE FROM tbl_order WHERE oId="+orderID+"";
            cnn = new SqlConnection(connectionstring);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                int status = cmd.ExecuteNonQuery();
                if (status != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

    }
}
