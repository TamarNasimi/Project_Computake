using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComputers.DALL;

namespace ProjectComputers.BLL
{
    public class OrderDetail : GeneralRow
    {
        public OrderDetail() { }
        public OrderDetail(DataRow dr)
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
       
        
       
        private int countOrder;

        public int CounttOrder
        {
            get { return countOrder; }
            set { countOrder = value; }
        }

      

        public override void FillDataRow()
        {
            drow["productId"] = this.productId;
            drow["orderId"] = this.orderId;
           
            drow["countOrder"] = this.countOrder;
            

        }
        public override void FillFields()
        {
            this.countOrder = Convert.ToInt32(drow["countOrder"]);
            this.productId = Convert.ToInt32(drow["productId"]);
            this.orderId = Convert.ToInt32(drow["orderId"]);
        }
        public Product GetProduct()
        {
            return MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == this.productId);

        }
    }
}
