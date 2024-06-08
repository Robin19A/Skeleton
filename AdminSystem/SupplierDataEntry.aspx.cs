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
        //capture the supplier Id
        string SupplierId = txtSupplierId.Text;
        //capture the supplierName
        string SupplierName = txtSupplierName.Text;
        //capture the Address
        string Address = txtAddress.Text;
        //capture the Phone
        string Phone = txtPhone.Text;
        //capture the supplier Id
        string Email = txtEmail.Text;
        //capture the supplier Id
        string DateAdded = txtDateAdded.Text;
        //capture the Active checkbox
        string Active = chkActive.Text;
        //variable to store any error messages 
        string Error = "";
        //validate the data 
        Error = AnSupplier.Valid(SupplierName, Address, Phone, Email, DateAdded);
        if (Error == "")
        {
            //capture the address
            AnSupplier.Address = txtAddress.Text;
            //capture the SupplierName  
            AnSupplier.SupplierName = txtSupplierName.Text;
            //capture the SupplierId
            AnSupplier.SupplierId = Convert.ToInt32(SupplierId);
            //capture the Phone
            AnSupplier.Phone = txtPhone.Text;
            //capture the Email
            AnSupplier.Email = txtEmail.Text;
            //capture the Date Added
            AnSupplier.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the Active
            AnSupplier.Active = chkActive.Checked;
            //create a new instance of supplier collection
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            //set the this supplier property
            SupplierList.ThisSupplier = AnSupplier;
            //add the new record
            SupplierList.Add();
            //redirect back to list page
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
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

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }
}

    

