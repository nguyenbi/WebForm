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

        protected void LoadDataGRNhanVien()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");

            // Lay tu DB
            // Select * from tblNhanVien
            dt.Rows.Add("1", "Nguyen van A", "0546565", "123 Da Nang");
            dt.Rows.Add("2", "Nguyen van B", "0546565", "123 Da Nang");
            dt.Rows.Add("3", "Nguyen van C", "0546565", "123 SG");
            dt.Rows.Add("4", "Nguyen van D", "0546565", "123 Da Nang");
            dt.Rows.Add("5", "Nguyen van E", "0546565", "123 Can tho");

            grNhanVien.DataSource = dt;
            grNhanVien.DataBind();
        }

        protected void grNhanVien_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                grNhanVien.EditItemIndex = e.Item.ItemIndex;
                LoadDataGRNhanVien();
            }
            if (e.CommandName == "Update")
            {
                TextBox txtName = (TextBox)e.Item.FindControl("txtName");
                string name = txtName.Text;
                // 
                Label lblErrorName = (Label)e.Item.FindControl("lblErrorName");
                if(name.Length > 20)
                {
                  lblErrorName.Text = "Ten khong duoc vuot qua 20";
                }


                TextBox txtPhone = (TextBox)e.Item.FindControl("txtPhone");
                string phone = txtPhone.Text;
                /// Viet ham validate phone

                TextBox txtAdd = (TextBox)e.Item.FindControl("txtAddress");
                string diaChi = txtAdd.Text;

                // Luu DB
                // Insert DB
                ///

                grNhanVien.EditItemIndex = -1;
                LoadDataGRNhanVien();
            }

            if(e.CommandName =="Cancel")
            {
                grNhanVien.EditItemIndex = -1;
                // Load lai DB
                LoadDataGRNhanVien();
            }

            switch (e.CommandName)
            {
                case "Edit":
                    {
                        grNhanVien.EditItemIndex = e.Item.ItemIndex;
                        LoadDataGRNhanVien();
                        break;
                    }
                case "Update":
                    {

                        break;
                    }
                case "Cancel":
                    {

                        break;
                    }
            }
        }
    }
}