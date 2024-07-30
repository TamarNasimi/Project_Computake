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
    public partial class UcOrderTotal : UserControl
    {
        public static Product pro;
        OrderDetail or;
        Borrow b;
        Label l;
        int codeSellOrRent;
        public UcOrderTotal() { }

        public UcOrderTotal(OrderDetail p, Label l,int code)

        {
            InitializeComponent();
            or = p;
            this.codeSellOrRent = code;
            this.l = l;
            pro = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == p.ProductId);
           
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\" + pro.ProductPicture);
            lblName.Text = pro.ProductName.ToString();
            lblNumP1.Text = p.CounttOrder.ToString();
            lblPriceCount.Text = (pro.PriceTotal * p.CounttOrder).ToString();
            if (pro.CountinStock <= 0)
            {
                lblCountStock.Visible = true;
                btnAdd.Enabled = false;
                btnLess.Enabled = false;
            }
        }
        public UcOrderTotal(Borrow p, Label l, int code)

        {
            InitializeComponent();
            b = p;
            this.codeSellOrRent = code;
            this.l = l;
            int o1 = 0;
            pro = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == p.ProductId);
            if (pro.CountinStock == 0)
            {
                lblCountStock.Visible = true;
                btnAdd.Enabled = false;
                btnLess.Enabled = false;
            }
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\" + pro.ProductPicture);
            lblName.Text = pro.ProductName.ToString();
            label2.Text = "מס' ימים להשאלה";
            lblNumP1.Text = b.CountDay.ToString();
            lblPriceCount.Text = (pro.PriceHour * p.CountDay).ToString();
            if (Convert.ToInt32(lblNumP1.Text) == 0)
            {
                btnLess.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        public int GetTotalPrice()
        {
            return Convert.ToInt32(lblPriceCount.Text);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UcProduct.countP <= Convert.ToInt32(lblNumP1.Text))
            {
                lblCountStock.Visible = true;
                btnAdd.Enabled = false;
            }
            else
            {
                lblNumP1.Text = (Convert.ToInt32(lblNumP1.Text) + 1).ToString();

                lblPriceCount.Text = (pro.PriceTotal * Convert.ToInt32(lblNumP1.Text)).ToString();
                btnLess.Visible = true;


                if (codeSellOrRent == 1)
                {
                    or.CounttOrder++;
                    MyTable.OrderDetailTable.Update(or);
                    MyTable.OrderDetailTable.Save();

                }
                else
                {
                    b.CountDay++;
                    MyTable.BorrowTable.Update(b);
                    MyTable.BorrowTable.Save();
                }
                l.Text = (Convert.ToInt32(l.Text) + pro.PriceTotal).ToString();

            }
        }
        private void btnLess_Click(object sender, EventArgs e)
        {
         
            if (Convert.ToInt32(lblNumP1.Text) == 1)
            {
                btnLess.Visible = false;
            }
            if (pro.CountinStock != 0)
            {
                lblCountStock.Visible = false;
                btnAdd.Enabled = true;
                lblNumP1.Text = (Convert.ToInt32(lblNumP1.Text) - 1).ToString();
                lblPriceCount.Text = (Convert.ToInt32(lblNumP1.Text) * pro.PriceTotal).ToString();
                if (codeSellOrRent == 1)
                {
                    or.CounttOrder--;
                    MyTable.OrderDetailTable.Update(or);
                    MyTable.OrderDetailTable.Save();

                }
                else
                {
                    b.CountDay--;
                    MyTable.BorrowTable.Update(b);
                    MyTable.BorrowTable.Save();
                }
                l.Text = (Convert.ToInt32(l.Text) - pro.PriceTotal).ToString();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           pictureBox2.Parent.Parent.Controls.Remove(this);
            int totalPrice = Convert.ToInt32(l.Text) - Convert.ToInt32(lblPriceCount.Text);
            l.Text = totalPrice.ToString();
            if (codeSellOrRent == 1)
            {
                MyTable.OrderDetailTable.Delete(or);
                MyTable.OrderDetailTable.Save();
            }
            else
            {
                MyTable.BorrowTable.Delete(b);
                MyTable.BorrowTable.Save();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
