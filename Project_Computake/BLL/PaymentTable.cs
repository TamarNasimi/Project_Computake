using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectComputers.BLL
{
  public  class PaymentTable: GeneralTable
    {
        public PaymentTable() : base("tblPayment")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new Payment(dr));
            }
        }
        public List<Payment> GetList()
        {
            return list.Cast<Payment>().ToList();
        }

    }
}
