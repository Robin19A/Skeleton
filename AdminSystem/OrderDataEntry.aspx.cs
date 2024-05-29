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
    protected void txtOrderId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the Order Id
        AnOrder.OrderId = Convert.ToInt16(txtOrderId.Text);
        //capture the Customer Id
        AnOrder.CustomerId = Convert.ToInt16(txtCustomerId.Text);
        //capture the Order Date
        AnOrder.OrderDate = Convert.ToDateTime(DateTime.Now);
        //capture the Delivered Status
        AnOrder.DeliveredStatus = txtDeliveredStatus.Text;
        //capture the Total Amount
        AnOrder.TotalAmount = Decimal.Parse(txtTotalAmount.Text);
        //capture the Shipping Address
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        //capture the Staff Id
        AnOrder.StaffId = Convert.ToInt16(txtStaffID.Text);
        //capture Complete check box
        AnOrder.Active  = chkComplete.Checked;
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}