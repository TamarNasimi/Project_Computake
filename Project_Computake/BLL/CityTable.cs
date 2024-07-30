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
    public class CityTable : GeneralTable
    {
        public CityTable() : base("tblCity")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new City(dr));
            }
        }

        public List<City> GetList()
        {
            return list.Cast<City>().ToList();
        }
        public int Next()
        {
            if (this.GetList().Count == 0)
                return 1;
            else
                return this.GetList().Max(x => x.CityId) + 1;
        }
    }
}
