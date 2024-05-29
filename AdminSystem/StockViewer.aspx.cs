using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsProduct AnProduct = new clsProduct();

        AnProduct = (clsProduct)Session["AnProduct"];
        Response.Write("Product ID: " + AnProduct.ProductID + "<br/>");
        Response.Write("Name: " + AnProduct.Name + "<br/>");
        Response.Write("Supplier ID: " + AnProduct.SupplierID + "<br/>");
        Response.Write("Description: " + AnProduct.Description + "<br/>");
        Response.Write("Date Added: " + AnProduct.DateAdded.ToString("yyyy-MM-dd") + "<br/>");
        Response.Write("Unit Price: " + AnProduct.UnitPrice.ToString("c") + "<br/>");
        Response.Write("Available: " + (AnProduct.Available ? "Yes" : "No") + "<br/>");

    }
}