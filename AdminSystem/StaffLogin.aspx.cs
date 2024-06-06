﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the address user class
        clsStaffUser AnUser = new clsStaffUser();
        //create the variablesto store the username and password
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        Username = Convert.ToString(txtUsername.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(Username, Password);
        //if  username and/or password is empty
        if (txtUsername.Text == "")
        {
            lblError.Text = "Enter a Username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password";
        }
        //if found
        else if (Found == true)
        {
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Loging informations are incorrect. Please try again";
        }


    }
}