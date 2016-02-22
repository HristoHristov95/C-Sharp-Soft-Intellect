<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnterInfo.aspx.cs" Inherits="sampleProject.EnterInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="Enter date:" runat="server" />
        <asp:TextBox runat="server"  ID="data123" TextMode="Date"/>
        <br />
        <asp:Label Text="Enter expense:" runat="server" />
        <asp:TextBox runat="server" ID="product"/>
        <br />
        <asp:Label Text="Enter price:" runat="server" />
        <asp:TextBox runat="server" ID="price"/>
        <br />
        <asp:Button Text="Enter Data" runat="server" OnClick="EnterButton"/>
        <br />
        <br />
        <asp:Label Text="" runat="server" ID="exceptionHandling"/>
    </div>
    </form>
</body>
</html>
