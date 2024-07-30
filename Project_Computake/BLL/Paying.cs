using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectComputers.DALL;

namespace ProjectComputers.BLL
{
    public class Paying:GeneralRow
    { 
          public Paying(DataRow dr)
          {
             this.drow = dr;
             FillFields();

          }
    
        private string cusNumCard;
        
        public string CusNumCard
        {
            get { return cusNumCard; }
            set {
                if (value == "")
                    throw new Exception("שדה חובה");
                if (!validation.LegalId(value))
                    throw new Exception("תעודת זהות לא תקינה");
                cusNumCard = value;
            }
        }
        
        private int cvv;

        public int Cvv
        {
            get { return cvv; }
            set
            {
                if (value == 0)
                    throw new Exception("שדה חובה");
                if (value.ToString().Length != 3)
                    throw new Exception("לא תקין");
                if (!validation.IsNumber(value.ToString()))
                    throw new Exception("מספרים בלבד");
                cvv = value;
            }
        }
        
        private string numCard;

        public string NumCard
        {
            get { return numCard; }
            set {
                if (value == "")
                    throw new Exception("שדה חובה");
                if (!validation.checkVisa(value))
                    throw new Exception("מספר כרטיס אשראי לא תקין");
                if (!validation.IsNumber(value))
                    throw new Exception("מספרים בלבד");
                numCard = value;
            }
        }
        
        private DateTime dateCard;

        public DateTime DateCard
        {
            get { return dateCard; }
            set {
                if (value == null)
                    throw new Exception("שדה חובה");
                if (value < DateTime.Today.Date)
                    throw new Exception("כרטיס לא בתוקף");
                dateCard = value;
            }
        }
       
        
            private int numPayment;

        public int NumPayment
        {
            get { return numPayment; }
            set {
                if (value == 0)
                    throw new Exception("שדה חובה");
                numPayment = value; }
        }

        public override void FillFields()
        {
            this.cusNumCard = drow["cusNumCard"].ToString();
            this.dateCard = Convert.ToDateTime(drow["dateCard"]);
            this.cvv = Convert.ToInt32(drow["cvv"]);
            this.numCard = (drow["numCard"].ToString());
            this.numPayment = Convert.ToInt32(drow["numPayment"]);
        }
        public override void FillDataRow()
        {
            drow["dateCard"] = this.dateCard;
            drow["cusNumCard"] = this.cusNumCard;
            drow["numPayment"] = this.numPayment;
            drow["cvv"] = this.cvv;
            drow["numCard"] = this.numCard;
        }
    }
}
