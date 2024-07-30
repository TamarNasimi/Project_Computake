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
    public partial class frmAllOrder : Form
    {
        Order or;
        public frmAllOrder()
        {
            InitializeComponent();
            or = new Order();
            dgvallOorders.DataSource = MyTable.OrderTable.GetList().Where(x => x.Status).Select(x => new { x.OrderId, x.EmployeeId, x.CustomerId, x.OrderDate, x.Price, name = x.GetCategories() }).ToList();
            dgvallOorders.Columns[0].HeaderText = "קוד הזמנה";
            dgvallOorders.Columns[1].HeaderText = "ת.ז. עובד";
            dgvallOorders.Columns[2].HeaderText = "ת.ז. לקוח";
            dgvallOorders.Columns[3].HeaderText = "תאריך הזמנה";
            dgvallOorders.Columns[4].HeaderText = "מחיר";
            dgvallOorders.Columns[5].HeaderText = "קטגוריה";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOrderBuy frm = new frmOrderBuy();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvallOorders.DataSource = MyTable.OrderTable.GetList().Where(x => x.Status && (x.OrderId.ToString()).Contains(textBox1.Text)).Select(x => new { x.OrderId, x.EmployeeId, x.CustomerId, x.OrderDate, x.Price, name = x.GetCategories() }).ToList();
            dgvallOorders.Columns[0].HeaderText = "קוד הזמנה";
            dgvallOorders.Columns[1].HeaderText = "ת.ז. עובד";
            dgvallOorders.Columns[2].HeaderText = "ת.ז. לקוח";
            dgvallOorders.Columns[3].HeaderText = "תאריך הזמנה";
            dgvallOorders.Columns[4].HeaderText = "מחיר";
            dgvallOorders.Columns[5].HeaderText = "קטגוריה";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txtIdCustomer.Text = "";
            txtIdEmployee.Text = "";
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dgvallOorders.DataSource = MyTable.OrderTable.GetList().Where(x => x.Status && (x.EmployeeId.ToString()).Contains(txtIdEmployee.Text)).Select(x => new { x.OrderId, x.EmployeeId, x.CustomerId, x.OrderDate, x.Price, name =x.GetCategories() }).ToList();
            dgvallOorders.Columns[0].HeaderText = "קוד הזמנה";
            dgvallOorders.Columns[1].HeaderText = "ת.ז. עובד";
            dgvallOorders.Columns[2].HeaderText = "ת.ז. לקוח";
            dgvallOorders.Columns[3].HeaderText = "תאריך הזמנה";
            dgvallOorders.Columns[4].HeaderText = "מחיר";
            dgvallOorders.Columns[5].HeaderText = "קטגוריה";
        }

        private void txtIdCustomer_TextChanged(object sender, EventArgs e)
        {
            dgvallOorders.DataSource = MyTable.OrderTable.GetList().Where(x => x.Status && (x.CustomerId.ToString()).Contains(txtIdCustomer.Text)).Select(x => new { x.OrderId, x.EmployeeId, x.CustomerId, x.OrderDate, x.Price, name = x.GetCategories() }).ToList();
            dgvallOorders.Columns[0].HeaderText = "קוד הזמנה";
            dgvallOorders.Columns[1].HeaderText = "ת.ז. עובד";
            dgvallOorders.Columns[2].HeaderText = "ת.ז. לקוח";
            dgvallOorders.Columns[3].HeaderText = "תאריך הזמנה";
            dgvallOorders.Columns[4].HeaderText = "מחיר";
            dgvallOorders.Columns[5].HeaderText = "קטגוריה";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {          
            dgvallOorders.DataSource = MyTable.OrderTable.GetList().Where(x => x.Status && (x.CodeCategory==1)).Select(x => new { x.OrderId, x.EmployeeId, x.CustomerId, x.OrderDate, x.Price, name = x.GetCategories() }).ToList();
            dgvallOorders.Columns[0].HeaderText = "קוד הזמנה";
            dgvallOorders.Columns[1].HeaderText = "ת.ז. עובד";
            dgvallOorders.Columns[2].HeaderText = "ת.ז. לקוח";
            dgvallOorders.Columns[3].HeaderText = "תאריך הזמנה";
            dgvallOorders.Columns[4].HeaderText = "מחיר";
            dgvallOorders.Columns[5].HeaderText = "קטגוריה";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dgvallOorders.DataSource = MyTable.OrderTable.GetList().Where(x => x.Status && (x.CodeCategory == 2)).Select(x => new { x.OrderId, x.EmployeeId, x.CustomerId, x.OrderDate, x.Price, name = x.GetCategories() }).ToList();
            dgvallOorders.Columns[0].HeaderText = "קוד הזמנה";
            dgvallOorders.Columns[1].HeaderText = "ת.ז. עובד";
            dgvallOorders.Columns[2].HeaderText = "ת.ז. לקוח";
            dgvallOorders.Columns[3].HeaderText = "תאריך הזמנה";
            dgvallOorders.Columns[4].HeaderText = "מחיר";
            dgvallOorders.Columns[5].HeaderText = "קטגוריה";
        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Order or = MyTable.OrderTable.GetList().FirstOrDefault(x => x.OrderId == Convert.ToInt32(dgvallOorders.CurrentRow.Cells[0].Value));
          
            OrderDetail ord = MyTable.OrderDetailTable.GetList().FirstOrDefault(x => x.OrderId == Convert.ToInt32(dgvallOorders.CurrentRow.Cells[0].Value));
            Borrow br = MyTable.BorrowTable.GetList().FirstOrDefault(x => x.OrderId == Convert.ToInt32(dgvallOorders.CurrentRow.Cells[0].Value));
            if (MessageBox.Show("האם ברצונך למחוק?", "התרעה על מחיקה", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                if (or.CodeCategory == 2)
                {
                    or.Status = false;
                    MyTable.OrderTable.Update(or);
                    MyTable.OrderTable.Save();
                    MyTable.OrderDetailTable.Delete(ord);
                    MyTable.OrderDetailTable.Save();
                }
                if (or.CodeCategory == 1)
                {
                    or.Status = false;
                    MyTable.OrderTable.Update(or);
                    MyTable.OrderTable.Save();
                    MyTable.BorrowTable.Delete(br);
                    MyTable.BorrowTable.Save();
                }
                dgvallOorders.DataSource = MyTable.OrderTable.GetList().Where(x => x.Status).Select(x => new { x.OrderId, x.EmployeeId, x.CustomerId, x.OrderDate, x.Price, name = x.GetCategories() }).ToList();
                dgvallOorders.Columns[0].HeaderText = "קוד הזמנה";
                dgvallOorders.Columns[1].HeaderText = "ת.ז. עובד";
                dgvallOorders.Columns[2].HeaderText = "ת.ז. לקוח";
                dgvallOorders.Columns[3].HeaderText = "תאריך הזמנה";
                dgvallOorders.Columns[4].HeaderText = "מחיר";
                dgvallOorders.Columns[5].HeaderText = "קטגוריה";
            }
            else
                MessageBox.Show("המחיקה בוטלה");
        }

        private void פירוטהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order o = MyTable.OrderTable.GetList().FirstOrDefault(x => x.OrderId == Convert.ToInt32(dgvallOorders.CurrentRow.Cells[0].Value));
            frmOrderTotal frm = new frmOrderTotal(o);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOrderBorrow frm = new frmOrderBorrow();
            frm.Show();
        }
    }
}
