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
using System.IO;

namespace ProjectComputers.GUI
{
    public partial class frmProduct : Form
    {
        public Product p;
       public static string status, pathPicture, namePicture;
        public frmProduct()
        {
            InitializeComponent();
            p = new Product();
            btnOk.Text = "הוסף";
            cmbCategorySellOrRent.DataSource = MyTable.CategoriesTable.GetList();
            cmbCategorySellOrRent.SelectedItem = null;
            status = "add";
            p.ProductId = MyTable.ProductTable.Next();
            txtId.Text = p.ProductId.ToString();
            cmbColor.DataSource = MyTable.ColorProductTable.GetList();
            cmbColor.SelectedItem = null;
            cmbCompanyPro.DataSource = MyTable.CompanyProductTable.GetList();
            cmbCompanyPro.SelectedItem = null;
            cmbCategoryPro.DataSource = MyTable.CategoryProductTable.GetList();
            cmbCategoryPro.SelectedItem = null;
        }
        public frmProduct(Product p)
        {
            InitializeComponent();
            this.p = p;
            cmbCategorySellOrRent.DataSource = MyTable.CategoriesTable.GetList();
            cmbCategorySellOrRent.SelectedItem = null;
            cmbColor.DataSource = MyTable.ColorProductTable.GetList();
            cmbColor.SelectedItem = null;
            cmbCompanyPro.DataSource = MyTable.CompanyProductTable.GetList();
            cmbCompanyPro.SelectedItem = null;
            cmbCategoryPro.DataSource = MyTable.CategoryProductTable.GetList();
            cmbCategoryPro.SelectedItem = null;
            txtId.ReadOnly = true;
            status = "update";
            fillTextBox();

        }
        void fillTextBox()
        {
            txtId.Text = p.ProductId.ToString();
            txtProductName.Text = p.ProductName;
            txtPriceTotal.Text = p.PriceTotal.ToString();
            txtDescribeProduct.Text = p.DescribeProduct;
            cmbCategorySellOrRent.SelectedItem = p.GetCategories();
            cmbColor.SelectedItem = p.GetColorProduct();
            cmbCompanyPro.SelectedItem = p.GetCompanyProduct();
            cmbCategoryPro.SelectedItem = p.GetCategoryProduct();
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\" + p.ProductPicture);
            txtCount.Text = p.CountinStock.ToString();
        }
        public bool Check()
        {
            bool flag = true;
            errorProvider1.Clear();
            
            try
            {
                p.ProductName = txtProductName.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtProductName, ex.Message);
            }
           
            try
            {
                p.CountinStock = Convert.ToInt32(txtCount.Text);
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtCount, ex.Message);
            }

            try
            {
                p.DescribeProduct = txtDescribeProduct.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtDescribeProduct, ex.Message);
            }

            if (cmbCategorySellOrRent.SelectedItem != null)
                p.SellOrRent = ((Categories)cmbCategorySellOrRent.SelectedItem).CategoryId;
            else
            {
                errorProvider1.SetError(cmbCategorySellOrRent, "לא נבחרה קטגוריה");
                flag = false;
            }

            try
            {
               p.PriceTotal = Convert.ToInt32(txtPriceTotal.Text);
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtPriceTotal, ex.Message);
            }

            if (cmbColor.SelectedItem != null)
                p.ColorCode = ((ColorProduct)cmbColor.SelectedItem).ColorCode;
            else
            {
                errorProvider1.SetError(cmbColor, "לא נבחר צבע");
                flag = false;
            }
         
            if (cmbCompanyPro.SelectedItem != null)
                p.CompanyProductCode = ((CompanyProduct)cmbCompanyPro.SelectedItem).CompanyProductCode;
            else
            {
                errorProvider1.SetError(cmbCompanyPro, "לא נבחרה חברה");
                flag = false;
            }

            if (cmbCategoryPro.SelectedItem != null)
                p.CategoryPrId = ((CategoryProduct)cmbCategoryPro.SelectedItem).CategoryPrId;
            else
            {
                errorProvider1.SetError(cmbCategoryPro, "לא נבחרה קטגוריה");
                flag = false;
            }


            try
            {
                p.ProductPicture = namePicture;
                if (!File.Exists(Application.StartupPath + @"\picture\" + p.ProductPicture))
                    File.Copy(pathPicture, Application.StartupPath + @"\picture\" + p.ProductPicture);

            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(btnPicture, "הכנס תמונה");
            }

            p.Status = true;
            
            return flag;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
              if (Check())

              if (status == "add")
              {
                 MyTable.ProductTable.Add(p);
                 MyTable.ProductTable.Save();
                 MessageBox.Show("המוצר נוסף בהצלחה!");
                 this.Close();
              }
              else
              {
                 MyTable.ProductTable.Update(p);
                 MyTable.ProductTable.Save();
                 MessageBox.Show("השינויים נשמרו בהצלחה!! ");
                 this.Close();
              }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files |*.jpeg;*.jpg;*.wmf;*.png;*.tif|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathPicture = openFileDialog1.FileName;
                namePicture = openFileDialog1.SafeFileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
