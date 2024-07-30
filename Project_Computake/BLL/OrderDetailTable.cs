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
    public class OrderDetailTable:GeneralTable
    {
        public OrderDetailTable() : base("tblOrderDetail")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new OrderDetail(dr));
            }
        }

        public List<OrderDetail> GetList()
        {
            return list.Cast<OrderDetail>().ToList();
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
