﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="sampleProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink NavigateUrl="~/CalculateInfo.aspx" runat="server" Text="Calculate information." />
        <br />
        <asp:HyperLink NavigateUrl="~/EnterInfo.aspx" runat="server" Text="Enter information into database." />
    </div>
    </form>
</body>
</html>