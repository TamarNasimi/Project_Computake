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
   
    public partial class ucOrderBorrow : UserControl
    {
        public Product prod;
        OrderDetail or;
        Product p;
        public static Borrow br;
        public static int countBr;
        public ucOrderBorrow()
        {
            InitializeComponent();
            prod = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == p.ProductId);
            lblPriceCount.Text = p.PriceTotal.ToString();
            label1.Text = p.DescribeProduct.ToString();
            btnLess.Visible = false;
            p = new Product();
        }
        public ucOrderBorrow(Product p)
        {
            InitializeComponent();
            prod = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == p.ProductId);
            lblPriceCount.Text = p.PriceTotal.ToString();
            btnLess.Visible = false;
            this.p = p;

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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lblNumP.Text == "0")
                MessageBox.Show("לא בחרת כמות ימים");
            br = new Borrow();
            br.CodeBorrow = MyTable.BorrowTable.Next();
            br.OrderId = frmOrderBorrow.orderId; ;
            br.ProductId = p.ProductId;
            br.CountDay = Convert.ToInt32(lblNumP.Text);
            Borrow br2 = MyTable.BorrowTable.GetList().FirstOrDefault(x => x.CodeBorrow == br.CodeBorrow);
            countBr = Convert.ToInt32(lblNumP.Text);

            if (lblNumP.Text == "0")
                MessageBox.Show("לא בחרת כמות");
            else
            {
                if (br2 == null)
                {
                    MyTable.BorrowTable.Add(br);
                    MyTable.BorrowTable.Save();
                    MessageBox.Show("המוצר נוסף בהצלחה!");
                    this.Controls.Clear();
                }
                else
                {
                    br2.CountDay = Convert.ToInt32(lblNumP.Text);
                    MyTable.BorrowTable.Update(br2);
                    MyTable.BorrowTable.Save();
                    MessageBox.Show("השינויים נשמרו בהצלחה!");
                    this.Controls.Clear();
                }
            }
            

        }
    }
}
