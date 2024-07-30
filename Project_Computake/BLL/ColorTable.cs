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
   public class ColorTable: GeneralTable
    {
        public ColorTable() : base("tblColor")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new Color(dr));
            }
        }

        public List<Color> GetList()
        {
            return list.Cast<Color>().ToList();
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
   

