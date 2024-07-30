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
    public partial class UsProduct : UserControl
    {
        public Product p;
        frmOrderBuy frm;
        OrderDetail ord;
        public static int numOrder;
       // Order or;
        public static int countOr;

        public UsProduct()
        {

        }
        public UsProduct(Product p)
        {
            InitializeComponent();
            this.frm = frm;
            this.p = p;
            productPicture1.Image = Image.FromFile(Application.StartupPath + @"\picture\" + p.ProductPicture);
            lblName.Text = p.ProductName.ToString();
            lblPriceCount.Text = p.PriceTotal.ToString();
            label1.Text = p.DescribeProduct.ToString();
            btnLess.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblNumP.Text = (Convert.ToInt32(lblNumP.Text) + 1).ToString();
            btnLess.Visible = true;
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            lblNumP.Text = (Convert.ToInt32(lblNumP.Text) - 1).ToString();
            if (Convert.ToInt32(lblNumP.Text) == 0)
            {
                btnLess.Visible = false;
            }

        }

        private void UsProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            if (lblNumP.Text == "0")
                MessageBox.Show("עליך לבחור כמות");
            else
        {
                ord = new OrderDetail();
                ord.OrderId = frmOrderBuy.orderId; ;
                ord.ProductId = p.ProductId;
                ord.CounttOrder = Convert.ToInt32(lblNumP.Text);
                OrderDetail or2 = MyTable.OrderDetailTable.GetList().FirstOrDefault(x => x.ProductId == p.ProductId && x.OrderId == ord.OrderId);
                countOr = Convert.ToInt32(lblNumP.Text);
                if (or2 == null)
                {
                    MyTable.OrderDetailTable.Add(ord);
                    MyTable.OrderDetailTable.Save();
                    MessageBox.Show("המוצר נוסף בהצלחה!");
                }
                else
                {
                    or2.CounttOrder= Convert.ToInt32(lblNumP.Text);
                    MyTable.OrderDetailTable.Update(or2);
                    MyTable.OrderDetailTable.Save();
                    MessageBox.Show("השינויים נשמרו בהצלחה!");
                }
            }
        }
        public int GetCategory()
        {
            return p.CategoryPrId;
        }

        private void productPicture1_Click(object sender, EventArgs e)
        {

        }
    }
}
