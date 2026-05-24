<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhanVienDGDatabase.aspx.cs" Inherits="Bai1.NhanVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataGrid ID="grNhanVien" runat="server" AutoGenerateColumns="false" OnItemCommand="grNhanVien_ItemCommand"  
                OnItemDataBound="grNhanVien_ItemDataBound">
                <Columns>
                    <asp:TemplateColumn HeaderText="ID">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "ID") %>
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Name">

                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Name") %>
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Name") %>'></asp:TextBox>
                            <br />
                            <asp:Label ID="lblErrorName" runat="server" ForeColor="Red"></asp:Label>
                        </EditItemTemplate>

                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Dien Thoai">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem,"Phone") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPhone" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Phone") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Address">
                        <ItemTemplate><%# DataBinder.Eval(Container.DataItem, "Address") %></ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAddress" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Address") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Action">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" CommandName="Edit" Text="Sua"></asp:LinkButton>
                            <asp:LinkButton runat="server" ID="btnDelete" CommandName="Delete" Text="Xoa"></asp:LinkButton>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton runat="server" CommandName="Update" Text="Luu"></asp:LinkButton>
                            <asp:LinkButton runat="server" CommandName="Cancel" Text="hủy"></asp:LinkButton>
                        </EditItemTemplate>
                    </asp:TemplateColumn>

                </Columns>
            </asp:DataGrid>

            <div>
                <table>
                    <tr>
                        <td></td>
                        <td>
                            <asp:TextBox ID="txtNewName" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNewPhone" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNewAddress" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnCreate"
                                runat="server"
                                Text="Tao moi" OnClick="btnCreate_Click" />
                        </td>
                    </tr>
                </table>

                <br />
            </div>
            <div>
                <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
        </div>
    </form>
</body>
</html>
