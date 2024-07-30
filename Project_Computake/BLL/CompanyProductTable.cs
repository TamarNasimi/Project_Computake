using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComputers.DALL;
using System.Data;
using ProjectComputers.BLL;

namespace ProjectComputers.BLL
{
    public class CompanyProductTable : GeneralTable
    {
        public CompanyProductTable() : base("tblCompanyProduct")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new CompanyProduct(dr));
            }
        }

        public List<CompanyProduct> GetList()
        {
            return list.Cast<CompanyProduct>().ToList();
        }
        public int Next()
        {
            if (this.GetList().Count == 0)
                return 1;
            else
                return this.GetList().Max(x => x.CompanyProductCode) + 1;
        }
    }
}
   
