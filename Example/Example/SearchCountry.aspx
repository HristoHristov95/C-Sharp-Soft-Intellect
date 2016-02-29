<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCountry.aspx.cs" Inherits="Example.SearchCountry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="Country (Not capital letters) :" runat="server" />
        <asp:TextBox runat="server" ID="TextBox"/>
        <br />
        <asp:Button Text="Search" runat="server" OnClick="Unnamed_Click" />
        <br />
           <asp:Repeater runat="server" ID="Repeater">
            <ItemTemplate>
                <asp:Label Text='<%# Eval("Country") %>' runat="server" />
                <br />
                <asp:Label Text='<%# Eval("Capital") %>' runat="server" />
                <br />
                <asp:Label Text='<%# Eval("Population") %>' runat="server" />
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
