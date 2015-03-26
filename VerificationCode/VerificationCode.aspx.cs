using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Verification_VerificationCode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (YZM.Text.Equals(Session["YZM"]))
        {
            YZMError.Text = "You have entered the correct code";
        }
        else
        {
            YZMError.Text = "Wrong verification code, please try again";
            YZMError.ForeColor = System.Drawing.Color.Red;
        }
    }
}