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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text += " " + DateTime.Today.ToShortDateString();
            toolStripStatusLabel1.Text += " " + DateTime.Now.ToShortTimeString();
        }

        private void EmployeeEnter_Click(object sender, EventArgs e)
        {
            frmPassword frm = new frmPassword();
            frm.Show();
        }

        private void CustomerEnter_Click(object sender, EventArgs e)
        {
            frmOrderBuy frm = new frmOrderBuy();
            frm.Show();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
