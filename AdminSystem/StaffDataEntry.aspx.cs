using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (StaffId != -1)
            {
                //dis[play the current data for the record
                DisplayStaff();
            }
        }
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
        Error = AnStaff.Valid(Name, Email, Gender, Address, DateOfBirth);
        if (Error == "")
        {
            //capture the staff id
            AnStaff.StaffId = StaffId;
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
            //capture active
            AnStaff.Active = chkActive.Checked;
            //create a new instance of the address collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i. e. StaffId = -1 then add the data
            if (StaffId == -1)
            {
                //set the ThisStaff Property
                StaffList.ThisStaff = AnStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the ThisStaff property
                StaffList.ThisStaff = AnStaff;
                //update the record
                StaffList.Update();

            }
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
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
    void DisplayStaff()
    {

        //create an instance of the Staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffId);
        //display the data for the record
        txtStaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtName.Text = StaffBook.ThisStaff.Name.ToString();
        txtEmail.Text = StaffBook.ThisStaff.Email.ToString();
        txtDateOfBirth.Text = StaffBook.ThisStaff.DateOfBirth.ToString();
        txtGender.Text = StaffBook.ThisStaff.Gender.ToString();
        txtAddress.Text = StaffBook.ThisStaff.Address.ToString();
        chkActive.Checked = StaffBook.ThisStaff.Active;

    }
}