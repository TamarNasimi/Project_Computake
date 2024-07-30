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
   public class TypeOfEmployeeTable: GeneralTable
    {
        public TypeOfEmployeeTable() : base("tblTypeEmployee")
        {

            foreach (DataRow dr in table.Rows)
            {
                this.list.Add(new TypeOfEmployee(dr));
            }
        }

        public List<TypeOfEmployee> GetList()
        {
            return list.Cast<TypeOfEmployee>().ToList();
        }
    }
}
