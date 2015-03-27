<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteByCheckBox.aspx.cs" Inherits="DeleteByCheckBox" %>

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
                <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Name") %></td>
                            <td>
                                <asp:CheckBox ID="CheckBox1" runat="server" value='<%# Eval("ProductId")%>' Visible="false"/>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
            <tfoot>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Visible="false" />
                    </td>
                </tr>
            </tfoot>
        </table>
    </div>
    </form>
</body>
</html>
