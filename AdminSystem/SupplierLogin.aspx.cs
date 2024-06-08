using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the address user class
        clsSupplierUser AnUser = new clsSupplierUser();
        //create the variablesto store the username and password
        string Username = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        Username = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(Username, Password);
        //Add a session to capture the user name
        Session["AnUser"] = AnUser;
        //if  username and/or password is empty
        if (txtUserName.Text == "")
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
            Response.Redirect("SupplierList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Loging informations are incorrect. Please try again";
        }


    }

    protected void txtPassword_TextChanged(object sender, EventArgs e)
    {

    }
}
