using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsProduct AnProduct = new clsProduct();
        AnProduct.Name = txtName.Text;
        Session["AnProduct"] = AnProduct;
        
        Response.Redirect("StockViewer.aspx");
    }

    protected void Available_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductID_TextChanged(object sender, EventArgs e)
    {

    }
}