using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FComManager
{
    public class OrderClass
    {
        DatabaseClass db = new DatabaseClass();

        public DataSet getOrderOverView() {
            return db.getOrderOverView();
        }

        public int getLaregestOrderGroupId()
        {
            return db.getLaregentOrdergroupID();
        }

        public Boolean addOrderGroupItem(int oGroupId, int productId, int unit, double sellingPrice)
        {
            return db.addOrderGroupItem(oGroupId, productId, unit, sellingPrice);
        }

        public Boolean addNewOrder(int orGroupId,string oMob, string oAddress, string username)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd"); //CurrentDate
            int oIsDelivered = 0;
            return db.addNewOrder(orGroupId, sqlFormattedDate, oIsDelivered,  oMob,oAddress, username);
        }

        public DataSet getOrderDetails(int orderId) {
            return db.getOrderDetails(orderId);
        }

        public DataSet getOrderGroupDetails(int orderGroupId) {
            return db.getOrderGroupDetails(orderGroupId);
        }

        public string getProductName(int productId) {
            return db.getProductName(productId);
        }

        public double totalCostofOGroup(int oGroupId) {
            return db.totalCostofOGroup(oGroupId);
        }

        public Boolean deleteFromOrder(int orderID) {
            return db.deleteFromOrder(orderID);
        }
    }
}
