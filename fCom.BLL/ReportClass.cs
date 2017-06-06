using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FComManager
{
    public class ReportClass
    {
        DatabaseClass db = new DatabaseClass();
  
        public DataSet getOrderReport(string fromDate, string toDate) {
            return db.getOrderBetweenTime(fromDate, toDate);  
        }

        public double getBasePriceByOrderGroup(int oGroupID) {
            return db.getBasePriceByOrderGroup(oGroupID);
        }



    }
}
