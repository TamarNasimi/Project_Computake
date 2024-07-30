using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectComputers.DALL;

namespace ProjectComputers.BLL
{
    public class Payment:GeneralRow
    { 
          public Payment(DataRow dr)
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
        
        private int codePaying;

        public int CodePaying
        {
            get { return codePaying; }
            set
            {
                codePaying = value;

            }
        }
        
        private string nameKind;

        public string NameKind
        {
            get { return nameKind; }
            set {
                nameKind = value;
            }
        }
        

        public override void FillFields()
        {
            this.nameKind = drow["nameKind"].ToString();
            this.codePaying = Convert.ToInt32(drow["codePaying"]);
        }
        public override void FillDataRow()
        {
            drow["nameKind"] = this.nameKind;
            drow["codePaying"] = this.codePaying;
        }
    }
}
