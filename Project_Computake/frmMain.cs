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
using ProjectComputers.GUI;

namespace ProjectComputers
{
    public partial class frmMain : Form
    {
        public Employee em;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(Employee em)
        {
            InitializeComponent();
          this.em = em;
            label2.Text = em.FirstName + " " + em.LastName;
        }



        private void הצגהזמנותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderBorrow frm = new frmOrderBorrow();
            frm.Show();
        }

        private void הוסףToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOrderBuy frm = new frmOrderBuy();
            frm.Show();
        }

        private void הצגהזמנותToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAllOrder frm = new frmAllOrder();
            frm.Show();
        }

        private void החזרתמוצרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnProduct frm = new frmReturnProduct();
            frm.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        
        private void הוסףלקוחToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
        }

        private void הצגלקוחותToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAllCustomers frm = new frmAllCustomers();
            frm.Show();
        }

        private void הוסףעובדToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.Show();
        }

        private void הצגעובדיםToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAllEmployee frm = new frmAllEmployee();
            frm.Show();
        }

        private void הוסףמוצרToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void הצגמוצריםToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAllProduct frm = new frmAllProduct();
            frm.Show();
        }

        private void הToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllCity frm = new frmAllCity();
            frm.Show();
        }
    }
}
