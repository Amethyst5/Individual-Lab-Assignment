<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="Lab_3.WebForm27" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="font-size: 48px; text-align: center;" class="auto-style1"><span class="newStyle1">Order History</span></h1>

    <table border="1" style="width: 50%; height: 264px; background: linear-gradient(to bottom, #33ccff 0%, #ff99cc 100%)">
        <tr>
            <td class="auto-style1" style="font-size: large; width: 273px"><strong>Select Your Order ID</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="103px" Width="587px" DataSourceID="SqlDataSource1" DataTextField="orderID" DataValueField="orderID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 273px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Height="39px" Text="View Order Details" Width="167px" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    </br>
    </br>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataSourceID="SqlDataSource2" GridLines="None" Visible="False">
        <Columns>
            <asp:BoundField DataField="no" HeaderText="No" SortExpression="no" />
            <asp:BoundField DataField="productID" HeaderText="Product ID" SortExpression="productID" />
            <asp:BoundField DataField="productCategory" HeaderText="Product Category" SortExpression="productCategory" />
            <asp:BoundField DataField="productName" HeaderText="Product Name" SortExpression="productName" />
            <asp:BoundField DataField="productDescription" HeaderText="Product Description" SortExpression="productDescription" />
            <asp:BoundField DataField="unitPrice" HeaderText="Unit Price" SortExpression="unitPrice" />
            <asp:BoundField DataField="productQuantity" HeaderText="Product Quantity" SortExpression="productQuantity" />
            <asp:BoundField DataField="imageUrl" HeaderText="Image Url" SortExpression="imageUrl" />
            <asp:BoundField DataField="totalPrice" HeaderText="Total Price" SortExpression="totalPrice" />
            <asp:BoundField DataField="userName" HeaderText="User Name" SortExpression="userName" />
            <asp:BoundField DataField="orderID" HeaderText="Order ID" SortExpression="orderID" />
            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
            <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
</asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Lab3ConnectionString4 %>" SelectCommand="SELECT * FROM [Order] WHERE ([userName] = @userName)">
        <SelectParameters>
            <asp:SessionParameter Name="userName" SessionField="username" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Lab3ConnectionString5 %>" SelectCommand="SELECT * FROM [Order] WHERE ([orderID] = @orderID)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="orderID" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
</asp:SqlDataSource>

</asp:Content>
