using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectComputers.BLL
{
    public abstract class GeneralRow
    {
        protected DataRow drow;
        public abstract void FillFields();
        public abstract void FillDataRow();
        public void SetNewRow(DataRow row)
        {
            if (drow == null)
                drow = row;
        }
        public DataRow DataRow { get { return this.drow; } }
    }
}
