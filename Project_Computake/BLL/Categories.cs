using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectComputers.BLL
{
   public class Categories:GeneralRow //טבלת השאלה או מכירה
   {
        public Categories(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }

        public Categories() { }
       
        private int categoryId;

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        private string categoryName;

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public override void FillDataRow()
        {
            drow["categoryId"] = this.categoryId;
            drow["categoryName"] = this.categoryName;


        }

        public override void FillFields()
        {
            this.categoryId = Convert.ToInt32(drow["categoryId"]);
            this.categoryName = drow["categoryName"].ToString();
        }
        public List<Product> GetProduct()
        {
            return MyTable.ProductTable.GetList().Where(x => x.SellOrRent == this.categoryId).ToList();
        }
        public override string ToString()
        {
            return this.categoryName;
        }
        public  string GetName()
        {
            return this.categoryName;
        }

        public List<Order> GetOrder()
        {
            return MyTable.OrderTable.GetList().Where(x => x.CodeCategory == this.categoryId).ToList();
        }
    }
}
