<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Homework13.WebForm2" %>

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
        Your password doesnt match 
        <asp:HyperLink NavigateUrl="~/WebForm.aspx" runat="server" Text="Return To Previous Page"/>
    </div>
    </form>
</body>
</html>
