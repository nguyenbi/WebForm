using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1
{
    public partial class Login : System.Web.UI.Page
    {
        // thuoc tinh
        int a = 5;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (string.IsNullOrEmpty(name))
            {
                lblName.Text = "Vui longh nha[p";

               
            }
            else
            {
                 lblName.Text = "Xin Chao: " + txtName.Text;
            }    
        }

        protected void Page_Render(object sender, EventArgs e)
        {

        }

    }
}