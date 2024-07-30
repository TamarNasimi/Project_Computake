using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ProjectComputers.GUI;
using ProjectComputers.DALL;
namespace ProjectComputers.BLL
{
    public class City : GeneralRow
    {
        public City(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }
        public City()
        {

        }

        private int cityId;

        public int CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }
        private string cityName;

        public string CityName
        {
            get { return cityName; }
            set
            {
                if (value.Length < 2)
                    throw new Exception("שם עיר לא תקין");
                else
                {
                    if (validation.IsHebrew(value))
                        cityName = value;
                    else
                        throw new Exception("שם עיר שגוי");
                    cityName = value; }
        }
            }
        public override void FillDataRow()
        {
            drow["cityId"] = this.cityId;
            drow["cityName"] = this.cityName;


        }

        public override void FillFields()
        {

            this.cityName = drow["cityName"].ToString();
            this.cityId = Convert.ToInt32(drow["cityId"]);

        }

        public override string ToString()
        {
            return this.cityName;
        }

        public List<Customer> GetCustomer()
        {
            return MyTable.CustomerTable.GetList().Where(x => x.CityId == this.cityId).ToList();
        }
        public List<Employee> GetEmployee()
        {
            return MyTable.EmployeeTable.GetList().Where(x => x.CityId == this.CityId).ToList();
        }
    }
}