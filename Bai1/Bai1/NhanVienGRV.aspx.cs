using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1
{
    public partial class NhanVienGRV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //  !false => if(true = true) { }
            {
                LoadData();
            }
        }

        public void LoadData()
        {
            // Select * from NhanVien
            DataTable dt = new DataTable();
            
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");

            dt.Rows.Add("1", "An");
            dt.Rows.Add("2", "Bình");

            gvStudents.DataSource = dt;
            gvStudents.DataBind();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

        }

        protected void gvStudents_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStudents.EditIndex = e.NewEditIndex;
            LoadData();
        }
    }
}