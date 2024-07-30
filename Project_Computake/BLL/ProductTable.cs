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
    public class ProductTable : GeneralTable
    {
        public ProductTable() : base("tblProduct")
        {
            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new Product(dr));
            }
        }


        public List<Product> GetList()
        {
            return list.Cast<Product>().ToList();
        }
        public int Next()
        {
            if (this.GetList().Count == 0)
                return 1;
            else
                return this.GetList().Max(x => x.ProductId) + 1;
        }
    }
}
