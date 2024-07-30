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

namespace ProjectComputers.GUI
{
    public partial class frmOrder : Form
    {
        UsProduct uc;
        
        ProductTable tblP = new ProductTable();
        Product p;
        public Order or;

        public frmOrder()
        {
            InitializeComponent();
          foreach(Product p in tblP.GetList())
          {
               uc = new UsProduct(p);
                flowLayoutPanel1.Controls.Add(uc);
          }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void btnOrderOk_Click(object sender, EventArgs e)
        {
           
        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.SellOrRent == 1)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void frmOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOrderFinish_Click_1(object sender, EventArgs e)
        {
            frmOrderTotal frm = new frmOrderTotal();
            frm.Show();
            //שמירת הזמנה בטבלת order

            // or = new Order();
            //or.CustomerId =
            //     or.EmployeeId =
            or.OrderId = UsProduct.numOrder;
           // or;
        }

        private void rbComputerRent_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
           
            foreach (Product p in tblP.GetList())
            {
                if ((p.CategoryPrId == 1)&&(p.SellOrRent==1))
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbprojectorRent_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if ((p.CategoryPrId == 2)&& (p.SellOrRent == 1))
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbSell_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.SellOrRent == 2)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbComputerSell_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if ((p.CategoryPrId == 1) && (p.SellOrRent == 2))
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbprojectorSell_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if ((p.CategoryPrId == 2) && (p.SellOrRent == 2))
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorBlack_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.ColorCode==1)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ColorBlack.Visible = true;
            ColorSilver.Visible = true;
            ColorWhite.Visible = true;
            ColorGold.Visible = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 1)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 2)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 3)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 4)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 5)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 6)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorBlack_CheckedChanged_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.ColorCode == 2)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorSilver_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.ColorCode == 3)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorWhite_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.ColorCode == 1)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorGold_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.ColorCode == 4)
                {
                    uc = new UsProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LenovoCompany.Visible = true;
            HPCompany.Visible = true;
            DellCompany.Visible = true;
            AppleCompany.Visible = true;
            AsusCompany.Visible = true;
            AcerCompany.Visible = true;
        }

        private void btnClearFiltering_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Product p in tblP.GetList())
            {
                uc = new UsProduct(p);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }
    }
}
