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
   public class ColorProductTable: GeneralTable
    {
        public ColorProductTable() : base("tblColor")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new ColorProduct(dr));
            }
        }

        public List<ColorProduct> GetList()
        {
            return list.Cast<ColorProduct>().ToList();
        }
        public int Next()
        {
            if (this.GetList().Count == 0)
                return 1;
            else
                return this.GetList().Max(x => x.ColorCode) + 1;
        }
    }
}
   

