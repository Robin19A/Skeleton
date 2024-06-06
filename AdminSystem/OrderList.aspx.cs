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
            //updete the list box
            DisplayAddresses();
        }

    }
    void DisplayAddresses()
    {
            //create an instance of the Address collection
            clsOrderCollection Orders = new clsOrderCollection();
            //set the data source to list of Orders in the collection
            1stOrderList.DataSource = Orders.OrderList;
            // set the name of the primary key
            1stOrderList.DataValueField = "OrderNo";
            // set the data field to display
            1stOrderList.DataTextField = "PostCode";
            //bind the data to the list IstAddressList.DataBind();
            1stOrderList.DataBind();

    }
}