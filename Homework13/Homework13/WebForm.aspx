<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Homework13.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div class="top-menu" >
        </div>
    <div>
        <asp:Label Text="Username" runat="server" />
        <asp:TextBox runat="server" ID="txtBox" />
        <br />
        <asp:Label Text="Password" runat="server" />
        <asp:TextBox runat="server" ID="Password" TextMode="Password"/>
        <br />
        <asp:Label Text="Repeat Password" runat="server" />
        <asp:TextBox runat="server" ID="RepeatedPassword" TextMode="Password"/>
        <br />
        <asp:Label Text="Age" runat="server" />
        <asp:TextBox runat="server" ID="Age" TextMode="Number"/>
        <br />
        <asp:Label Text="E-mail" runat="server" />
        <asp:TextBox runat="server" ID="Email" />
        <br />
        <asp:Button Text="Register" runat="server" OnClick="Register"/>
        <br />
    </div>
    </form>
</body>
</html>
