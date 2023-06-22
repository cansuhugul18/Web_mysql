using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace Web_mysql
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("Server=localhost;Database=my_schema;Uid=root;Pwd=Chbcd12012018;");
            mySqlConnection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from kisiler", mySqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt); adapter.Dispose();mySqlConnection.Dispose();
            tablegridview.DataSource = dt;
            tablegridview.DataBind();
            dt.Dispose();

        }
    }
}