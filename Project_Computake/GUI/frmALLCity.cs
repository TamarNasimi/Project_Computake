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
    public partial class frmAllCity : Form
    {
        City c;
        public City c2;
        string frmstatus;
        public frmAllCity()
        {
            InitializeComponent();
            dgvAllCity.DataSource = MyTable.CityTable.GetList();
            dgvAllCity.Columns[1].HeaderText = "שם עיר";
            dgvAllCity.Columns[0].Visible = false;
            dgvAllCity.Columns[2].Visible = false;
            c = new City();
        }
        public frmAllCity(string frmstatus) : this()
        {
            this.frmstatus = frmstatus;
            c = new City();
            groupBox2.Visible = true;
            groupBox2.Text = "הוספת עיר";
            txtCity.Text = "";
        }

        public Boolean Check()
        {
            bool flag = true;

            if (groupBox2.Text == "הוספת עיר")
            {
                City c2 = MyTable.CityTable.GetList().FirstOrDefault(x => x.CityName == txtCity.Text);
                if (c2 != null)
                {
                    txtCity.Clear();
                    MessageBox.Show("העיר קיימת כבר במערכת", "אופס...");
                    flag = false;
                }
                else
                {
                    errorProvider1.Clear();
                    try
                    {
                        c.CityName = txtCity.Text;

                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(txtCity, ex.Message);
                        flag = false;
                    }
                }
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    c.CityName = txtCity.Text;

                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtCity, ex.Message);
                    flag = false;
                }
            }
            return flag;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNameCity.Text = " ";
            dgvAllCity.DataSource = MyTable.CityTable.GetList();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (Check())

                if ((groupBox2.Text == "הוספת עיר") || (frmstatus == "AddToForm"))
                {

                    c.CityId = MyTable.CityTable.Next();
                    MyTable.CityTable.Add(c);
                    MyTable.CityTable.Save();
                    MessageBox.Show("התהליך בוצע בהצלחה! העיר  " + c.CityName + "  נוספה למערכת");
                    groupBox2.Visible = false;
                    dgvAllCity.DataSource = MyTable.CityTable.GetList();
                    dgvAllCity.Columns[2].Visible = false;
                }
                else
                {

                    MyTable.CityTable.Update(c);
                    MyTable.CityTable.Save();
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                    groupBox2.Visible = false;
                    dgvAllCity.DataSource = MyTable.CityTable.GetList();
                    dgvAllCity.Columns[2].Visible = false;

                }
           

            if (frmstatus == "AddToForm")
            {
                c2 = c;
                this.Close();
            }
        }

        private void txtNameCity_TextChanged(object sender, EventArgs e)
        {
            dgvAllCity.DataSource = MyTable.CityTable.GetList().Where(x => x.CityName.IndexOf(txtNameCity.Text) == 0).ToList();
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            c = new City();
            groupBox2.Visible = true;
            groupBox2.Text = "הוספת עיר";
            txtCity.Text = "";
        }

        private void dgvAllCity_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            c = MyTable.CityTable.GetList().FirstOrDefault(x => x.CityId == Convert.ToInt32(dgvAllCity.CurrentRow.Cells[0].Value));
            groupBox2.Visible = true;
            txtCity.Text = c.CityName;
            groupBox2.Text = "עדכן";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmMain frm = new frmMain();
            frm.Show();
        }

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = MyTable.CityTable.GetList().FirstOrDefault(x => x.CityId == Convert.ToInt32(dgvAllCity.CurrentRow.Cells[0].Value));
            groupBox2.Visible = true;
            txtCity.Text = c.CityName;
            groupBox2.Text = "עדכן";
        }

        private void מחיקהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllCity.SelectedRows.Count == 0)
                MessageBox.Show("לא נבחרה שורה למחיקה");
            else
            {
                c = MyTable.CityTable.GetList().FirstOrDefault(x => x.CityName == dgvAllCity.CurrentRow.Cells[1].Value);

                if (c == null)

                    MessageBox.Show("לא נבחרה שורה למחיקה");
                else
                {
                    City c = MyTable.CityTable.GetList().FirstOrDefault(x => x.CityId == Convert.ToInt32(dgvAllCity.CurrentRow.Cells[0].Value.ToString()));
                    if (c != null)
                        if ((c.GetCustomer().Count == 0) && (c.GetEmployee().Count == 0))
                        {
                            if (MessageBox.Show("האם ברצונך למחוק?", "התראה על מחיקה", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                                MyTable.CityTable.Delete(c);
                            MyTable.CityTable.Save();
                            MessageBox.Show("המחיקה בוצעה בהצלחה");
                            dgvAllCity.DataSource = MyTable.CityTable.GetList();
                            dgvAllCity.Columns[2].Visible = false;
                        }
                        else
                            MessageBox.Show(" לא ניתן למחוק עיר זו");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox2.Text = "הוספת עיר";
            txtCity.Text = "";
            btnSave.Text = "הוסף";
        }
        }
}
