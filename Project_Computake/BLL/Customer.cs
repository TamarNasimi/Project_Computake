using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComputers.DALL;
using ProjectComputers.GUI;
using System.Data;

namespace ProjectComputers.BLL
{
    public class Customer : GeneralRow
    {
        public Customer(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }
        public Customer()
        {

        }
        private string customerId;

        public string CustomerId
        {
            get { return customerId; }
            set
            {
                if (frmCustomer.status == "add")
                {
                    if (MyTable.CustomerTable.GetList().FirstOrDefault(x => x.customerId == value) != null)
                        throw new Exception("ת.ז. קיימת");
                }
               
                if (validation.LegalId(value) == true)
                    customerId = value;
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
            set
            {
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
                    throw new Exception("שם לא תקין");
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
            set {
                if (value.Length < 2)
                    throw new Exception("כתובת לא תקינה");
               
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
                    throw new Exception("לא הקשת מספר דירה");

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
                if (validation.IsHebrew(value))
                    throw new Exception("מספרים בלבד");
               
                    if (value == "")
                    throw new Exception("לא הקשת פלאפון");
              
                phone = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        //מילוי השדות בשורה בטבלה מתוך השדות של האוביקט
        public override void FillDataRow()
        {
            drow["customerId"] = this.customerId;
            drow["firstName"] = this.firstName;
            drow["lastName"] = this.lastName;
            drow["adrress"] = this.address;
            drow["phone"] = this.phone;
            drow["status"] = this.status;
            drow["cityId"] = this.cityId;
            drow["num"] = this.num;

        }

        public override void FillFields()
        {

            this.customerId = drow["customerId"].ToString();
            this.firstName = drow["firstName"].ToString();
            this.lastName = drow["lastName"].ToString();
            this.address = drow["adrress"].ToString();
            this.phone = drow["phone"].ToString();
            this.status = Convert.ToBoolean(drow["status"]);
            this.cityId = Convert.ToInt32(drow["cityId"]);
            this.num = Convert.ToInt32(drow["num"]);
        }
        public City GetCity()
        {
            return MyTable.CityTable.GetList().FirstOrDefault(x => x.CityId == this.cityId);

        }
    }
}
