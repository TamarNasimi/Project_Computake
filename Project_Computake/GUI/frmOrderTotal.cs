using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComputers.GUI;
using ProjectComputers.BLL;
using ProjectComputers.DALL;

namespace ProjectComputers.GUI
{
    public partial class frmOrderTotal : Form
    {
        UcProduct uc;
        public static string cusId;
        public static int sum;
        public static int codeBuy;
        public static DateTime date;
        Product p;
        Order or;
        string status;
        public frmOrderTotal(int idorder,int code, Order or)
        {
            InitializeComponent();
            int sum = 0;
            this.or = or;
            p = new Product();
            if (code == 1)
            {
                codeBuy=2;
                List<OrderDetail> lst = MyTable.OrderDetailTable.GetList().Where(X => X.OrderId == idorder).ToList();
                foreach (OrderDetail od in lst)
                {
                        UcOrderTotal uc = new UcOrderTotal(od, label4, code);
                    flowLayoutPanel1.Controls.Add(uc);
                    sum += uc.GetTotalPrice();
                }
            }
            else
            {
                codeBuy = 1;
                label2.Visible = true;
                List<Borrow> lst = MyTable.BorrowTable.GetList().Where(X => X.OrderId == idorder).ToList();
                foreach (Borrow od1 in lst)
                {
                    UcOrderTotal uc = new UcOrderTotal(od1, label4, code);
                    flowLayoutPanel1.Controls.Add(uc);
                    sum += uc.GetTotalPrice();
                }
            }
            label4.Text = sum.ToString();
            
        }

        public frmOrderTotal() { }
        public frmOrderTotal(Product p)
        {
            InitializeComponent();
            uc = new UcProduct(p);
            flowLayoutPanel1.Controls.Add(uc);
        }
        public frmOrderTotal(Order or)
        {
            InitializeComponent();
            status = "show";
            int sum = 0;
            // or = new Order();
            p = new Product();
            txtId.Text = or.CustomerId;
            txtId.Enabled = false;
            if (or.CodeCategory == 2)
            {
                codeBuy = 2;
                List<OrderDetail> lst = MyTable.OrderDetailTable.GetList().Where(X => X.OrderId == or.OrderId).ToList();
                foreach (OrderDetail od in lst)
                {
                    UcOrderTotal uc = new UcOrderTotal(od, label4, or.CodeCategory);
                    flowLayoutPanel1.Controls.Add(uc);
                    sum += uc.GetTotalPrice();
                }
            }
            else
            {
                codeBuy = 1;
                label2.Visible = true;
                List<Borrow> lst = MyTable.BorrowTable.GetList().Where(X => X.OrderId == X.OrderId).ToList();
                foreach (Borrow od1 in lst)
                {
                    UcOrderTotal uc = new UcOrderTotal(od1, label4, or.CodeCategory);
                    flowLayoutPanel1.Controls.Add(uc);
                    sum += uc.GetTotalPrice();
                }
            }
            label4.Text = sum.ToString();
            label4.Enabled = false;
            button1.Visible = false;
            btnPay.Visible = false;
            label2.Visible = false;
            flowLayoutPanel1.Enabled = false;
            label4.Text = or.Price.ToString();

        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            Customer cus = MyTable.CustomerTable.GetList().FirstOrDefault(x => txtId.Text == x.CustomerId);
            if (txtId.Text == "")
                MessageBox.Show(".נא מלא ת.ז. שדה חובה", "שדה חובה");
        
            else
                if (cus == null)
            {
                if (MessageBox.Show("לקוח לא קיים, האם ברצונך להוסיפו למאגר?", "הוסף לקוח", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    frmCustomer frm = new frmCustomer(txtId.Text);
                    frm.Show();
                }
                else
                    MessageBox.Show(" הפעולה בוטלה");
            }
           
            else
            {
                if (codeBuy == 2)
                {
                    frmOrderBuy.or.CustomerId = txtId.Text;
                    
                    frmOrderBuy.or.Price = Convert.ToInt32(label4.Text);
                    frmOrderBuy.or.Status = true;
                    MyTable.OrderTable.Update(frmOrderBuy.or);
                    MyTable.OrderTable.Save();
                    frmPay frm = new frmPay(label4.Text, lblFirstName.Text);
                    frm.Show();
                }
                else
                {
                    frmOrderBorrow.or.CustomerId = txtId.Text;
                    frmOrderBorrow.or.Price = Convert.ToInt32(label4.Text);
                    frmOrderBorrow.or.Status = true;
                    date = frmOrderBorrow.or.OrderDate;
                    MyTable.OrderTable.Update(frmOrderBorrow.or);
                    MyTable.OrderTable.Save();
                    cusId = frmOrderBorrow.or.CustomerId;
                    frmPay frm = new frmPay(label4.Text, lblFirstName.Text);
                    frm.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Customer cus = MyTable.CustomerTable.GetList().FirstOrDefault(x => txtId.Text == x.CustomerId);

            if (txtId.Text == "")
                MessageBox.Show("נא למלא תעודת זהות");
            else
            {

                if (validation.IsHebrew(txtId.Text))
                    MessageBox.Show("מספרים בלבד");
                else
                {
                    if (cus == null)
                    {
                        if (MessageBox.Show("לקוח לא קיים, האם ברצונך להוסיפו למאגר?", "הוסף לקוח", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                        {
                            frmCustomer frm = new frmCustomer(txtId.Text);
                            frm.Show();
                        }

                    }
                    else
                    {
                        groupBox1.Visible = true;
                        lblFirstName.Text = cus.FirstName + " " + cus.LastName;
                        lblPHONE.Text = cus.Phone;
                        lblAddres.Text = cus.Address;
                        lblNum.Text = cus.Num.ToString();
                        lblCity.Text = cus.GetCity().ToString();
                    }
                }
            }

        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOrderBuy frm = new frmOrderBuy();
            frm.Show();
           
        }

        private void frmOrderTotal_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("האם לסגור את הטופס בכל אופן ,הינך באמצע פעולה.  שים לב! אם תסגר את הטופס , הזמנתך לא תשמר?", "סגירה", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;

            else
            {
                if (status != "show")
                {
                    Product p2;
                    List<OrderDetail> lst = MyTable.OrderDetailTable.GetList().Where(x => x.OrderId == or.OrderId).ToList();
                    foreach (OrderDetail ord2 in lst)
                    {
                        p2 = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == ord2.ProductId);
                        p2.CountinStock += ord2.CounttOrder;
                        MyTable.ProductTable.Update(p2);
                        MyTable.ProductTable.Save();
                        MyTable.OrderDetailTable.Delete(ord2);
                        MyTable.OrderDetailTable.Save();
                    }

                    MyTable.OrderTable.Delete(or);
                    MyTable.OrderTable.Save();
                }
            }
        }
        }
    }
       

   
         
