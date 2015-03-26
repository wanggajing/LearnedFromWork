<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VerificationCode.aspx.cs" Inherits="Verification_VerificationCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Please enter the contents of the picture<br />
        <asp:TextBox ID="YZM" runat="server"></asp:TextBox>
        <img src="YZM.ashx" onclick="this.src='YZM.ashx'"/><%-- the onclick attribute make sure when verification code is clicked, it refresh
            itself --%>         
        <asp:Label ID="YZMError" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
     </div>
    </form>
</body>
</html>
