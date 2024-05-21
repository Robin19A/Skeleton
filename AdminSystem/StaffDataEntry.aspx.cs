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
        //capture the name
        AnStaff.Name = txtName.Text;
        //capture the StaffId
        AnStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the DateOfbirth
        AnStaff.DateOfBirth = Convert.ToDateTime(DateTime.Now);
        //capture the Active check box
        AnStaff.Active = chkActive.Checked;
        //capture the Email
        AnStaff.Email = txtEmail.Text;
       
        //capture the Gender
        AnStaff.Gender = txtGender.Text;
        //capture the Address
        AnStaff.Address = txtAddress.Text;
        //Store the staff in the session object
        Session["AnStaff"] = AnStaff;
        //navigte to the view page
        Response.Redirect("StaffViewer.aspx");
    }
}