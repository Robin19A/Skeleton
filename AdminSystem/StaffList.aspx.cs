﻿using System;
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
        if(IsPostBack == false)
        {
            DisplayStaffes();
        }
    }
    void DisplayStaffes()
    {
        clsStaffCollection Staffes = new clsStaffCollection();
        lstStaffList.DataSource = Staffes.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "Address";
        lstStaffList.DataBind();
    }
}