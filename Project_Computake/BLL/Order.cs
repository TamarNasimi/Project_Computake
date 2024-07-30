using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectComputers.BLL
{
    public class Order : GeneralRow
    {
        public Order(DataRow dr)
        {
            this.drow = dr;
            FillFields();

        }
        public Order() 
        {
        }

        private int orderId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        private string customerId;

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        private string employeeId;

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private int codePaying;

        public int CodePaying
        {
            get { return codePaying; }
            set { codePaying = value; }
        }


        private int codeCategory;

        public int CodeCategory
        {
            get { return codeCategory; }
            set { codeCategory = value; }
        }
        public override void FillFields()
        {
            this.customerId = drow["customerId"].ToString();
            this.employeeId = drow["employeeId"].ToString();
            this.status = Convert.ToBoolean(drow["status"]);
            this.orderDate = Convert.ToDateTime(drow["orderDate"]);
            this.orderId = Convert.ToInt32(drow["orderId"]);
            this.price = Convert.ToInt32(drow["price"]);
            this.codePaying = Convert.ToInt32(drow["codePaying"]);
            this.codeCategory = Convert.ToInt32(drow["codeCategory"]);
        }
        public override void FillDataRow()
        {
            drow["orderId"] = this.orderId;
            drow["customerId"] = this.customerId;
            drow["employeeId"] = this.employeeId;
            drow["orderDate"] = this.orderDate;
            drow["status"] = this.status;
            drow["price"] = this.price;
            drow["codePaying"] = this.codePaying;
            drow["codeCategory"] = this.codeCategory;
        }
        public List<Borrow> GetBorrowinOrder()
        {
            return MyTable.BorrowTable.GetList().Where(x => x.OrderId == this.OrderId).ToList();
        }
        public Categories GetCategories()
        {
            return MyTable.CategoriesTable.GetList().FirstOrDefault(x => x.CategoryId == this.CodeCategory);
        }
    }
}
