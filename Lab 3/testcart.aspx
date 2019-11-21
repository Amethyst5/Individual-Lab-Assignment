<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testcart.aspx.cs" Inherits="Lab_3.WebForm16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <title>Cart</title>

    <br />
<h1 style="font-size: 48px; text-align: center;" class="auto-style1"><span class="newStyle1">Cart</span></h1>
<p style="font-size: xx-small; text-align: left;" class="auto-style1">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Continue Shopping</asp:HyperLink>
</p>
    <p style="font-size: xx-small; text-align: left;" class="auto-style1">
        <asp:LinkButton ID="LinkButton4" runat="server">LinkButton</asp:LinkButton>
        <asp:LinkButton ID="LinkButton5" runat="server">LinkButton</asp:LinkButton>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
       </p>
    <p style="font-size: xx-small; text-align: right;" class="auto-style1">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" GridLines="None" OnRowDeleting="GridView1_RowDeleting" ShowFooter="True" CellSpacing="1">
            <Columns>
                <asp:BoundField DataField="no" HeaderText="No.">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="productid" HeaderText="Product ID">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="productcategory" HeaderText="Product Category">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="productname" HeaderText="Product Name">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="productdescription" HeaderText="Product Description">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="unitprice" HeaderText="Product Price">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="productquantity" HeaderText="Product Quantity">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:ImageField DataImageUrlField="imageurl" HeaderText="Product Image">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:ImageField>
                <asp:BoundField DataField="totalprice" HeaderText="Total Price">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" Height="50px" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" OnClick="LinkButton1_Click">Clear Cart</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
</p>

    



</asp:Content>
