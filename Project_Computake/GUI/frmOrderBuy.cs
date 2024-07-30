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
    public partial class frmOrderBuy : Form
    {
        UcProduct uc;
        ProductTable tblP = new ProductTable();
        public static Product p;
        public static Order or;
       public static int orderId;
       public static int countP;
        public frmOrderBuy()
        {
            InitializeComponent();
            orderId = MyTable.OrderTable.Next();
            or = new Order();
            p = new Product();
            or.OrderId = frmOrderBuy.orderId;
            or.EmployeeId = frmPassword.emId;
            or.OrderDate = DateTime.Today;
            or.Price = 0;
            or.CodeCategory = 2;
            or.CodePaying = 1;
            or.Status = true;
            MyTable.OrderTable.Add(or);
            MyTable.OrderTable.Save();
            foreach (Product p in tblP.GetList().Where(x=> x.SellOrRent==2).ToList())
            {
                uc = new UcProduct(p);
                flowLayoutPanel1.Controls.Add(uc);
            }
            label2.Text = orderId.ToString();
        }

        public void Save()
        {
            MyTable.OrderTable.Add(or);
            MyTable.OrderTable.Save();
        }
       
        private void btnOrderOk_Click(object sender, EventArgs e)
        {
            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                uc = new UcProduct(p);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                uc = new UcProduct(p);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void rbComputerRent_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if ((p.CategoryPrId == 1)&&(p.SellOrRent==1))
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbprojectorRent_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())

            {
                if ((p.CategoryPrId == 2)&& (p.SellOrRent == 1))
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbSell_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())

            {
                if (p.SellOrRent == 2)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbComputerSell_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())

            {
                if ((p.CategoryPrId == 1) && (p.SellOrRent == 2))
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbprojectorSell_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())

            {
                if ((p.CategoryPrId == 2) && (p.SellOrRent == 2))
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorBlack_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.ColorCode==1)
                {
                    uc = new UcProduct(p);
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

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.CompanyProductCode == 1)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.CompanyProductCode == 2)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.CompanyProductCode == 3)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.CompanyProductCode == 4)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.CompanyProductCode == 5)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.CompanyProductCode == 6)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorBlack_CheckedChanged_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.ColorCode == 2)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorSilver_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.ColorCode == 3)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorWhite_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.ColorCode == 1)
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorGold_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                if (p.ColorCode == 4)
                {
                    uc = new UcProduct(p);
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
            rbComputerSell.Checked = false;
            rbprojectorSell.Checked = false;
            ColorBlack.Checked = false;
            ColorGold.Checked = false;
            ColorWhite.Checked = false;
            ColorSilver.Checked = false;
            AppleCompany.Checked = false;
            AcerCompany.Checked = false;
            HPCompany.Checked = false;
            LenovoCompany.Checked = false;
            DellCompany.Checked = false;
            AsusCompany.Checked = false;
            flowLayoutPanel1.Controls.Clear();
            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 2).ToList())
            {
                uc = new UcProduct(p);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            List<Product> lstP = MyTable.ProductTable.GetList().Where(x => x.ProductName.Contains(textBox1.Text) && x.SellOrRent == 2).ToList();
            flowLayoutPanel1.Controls.Clear();
            foreach (Product p in lstP)
            {
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (UcProduct.ord == null)
                MessageBox.Show("לא בחרת מוצר");
            else
            {
                frmOrderTotal frm = new frmOrderTotal(orderId, 1, or);
                frm.Show();
                this.Hide();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void frmOrderBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("האם לסגור את הטופס בכל אופן ,הינך באמצע פעולה.  שים לב! אם תסגר את הטופס , הזמנתך לא תשמר?", "סגירה", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                List<OrderDetail> lst = MyTable.OrderDetailTable.GetList().Where(x => x.OrderId == or.OrderId).ToList();
                foreach (OrderDetail ord2 in lst)
                {
                    p = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == ord2.ProductId);
                    countP += ord2.CounttOrder;
                    MyTable.ProductTable.Update(p);
                    MyTable.ProductTable.Save();
                    MyTable.OrderDetailTable.Delete(ord2);
                    MyTable.OrderDetailTable.Save();

                }

                MyTable.OrderTable.Delete(or);
                MyTable.OrderTable.Save();

            }

            else
                e.Cancel = true;

        }
         
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "לחיפוש הקש שם מוצר")
                textBox1.Text = "";
        }
    }
}
