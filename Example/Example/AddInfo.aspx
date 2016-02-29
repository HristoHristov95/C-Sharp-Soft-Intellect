<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddInfo.aspx.cs" Inherits="Example.AddInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:Label Text="Country:" runat="server" />
        <asp:TextBox runat="server" id="textbox1"/>
        <br />
        <asp:Label Text="Capital:" runat="server" />
        <asp:TextBox runat="server" id="textbox2"/>
        <br />
        <asp:Label Text="Population:" runat="server" />
        <asp:TextBox runat="server" id="textbox3"/>
        <br />
        <asp:Button Text="Enter" runat="server" OnClick="Unnamed_Click"/>
        <br />
        <asp:Label Text="" runat="server" ID="label"/>
    </div>
    </form>
</body>
</html>
