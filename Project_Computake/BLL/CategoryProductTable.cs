using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComputers.DALL;
using System.Data;
using ProjectComputers.BLL;
using ProjectComputers.GUI;

namespace ProjectComputers.BLL
{
    public class CategoryProductTable : GeneralTable
    {
        public CategoryProductTable() : base("tblcategoryProduct")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new CategoryProduct(dr));
            }
        }

        public List<CategoryProduct> GetList()
        {
            return list.Cast<CategoryProduct>().ToList();
        }
    }
}
