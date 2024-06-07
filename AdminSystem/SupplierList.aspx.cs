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
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySuppliers();

        }

    }

    void DisplaySuppliers() 
    {
        //create an instance of supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();  
        //set the data source to list of suppliers in the collection 
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of primary key
        lstSupplierList.DataValueField = "SupplierId";
        //set the data field to display
        lstSupplierList.DataTextField = "Address";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["SupplierId"] = -1;
        //redirect to the data entry page
        Response.Redirect("SupplierDataEntry.aspx");
    }
}