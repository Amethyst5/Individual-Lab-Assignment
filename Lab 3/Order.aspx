<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Lab_3.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <title>Checkout</title>

    <br />
<h1 style="font-size: 48px; text-align: center;" class="auto-style1"><span class="newStyle1">Orders</span></h1>

           <span class="auto-style1" style="font-size: large"><strong>Order ID:<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </strong></span>
<br />
<br />
<asp:Button ID="Button1" runat="server" Height="39px" OnClick="Button1_Click" Text="Download Invoice" Width="192px" />
<br />
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="323px">
        <table style="width: 100%; background-color: #CCCCFF; height: 207px;" border="1">
            <tr>
                <td class="text-center" style="color: #660066; font-size: xx-large" ><strong>Invoice</strong></td>
            </tr>
            <tr>
                <td class="auto-style1" style="font-size: small"><strong>Order ID:
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                    <br />
                    <br />
                    Order Date:<asp:Label ID="Label5" runat="server"></asp:Label>
                    <br />
                    <br />
                    Order Time:<asp:Label ID="Label6" runat="server"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <table style="width: 100%; height: 133px; background-color: #CCCCFF" border="1">
                        <tr>
                            <td class="auto-style1" style="width: 786px; font-size: large"><strong>Buyer Address<br /> </strong>
                                <asp:Label ID="Label7" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style1" style="font-size: large"><strong>Seller Address<br /> </strong>
                                <asp:Label ID="Label8" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height: 365px"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" GridLines="None" ShowFooter="True" CellSpacing="1" Height="446px">
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
</td>
            </tr>
            <tr>
                <td class="auto-style1" style="font-size: medium; height: 95px;"><strong>Grand Total:
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                    </strong></td>
            </tr>
             <tr>
                <td style="font-size: small"> <strong>Declaration: We declare that this invoice shows actual price of the goods described inclusive of taxes and that all particulars are true and correct.<br />
                    <br />
                    THIS IS A COMPUTER GENERATED INVOICE AND DOES NOT REQUIRE A SIGNATURE.</strong></td>
            </tr>
        </table>
    </asp:Panel>
&nbsp;
</asp:Content>
