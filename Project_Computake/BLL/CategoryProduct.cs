using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComputers.DALL;
using ProjectComputers.BLL;
using System.Data;

namespace ProjectComputers.BLL
{
    public class CategoryProduct : GeneralRow //מחשב או מקרן
    {
        public CategoryProduct() { }
        public CategoryProduct(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }
        private int categoryPrId;

        public int CategoryPrId
        {
            get { return categoryPrId; }
            set { categoryPrId = value; }
        }
        private string categoryPrName;

        public string CategoryPrName
        {
            get { return categoryPrName; }
            set { categoryPrName = value; }
        }

        public override void FillDataRow()
        {
            drow["categoryPrId"] = this.categoryPrId;
            drow["CategoryPrName"] = this.CategoryPrName;


        }

        public override void FillFields()
        {
            this.categoryPrId = Convert.ToInt32(drow["categoryPrId"]);
            this.CategoryPrName = drow["CategoryPrName"].ToString();
        }

        public List<Product> GetProduct()
        {
            return MyTable.ProductTable.GetList().Where(x => x.CategoryPrId == this.categoryPrId).ToList();
        }
        public override string ToString()
        {
            return this.CategoryPrName;
        }
        public string GetName()
        {
            return this.CategoryPrName;
        }
    }
}
