<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="DeleteItemInRepeater_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <thead>
                <tr>
                    <th>ProductName</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="btnDeleteTopic_Click" OnItemDataBound="Repeater1_ItemDataBound">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Name") %></td>
                            <td>
                                <asp:Button ID="btnDeleteTopic" class="btn-sm btncolor" runat="server" CommandName="Delete" CommandArgument='<%# Eval("ProductId") %>' Text="delete" Visible="false" OnClientClick='javascript:return confirm("are you sure?")' />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
    </form>
</body>
</html>
