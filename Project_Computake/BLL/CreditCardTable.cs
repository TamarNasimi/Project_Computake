using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectComputers.BLL
{
  public  class CreditCardTable:GeneralTable
    {
        public CreditCardTable():base("tblCreditCard")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new CreditCard(dr));
            }
        }
        public List<CreditCard> GetList()
        {
            return list.Cast<CreditCard>().ToList();
        }
        
    }
}