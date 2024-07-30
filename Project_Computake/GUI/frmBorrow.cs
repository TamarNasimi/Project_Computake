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
    public partial class frmBorrow : Form
    {
        public frmBorrow()
        {
            InitializeComponent();
        }
        public frmBorrow(Product p,int count)
        {
            InitializeComponent();
           // label3.Text = count.ToString();
            for (int i = 0; i < count ; i++)
            {
                ucOrderBorrow uc = new ucOrderBorrow(p);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
