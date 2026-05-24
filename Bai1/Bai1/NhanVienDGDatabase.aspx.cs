using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1
{
    public partial class NhanVien : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataGRNhanVien();
            }
        }



        protected void grNhanVien_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            int rowIndex = e.Item.ItemIndex;
            if (e.CommandName == "Edit")
            {
                grNhanVien.EditItemIndex = rowIndex;
                LoadDataGRNhanVien();
            }
            if (e.CommandName == "Update")
            {

                TextBox txtName = (TextBox)e.Item.FindControl("txtName");
                string name = txtName.Text;
                // 
                Label lblErrorName = (Label)e.Item.FindControl("lblErrorName");
                if (name.Length > 20)
                {
                    lblErrorName.Text = "Ten khong duoc vuot qua 20";
                }

                TextBox txtPhone = (TextBox)e.Item.FindControl("txtPhone");

                TextBox txtAddress = (TextBox)e.Item.FindControl("txtAddress");

                // Update du lieu nguoi dung nhap tu DataGrid vaof Viewstate de luu tru

                DataTable dt = (DataTable)ViewState["NhanVienTable"];
                dt.Rows[rowIndex]["Name"] = txtName.Text;

                dt.Rows[rowIndex]["Phone"] = txtPhone.Text;

                dt.Rows[rowIndex]["Address"] = txtAddress.Text;
                ViewState["NhanVienTable"] = dt;

                grNhanVien.EditItemIndex = -1;
                LoadDataGRNhanVien();
            }

            if (e.CommandName == "Cancel")
            {
                grNhanVien.EditItemIndex = -1;
                // Load lai DB
                LoadDataGRNhanVien();
            }

            if (e.CommandName == "Delete")
            {

                DataTable dt = (DataTable)ViewState["NhanVienTable"];
                dt.Rows.RemoveAt(e.Item.ItemIndex);

                ViewState["NhanVienTable"] = dt;

                LoadDataGRNhanVien();
            }
        }
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["NhanVienTable"];

            int newID = dt.Rows.Count + 1;

            dt.Rows.Add(
                newID.ToString(),
                txtNewName.Text,
                txtNewPhone.Text,
                txtNewAddress.Text
            );

            ViewState["NhanVienTable"] = dt;

            txtNewName.Text = "";
            txtNewPhone.Text = "";
            txtNewAddress.Text = "";

            LoadDataGRNhanVien();
        }

        protected void LoadDataGRNhanVien()
        {
            grNhanVien.DataSource = NhanVienTable;
            grNhanVien.DataBind();
        }

        private DataTable NhanVienTable
        {
            get
            {
                if (ViewState["NhanVienTable"] == null)
                {
                    // 
                    SqlConnection con =
                new SqlConnection(strCon);

                    string sql = "SELECT  ID, Name, Phone, Address FROM NhanVien";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();
                    //dt.Columns.Add("ID");
                    //dt.Columns.Add("Name");
                    //dt.Columns.Add("Phone");
                    //dt.Columns.Add("Address");

                    //dt.Rows.Add("1", "Nguyen van A", "0546565", "123 Da Nang");
                    //dt.Rows.Add("2", "Nguyen van B", "0546565", "123 Da Nang");
                    //dt.Rows.Add("3", "Nguyen van C", "0546565", "123 SG");

                    da.Fill(dt);

                    ViewState["NhanVienTable"] = dt;
                }

                return (DataTable)ViewState["NhanVienTable"];
            }
            set
            {
                ViewState["NhanVienTable"] = value;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con =
                new SqlConnection(strCon);

            // Xóa dữ liệu cũ trong DB
            string deleteSql =
                "DELETE FROM NhanVien ";


            SqlCommand deleteCmd =
                new SqlCommand(deleteSql, con);

            con.Open();
            deleteCmd.ExecuteNonQuery();

            // Insert lại dữ liệu từ DataGrid/ViewState
            DataTable dt =
               (DataTable)ViewState["NhanVienTable"];
            foreach (DataRow row in dt.Rows)
            {
                string insertSql =
                    @"INSERT INTO NhanVien
              (
                  Name,
                  Phone,
                  Address
              )
              VALUES
              (
                  @ten,
                  @dienThoai,
                  @diaChi
              )";

                SqlCommand insertCmd =
                    new SqlCommand(insertSql, con);

                insertCmd.Parameters.AddWithValue(
                    "@ten",
                    row["Name"].ToString());

                insertCmd.Parameters.AddWithValue(
                    "@dienThoai",
                    row["Phone"].ToString());

                insertCmd.Parameters.AddWithValue(
                    "@diaChi",
                    row["Address"].ToString());

                insertCmd.ExecuteNonQuery();
            }

            txtNewName.Text = "";
            txtNewPhone.Text = "";
            txtNewAddress.Text = "";
            LoadDataGRNhanVien();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ViewState["NhanVienTable"] = null;

            grNhanVien.EditItemIndex = -1;
            txtNewName.Text = "";
            txtNewPhone.Text = "";
            txtNewAddress.Text = "";
            LoadDataGRNhanVien();
        }

        // Duoc goi khi datagrid đỗ dữ liệu ra. Từng dòng sẽ gọi grNhanVien_ItemDataBound

        protected void grNhanVien_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem
                )
            {
                // Neu so dien thoai la 113 thi khong duoc hien thi nut xoa
                DataRowView row = (DataRowView)e.Item.DataItem;

                if (row["Phone"].ToString() == "113")
                {
                    LinkButton btnDelete =
                        (LinkButton)e.Item.FindControl("btnDelete");

                    btnDelete.Visible = false;
                }
            }
            if (e.Item.ItemType == ListItemType.EditItem)
            {
                // Neeus so dien thoai laf 113, 115 thi khong duoc sua so dien thoai
                DataRowView dtRow = (DataRowView)e.Item.DataItem;
                if (dtRow["Phone"].ToString() == "113" || dtRow["Phone"].ToString() == "115")
                {
                    TextBox dienThoai = (TextBox)e.Item.FindControl("txtPhone");
                    dienThoai.Enabled = false;
                }

            }

            if (e.Item.ItemType == ListItemType.Header)
            {
                // Cho backroud mau xanh
                e.Item.BackColor = System.Drawing.Color.Blue;
                e.Item.ForeColor = System.Drawing.Color.White;
            }


            if (e.Item.ItemType == ListItemType.AlternatingItem)
            {
                e.Item.BackColor = System.Drawing.Color.Violet;
            }
        }
    }
}