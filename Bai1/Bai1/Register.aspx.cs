using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Su dung để khoi tạo cac gia trị default control
            // Moi mo IsPostBack = false
            if (!IsPostBack) 
            {
               
                // Khoi tạo giá trị
                lblKetQua.Text = "Xin chao";
            }
            else
            {
                // Truong

            }
        }

        protected void BtnGui_Click(object sender, EventArgs e)
        {
           string name = txtName.Text;

            //Int32[] arrA = new Int32[] { 1, 2, 5, 6, 4 };
            //for(int k = 6; k > 4; k--)
            //{
            //    if(arrA[k] == 0)
            //    {
            //        break;
            //    }
            //}

            //arrA[0] = 2;
            //arrA[1] = 4;

            // CheckboxList
            // string soThich = cblHobby.SelectedValue;

            List<string> lstHobbyChecked = new List<string>();
            foreach (ListItem item in cblHobby.Items)
            {
                if (item.Selected)
                {
                    lstHobbyChecked.Add(item.Value);
                }
            }

            string ngheNghiep = rblGender.SelectedValue;
            string phongBan = ddlDept.SelectedValue;
            string hobbistr = string.Join(", ", lstHobbyChecked);
            string ketQua  = name + " So thich là: " + hobbistr +
                " Nghề nghiệp: " + ngheNghiep + " Phòng ban: " + phongBan;

            lblKetQua.Text = ketQua;
        }

        protected void TxtName_Change(object sender, EventArgs e)
        {

            if (txtName.Text.Length > 15)
            {
                lblName.Text = "Vui lòng nhập mã số nhỏ hơn 15 ký tự";
            }
            else if (txtName.Text == "A001")
            {
                lblName.Text = "Laptop Asus A001";
            }
            else
            {
                lblName.Text = "Khong tim thây";
            }
        }

        protected void rblGender_Change(object sender, EventArgs e)
        {
            if (rblGender.SelectedValue == "M") // Học sinh
            {
                foreach (ListItem item in cblHobby.Items)
                {
                    if (item.Value == "football" || item.Value == "music")
                    {
                        item.Selected = true;
                    }
                }
            }
        }

        protected void cblHobby_Change(object sender, EventArgs e)
        {

        }

        protected void ddlDept_Change(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {

        }
    }
}