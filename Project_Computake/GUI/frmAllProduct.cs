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
    public partial class frmAllProduct : Form
    {
        int c1 = 0, c2 = 0, c3 = 0, c4 = 0;

        public frmAllProduct()
        {
            InitializeComponent();

            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.Status).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct(), x.CountinStock }).ToList();
            dgvAllProduct.Columns[0].HeaderText = "קוד מוצר";
            dgvAllProduct.Columns[1].HeaderText = "שם מוצר";
            dgvAllProduct.Columns[2].HeaderText = "קטגוריה";
            dgvAllProduct.Columns[3].HeaderText = "מחיר";
            dgvAllProduct.Columns[4].HeaderText = "תאור מוצר";
            dgvAllProduct.Columns[5].HeaderText = "צבע";
            dgvAllProduct.Columns[6].HeaderText = "כמות במלאי";
            rbRent.Visible = true;
        }
        void Refreashed()
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.Status).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct(), x.CountinStock }).ToList();
            dgvAllProduct.Columns[0].HeaderText = "קוד מוצר";
            dgvAllProduct.Columns[1].HeaderText = "שם מוצר";
            dgvAllProduct.Columns[2].HeaderText = "קטגוריה";
            dgvAllProduct.Columns[3].HeaderText = "מחיר";
            dgvAllProduct.Columns[4].HeaderText = "תאור מוצר";
            dgvAllProduct.Columns[5].HeaderText = "צבע";
            dgvAllProduct.Columns[6].HeaderText = "כמות במלאי";
            rbSell.Checked = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
            this.Close();
        }
        private void txtSearchNamePro_TextChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.ProductName.IndexOf(txtSearchNamePro.Text) == 0).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct(), x.CountinStock }).ToList();
            dgvAllProduct.Columns[0].HeaderText = "קוד מוצר";
            dgvAllProduct.Columns[1].HeaderText = "שם מוצר";
            dgvAllProduct.Columns[2].HeaderText = "קטגוריה";
            dgvAllProduct.Columns[3].HeaderText = "מחיר";
            dgvAllProduct.Columns[4].HeaderText = "תאור מוצר";
            dgvAllProduct.Columns[5].HeaderText = "צבע";
            dgvAllProduct.Columns[6].HeaderText = "כמות במלאי";
        }

        private void btnDelSearch_Click(object sender, EventArgs e)
        {
            txtSearchNamePro.Text = "";
        }

        private void dgvAllProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Product p = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == Convert.ToInt32(dgvAllProduct.CurrentRow.Cells[0].Value));
            if (p != null)
            {
                frmProduct frm = new frmProduct(p);
                frm.Show();
            }
        }

        private void AddPro_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show(); 
        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.SellOrRent == 1).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ColorBlack.Visible = true;
            ColorSilver.Visible = true;
            ColorWhite.Visible = true;
            ColorGold.Visible = true;
        }

        private void rbSell_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.SellOrRent == 2).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void rbComputerRent_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => (x.SellOrRent == 1)&& (x.CategoryPrId==1)) .Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void rbprojectorRent_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => (x.SellOrRent == 1) && (x.CategoryPrId == 2)).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void rbComputerSell_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x =>( x.SellOrRent == 2) && (x.CategoryPrId == 1)).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void rbprojectorSell_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => (x.SellOrRent == 2) && (x.CategoryPrId == 2)).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (!ColorBlack.Checked)
                    c1 = 0;
                else
                    c1 = 2;
                dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.ColorCode == c4 || x.ColorCode == c3 || x.ColorCode == c2 || x.ColorCode == c1).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
            }
        }

        private void ColorSilver_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (!ColorSilver.Checked)
                    c2 = 0;
                else
                    c2 = 3;
                dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.ColorCode == c4 || x.ColorCode == c3 || x.ColorCode == c2 || x.ColorCode == c1).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
            }
        }

        private void ColorWhite_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (!ColorWhite.Checked)
                    c3 = 0;
                else
                    c3 = 1;
                dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.ColorCode == c4 || x.ColorCode == c3 || x.ColorCode == c2 || x.ColorCode == c1).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
            }
        }

        private void ColorGold_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (!ColorGold.Checked)
                    c4 = 0;
                else
                    c4 = 4;
                dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.ColorCode == c4 || x.ColorCode == c3 || x.ColorCode == c2 || x.ColorCode == c1).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LenovoCompany.Visible = true;
            HPCompany.Visible = true;
            DellCompany.Visible = true;
            AppleCompany.Visible = true;
            AsusCompany.Visible = true;
            AcerCompany.Visible = true;
        }

        private void LenovoCompany_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.CompanyProductCode ==1).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void HPCompany_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.CompanyProductCode == 2).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void DellCompany_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.CompanyProductCode == 3).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void AsusCompany_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.CompanyProductCode == 4).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == Convert.ToInt32(dgvAllProduct.CurrentRow.Cells[0].Value));
            if (p != null)
            {
                frmProduct frm = new frmProduct(p);
                frm.Show();
                this.Close();
            }
        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = MyTable.ProductTable.GetList().FirstOrDefault(x => x.ProductId == Convert.ToInt32(dgvAllProduct.CurrentRow.Cells[0].Value));
            if (MessageBox.Show("האם ברצונך למחוק?", "התרעה על מחיקה", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                p.Status = false;
                MyTable.ProductTable.Update(p);
                MyTable.ProductTable.Save();
                //רענון
                dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.Status && x.ProductName.IndexOf(txtSearchNamePro.Text) == 0).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
                dgvAllProduct.Columns[0].HeaderText = "קוד מוצר";
                dgvAllProduct.Columns[1].HeaderText = "שם מוצר";
                dgvAllProduct.Columns[2].HeaderText = "קטגוריה";
                dgvAllProduct.Columns[3].HeaderText = "מחיר";
                dgvAllProduct.Columns[4].HeaderText = "תאור מוצר";
                dgvAllProduct.Columns[5].HeaderText = "צבע";
            }
            else
                MessageBox.Show("המחיקה בוטלה");
        }

        private void AppleCompany_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.CompanyProductCode == 5).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void AcerCompany_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.CompanyProductCode == 6).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
        }

        private void btnClearFiltering_Click(object sender, EventArgs e)
        {
            rbComputerRent.Checked = false;
            rbComputerSell.Checked = false;
            rbprojectorRent.Checked = false;
            rbRent.Checked = false;
            rbSell.Checked = false;
            rbprojectorSell.Checked = false;
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
            dgvAllProduct.DataSource = MyTable.ProductTable.GetList().Where(x => x.Status).Select(x => new { x.ProductId, x.ProductName, category = x.GetCategories(), x.PriceTotal, x.DescribeProduct, colorproduct = x.GetColorProduct() }).ToList();
            dgvAllProduct.Columns[0].HeaderText = "קוד מוצר";
            dgvAllProduct.Columns[1].HeaderText = "שם מוצר";
            dgvAllProduct.Columns[2].HeaderText = "קטגוריה";
            dgvAllProduct.Columns[3].HeaderText = "מחיר";
            dgvAllProduct.Columns[4].HeaderText = "תאור מוצר";
            dgvAllProduct.Columns[5].HeaderText = "צבע";
            rbRent.Visible = true;
        }
    }
}