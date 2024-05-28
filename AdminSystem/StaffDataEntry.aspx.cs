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
        
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the Name
        string Name = txtName.Text;
        //capture the Email
        string Email = txtEmail.Text;
        //capture the DateOfBirth
        string DateOfBirth = txtDateOfBirth.Text;
        //capture the Gender
        string Gender = txtGender.Text;
        //capture the Address
        string Address = txtAddress.Text;
        //capture Active check box
        string Active = chkActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(Name, Email, DateOfBirth, Gender, Address);
        if (Error == "")
        {
            //capture the name
            AnStaff.Name = Name;
            //capture the Email
            AnStaff.Email = Email;
            //capture the DateOfbirth
            AnStaff.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture the Gender
            AnStaff.Gender = Gender;
            //capture the Address
            AnStaff.Address = Address;
            
            
            
            //Store the staff in the session object
            Session["AnStaff"] = AnStaff;
            //navigte to the view page
            Response.Redirect("StaffViewer.aspx");

            
            
        }
        else 
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}