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
    public partial class UcProduct : UserControl
    {
        public Product p;
        public static OrderDetail ord;
        public static int numOrder;
        public static int countOr;
        public int count;
        FlowLayoutPanel f;
        public static int countP;
        public static int countP1;
        public UcProduct()
        {

        }
        public UcProduct(Product p, FlowLayoutPanel f1)
        {
            InitializeComponent();
            this.f = f1;
            this.p = p;
           
            if (p.CountinStock == 0)
            {
                lblCountStock.Visible = true;
                btnAddPro.Enabled = false;
            }
            productPicture1.Image = Image.FromFile(Application.StartupPath + @"\picture\" + p.ProductPicture);
            lblName.Text = p.ProductName.ToString();
            lblPriceCount.Text = p.PriceHour.ToString();
            label1.Text = p.DescribeProduct.ToString();
            btnLess.Visible = false;
            countP = p.CountinStock;
            label3.Text = p.CountinStock.ToString();
        }
        public UcProduct(Product p)
        {
            InitializeComponent();
            this.p = p;
            if (p.CountinStock == 0)
            {
                lblCountStock.Visible = true;
                btnAddPro.Enabled = false;
            }

            label3.Text = p.CountinStock.ToString();
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
            if (p.CountinStock <= Convert.ToInt32(lblNumP.Text))
            {
                btnAddPro.Enabled = false;
                lblCountStock.Visible = true;
                btnAdd.Enabled = false;
            }
           
        }
       

        private void btnLess_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblNumP.Text) == 0)
            {
                btnLess.Visible = false;
            }
            else
            {
                lblNumP.Text = (Convert.ToInt32(lblNumP.Text) - 1).ToString();
            }

            if (lblCountStock.Visible == true)
            {
                lblCountStock.Visible = false;
                btnAdd.Enabled = true;
            }


        }



        private void btnAddPro_Click(object sender, EventArgs e)
        {
            if (lblNumP.Text == "0")
                MessageBox.Show("לא בחרת כמות");
            else
            {
                if (btnAddPro.Text != "עדכן כמות")
                {
                    if (p.SellOrRent == 1)
                    {
                       
                        count = Convert.ToInt32(lblNumP.Text);
                        for (int i = 0; i < count; i++)
                        {
                            ucOrderBorrow uc = new ucOrderBorrow(p);
                            f.Controls.Add(uc);
                            p.CountinStock--;
                            label3.Text = p.CountinStock.ToString();
                            MyTable.ProductTable.Update(p);
                            MyTable.ProductTable.Save();
                        }
                        countP = count;
                    }



                    else
                    {
                        ord = new OrderDetail();
                        ord.OrderId = frmOrderBuy.orderId; ;
                        ord.ProductId = p.ProductId;
                        ord.CounttOrder = Convert.ToInt32(lblNumP.Text);
                        p.CountinStock -= ord.CounttOrder;

                        countOr = Convert.ToInt32(lblNumP.Text);

                       
                            MyTable.OrderDetailTable.Add(ord);
                            MyTable.OrderDetailTable.Save();
                           
                            countP = p.CountinStock;
                            label3.Text = (Convert.ToInt32(label3.Text) - Convert.ToInt32(lblNumP.Text)).ToString();
                        countP = Convert.ToInt32( label3.Text);
                        countP1 = Convert.ToInt32(lblNumP.Text);
                        MyTable.ProductTable.Update(p);
                            MyTable.ProductTable.Save();
                            MessageBox.Show("המוצר נוסף בהצלחה!");
                            btnAddPro.Text = "עדכן כמות";
                        

                    }
                }
                else
                {
                    OrderDetail or2 = MyTable.OrderDetailTable.GetList().FirstOrDefault(x => x.ProductId == p.ProductId && x.OrderId == ord.OrderId);
                    if (or2 != null)
                    {
                        or2.CounttOrder = Convert.ToInt32(lblNumP.Text);
                        MyTable.OrderDetailTable.Update(or2);
                        MyTable.OrderDetailTable.Save();
                        countP += countP1;
                        countP -= Convert.ToInt32(lblNumP.Text);
                        p.CountinStock = countP;
                        label3.Text = countP.ToString();
                        MyTable.ProductTable.Update(p);
                        MyTable.ProductTable.Save();
                        MessageBox.Show("השינויים נשמרו בהצלחה!");
                    }
                }
                }
           
        }


        public int GetCategory()
        {
            return p.CategoryPrId;
        }

    }
   
}
