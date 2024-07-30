using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectComputers.BLL
{
    public class EmployeeTable : GeneralTable
    {
        public EmployeeTable() : base("tblEmployee")
        {
            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new Employee(dr));
            }
        }
        public List<Employee> GetList()
        {
            return list.Cast<Employee>().ToList();
        }
    }
}
