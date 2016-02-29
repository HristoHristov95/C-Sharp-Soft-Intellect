<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Example.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink NavigateUrl="~/Search.aspx" runat="server" Text="Search"/>
        <br />
        <asp:HyperLink NavigateUrl="~/AddInfo.aspx" runat="server" Text="Add"/>
    </div>
    </form>
</body>
</html>
