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
    public partial class frmOrderBorrow : Form
    {
        UcProduct uc;

        ProductTable tblP = new ProductTable();
       public static Product p;
        public static Order or;
        public static DateTime date;
        public static int orderId;

        public frmOrderBorrow()
        {
            InitializeComponent();
            orderId = MyTable.OrderTable.Next();
            or = new Order();
            p = new Product();
            or.OrderId = orderId;
            or.EmployeeId = frmPassword.emId;
            or.OrderDate = DateTime.Today;
            or.Price = 0;
            or.Status = false;
            or.CodeCategory = 1;
            or.CodePaying = 1;
            MyTable.OrderTable.Add(or);
            MyTable.OrderTable.Save();
            date = or.OrderDate;
            foreach (Product p in tblP.GetList().Where(x => x.SellOrRent == 1).ToList())
            {
                uc = new UcProduct(p, flowLayoutPanel2);
                flowLayoutPanel1.Controls.Add(uc);
            }
            label2.Text = orderId.ToString();
        }

        private void AcerCompany_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 6)
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.SellOrRent == 2)
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }
        private void rbComputerRent_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if ((p.CategoryPrId == 1) && (p.SellOrRent == 1))
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void rbprojectorRent_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if ((p.CategoryPrId == 2) && (p.SellOrRent == 1))
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void ColorBlack_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.ColorCode == 2)
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
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
                    uc = new UcProduct(p, flowLayoutPanel2);
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
                    uc = new UcProduct(p, flowLayoutPanel2);
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
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void LenovoCompany_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 1)
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void HPCompany_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 2)
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void DellCompany_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 3)
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void AsusCompany_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 4)
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void AppleCompany_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Product p in tblP.GetList())
            {
                if (p.CompanyProductCode == 5)
                {
                    uc = new UcProduct(p, flowLayoutPanel2);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void btnClearFiltering_Click(object sender, EventArgs e)
        {
            rbComputerRent.Checked = false;
            rbprojectorRent.Checked = false;
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
            foreach (Product p in tblP.GetList())
            {
                uc = new UcProduct(p, flowLayoutPanel2);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ucOrderBorrow.br == null)
                MessageBox.Show("לא בחרת מוצר");
            else
            {
                frmOrderTotal frm = new frmOrderTotal(orderId, 2, or);
                frm.Show();
                this.Hide();
            }
        }

        private void frmOrderBorrow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("האם לסגור את הטופס בכל אופן ,הינך באמצע פעולה.  שים לב! אם תסגר את הטופס , הזמנתך לא תשמר?", "סגירה", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                List<Borrow> lst = MyTable.BorrowTable.GetList().Where(x => x.OrderId == or.OrderId).ToList();
                foreach (Borrow br in lst)
                {
                    MyTable.BorrowTable.Delete(br);
                    MyTable.BorrowTable.Save();
                }
                MyTable.OrderTable.Delete(or);
                MyTable.OrderTable.Save();
            }
            else
                e.Cancel = true;
        }
       
private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Product> lstP = MyTable.ProductTable.GetList().Where(x => x.ProductName.Contains(textBox1.Text) && x.SellOrRent == 1).ToList();
            flowLayoutPanel1.Controls.Clear();
            foreach (Product p in lstP)
            {
                {
                    uc = new UcProduct(p);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "לחיפוש הקש שם מוצר")
                textBox1.Text = "";
        }
    }
}
