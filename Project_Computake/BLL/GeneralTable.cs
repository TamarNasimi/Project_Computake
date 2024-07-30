using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectComputers.DALL;
using ProjectComputers.BLL;

namespace ProjectComputers.BLL
{
    public class GeneralTable
    {
        protected DataTable table;
        protected static Dal dal = new Dal();
        protected List<GeneralRow> list;

        public GeneralTable(string nameTable)
        {
            table = dal.GetTable(nameTable);
            list = new List<GeneralRow>();
        }

        public DataTable GetTable()
        {
            return this.table;
        }
        //הוספת שורה לטבלה
        public void Add(GeneralRow item)
        {
            list.Add(item);
            item.SetNewRow(table.NewRow());
            item.FillDataRow();
            table.Rows.Add(item.DataRow);
        }
        // עדכון שורה בטבלה
        public void Update(GeneralRow item)
        {
            item.FillDataRow();
        }
        // מחיקת שורה בטבלה
        public void Delete(GeneralRow item)
        {
            list.Remove(item);
            item.DataRow.Delete();
        }

        // שמירת הנתונים באקסס
        public void Save()
        {
            try
            {
                dal.Update(table.TableName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}