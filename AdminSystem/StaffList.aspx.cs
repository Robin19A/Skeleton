using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayStaffes();
        }

        //create a new instance of clsStaffUser
        clsStaffUser AnUser = new clsStaffUser();
        //get data from the session object
        AnUser = (clsStaffUser)Session["AnUser"];
        //display the user name
        Response.Write("logged in as: " + AnUser.Username);
    }
    void DisplayStaffes()
    {
        clsStaffCollection Staffes = new clsStaffCollection();
        lstStaffList.DataSource = Staffes.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "Address";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;

        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else      //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";

        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else      //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to delete";

        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsStaffCollection AnStaff = new clsStaffCollection();
        //retrieve the value of Address from the presentation layer
        AnStaff.ReportByAddress(txtFilter.Text);
        //set the data source to the list of Staffes in the collection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "Address";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsStaffCollection AnStaff = new clsStaffCollection();
        //set empty string
        AnStaff.ReportByAddress("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of Staffes in the collection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "Address";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnReturntoMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}

