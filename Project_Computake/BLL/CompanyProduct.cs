using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ProjectComputers.BLL
{
    public class CompanyProduct : GeneralRow
    {
   
       
            public CompanyProduct(DataRow dr)
            {
                this.drow = dr;
                FillFields();
            }
            public CompanyProduct() { }

            private int companyProductCode;

            public int CompanyProductCode
        {
                get { return companyProductCode; }
                set { companyProductCode = value; }
            }
            private string companyProductName;

            public string CompanyProductName
        {
                get { return companyProductName; }
                set { companyProductName = value; }
            }
            public override void FillDataRow()
            {
                drow["companyProductCode"] = this.companyProductCode;
                drow["companyProductName"] = this.companyProductName;


            }

            public override void FillFields()
            {

                this.companyProductName = drow["companyProductName"].ToString();
                this.companyProductCode = Convert.ToInt32(drow["companyProductCode"]);

            }

            public override string ToString()
            {
                return this.companyProductName;
            }

            public List<Product> GetProduct()
            {
                return MyTable.ProductTable.GetList().Where(x => x.CompanyProductCode == this.companyProductCode).ToList();
            }
    }
}

