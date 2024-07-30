using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComputers.DALL;
using ProjectComputers.GUI;
using System.Data;

namespace ProjectComputers.BLL
{
    public class Product : GeneralRow
    {
        public Product() { }
        public Product(DataRow dr)
        {
            this.drow = dr;
            FillFields();
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set
            {
                if (frmProduct.status == "add")
                {
                    if (MyTable.ProductTable.GetList().FirstOrDefault(x => x.productId == value) != null)
                        throw new Exception("ת.ז. קיימת");
                }

                if (value == 0)
                    throw new Exception("לא הקשת ת.ז.");
                else
                    productId = value;
            }
        }
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (value.Length < 2)
                    throw new Exception("שם מוצר לא תקין");
                else
                {
                    if (validation.IsNumber(value))
                    //    productName = value;
                    //else
                        throw new Exception("שם מוצר שגוי");
                    productName = value;
                }
                productName = value; }
        }

        private string productPicture;
        public string ProductPicture
        {
            get { return productPicture; }
            set { productPicture = value; }
        }
       
        private int priceHour;

        public int PriceHour
        {
            get { return priceHour; }
            set
            {
                if (value >= 0)
                    priceHour = value;
                else
                    throw new Exception("לא ניתן מחיר שלילי");
            }
        }
        private int priceTotal;

        public int PriceTotal
        {
            get { return priceTotal; }
            set
            {
                if (validation.IsHebrew(value.ToString()) == true)
                    throw new Exception("מספרים בלבד");
                if (value >= 0)
                    priceTotal = value;
                else
                    throw new Exception("לא ניתן מחיר שלילי");
            }
        }
        private int countinStock;

        public int CountinStock
        {
            get { return countinStock; }
            set { countinStock = value; }
        }
        private string describeProduct;

        public string DescribeProduct
        {
            get { return describeProduct; }
            set {
                if (!validation.IsHebrew(value))
                
                throw new Exception("תאור מוצר שגוי");
                else

                   if (value == "")
                    throw new Exception("נא הכנס תיאור מוצר");
                
                    
                describeProduct = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        private int sellOrRent;

        public int SellOrRent
        {
            get { return sellOrRent; }
            set { sellOrRent = value; }
        }

        private int categoryPrId;

        public int CategoryPrId
        {
            get { return categoryPrId; }
            set { categoryPrId = value; }
        }

        private int colorCode;

        public int ColorCode
        {
            get { return colorCode; }
            set { colorCode = value; }
        }

        private int companyProductCode;

        public int CompanyProductCode
        {
            get { return companyProductCode; }
            set { companyProductCode = value; }
        }
        public override void FillDataRow()
        {
            drow["productId"] = this.productId;
            drow["productName"] = this.productName;
            drow["priceTotal"] = this.priceTotal;
            drow["countinStock"] = this.countinStock;
            drow["describeProduct"] = this.describeProduct;
            drow["priceHour"] = this.priceHour.ToString();
            drow["status"] = this.status;
            drow["sellOrRent"] = this.sellOrRent.ToString();
            drow["categoryPrId"] = this.categoryPrId.ToString();
            drow["colorCode"] = this.colorCode.ToString();
            drow["companyProductCode"] = this.companyProductCode.ToString();
            drow["productPicture"] = this.productPicture;
        }

        public override void FillFields()
        {

            this.productName = drow["productName"].ToString();
            this.describeProduct = drow["describeProduct"].ToString();
            this.status = Convert.ToBoolean(drow["status"]);
            this.priceHour = Convert.ToInt32(drow["priceHour"]);
            this.priceTotal = Convert.ToInt32(drow["priceTotal"]);
            this.countinStock = Convert.ToInt32(drow["countinStock"]);
            this.productId = Convert.ToInt32(drow["productId"]);
            this.sellOrRent = Convert.ToInt32(drow["sellOrRent"]);
            this.categoryPrId = Convert.ToInt32(drow["categoryPrId"]);
            this.colorCode = Convert.ToInt32(drow["colorCode"]);
            this.companyProductCode = Convert.ToInt32(drow["companyProductCode"]);
            this.productPicture = drow["productPicture"].ToString();
        }
        public Categories GetCategories()
        {
            return MyTable.CategoriesTable.GetList().FirstOrDefault(x =>x.CategoryId == this.sellOrRent);
        }
        public ColorProduct GetColorProduct()
        {
            return MyTable.ColorProductTable.GetList().FirstOrDefault(x => x.ColorCode == this.colorCode);
        }

        public CompanyProduct GetCompanyProduct()
        {
            return MyTable.CompanyProductTable.GetList().FirstOrDefault(x => x.CompanyProductCode == this.companyProductCode);
        }

        public CategoryProduct GetCategoryProduct()
        {
            return MyTable.CategoryProductTable.GetList().FirstOrDefault(x => x.CategoryPrId == this.categoryPrId);
        }
      
    }
}

