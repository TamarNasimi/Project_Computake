using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComputers.BLL;

namespace ProjectComputers.GUI
{
    public partial class frmReturnProduct : Form
    {
        Borrow br;
        Order or;
        Product p;
        public DateTime nameDay;

        public frmReturnProduct()
        {
            InitializeComponent();
            or = new Order();
            p = new Product();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtId.Text=="")
            or = MyTable.OrderTable.GetList().FirstOrDefault(x => x.OrderId == Convert.ToInt32(txtCode.Text));
            else
            if(txtCode.Text=="")
                or = MyTable.OrderTable.GetList().FirstOrDefault(x => x.CustomerId == txtId.Text);
            if (or != null)
            {
                dgvProduct.DataSource = MyTable.BorrowTable.GetList().Where(x => x.Status==false && (x.OrderId.ToString()).Contains(txtCode.Text)).Select(x => new { x.CodeBorrow, x.CountDay, product = x.GetNameProduct() }).ToList();
                dgvProduct.Columns[0].HeaderText = "קוד השאלה";
                dgvProduct.Columns[1].HeaderText = "כמות:";
                dgvProduct.Columns[2].HeaderText = "שם מוצר";
            }
            else
                MessageBox.Show("קוד שגוי");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            or.Status = false;
            or.EmployeeId = frmPassword.emId ;
            MyTable.OrderTable.Update(or);
            MyTable.OrderTable.Save();
            MessageBox.Show("ההחזרה בוצעה בהצלחה");
        }

        private void dgvProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            br = MyTable.BorrowTable.GetList().FirstOrDefault(x => x.CodeBorrow == Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value));
            nameDay = or.OrderDate.AddDays(br.CountDay);
            if (nameDay < DateTime.Today)
            {
                int sum = 0;
                sum += (or.Price) + 10;
                MessageBox.Show(" הינך באיחור של" + (DateTime.Today.Day - nameDay.Day) + " ימים! עליך לשלם קנס של:" + sum);
            }
        }

        private void החזרמוצרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow br = MyTable.BorrowTable.GetList().FirstOrDefault(x => x.CodeBorrow.ToString() == dgvProduct.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("האם ברצונך להחזיר מוצר זה?","החזרה", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                br.Status = true;
                MyTable.BorrowTable.Update(br);
                MyTable.BorrowTable.Save();
                //רענון
                dgvProduct.DataSource = MyTable.BorrowTable.GetList().Where(x => x.Status&& (x.OrderId.ToString()).Contains(txtCode.Text)).Select(x => new { x.CodeBorrow, x.CountDay, product = x.GetNameProduct() }).ToList();
                dgvProduct.Columns[0].HeaderText = "קוד השאלה";
                dgvProduct.Columns[1].HeaderText = "כמות:";
                dgvProduct.Columns[2].HeaderText = "שם מוצר";
                if (dgvProduct.RowCount == 0)
                    btnOk.Enabled = true;
                p = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == br.ProductId);
                p.CountinStock++;
                MyTable.ProductTable.Update(p);
                MyTable.ProductTable.Save();
            }
        }
    }
}
