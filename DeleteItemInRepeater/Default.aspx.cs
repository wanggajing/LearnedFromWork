using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteItemInRepeater_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
    protected void btnDeleteTopic_Click(object sender, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlConnection connection = new SqlConnection(s);
            string sql = "delete from ProductTable where ProductId=@id";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlParameter p1 = new SqlParameter("@id", Convert.ToInt32(e.CommandArgument));
            command.Parameters.Add(p1);
            connection.Open();
            int i = command.ExecuteNonQuery();
            bindData();
            connection.Close();
        }
    }
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
            Button btn = e.Item.FindControl("btnDeleteTopic") as Button;
            btn.Visible = true;
    }
}