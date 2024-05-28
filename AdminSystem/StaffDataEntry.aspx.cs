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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStaff AnStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false; 
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AnStaff.Find(StaffId);
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = AnStaff.Name;
            txtEmail.Text = AnStaff.Email;
            txtDateOfBirth.Text = AnStaff.DateOfBirth.ToString();
            txtGender.Text = AnStaff.Gender;
            txtAddress.Text = AnStaff.Address;
            chkActive.Checked = AnStaff.Active;
        }

    }
}