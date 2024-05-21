using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data rom the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the name for this entry
        Response.Write(AnStaff.Name);
        Response.Write(AnStaff.StaffId);
        Response.Write(AnStaff.DateOfBirth);
        Response.Write(AnStaff.Active);
        Response.Write(AnStaff.Email);
        Response.Write(AnStaff.Gender);
        Response.Write(AnStaff.Address);


    }
}