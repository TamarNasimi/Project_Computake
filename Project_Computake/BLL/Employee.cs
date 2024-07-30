using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectComputers.DALL;
using ProjectComputers.GUI;

namespace ProjectComputers.BLL
{
    public class Employee:GeneralRow
    {
        public Employee(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }
        public Employee() { }

       
        private string employeeId;

        public string EmployeeId
        {
            get { return employeeId; }
            set {
                if (frmEmployee.status == "add")
                {
                    if (MyTable.EmployeeTable.GetList().FirstOrDefault(x => x.employeeId == value) != null)
                        throw new Exception("ת.ז. קיימת");
                }

                if (validation.LegalId(value) == true)
                    employeeId = value;
                else
                  if (value == "")
                    throw new Exception("לא הקשת ת.ז");
                else
                    throw new Exception("ת.ז. שגויה");
            }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set {

                if (value.Length < 2)
                    throw new Exception("שם משפחה לא תקין");
                else
                {
                    if (validation.IsHebrew(value))
                        lastName = value;
                    else

                           if (value == "")
                        throw new Exception("לא הקשת שם משפחה");
                    else
                        throw new Exception("שם משפחה שגוי");
                }
            }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set {
                if (value.Length < 2)
                    throw new Exception("שם משפחה לא תקין");
                else
                {
                    if (validation.IsHebrew(value))
                    firstName = value;
                else

                   if (value == "")
                    throw new Exception("לא הקשת שם פרטי");
                else
                    throw new Exception("שם שגוי");
                }
                }
        }


        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                if (value.Length < 2)
                    throw new Exception("כתובת לא תקינה");
                
                    else

                     if (value == "")
                        throw new Exception("לא הקשת כתובת");
                    
            }
        }
        private int num;

        public int Num
        {
            get { return num; }
            set {
                if (validation.IsHebrew(value.ToString()) == true)
                    throw new Exception("מספרים בלבד");

                if (value == 0)
                    throw new Exception("לא הקשת פלאפון");

                num = value;
            }
        }
        private int cityId;

        public int CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set {
                if (value == "")
                    throw new Exception("לא הקשת פלאפון");
                for (int i = 0; i < value.Length; i++)
                {
                    int digit = Convert.ToInt32(value[i].ToString());
                    if (!(digit >= 0 && digit <= 9))
                        throw new Exception("הקש מספרים בלבד ");
                }
                phone = value;
            }
        }
        
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        private int numHourWeek;

        public int NumHourWeek
        {
            get { return numHourWeek; }
            set { numHourWeek = value; }

        }
        
        private int typeCode;
        public int TypeCode
        {
            get { return typeCode; }
            set { typeCode = value; }
        }

        public override void FillDataRow()
        {
            drow["employeeId"] = this.employeeId;
            drow["firstName"] = this.firstName;
            drow["lastName"] = this.lastName;
            drow["adrress"] = this.address;
            drow["phone"] = this.phone;
            drow["status"] = this.status;
            drow["cityId"] = this.cityId;
            drow["num"] = this.num;
            drow["typeCode"] = this.typeCode;

        }

        public override void FillFields()
        {

            this.employeeId = drow["employeeId"].ToString();
            this.firstName = drow["firstName"].ToString();
            this.lastName = drow["lastName"].ToString();
            this.address = drow["adrress"].ToString();
            this.phone = drow["phone"].ToString();
            this.status = Convert.ToBoolean(drow["status"]);
            this.cityId = Convert.ToInt32(drow["cityId"]);
            this.num = Convert.ToInt32(drow["num"]);
            this.typeCode = Convert.ToInt32(drow["typeCode"]);
        }
        public City GetCity()
        {
            return MyTable.CityTable.GetList().FirstOrDefault(x => x.CityId == this.cityId);
        }
        public TypeOfEmployee GetTypeWorker()
        {
            return MyTable.TypeOfEmployeeTable.GetList().FirstOrDefault(x => x.TypeCode == this.typeCode);
        }
    }
}
