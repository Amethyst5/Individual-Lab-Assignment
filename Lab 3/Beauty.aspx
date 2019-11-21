<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Beauty.aspx.cs" Inherits="Lab_3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <title>Beauty</title>
    <link href="Pagination.css" rel="stylesheet" />

    <center><h1 style="font-size: 48px;" class="auto-style1"><span class="newStyle1">Beauty</span></h1></center>

    <asp:DataList ID="DataList1" runat="server" CellPadding="3" DataKeyField="productID" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal" RepeatColumns="4" RepeatDirection="Horizontal" Width="964px" OnItemCommand="DataList1_ItemCommand">
        <AlternatingItemStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <ItemTemplate>
            <table border="1" class="nav-justified">
                <tr>
                    <td class="text-center">
                        <asp:Label ID="Label1" runat="server" Text="Product ID"></asp:Label>
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("productID") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="text-center">
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("productCategory") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="text-center">
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("productName") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="height: 21px">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("imageUrl") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="text-center">
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("productDescription") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="text-center">Price: $<asp:Label ID="Label6" runat="server" Text='<%# Eval("unitPrice") %>'></asp:Label>
                        .00</td>
                </tr>
                <tr>
                    <td class="text-center">Quantity
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td class="text-center">
                       
                        <asp:ImageButton ID="ImageButton2" runat="server" CommandArgument='<%# Eval("productid")%>' CommandName="addtocart" Height="43px" ImageUrl="~/imgfile/newbutton.JPG" Width="107px"  />
                       
                    </td>
                </tr>
                
            </table>
            <br />
            <br />
        </ItemTemplate>
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Lab3ConnectionString %>" SelectCommand="SELECT productID, productCategory, productName, productDescription, unitPrice, imageUrl FROM ProductDetails WHERE (productCategory = 'Beauty')"></asp:SqlDataSource>

<center>
    <div class="pagination">
    <!--<a href="#">&laquo;</a>-->
    <a href="Beauty.aspx"class="active"  >1</a>
    <!--<a href="Beauty2.aspx">2</a>
    <a href="Beauty2.aspx">&raquo;</a><!--next page-->
   </div>
</center>

</asp:Content>


