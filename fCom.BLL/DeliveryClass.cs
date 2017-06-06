using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FComManager
{
    public class DeliveryClass
    {
        DatabaseClass db = new DatabaseClass();

        public DataSet getNotDeliveredAll() {
            return db.getNotDeliveredOrders();
        }

        public void getDeliveryDetails(int orderId) {
        }

        public Boolean confirmDelivered(int orderID) {
            return db.confirmDelivered(orderID);
        }
    
    }
}
