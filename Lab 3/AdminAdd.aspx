<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminAdd.aspx.cs" Inherits="Lab_3.WebForm20" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <title>Admin Add</title>

      <br />

<h1 style="font-size: 48px; text-align: center;" class="auto-style1"><span class="newStyle1">ADD PRODUCTS</span></h1>

    <table style="width: 40%; background: linear-gradient(to bottom, #33ccff 0%, #ff99cc 100%)" align="center">
         <tr>
            <td style="width: 190px"></td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td style="width: 190px"><strong>Product ID</strong></td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 190px"><strong>Product Category</strong></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 190px"><strong>Product Name</strong></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 190px"><strong>Product Description</strong></td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 190px"><strong>Unit Price</strong></td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 190px"><strong>Image</strong></td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
            </td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>
                <strong>
                <asp:Label ID="Label3" runat="server"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>


</asp:Content>
