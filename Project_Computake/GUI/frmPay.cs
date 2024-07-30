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
using ProjectComputers.DALL;

namespace ProjectComputers.GUI
{
    public partial class frmPay : Form
    {
        CreditCard creditCard;

        public frmPay()
        {
            InitializeComponent();
        }
        public frmPay(string pricePay, string namePay)
        {
            InitializeComponent();
            lblPrice.Text = pricePay;
            lblName.Text = namePay;
            rbCash.Checked = false;
            rbCredit.Checked = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }
        public bool Check1()
        {
            bool flag = true;
            errorProvider1.Clear();
            if (frmOrderTotal.codeBuy==2)
            {
                if (rbCash.Checked)
                {
                    frmOrderBuy.or.CodePaying = 1;
                    return flag = true;
                }
                else
                    if (rbCredit.Checked)
                {
                    frmOrderBuy.or.CodePaying = 2;
                    return flag = true;
                }

                else
                {
                    MessageBox.Show("לא בחרת את סוג התשלום"); 
                    return flag = false;
                }
            }
            else
            {
                if (rbCash.Checked)
                {
                    frmOrderBorrow.or.CodePaying = 1;
                    return flag = true;
                }
                else
                   if (rbCredit.Checked)
                {
                    frmOrderBorrow.or.CodePaying = 2;
                    return flag = true;
                }

                else
                {
                    MessageBox.Show("לא בחרת את סוג התשלום");
                    return flag = false;
                }
            }
        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (frmOrderTotal.codeBuy == 2)
            {
                if (check2())
                {
                    frmOrderBuy.or.CodePaying = 2;
                    CreditCard cr = MyTable.CreditCardTable.GetList().FirstOrDefault(x => x.NumCard == creditCard.NumCard);
                    if (cr != null)
                        MessageBox.Show("כרטיס אשראי קיים במערכת, התשלום בוצע בהצלחה");
                    else
                    {
                        MyTable.CreditCardTable.Add(creditCard);
                        MyTable.CreditCardTable.Save();
                    }
                    MyTable.OrderTable.Update(frmOrderBuy.or);
                    MyTable.OrderTable.Save();
                 
                    label2.Visible = true;
                    label1.Visible = false;
                    lblName.Visible = false;
                    label5.Visible = false;
                    lblPrice.Visible = false;
                    label3.Visible = false;
                    rbCash.Visible = false;
                    rbCredit.Visible = false;
                    groupBox1.Visible = false;
                    btnOk.Visible = false;
                    btnSave.Visible = false;
                }
                else
                {
                    //MyTable.CreditCardTable.Update(creditCard);
                    //MyTable.CreditCardTable.Save();
                }
            }
            else
            {
                if (check2())
                {
                    frmOrderBorrow.or.CodePaying = 2;
                    MyTable.CreditCardTable.Add(creditCard);
                    MyTable.CreditCardTable.Save();
                    MyTable.OrderTable.Update(frmOrderBorrow.or);
                    MyTable.OrderTable.Save();
                    frmOrderBorrow.p.Status = false;
                    frmOrderBorrow.p.CountinStock--;
                    MyTable.ProductTable.Update(frmOrderBorrow.p);
                    MyTable.ProductTable.Save();
                    label2.Visible = true;
                    label2.Visible = true;
                    label1.Visible = false;
                    lblName.Visible = false;
                    label5.Visible = false;
                    lblPrice.Visible = false;
                    label3.Visible = false;
                    rbCash.Visible = false;
                    rbCredit.Visible = false;
                    groupBox1.Visible = false;
                    btnOk.Visible = false;
                    btnSave.Visible = false;

                }
                else
                {
                    MyTable.CreditCardTable.Update(creditCard);
                    MyTable.CreditCardTable.Save();
                }
            }
        }

        public bool check2()
        {
            creditCard = new CreditCard();
            errorProvider1.Clear();
            bool flag = true;
            try
            {
                creditCard.CusNumCard = txtId.Text;
            }

            catch (Exception ex)
            {
                flag = false;


                errorProvider1.SetError(txtId, ex.Message);
            }

            try
            {
                creditCard.NumCard = txtNumCard.Text;
            }



            catch (Exception ex)
            {
                flag = false;


                errorProvider1.SetError(txtNumCard, ex.Message);
            }
            try
            {
                creditCard.Cvv = Convert.ToInt32(txtCVV.Text);
            }



            catch (Exception ex)
            {
                flag = false;


                errorProvider1.SetError(txtCVV, ex.Message);
            }
            try
            {
                creditCard.DateCard = dateCard.Value;
            }



            catch (Exception ex)
            {
                flag = false;


                errorProvider1.SetError(dateCard, ex.Message);
            }

            try
            {
                if (numericUpDown1.Value > 0 && numericUpDown1.Value <= 3)
                    creditCard.NumPayment = NumericUpDown.ScrollStateAutoScrolling;
                else
                    throw new Exception("עליך לבחור עד 3 תשלומים");
            }



            catch (Exception ex)
            {
                flag = false;


                errorProvider1.SetError(numericUpDown1, ex.Message);
            }
            return flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if ((frmOrderBuy.or.CodeCategory == 2) || (frmOrderBorrow.or.CodeCategory ==2))
            if(frmOrderTotal.codeBuy==2)
            {
                if (Check1())
                {
                    frmOrderBuy.or.Status = true;
                    MyTable.OrderTable.Update(frmOrderBuy.or);
                    MyTable.OrderTable.Save();                   
                    label2.Visible = true;
                    label1.Visible = false;
                    lblName.Visible = false;
                    label5.Visible = false;
                    lblPrice.Visible = false;
                    label3.Visible = false;
                    rbCash.Visible = false;
                    rbCredit.Visible = false;
                    groupBox1.Visible = false;
                    btnOk.Visible = false;
                    btnSave.Visible = false;
                    groupBox2.Visible = false;
                }
            }
            else
            {
               
                if (Check1())
                {
                    frmOrderBorrow.or.Status = true;
                    MyTable.OrderTable.Update(frmOrderBorrow.or);
                    MyTable.OrderTable.Save();
                    label2.Visible = true;
                    label1.Visible = false;
                    lblName.Visible = false;
                    label5.Visible = false;
                    lblPrice.Visible = false;
                    label3.Visible = false;
                    rbCash.Visible = false;
                    rbCredit.Visible = false;
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                    btnOk.Visible = false;
                    btnSave.Visible = false;
                }
            }
           
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (validation.IsHebrew(textBox1.Text))
                MessageBox.Show("עליך להכניס מספרים בלבד");
            else
            {
                if (Convert.ToInt32(textBox1.Text) < Convert.ToInt32(lblPrice.Text))
                    MessageBox.Show("אין באפשרותך להכניס מחיר זה.");
                else
                {
                    int sum2 = 0;
                    int sum1 = 0;
                    button1.Visible = true;
                    sum1 = Convert.ToInt32(textBox1.Text);
                    sum2 = sum1 - Convert.ToInt32(lblPrice.Text);
                    button1.Visible = true;
                    button1.Text = "עודף:  ";
                    label10.Text = sum2.ToString(); ;
                }
            }
        }

        private void txtNumCard_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNumCard.Text == "0000 0000 0000 0000")
                txtNumCard.Text = "";
        }
    } 
}
