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
    public partial class frmPassword : Form
    {
        public Employee em;
        public static string emId;
        public frmPassword()
        {
            InitializeComponent();
            txtPassword.Focus();
            em = new Employee();
            pictureBox2.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            em = MyTable.EmployeeTable.GetList().FirstOrDefault(x => x.EmployeeId == txtPassword.Text);
            if (em == null)
            {
                MessageBox.Show("שגיאה, נסה שנית!");
                txtPassword.Clear();
            }
            else
            {
                emId = em.EmployeeId;
                MessageBox.Show("שלום לך" + " " + em.FirstName +" "+ em.LastName );
                frmMain frm = new frmMain(em);
                frm.Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }
    }
}
