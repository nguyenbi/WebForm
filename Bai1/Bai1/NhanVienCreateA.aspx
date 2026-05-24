<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhanVienCreateA.aspx.cs" Inherits="Bai1.NhanVienCreateA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="clsHeader">
                <h3>Thêm mới nhân viên</h3>
                <div>
                    <table>
                        <tr>
                            <td>
                                <asp:Label Text="ID" runat="server"></asp:Label></td>
                            <td>
                                <asp:TextBox runat="server" ID="txtID"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label Text="Tên" runat="server"></asp:Label></td>
                            <td>
                                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label Text="Dien Thoai" runat="server"></asp:Label></td>
                            <td>
                                <asp:TextBox runat="server" ID="txtDienThoai"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label Text="Địa chỉ" runat="server"></asp:Label></td>
                            <td>
                                <asp:TextBox runat="server" ID="txtDiaChi"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>

            </div>


            <div class="clsChiTiet">
                <h4>Phòng ban</h4>
                <div>
                    <asp:DataGrid runat="server" ID="dgPhongBan" AutoGenerateColumns="false">
                        <Columns>

                            <asp:TemplateColumn HeaderText="ID">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblIdDept" Text='1'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateColumn>

                            <asp:TemplateColumn FooterText="Ma Phong ban">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblMaPhongBan" Text="CNTT"></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtMaPhongBan" Text="CNTT"></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateColumn>

                            <asp:TemplateColumn FooterText="Ten Phong Ban">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblMaPhongBan" Text="CNTT"></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtMaPhongBan" Text="CNTT"></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateColumn>

                            <asp:TemplateColumn FooterText=Action">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblMaPhongBan" Text="CNTT"></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtMaPhongBan" Text="CNTT"></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateColumn>

                        </Columns>
                    </asp:DataGrid>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
