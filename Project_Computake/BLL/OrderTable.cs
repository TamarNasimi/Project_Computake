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
    public class OrderTable : GeneralTable
    {
        public OrderTable() : base("tblOrder")
        {
            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new Order(dr));
            }
        }

        public List<Order> GetList()
        {
            return list.Cast<Order>().ToList();
        }

        public int Next()
        {
            if (this.GetList().Count == 0)
                return 1;
            else
                return this.GetList().Max(x => x.OrderId) + 1;
        }

    }
}