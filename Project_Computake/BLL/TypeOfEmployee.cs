using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectComputers.BLL
{
   public class TypeOfEmployee: GeneralRow
    {
        public TypeOfEmployee(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }
        public TypeOfEmployee(){ }
       
        private int typeCode;

        public int TypeCode
        {
            get { return typeCode; }
            set { typeCode = value; }
        }

        private string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        public override void FillDataRow()
        {
            drow["typeCode"] = this.typeCode;
            drow["typeName"] = this.typeName;


        }

        public override void FillFields()
        {

            this.typeName = drow["typeName"].ToString();
            this.typeCode = Convert.ToInt32(drow["typeCode"]);

        }

        public override string ToString()
        {
            return this.typeName;
        }


        public List<Employee> GetEmployee()
        {
            return MyTable.EmployeeTable.GetList().Where(x => x.TypeCode == this.typeCode).ToList();
        }
    }
}
