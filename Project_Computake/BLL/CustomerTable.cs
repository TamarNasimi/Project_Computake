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
    public class CustomerTable : GeneralTable
    {
        public CustomerTable() : base("tblCustomer")
        {
            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new Customer(dr));
            }
        }


        public List<Customer> GetList()
        {
            return list.Cast<Customer>().ToList();
        }

    }
}