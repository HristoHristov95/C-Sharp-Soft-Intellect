<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPopulation.aspx.cs" Inherits="Example.SearchPopulation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Label Text="Minimum Population :" runat="server" />
        <asp:TextBox runat="server" ID="TextBox"/>
        <br />
        <asp:Label Text="Maximum Population" runat="server" />
        <asp:TextBox runat="server" ID="TextBox1"/>
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
        <asp:Label Text="" runat="server" ID="label"/>
    </div>
    </form>
</body>
</html>
