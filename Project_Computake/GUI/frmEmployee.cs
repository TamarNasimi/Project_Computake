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
    public partial class frmEmployee : Form
    {
        Employee em;
       public static string status;
        public frmEmployee()
        {
            InitializeComponent();
            txtId.Focus();
            btnSave.Text = "הוסף";
            em = new Employee();//בניית אוביקט ריק
            cmbCity.DataSource = MyTable.CityTable.GetList();//הצגת טבלת ערים
            cmbCity.SelectedItem = null;//שהערך הראשון מטבלת ערים לא יוצג
            status = "add";//הטופס כרגע במצב הוספת לקוח
            cmbEmployeeType.DataSource = MyTable.TypeOfEmployeeTable.GetList();
            cmbEmployeeType.SelectedItem = null;
        }

        public frmEmployee(Employee em)
        {
            InitializeComponent();
            this.em = em;
            cmbCity.DataSource = MyTable.CityTable.GetList();
            cmbCity.SelectedItem = null;
            cmbEmployeeType.DataSource = MyTable.TypeOfEmployeeTable.GetList();
            cmbEmployeeType.SelectedItem = null;
            txtId.ReadOnly = true;
            status = "update";
            fillTextBox();

        }
        void fillTextBox()
        {
            txtId.Text = em.EmployeeId;
            txtLastName.Text = em.LastName;
            txtFirstName.Text = em.FirstName;
            txtAddress.Text = em.Address;
            txtNum.Text = em.Num.ToString();
            txtPhone.Text = em.Phone;
            cmbEmployeeType.SelectedItem = em.GetTypeWorker();
            cmbCity.SelectedItem = em.GetCity();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check2())
            {
                if (status == "add")
                {
                    em.Status = true;
                    MyTable.EmployeeTable.Add(em);
                    MyTable.EmployeeTable.Save();
                    MessageBox.Show("נוספת בהצלחה למאגר העובדים שלנו! ");
                    this.Close();
                }
                else
                {
                    MyTable.EmployeeTable.Update(em);
                    MyTable.EmployeeTable.Save();
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
                em.EmployeeId = txtId.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtId, ex.Message);
            }
            try
            {
                em.LastName = txtLastName.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtLastName, ex.Message);
            }
            try
            {
                em.FirstName = txtFirstName.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtFirstName, ex.Message);
            }
            try
            {
                em.Phone = txtPhone.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtPhone, ex.Message);
            }
            try
            {
                em.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtAddress, ex.Message);
            }

            try
            {
               em.Num = Convert.ToInt32(txtNum.Text);
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtNum, ex.Message);
            }

            if (cmbCity.SelectedItem != null)
               em.CityId = ((City)cmbCity.SelectedItem).CityId;
            else
            {
                errorProvider1.SetError(cmbCity, "לא נבחרה עיר");
                flag = false;
            }
            
          
            if (cmbEmployeeType.SelectedItem != null)
                em.TypeCode = ((TypeOfEmployee)cmbEmployeeType.SelectedItem).TypeCode;
            else
            {
                errorProvider1.SetError(cmbEmployeeType, "לא נבחר סוג עובד");
                flag = false;
            }
            

            return flag;
        }
       

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
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
            return em.CityId == ((City)cmbCity.SelectedItem).CityId && em.FirstName == txtFirstName.Text && em.Phone == cmbCity.Text && em.Address == cmbCity.Text;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            frmAllCity frm = new frmAllCity("AddToForm");
            frm.ShowDialog();
            cmbCity.DataSource = MyTable.CityTable.GetList();
            cmbCity.SelectedItem = frm.c2;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}
