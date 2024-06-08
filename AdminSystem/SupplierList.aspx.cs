using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplaySuppliers();
        }

        //create a new instance of clsSupplierUser
        clsSupplierUser AnUser = new clsSupplierUser();
        //get data from the session object
        AnUser = (clsSupplierUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplaySuppliers()
    {
        // create an instance of supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        // set the data source to list of suppliers in the collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        // set the name of primary key
        lstSupplierList.DataValueField = "SupplierId";
        // set the data field to display
        lstSupplierList.DataTextField = "Address";
        // bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["SupplierId"] = -1;
        // redirect to the data entry page
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 SupplierId;
        // if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            // store the data in the session object
            Session["SupplierId"] = SupplierId;
            // redirect to the delete page
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            // display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        Int32 SupplierId;
        // if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            // store the data in the session object
            Session["SupplierId"] = SupplierId;
            // redirect to the edit page
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else // if no record has been selected
        {
            // display an error message
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        // retrieve value of the Phone from the presentation layer
        Suppliers.ReportByPhone(txtFilter.Text);
        // set the datasource to the list of suppliers in the collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        // set the name of the primary key
        lstSupplierList.DataValueField = "SupplierId";
        // set the name of the field to display
        lstSupplierList.DataTextField = "Phone";
        // bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the supplier collection
        clsSupplierCollection AnSupplier = new clsSupplierCollection();
        // Call ReportByPhone with an empty string to clear the filter
        AnSupplier.ReportByPhone("");
        // Clear the filter text box
        txtFilter.Text = "";
        // Set the datasource to the list of suppliers in the collection
        lstSupplierList.DataSource = AnSupplier.SupplierList;
        // Set the name of the primary key
        lstSupplierList.DataValueField = "SupplierId";
        // Set the name of the field to display
        lstSupplierList.DataTextField = "Phone";
        // Bind the data to the list
        lstSupplierList.DataBind();
    }



    protected void lstSupplierList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtFilter_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnReturn1_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}

