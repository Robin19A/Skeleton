﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{   
    //variable to store the primary key value of the record to be deleted
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        SupplierId = Convert.ToInt32(Session["SupplierId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the supplier collection class
        clsSupplierCollection Supplier = new clsSupplierCollection();
        //find the record to delete
        Supplier.ThisSupplier.Find(SupplierId);
        //delete the record
        Supplier.Delete();
        //redirect back to main page 
        Response.Redirect("SupplierList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the main page 
        Response.Redirect("SupplierList.aspx");

    }
}

