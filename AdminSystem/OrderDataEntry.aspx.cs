using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtOrderId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the Order Id
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture the Customer Id
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //capture the Order Date
        AnOrder.OrderDate = Convert.ToDateTime(DateTime.Now);
        //capture the Delivered Status
        AnOrder.TotalAmount = Decimal.Parse(txtTotalAmount.Text);
        //capture the Shipping Address
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        //capture the Staff Id
        AnOrder.StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the Delivered Status
        AnOrder.DeliveryStatus = chkDeliveryStatus.Checked;
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress.ToString();
            txtStaffId.Text = AnOrder.StaffId.ToString();   
            chkDeliveryStatus.Checked = AnOrder.DeliveryStatus;
        }
    }
}
