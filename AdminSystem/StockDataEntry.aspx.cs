using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;





public partial class _1_DataEntry : System.Web.UI.Page
{
    private object txtDateAdded;
    private object txtSupplierID;
    private object SupplierID;
    private object txtUnitPrice;
    private object chkAvailable;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Decimal_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsProduct AnProduct = new clsProduct();
        AnProduct.Name = txtName.Text;
        Session["AnProduct"] = AnProduct;
         AnProduct.ProductID = int.Parse(txtProductID.Text);

          AnProduct.Description = txtDescription.Text;
          AnProduct.DateAdded = Convert.ToDateTime(DateTime.Now);
          AnProduct.SupplierID =Convert.ToInt32(txtSupplierID);
          AnProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice);
          AnProduct.Available= chkActive.Checked;











        Response.Redirect("StockViewer.aspx");
    }

    protected void txtProductID_TextChanged(object sender, EventArgs e)
    {

    }
}

