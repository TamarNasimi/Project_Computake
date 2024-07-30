using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComputers.BLL;

namespace ProjectComputers.BLL
{
    public static class MyTable
    {
        private static CustomerTable customerTable = new CustomerTable();
        private static OrderTable orderTable = new OrderTable();
        private static CityTable cityTable = new CityTable();
        private static EmployeeTable employeeTable = new EmployeeTable();
        private static ProductTable productTable = new ProductTable();
        private static CategoriesTable categoriesTable = new CategoriesTable();
        private static TypeOfEmployeeTable typeOfEmployeeTable = new TypeOfEmployeeTable();
        private static ColorProductTable colorProductTable = new ColorProductTable();
        private static CompanyProductTable companyProductTable = new CompanyProductTable();
        private static CategoryProductTable categoryProductTable = new CategoryProductTable();
        private static OrderDetailTable orderDetailTable = new OrderDetailTable();
        private static BorrowTable borrowTable = new BorrowTable();
        private static CreditCardTable creditCardTable = new CreditCardTable();
        private static PaymentTable paymentTable = new PaymentTable();
        public static CustomerTable CustomerTable
        {
            get
            {
                return customerTable;
            }
        }
        public static CityTable CityTable
        {
            get
            {
                return cityTable;
            }
        }
        public static OrderTable OrderTable
        {
            get
            {
                return orderTable;
            }
        }
        public static EmployeeTable EmployeeTable
        {
            get
            {
                return employeeTable;
            }
        }
        public static ProductTable ProductTable
        {
            get
            {
                return productTable;
            }
        }
        public static CategoriesTable CategoriesTable
        {
            get
            {
                return categoriesTable;
            }
        }
        public static TypeOfEmployeeTable TypeOfEmployeeTable
        {
            get
            {
                return typeOfEmployeeTable;
            }
        }
        public static ColorProductTable ColorProductTable
        {
            get
            {
                return colorProductTable;
            }
        }

        public static CompanyProductTable CompanyProductTable
        {
            get
            {
                return companyProductTable;
            }
        }

       public static CategoryProductTable CategoryProductTable
       {
            get
            {
                return categoryProductTable;
            }
       }

        public static OrderDetailTable OrderDetailTable
        {
            get
            {
                return orderDetailTable;
            }
        }
        public static BorrowTable BorrowTable
        {
            get
            {
                return borrowTable;
            }
        }
        public static CreditCardTable CreditCardTable
        {
            get
            {
                return creditCardTable;
            }
        }
        public static PaymentTable PaymentTable
        {
            get
            {
                return paymentTable;
            }
        }
    }
}