using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComputers.DALL;
using System.Data;

namespace ProjectComputers.BLL
{
    public class Borrow: GeneralRow
    {
        public Borrow() { }
        public Borrow(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }
        private int orderId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set
            {
                if (value == 0)
                    throw new Exception("לא הקשת ת.ז.");
                else
                    productId = value;
            }
        }



        private int countDay;

        public int CountDay
        {
            get { return countDay; }
            set { countDay = value; }
        }

        private int codeBorrow;

        public int CodeBorrow
        {
            get { return codeBorrow; }
            set { codeBorrow = value; }
        }

        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public override void FillDataRow()
        {
            drow["productId"] = this.productId;
            drow["orderId"] = this.orderId;
            drow["codeBorrow"] = this.codeBorrow;
            drow["countDay"] = this.countDay;
            drow["status"] = this.status;
        }
        public override void FillFields()
        {
            this.countDay = Convert.ToInt32(drow["countDay"]);
            this.productId = Convert.ToInt32(drow["productId"]);
            this.orderId = Convert.ToInt32(drow["orderId"]);
            this.codeBorrow = Convert.ToInt32(drow["codeBorrow"]);
            this.status = Convert.ToBoolean(drow["status"]);
        }

        public string GetNameProduct()
        {
            return MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == this.productId).ProductName;
        }
    }
}
