using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectComputers.DALL;
using ProjectComputers.BLL;

namespace ProjectComputers.BLL
{
  public  class BorrowTable:GeneralTable
    {
        public BorrowTable() : base("tblBorrow")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new Borrow(dr));
            }
        }

        public List<Borrow> GetList()
        {
            return list.Cast<Borrow>().ToList();
        }
        public int Next()
        {
            if (this.GetList().Count == 0)
                return 1;
            else
                return this.GetList().Max(x => x.CodeBorrow) + 1;
        }
    }
}

