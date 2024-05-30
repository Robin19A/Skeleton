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

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier class
        clsSupplier AnSupplier = new clsSupplier();
        //create a variable to store the primary key 
        Int32 SupplierId;
        //create a variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user
        SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //find the record 
        Found = AnSupplier.Find(SupplierId);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSupplierName.Text = AnSupplier.SupplierName;
            txtAddress.Text = AnSupplier.Address;
            txtPhone.Text = AnSupplier.Phone;
            txtEmail.Text = AnSupplier.Email;
            txtDateAdded.Text = AnSupplier.DateAdded.ToString();
            chkActive.Checked = AnSupplier.Active;

        }

    }
}
