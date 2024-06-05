using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class STOCKDataEntry : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            if (ProductID != -1)
            {
                DisplayProduct();

            }
        }

        clsProductUser AnUser = new clsProductUser();
        AnUser = (clsProductUser)Session["AnUser"];
        Response.Write("Logged In as a : " + AnUser.Username);
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {

        clsProduct AProduct = new clsProduct();
        string Name = txtName.Text;
        string Description = txtDescription.Text;
        string UnitPrice= Convert.ToString(txtUnitPrice.Text);
        string SupplierID = txtSupplierID.Text;
        string Available = Convert.ToString(chkActive.Checked);
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = AProduct.Valid(Name, Description, DateAdded, UnitPrice, SupplierID, Available);
        if (Error == "")
        {
            AProduct.ProductID = ProductID;
            AProduct.Name = Name;
            AProduct.Description = Description;
            AProduct.UnitPrice = Convert.ToDouble(UnitPrice);
            AProduct.SupplierID = Convert.ToInt32(SupplierID);
            AProduct.Available = Convert.ToBoolean(Available);
            AProduct.DateAdded = Convert.ToDateTime(DateAdded);
            clsProductCollection ProductList = new clsProductCollection();
            if (ProductID == -1)
            {
                ProductList.ThisProduct = AProduct;
                ProductList.Add();
            }
            else
            {
                ProductList.ThisProduct.Find(ProductID);
                ProductList.ThisProduct = AProduct;
                ProductList.Update();
            }
                Response.Redirect("StockList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        Int32 ProductID;
        Boolean Found = false;
        ProductID = Convert.ToInt32(txtProductID.Text);
        Found = AProduct.Find(ProductID);

        if (Found == true)
        {
            txtName.Text = AProduct.Name;
            txtDescription.Text = AProduct.Description;
            txtDateAdded.Text = AProduct.DateAdded.ToString();
            txtUnitPrice.Text = AProduct.UnitPrice.ToString();
            txtSupplierID.Text = AProduct.SupplierID.ToString();
            chkActive.Checked = AProduct.Available;

        }



    }
        void DisplayProduct()
        {
            clsProductCollection Stocks = new clsProductCollection();
            Stocks.ThisProduct.Find(ProductID);
            txtProductID.Text = Stocks.ThisProduct.ProductID.ToString();
            txtName.Text = Stocks.ThisProduct.Name.ToString();
            txtDescription.Text = Stocks.ThisProduct.Description.ToString();
            txtDateAdded.Text = Stocks.ThisProduct.DateAdded.ToString();
            txtUnitPrice.Text = Stocks.ThisProduct.UnitPrice.ToString();
            txtSupplierID.Text = Stocks.ThisProduct.SupplierID.ToString();
            chkActive.Checked = Stocks.ThisProduct.Available;
        }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}