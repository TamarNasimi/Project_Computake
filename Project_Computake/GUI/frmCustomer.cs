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
    public partial class frmCustomer : Form
    {
        public Customer c;
        public static string status;
        public static string cusId;
        public frmCustomer()
        {
            InitializeComponent();
            btnSave.Text = "הוסף";
            c = new Customer();//בניית אוביקט ריק
            cmbCity.DataSource = MyTable.CityTable.GetList();//הצגת טבלת ערים
            cmbCity.SelectedItem = null;//שהערך הראשון מטבלת ערים לא יוצג
            status = "add";//הטופס כרגע במצב הוספת לקוח
        }

        public frmCustomer(string cusId)
        {
            InitializeComponent();
            c = new Customer();
            txtId.Enabled = false;
            txtId.Text=cusId;
            btnSave.Text = "הוסף";
            cmbCity.DataSource = MyTable.CityTable.GetList();
            cmbCity.SelectedItem = null;
            status = "add";
        }

        public frmCustomer(Customer c)
        {
            InitializeComponent();
            this.c = c;
            cmbCity.DataSource = MyTable.CityTable.GetList();
            cmbCity.SelectedItem = null;
            txtId.ReadOnly = true;
            status = "update";
            fillTextBox();

        }
        void fillTextBox()
        {
            txtId.Text = c.CustomerId;
            txtLastName.Text = c.LastName;
            txtFirstName.Text = c.FirstName;
            txtAddress.Text = c.Address;
            txtNum.Text = c.Num.ToString();
            txtPhone.Text = c.Phone;
            cmbCity.SelectedItem = c.GetCity();
            

        }

        private void btnAddCity_Click_1(object sender, EventArgs e)
        {
            frmAllCity frm = new frmAllCity("AddToForm");
            frm.ShowDialog();
            cmbCity.DataSource = MyTable.CityTable.GetList();
            cmbCity.SelectedItem = frm.c2;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (Check2())
            {
                if (status == "add")
                {
                    c.Status = true;
                    MyTable.CustomerTable.Add(c);
                    MyTable.CustomerTable.Save();
                    MessageBox.Show("נוספת בהצלחה למאגר הלקוחות שלנו! ");
                    this.Close();
                }
                else
                {
                  
                    MyTable.CustomerTable.Update(c);
                    MyTable.CustomerTable.Save();
                    MessageBox.Show("השינויים נשמרו בהצלחה!! ");
                    this.Close();
                }

            }
        }

        public bool Check2()
        {
            bool flag = true;
            errorProvider1.Clear();
            try
            {
                c.CustomerId = txtId.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtId, ex.Message);
                txtId.Enabled = true;
            }
            
            try
            {
                c.LastName = txtLastName.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtLastName, ex.Message);
            }
           
            try
            {
                c.FirstName = txtFirstName.Text;
            }
           
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtFirstName, ex.Message);
            }
            
            try
            {
                c.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtAddress, ex.Message);
            }


            try
            {
                c.Num = Convert.ToInt32(txtNum.Text);
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtNum, ex.Message);
            }
          
            if (cmbCity.SelectedItem != null)
                c.CityId = ((City)cmbCity.SelectedItem).CityId;
            else
            {
                errorProvider1.SetError(cmbCity, "לא נבחרה עיר");
                flag = false;
            }
            
            try
            {
                c.Phone = txtPhone.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtPhone, ex.Message);
            }
           
           
            return flag;
        }
      

        private void frmCustomer_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (status == "add")
            {
                if (MessageBox.Show("הינך באמצע פעולה, האם לסגור את הטופס בכל אופן?", "סגירה", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }
            else
            {
                if (Check3())
                    {
                        if (MessageBox.Show("האם לסגור את הטופס?", "סגירה", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
                }
                else
                    if (MessageBox.Show("הינך באמצע פעולה, האם לסגור את הטופס?", "סגירה", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }

        }
        bool Check3()
        {
            if (cmbCity.Text == "")
                return false;
            return c.CityId == ((City)cmbCity.SelectedItem).CityId && c.FirstName == txtFirstName.Text && c.Phone == cmbCity.Text && c.Address == cmbCity.Text;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}