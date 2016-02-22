<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateInfo.aspx.cs" Inherits="sampleProject.CalculateInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="" runat="server" ID="exception1"/>
      <asp:Repeater runat="server" ID="repeater">
            <ItemTemplate>
                <asp:Label Text='<%# Eval("Date") %>' runat="server" />
                <br />
                <asp:Label Text='<%# Eval("Expenses") %>' runat="server" />
                <br />
                <asp:Label Text='<%# Eval("Price") %>' runat="server" />
                <br />
                <br />
            </ItemTemplate>
        </asp:Repeater>
        <br />
        <asp:Label Text="Choose option:" runat="server" />
        <asp:DropDownList runat="server" ID="dropdown" OnSelectedIndexChanged="onSelected" AutoPostBack="true">
            <asp:ListItem Text="Weekly" Value="1"/>
            <asp:ListItem Text="Monthly" Value="2"/>
            <asp:ListItem Text="Yearly" Value="3"/>
        </asp:DropDownList>
        <br />
        <asp:Label Text="Result :" runat="server" />
        <asp:Label Text="" runat="server" ID="res"/>
        <br />
    </div>
    </form>
</body>
</html>
