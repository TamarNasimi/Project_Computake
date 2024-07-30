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
     public class OrderStock : GeneralRow
     {
        public OrderStock() { }
        public OrderStock(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }

        private int orderStockId;

        public int OrderStockId
        {
            get { return orderStockId; }
            set { orderStockId = value; }
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

        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new Exception("לא ניתן מחיר שלילי");
            }
        }

        private int countStock;

        public int CountStock
        {
            get { return countStock; }
            set { countStock = value; }
        }

        private string employeeId;

        public string EmployeeId
        {
            get { return employeeId; }
            set
            {
                if (validation.LegalId(value) == true)
                    employeeId = value;
                else
                  if (value == "")
                    throw new Exception("לא הקשת ת.ז");
                else
                    throw new Exception("ת.ז. שגויה");
            }
        }

        public override void FillDataRow()
        {
            drow["productId"] = this.productId;
            drow["orderStockId"] = this.orderStockId;
            drow["price"] = this.price;
            drow["countStock"] = this.countStock;
            drow["employeeId"] = this.employeeId;
        }

        public override void FillFields()
        {

            this.employeeId = drow["employeeId"].ToString();
            this.price = Convert.ToInt32(drow["price"]);
            this.countStock = Convert.ToInt32(drow["countStock"]);
            this.productId = Convert.ToInt32(drow["productId"]);
            this.orderStockId = Convert.ToInt32(drow["orderStockId"]);
        }
     }
}
