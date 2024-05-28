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
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //display the address for this entry 
        Response.Write(AnSupplier.Address);
        Response.Write(AnSupplier.SupplierName);
        Response.Write(AnSupplier.SupplierId);
        Response.Write(AnSupplier.Phone);
        Response.Write(AnSupplier.Email);
        Response.Write(AnSupplier.DateAdded);
        Response.Write(AnSupplier.Active);
    }
}