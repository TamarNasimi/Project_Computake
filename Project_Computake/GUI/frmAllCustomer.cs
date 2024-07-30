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

namespace ProjectComputers.GUI
{

    public partial class frmAllCustomers : Form
    {
        public frmAllCustomers()
        {
            InitializeComponent();
            dgvallCustomers.DataSource = MyTable.CustomerTable.GetList().Where(x => x.Status).Select(x => new { x.CustomerId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address +" " + x.GetCity() + " " + x.Num, x.Phone }).ToList();
            dgvallCustomers.Columns[0].HeaderText = "תעודת זהות";
            dgvallCustomers.Columns[1].HeaderText = "שם";
            dgvallCustomers.Columns[2].HeaderText = "כתובת";
            dgvallCustomers.Columns[3].HeaderText = "טלפון";
        }
   
    void Refreashed()
        {
            dgvallCustomers.DataSource = MyTable.CustomerTable.GetList();
        }
     
        private void btnVeiw_Click(object sender, EventArgs e)
        {
            dgvallCustomers.DataSource = MyTable.CustomerTable.GetList().Where(x => x.Status).Select(x => new { x.CustomerId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity() + " "+ x.Num, x.Phone }).ToList();
            dgvallCustomers.Columns[0].HeaderText = "תעודת זהות";
            dgvallCustomers.Columns[1].HeaderText = "שם";
            dgvallCustomers.Columns[2].HeaderText = "כתובת";
            dgvallCustomers.Columns[3].HeaderText = "טלפון";
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dgvallCustomers.DataSource = MyTable.CustomerTable.GetList().Where(x => x.Status && (x.LastName + " " + x.FirstName).Contains(txtName.Text) && x.Phone.IndexOf(txtPhone.Text) == 0).Select(x => new { x.CustomerId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity().CityName + " "+ x.Num, x.Phone }).ToList();
            dgvallCustomers.Columns[0].HeaderText = "תעודת זהות";
            dgvallCustomers.Columns[1].HeaderText = "שם";
            dgvallCustomers.Columns[2].HeaderText = "כתובת";
            dgvallCustomers.Columns[3].HeaderText = "טלפון";
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            dgvallCustomers.DataSource = MyTable.CustomerTable.GetList().Where(x => x.Status && (x.LastName + " " + x.FirstName).Contains(txtName.Text) && x.Phone.IndexOf(txtPhone.Text) == 0).Select(x => new { x.CustomerId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity().CityName + " " + x.Num, x.Phone }).ToList();
            dgvallCustomers.Columns[0].HeaderText = "תעודת זהות";
            dgvallCustomers.Columns[1].HeaderText = "שם";
            dgvallCustomers.Columns[2].HeaderText = "כתובת";
            dgvallCustomers.Columns[3].HeaderText = "טלפון";
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtCity.Text = "";
        }

        private void tsAddCus_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
            this.Close();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            dgvallCustomers.DataSource = MyTable.CustomerTable.GetList().Where(x => x.Status && (x.LastName + " " + x.FirstName).Contains(txtName.Text) && x.Phone.IndexOf(txtPhone.Text) == 0 && x.GetCity().CityName.IndexOf(txtCity.Text) == 0).Select(x => new { x.CustomerId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity().CityName + " " + x.Num, x.Phone }).ToList();
            dgvallCustomers.Columns[0].HeaderText = "תעודת זהות";
            dgvallCustomers.Columns[1].HeaderText = "שם";
            dgvallCustomers.Columns[2].HeaderText = "כתובת";
            dgvallCustomers.Columns[3].HeaderText = "טלפון";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }



        private void מחקToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customer c = MyTable.CustomerTable.GetList().FirstOrDefault(x => x.CustomerId == dgvallCustomers.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("האם ברצונך למחוק?","התראה על מחיקה", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                c.Status = false;
                MyTable.CustomerTable.Update(c);
                MyTable.CustomerTable.Save();
                //רענון
                dgvallCustomers.DataSource = MyTable.CustomerTable.GetList().Where(x => x.Status && (x.LastName + " " + x.FirstName).Contains(txtName.Text) && x.Phone.IndexOf(txtPhone.Text) == 0 && x.GetCity().CityName.IndexOf(txtCity.Text) == 0).Select(x => new { x.CustomerId, fullName = x.FirstName + " " + x.LastName, fullAdress = x.Address + " " + x.GetCity().CityName + " " + x.Num, x.Phone }).ToList();
                dgvallCustomers.Columns[0].HeaderText = "תעודת זהות";
                dgvallCustomers.Columns[1].HeaderText = "שם";
                dgvallCustomers.Columns[2].HeaderText = "כתובת";
                dgvallCustomers.Columns[3].HeaderText = "טלפון";
            }
            else
                MessageBox.Show("המחיקה בוטלה");
        }

        private void עדכןToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customer c = MyTable.CustomerTable.GetList().FirstOrDefault(x => x.CustomerId == dgvallCustomers.CurrentRow.Cells[0].Value.ToString());
            if (c != null)
            {
                frmCustomer frm = new frmCustomer(c);
                frm.Show();
                
            }
        }
    }
}