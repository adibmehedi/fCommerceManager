using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FComManager
{
    public class InventoryClass
    {
        DatabaseClass db = new DatabaseClass();

        public DataSet showDetails(int productID) {
            return db.getProductDEtails(productID);
        }

        public DataSet AllItem() {
            return db.getAllProduct();
        }

        public DataSet getAllCatagory(){ 
            return db.getAllCatagory();
        }

        public Boolean updateProductDetails(int pID, string pName, int cId, double pBasePrice, double pSellingPrice, int pUnit) {
            return db.updateProductDetails(pID, pName, cId, pBasePrice, pSellingPrice, pUnit);
        }

        public Boolean deleteProduct(int pId) {
            return db.deleteProduct(pId);
        }

        public Boolean addNewProduct(string pName, int cId, double pBasePrice, double pSellingPrice, int pUnit) {
            return db.addNewProduct(pName, cId, pBasePrice, pSellingPrice, pUnit);
        }

        public double getProductSellingPrice(string productId) {
            return db.getProductSellingPrice(productId); 
        }

        public Boolean addNewCatagory(string catagoryName) {
            return db.addNewCatagory(catagoryName);
        }

    }
}
