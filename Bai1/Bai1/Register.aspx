<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Bai1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Ma NV
        <asp:TextBox ID="txtName" runat="server" AutoPostBack="true" OnTextChanged="TxtName_Change"></asp:TextBox>
        <asp:Label ID="lblName" runat="server"></asp:Label>
        <br />
        <%--RadioButtonList--%>
        <div style="display: flex; align-items: center;">
            <asp:Label runat="server">Nghề Nghiệp:</asp:Label>
            <asp:RadioButtonList ID="rblGender" runat="server" AutoPostBack="true" RepeatDirection="Horizontal"
                OnSelectedIndexChanged="rblGender_Change"
                >
                <asp:ListItem Text="Hoc sinh" Value="M"></asp:ListItem>
                <asp:ListItem Text="Sinh vien" Value="F" Selected="True"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
         <!-- CheckBoxList -->
        <div style="display: flex; align-items: center;">
            <label>Sở thích:</label>

            <asp:CheckBoxList ID="cblHobby" runat="server" RepeatDirection="Horizontal" 
                OnSelectedIndexChanged="cblHobby_Change"
                >
                <asp:ListItem Text="Đá bóng" Value="football" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Nghe nhạc" Value="music"></asp:ListItem>
                <asp:ListItem Text="Đọc sách" Value="book"></asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <!-- DropDownList -->
        <div style="display: flex; align-items: center;">
            <label>Phòng ban:</label>
            <asp:DropDownList ID="ddlDept" runat="server" OnSelectedIndexChanged="ddlDept_Change">
                <asp:ListItem Text="IT" Value="IT"></asp:ListItem>
                <asp:ListItem Text="Kế toán" Value="ACC" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Nhân sự" Value="HR"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="btnGui" Text="Gửi" runat="server" OnClick="BtnGui_Click" />
        <asp:Label runat="server" ID="lblKetQua"></asp:Label>
        <br />
        <br />


    </form>
</body>
</html>
