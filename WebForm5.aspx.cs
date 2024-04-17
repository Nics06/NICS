using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication57
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        void LoadRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Administrator\Documents\Visual Studio 2012\Projects\WebApplication57\WebApplication57\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;

            cmd = new SqlCommand("Select * from Orders", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // Fill the DataTable dt

            GridView1.DataSource = dt;
            GridView1.DataBind();

            con.Close();
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Administrator\Documents\Visual Studio 2012\Projects\WebApplication57\WebApplication57\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Orders (ItemName, Quantity) VALUES (@ItemName, @Quantity)", con);
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            lblMessage.Text = "Saved Successfully";
            LoadRecord();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Administrator\Documents\Visual Studio 2012\Projects\WebApplication57\WebApplication57\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Orders SET Quantity = @Quantity WHERE ItemName = @ItemName", con);
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            lblMessage.Text = "Update Successfully";
            LoadRecord();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Administrator\Documents\Visual Studio 2012\Projects\WebApplication57\WebApplication57\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE ItemName = @ItemName AND Quantity = @Quantity", con);
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            lblMessage.Text = "Delete Successfully";
            LoadRecord();
        }

        protected void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Administrator\Documents\Visual Studio 2012\Projects\WebApplication57\WebApplication57\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE ItemName = @ItemName AND Quantity = @Quantity", con);
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
           

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // Fill the DataTable dt

            GridView1.DataSource = dt;
            GridView1.DataBind();

            con.Close();

        }
    }
}