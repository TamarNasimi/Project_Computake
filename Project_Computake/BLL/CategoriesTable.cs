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
    public class CategoriesTable : GeneralTable
    {
        public CategoriesTable() : base("tblCategories")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new Categories(dr));
            }
        }

        public List<Categories> GetList()
        {
            return list.Cast<Categories>().ToList();
        }
    }
}
