<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGrid.aspx.cs" Inherits="Bai1.DataGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataGrid
                ID="DataGrid1"
                runat="server"
                AutoGenerateColumns="False"
                DataKeyField="ID"
                OnItemCommand="DataGrid1_ItemCommand">
                <Columns>

                 
                    <asp:TemplateColumn HeaderText="ID">

                        <ItemTemplate>

                            <%# DataBinder.Eval(Container.DataItem, "ID") %>
                        </ItemTemplate>

                    </asp:TemplateColumn>

                    
                    <asp:TemplateColumn HeaderText="NAME">

                       
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "NAME") %>
                        </ItemTemplate>

                        <EditItemTemplate>

                            <asp:TextBox
                                ID="txtName"
                                runat="server"
                                Text='<%# DataBinder.Eval(Container.DataItem, "NAME") %>' />

                        </EditItemTemplate>

                    </asp:TemplateColumn>

                   
                    <asp:TemplateColumn HeaderText="Action">

                        <ItemTemplate>

                            <asp:LinkButton
                                runat="server"
                                CommandName="Edit"
                                Text="Sua" />

                        </ItemTemplate>

                        <EditItemTemplate>

                            <asp:LinkButton
                                runat="server"
                                CommandName="Update"
                                Text="Cap nhat" />

                            <asp:LinkButton
                                runat="server"
                                CommandName="Cancel"
                                Text="Cancel" />

                        </EditItemTemplate>

                    </asp:TemplateColumn>

                </Columns>

            </asp:DataGrid>
        </div>
    </form>
</body>
</html>
