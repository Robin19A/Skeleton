using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsProductUser AnUser = new clsProductUser();
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        Username = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnUser.FindUser(Username, Password);
        Session["AnUser"] = AnUser;
        if (txtUsername.Text == "")
        {
            lblError.Text = "Enter Username :: ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter Password ::";
        }
        else if (Found == true)
        {
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Details are Incorrect.";
        }
    }
}