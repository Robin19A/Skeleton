using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayProducts();
        }

        clsProductUser AnUser = new clsProductUser();
        AnUser = (clsProductUser)Session["AnUser"];
        Response.Write("Logged In as a : " + AnUser.Username);
    }

    void DisplayProducts()
    {
        clsProductCollection AllProducts = new clsProductCollection();
        lstProductList.DataSource = AllProducts.ProductList;
        lstProductList.DataValueField = "ProductID";
        lstProductList.DataTextField = "Name";
        lstProductList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductID;

        if (lstProductList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(lstProductList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a Record Form the list to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductID;

        if (lstProductList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(lstProductList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("StockConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a product from the List to Delete.";
        }
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsProductCollection AProduct = new clsProductCollection();
        AProduct.ReportByName(txtProductName.Text);
        lstProductList.DataSource = AProduct.ProductList;
        lstProductList.DataValueField = "ProductID";
        lstProductList.DataTextField = "Name";
        lstProductList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsProductCollection AProduct = new clsProductCollection();
        AProduct.ReportByName("");
        txtProductName.Text = "";
        lstProductList.DataSource = AProduct.ProductList;
        lstProductList.DataValueField = "ProductID";
        lstProductList.DataTextField = "Name";
        lstProductList.DataBind();
    }
}