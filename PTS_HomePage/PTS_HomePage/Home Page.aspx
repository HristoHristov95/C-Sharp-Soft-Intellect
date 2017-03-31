<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="PTS_HomePage.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="text-align: center">
                Home
            <asp:Button runat="server" ID="Register" Text="Register" OnClick="Register_Click" Style="float: right" Visible="true" />
                <asp:Button runat="server" ID="Login" Text="Login" OnClick="Login_Click" Style="float: right" Visible="true" />
                <asp:DropDownList ID="User_dropdownlist" AutoPostBack="true" runat="server" OnSelectedIndexChanged="User_dropdownlist_SelectedIndexChanged" Visible="false" Style="float: right">
                    <asp:ListItem Value="name"></asp:ListItem>
                    <asp:ListItem Value="Profile">Profile</asp:ListItem>
                    <asp:ListItem Value="Logout">Logout</asp:ListItem>
                </asp:DropDownList>
            </div>
            <hr />
        </div>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:DropDownList ID="Car_name_list" AutoPostBack="true" runat="server" OnSelectedIndexChanged="Car_name_list_SelectedIndexChanged">
                            <asp:ListItem Selected="True" Value="All"> All cars </asp:ListItem>
                            <asp:ListItem Value="Bmw">BMW</asp:ListItem>
                            <asp:ListItem Value="Audi">Audi</asp:ListItem>
                            <asp:ListItem Value="Vw">Vw</asp:ListItem>
                            <asp:ListItem Value="Volvo">Volvo</asp:ListItem>
                            <asp:ListItem Value="Ferrari">Ferrari</asp:ListItem>
                        </asp:DropDownList></td>
                    <td style="margin-left: 10px">
                        <asp:DropDownList ID="Model_name" AutoPostBack="true" runat="server" Style="margin-left: 10px">
                            <asp:ListItem Selected="True" Value="All models">All models</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button runat="server" Text="Search" ID="Search" OnClick="Search_Click" Style="margin-left: 20px" />
                    </td>
                </tr>
            </table>
        </div>
        <div>

            <asp:Label Text="" runat="server" ID="exception1" />
            <asp:Repeater runat="server" ID="repeater" Visible="false">
                <ItemTemplate>
                    <asp:Table runat="server" CellSpacing="20" CellPadding="0" BorderStyle="Solid">
                        <asp:TableRow>
                            <asp:TableCell>
                         <asp:Label Text="Car brand: " runat="server" /><asp:Label Text='<%# Eval("Car_Brand") %>' runat="server" />                             
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                 <asp:Label Text="Car model: " runat="server" /><asp:Label Text='<%# Eval("Car_Model") %>' runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                  <asp:Label Text="Seller telephone number: " runat="server" /><asp:Label Text='<%# Eval("Seller_Number") %>' runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                 <asp:Label Text="Year of production: " runat="server" /><asp:Label Text='<%# Eval("Year_Of_Production") %>' runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                     <asp:Label Text="Kilometers: " runat="server" /><asp:Label Text='<%# Eval("Kilometer_Count") %>' runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                       <asp:Label Text="Engine type: " runat="server" /><asp:Label Text='<%# Eval("Type") %>' runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                  <asp:Label Text="Horse power: " runat="server" /><asp:Label Text='<%# Eval("Horse_Power") %>' runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                       <asp:Label Text="Region: " runat="server" /><asp:Label Text='<%# Eval("Region_Name") %>' runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Width="700">
                                <asp:Repeater runat="server" ID="insideRepeater">
                                    <ItemTemplate>
                                        <asp:Image ID="img" runat="server" ImageUrl='<%# Eval("Image") %>' Width="400" />
                                    </ItemTemplate>
                                </asp:Repeater>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </ItemTemplate>
            </asp:Repeater>
            <div style="overflow: hidden;">
                <asp:Repeater ID="rptPaging" runat="server" OnItemCommand="rptPaging_ItemCommand">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnPage" CommandName="Page" CommandArgument="<%# Container.DataItem %>" runat="server"><%# Container.DataItem %></asp:LinkButton>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
