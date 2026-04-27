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
        protected void Page_Load(object sender, EventArgs e)
        {
            
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
    }
}