using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteByCheckBox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Visible = true;
        if (!IsPostBack)
        {
            bindData();
        }
    }
    private void bindData()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        SqlConnection connection = new SqlConnection(s);
        string sql = "select * from ProductTable";
        SqlDataAdapter adapter = new SqlDataAdapter(sql, s);
        DataTable table = new DataTable();
        adapter.FillSchema(table, SchemaType.Source);
        adapter.Fill(table);
        Repeater1.DataSource = table;
        Repeater1.DataBind();
        table.Dispose();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        SqlConnection connection = new SqlConnection(s);
        connection.Open();
        foreach (RepeaterItem item in Repeater1.Items)
        {
            CheckBox cbx = item.FindControl("CheckBox1") as CheckBox;
            if (cbx != null)
            {
                if (cbx.Checked)
                {
                    int i = Convert.ToInt32(cbx.Attributes["value"]);
                    string sql = "delete from ProductTable where ProductId="+i;
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                }
            }
        }
        bindData();
        connection.Close();
    }
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        //check if the member is administrator
        //if (Request.Cookies["memberid"].Value != null) add this if to avoid null reference excption
        //{
        //    if (Convert.ToInt32(Request.Cookies["memberid"].Value) != 55684 && Convert.ToInt32(Request.Cookies["memberid"].Value) != 30003)
        //    {

        //    }
        //    else
        //    {
        //        CheckBox ckb = e.Item.FindControl("ckbDelete") as CheckBox;
        //        ckb.Visible = true;
        //    }
        //}
        CheckBox cbx = e.Item.FindControl("CheckBox1") as CheckBox;
        cbx.Visible = true;
    }
}