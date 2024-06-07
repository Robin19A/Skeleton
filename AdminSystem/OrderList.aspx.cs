using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (OrderId != -1)
            {
                //displayad dres current data for the record
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        //create an instance of the Address collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of Orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        // set the name of the primary key
        lstOrderList.DataValueField = "OrderNo";
        // set the data field to display
        lstOrderList.DataTextField = "ShippingAddress";
        //bind the data to the list IstAddressList.DataBind();
        lstOrderList.DataBind();
    }
   
        

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store - 1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDatEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)

    {
        // variable to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the cord to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            // store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else      //if no record has been selected

        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}