<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="Lab_3.WebForm25" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <title>Checkout</title>

    <br />
<h1 style="font-size: 48px; text-align: center;" class="auto-style1"><span class="newStyle1">Checkout</span></h1>
        <table style="width: 40%; background-color: #660066">
            <tr>
                <td style="height: 20px; width: 163px"><span class="fa-inverse"><strong>Order ID</strong></span></td>
                <td style="height: 20px">
                    <asp:Label ID="Label3" runat="server" CssClass="fa-inverse" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 163px"><span class="fa-inverse"><strong>Order Date</strong></span></td>
                <td>
                    <asp:Label ID="Label4" runat="server" CssClass="fa-inverse" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 163px"><span class="fa-inverse">T<span style="font-weight: bold">ime</span></span></td>
                <td>
                    <asp:Label ID="Label5" runat="server" CssClass="fa-inverse" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 163px"><span class="fa-inverse"><strong>Order Status</strong></span></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <p style="font-size: xx-small; text-align: left;" class="auto-style1">
        &nbsp;</p>
    <p style="font-size: xx-small; text-align: left;" class="auto-style1">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" GridLines="None" ShowFooter="True" CellSpacing="1">
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


        <table style="width: 40%; height: 342px; background-color: #660066">
            <tr>
                <td class="text-left" style="width: 156px; height: 210px">T<span class="fa-inverse">Type your address here</span></td>
                <td class="text-center" style="height: 210px">
                    <asp:TextBox ID="TextBox1" runat="server" Height="155px" Width="520px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-left" style="color: #FFFFFF; width: 156px">mobile number</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBox2" runat="server" Height="40px" Width="528px"></asp:TextBox>
                </td>
            </tr>
        </table>
         </br>
        <asp:Button ID="Button1" runat="server" BackColor="#FF66FF" CausesValidation="False" Height="53px" Text="Place Order" Width="286px" OnClick="Button1_Click" />
        </br>
        

</asp:Content>
