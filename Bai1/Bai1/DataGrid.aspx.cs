using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1
{
    public partial class DataGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");

            dt.Rows.Add("1", "An");
            dt.Rows.Add("2", "Bình");
            dt.Rows.Add("3", "Nhuan");
            dt.Rows.Add("4", "Nam");
            dt.Rows.Add("5", "Xuan");


            DataGrid1.DataSource = dt;

            DataGrid1.DataBind();
        }
        protected void DataGrid1_ItemCommand(
    object source,
    DataGridCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                DataGrid1.EditItemIndex =
                    e.Item.ItemIndex;

                LoadData();
            }
            if (e.CommandName == "Update")
            {
                TextBox txtName =
                    (TextBox)e.Item.FindControl("txtName");

                string name = txtName.Text;

                string id =
                    DataGrid1.DataKeys[e.Item.ItemIndex].ToString();

                // UPDATE DB
                // INSERTYT
                ////

                DataGrid1.EditItemIndex = -1;

                LoadData();
            }
            if (e.CommandName == "Cancel")
            {
                DataGrid1.EditItemIndex = -1;

                LoadData();
            }
        }
    }
}