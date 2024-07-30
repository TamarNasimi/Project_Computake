using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace ProjectComputers.DALL
{
    public class Dal
    {
        private OleDbConnection con;
        private DataSet ds;

        public Dal()
        {
            ds = new DataSet();
            con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = '" + Application.StartupPath + @"\computers.mdb'");
        }

        public void AddTable(string tableName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
            adapter.Fill(ds, tableName);
        }

        public DataTable GetTable(string tableName)
        {
            if (!ds.Tables.Contains(tableName))
                AddTable(tableName);
            return ds.Tables[tableName];
        }

        public void Update(string tableName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.Update(ds, tableName);

        }
    }
}
