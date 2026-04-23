<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bai1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        .clsKhung {
            width: 450px;
            height: 350px;
            margin: 30px auto;
            border: 5px solid #32ab61;
            text-align: center;
        }
        .clsMargin{
            margin:10px auto;
           
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="clsKhung">
            Nhập tên: <asp:TextBox ID="txtName" Class="clsMargin" runat="server" /><br>
            <asp:Button ID="btnLogin" Class="clsMargin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br />
            <asp:Label ID="lblName" runat="server" />
        </div>
    </form>
</body>
</html>
