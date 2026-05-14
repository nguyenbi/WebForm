using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1
{
    public partial class ThucHanhDG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataGRNhanVien();
            }
        }

        //protected void LoadDataGRNhanVien()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("ID");
        //    dt.Columns.Add("Name");
        //    dt.Columns.Add("Phone");
        //    dt.Columns.Add("Address");

        //    // Lay tu DB
        //    // Select * from tblNhanVien
        //    dt.Rows.Add("1", "Nguyen van A", "0546565", "123 Da Nang");
        //    dt.Rows.Add("2", "Nguyen van B", "0546565", "123 Da Nang");
        //    dt.Rows.Add("3", "Nguyen van C", "0546565", "123 SG");
        //    dt.Rows.Add("4", "Nguyen van D", "0546565", "123 Da Nang");
        //    dt.Rows.Add("5", "Nguyen van E", "0546565", "123 Can tho");

        //    grNhanVien.DataSource = dt;
        //    grNhanVien.DataBind();
        //}
        protected void LoadDataGRNhanVien()
        {
            grNhanVien.DataSource = NhanVienTable;
            grNhanVien.DataBind();
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

    //    class a{
    //     protected string name{
    //         get{return name;}
    //         set{this.name = value;}
    //     }
    //    }
    // a obj = new a();
    // obj.name = 10;

        private DataTable NhanVienTable
        {
            get
            {
                if (ViewState["NhanVienTable"] == null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Phone");
                    dt.Columns.Add("Address");

                    dt.Rows.Add("1", "Nguyen van A", "0546565", "123 Da Nang");
                    dt.Rows.Add("2", "Nguyen van B", "0546565", "123 Da Nang");
                    dt.Rows.Add("3", "Nguyen van C", "0546565", "123 SG");

                    ViewState["NhanVienTable"] = dt;
                }

                return (DataTable)ViewState["NhanVienTable"];
            }
            set
            {
                ViewState["NhanVienTable"] = value;
            }
        }
    }
}