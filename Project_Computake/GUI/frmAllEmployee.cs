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
using ProjectComputers.DALL;
using ProjectComputers.GUI;

namespace ProjectComputers.GUI
{
    public partial class frmAllEmployee : Form
    {
        public frmAllEmployee()
        {
            InitializeComponent();
            dgvAllEmployee.DataSource = MyTable.EmployeeTable.GetList().Where(x => x.Status).Select(x => new { x.EmployeeId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity() + " " + x.Num, x.Phone, type = x.GetTypeWorker() }).ToList();
            dgvAllEmployee.Columns[0].HeaderText = "תעודת זהות";
            dgvAllEmployee.Columns[1].HeaderText = "שם";
            dgvAllEmployee.Columns[2].HeaderText = "כתובת";
            dgvAllEmployee.Columns[4].HeaderText ="סוג עובד" ;
            dgvAllEmployee.Columns[3].HeaderText = "טלפון";
        }
        void Refreashed()
        {
            dgvAllEmployee.DataSource = MyTable.EmployeeTable.GetList();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dgvAllEmployee.DataSource = MyTable.EmployeeTable.GetList().Where(x => x.Status && (x.LastName + " " + x.FirstName).Contains(txtName.Text) && x.Phone.IndexOf(txtPhone.Text) == 0).Select(x => new { x.EmployeeId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity().CityName + " "+x.Num, x.Phone, type = x.GetTypeWorker() }).ToList();
            dgvAllEmployee.Columns[0].HeaderText = "תעודת זהות";
            dgvAllEmployee.Columns[1].HeaderText = "שם";
            dgvAllEmployee.Columns[2].HeaderText = "כתובת";
            dgvAllEmployee.Columns[3].HeaderText = "טלפון";
            dgvAllEmployee.Columns[4].HeaderText = "סוג עובד";

        }

        private void btnAddEm_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            dgvAllEmployee.DataSource = MyTable.EmployeeTable.GetList().Where(x => x.Status && (x.LastName + " " + x.FirstName).Contains(txtName.Text) && x.Phone.IndexOf(txtPhone.Text) == 0).Select(x => new { x.EmployeeId, fullName = x.FirstName + " " + x.LastName,  fullAdress = x.Address + " " + x.GetCity().CityName + " "+ x.Num,  x.Phone, type = x.GetTypeWorker() }).ToList();
            dgvAllEmployee.Columns[0].HeaderText = "תעודת זהות";
            dgvAllEmployee.Columns[1].HeaderText = "שם";
            dgvAllEmployee.Columns[2].HeaderText = "כתובת";
            dgvAllEmployee.Columns[3].HeaderText = "טלפון";
            dgvAllEmployee.Columns[4].HeaderText = "סוג עובד";
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void dgvAllEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Employee em = MyTable.EmployeeTable.GetList().FirstOrDefault(x => x.EmployeeId == dgvAllEmployee.CurrentRow.Cells[0].Value.ToString());
            if (em != null)
            {
                frmEmployee frm = new frmEmployee(em);
                frm.Show();
                this.Close();
            }
        }

        private void tsAddEm_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.Show();
            this.Close();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            dgvAllEmployee.DataSource = MyTable.EmployeeTable.GetList().Where(x => x.Status && (x.LastName + " " + x.FirstName).Contains(txtName.Text) && x.Phone.IndexOf(txtPhone.Text) == 0 && x.GetCity().CityName.IndexOf(txtCity.Text) == 0).Select(x => new { x.EmployeeId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity().CityName + " " + x.Num, x.Phone, type = x.GetTypeWorker() }).ToList();
            dgvAllEmployee.Columns[0].HeaderText = "תעודת זהות";
            dgvAllEmployee.Columns[1].HeaderText = "שם";
            dgvAllEmployee.Columns[2].HeaderText = "כתובת";
            dgvAllEmployee.Columns[3].HeaderText = "טלפון";
            dgvAllEmployee.Columns[4].HeaderText = "סוג עובד";
        }

        private void btnVeiw_Click(object sender, EventArgs e)
        {
            dgvAllEmployee.DataSource = MyTable.EmployeeTable.GetList().Where(x => x.Status).Select(x => new { x.EmployeeId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity() + " " + x.Num, x.Phone,type= x.GetTypeWorker()}).ToList();
            dgvAllEmployee.Columns[0].HeaderText = "תעודת זהות";
            dgvAllEmployee.Columns[1].HeaderText = "שם";
            dgvAllEmployee.Columns[2].HeaderText = "כתובת";
            dgvAllEmployee.Columns[4].HeaderText = "סוג עובד";
            dgvAllEmployee.Columns[3].HeaderText = "טלפון";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee em = MyTable.EmployeeTable.GetList().FirstOrDefault(x => x.EmployeeId == dgvAllEmployee.CurrentRow.Cells[0].Value.ToString());
            if (em != null)
            {
                frmEmployee frm = new frmEmployee(em);
                frm.Show();
                this.Close();
            }
        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee em = MyTable.EmployeeTable.GetList().FirstOrDefault(x => x.EmployeeId == dgvAllEmployee.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("התרעה על מחיקה", "האם ברצונך למחוק?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                em.Status = false;
                MyTable.EmployeeTable.Update(em);
                MyTable.EmployeeTable.Save();
                //רענון
                dgvAllEmployee.DataSource = MyTable.EmployeeTable.GetList().Where(x => x.Status).Select(x => new { x.EmployeeId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity() + " " + x.Num, x.Phone, type = x.GetTypeWorker() }).ToList();
                dgvAllEmployee.Columns[0].HeaderText = "תעודת זהות";
                dgvAllEmployee.Columns[1].HeaderText = "שם";
                dgvAllEmployee.Columns[2].HeaderText = "כתובת";
                dgvAllEmployee.Columns[4].HeaderText = "סוג עובד";
                dgvAllEmployee.Columns[3].HeaderText = "טלפון";

            }
            else
                MessageBox.Show("המחיקה בוטלה");
        }
    }
}
