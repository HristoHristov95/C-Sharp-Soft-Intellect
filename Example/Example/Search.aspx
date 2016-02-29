<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Example.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink NavigateUrl="~/SearchAll.aspx" runat="server" Text="Search with all info"/>
        <br />
        <asp:HyperLink NavigateUrl="~/SearchCapital.aspx" runat="server" Text="Search with capital"/>
        <br />
        <asp:HyperLink NavigateUrl="~/SearchCountry.aspx" runat="server" Text="Search with country"/>
        <br />
        <asp:HyperLink NavigateUrl="~/SearchPopulation.aspx" runat="server" Text="Search with population"/>
        <br />
    </div>
    </form>
</body>
</html>
