<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhanVienGRV.aspx.cs" Inherits="Bai1.NhanVienGRV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="false"  OnRowEditing="gvStudents_RowEditing">
           <Columns>
              <%-- <asp:BoundField DataField="Name" HeaderText="Tên" />--%>
               <asp:TemplateField HeaderText="Tên">
                   <ItemTemplate>
                       <%# Eval("Name") %>
                   </ItemTemplate>
                   <EditItemTemplate>
                       <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name")%>'></asp:TextBox>
                   </EditItemTemplate>
               </asp:TemplateField>
                <asp:CommandField ShowEditButton="true" />
           </Columns>
        </asp:GridView>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
    </form>
</body>
</html>
