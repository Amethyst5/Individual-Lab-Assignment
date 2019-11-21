<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminEditDelete.aspx.cs" Inherits="Lab_3.WebForm28" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="font-size: 48px; text-align: center;" class="auto-style1"><span class="newStyle1">EDIT and DELETE PRODUCTS</span></h1>

    <strong>

    <asp:Label ID="Label1" runat="server" CssClass="auto-style1" style="font-size: large"></asp:Label>

    <br />
    </strong>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="productID" GridLines="None" OnRowEditing="GridView1_RowEditing" ShowFooter="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" >
        <Columns>
            <asp:TemplateField HeaderText="Product ID">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("productid") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("productid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Product Category">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("productcategory") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("productcategory") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Product Name">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("productname") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("productname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Product Description">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("productdescription") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("productdescription") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Unit Price">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("unitprice") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("unitprice") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Image Url">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox6" runat="server" Text='<%# Eval("imageurl") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Operations">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton6" runat="server" CommandName="Update">Update</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="LinkButton7" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton4" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton5" runat="server" CommandName="Delete">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
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
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Lab3ConnectionString %>" DeleteCommand="DELETE FROM [ProductDetails] WHERE [productID] = @productID" InsertCommand="INSERT INTO [ProductDetails] ([productID], [productCategory], [productName], [productDescription], [unitPrice], [imageUrl]) VALUES (@productID, @productCategory, @productName, @productDescription, @unitPrice, @imageUrl)" SelectCommand="SELECT * FROM [ProductDetails]" UpdateCommand="UPDATE [ProductDetails] SET [productCategory] = @productCategory, [productName] = @productName, [productDescription] = @productDescription, [unitPrice] = @unitPrice, [imageUrl] = @imageUrl WHERE [productID] = @productID">
        <DeleteParameters>
            <asp:Parameter Name="productID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="productID" Type="Int32" />
            <asp:Parameter Name="productCategory" Type="String" />
            <asp:Parameter Name="productName" Type="String" />
            <asp:Parameter Name="productDescription" Type="String" />
            <asp:Parameter Name="unitPrice" Type="Int64" />
            <asp:Parameter Name="imageUrl" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="productCategory" Type="String" />
            <asp:Parameter Name="productName" Type="String" />
            <asp:Parameter Name="productDescription" Type="String" />
            <asp:Parameter Name="unitPrice" Type="Int64" />
            <asp:Parameter Name="imageUrl" Type="String" />
            <asp:Parameter Name="productID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
