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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //capture the address
        AnSupplier.Address = txtAddress.Text;
        //capture the SupplierName  
        AnSupplier.SupplierName = txtSupplierName.Text;
        //capture the SupplierId
        AnSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //capture the Phone
        AnSupplier.Phone = txtPhone.Text;
        //capture the Email
        AnSupplier.Email = txtEmail.Text;  
        //capture the Date Added
        AnSupplier.DateAdded = Convert.ToDateTime(DateTime.Now);
        //capture the Active
        AnSupplier.Active = chkActive.Checked;
        //store the address in the session object
        Session["AnSupplier"] = AnSupplier;
        //navigate to the view page 
        Response.Redirect("SupplierViewer.aspx");

    }

    protected void txtSupplierID_TextChanged(object sender, EventArgs e)
    {

    }
}