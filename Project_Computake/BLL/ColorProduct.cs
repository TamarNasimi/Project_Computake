using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectComputers.BLL
{
   public class ColorProduct: GeneralRow
   {
        public ColorProduct(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }
        public ColorProduct() { }

        private int colorCode;

        public int ColorCode
        {
            get { return colorCode; }
            set { colorCode = value; }
        }
        private string colorName;

        public string ColorName
        {
            get { return colorName; }
            set { colorName = value; }
        }
        public override void FillDataRow()
        {
            drow["colorCode"] = this.colorCode;
            drow["colorName"] = this.colorName;


        }

        public override void FillFields()
        {

            this.colorName = drow["colorName"].ToString();
            this.colorCode = Convert.ToInt32(drow["colorCode"]);

        }

        public override string ToString()
        {
            return this.colorName;
        }

        public List<Product> GetProduct()
        {
            return MyTable.ProductTable.GetList().Where(x => x.ColorCode == this.colorCode).ToList();
        }
    }
}
