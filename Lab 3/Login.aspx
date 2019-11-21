<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab_3.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
    <table align="center" style="width: 50%; background: #FFFFFF">
        <tr>
            <td class="text-center" style="color: purple; font-size: large"><strong>LOGIN</strong></td>
        </tr>
    </table>



    <table align="center" style="width: 50%; background:linear-gradient(to bottom, #33ccff 0%, #ff99cc 100%)">
         <tr>
            <td>
                &nbsp;
            </td>
        </tr>
         <tr>
            <td class="text-center">
                <asp:Image ID="Image1" runat="server" Height="91px" ImageUrl="~/imgfile/0002_Talking Small-assets-C.jpg" Width="134px" />
                &nbsp;
            </td>
        </tr>
         <tr>
            <td class="text-center">
                <strong>&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label>
                </strong>
               </td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td class="text-center">
                &nbsp;
            <strong>
                <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
                </strong>
            </td>
        </tr>
        
        <tr>
            <td class="text-center">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
        </tr>
         <tr>
            <td class="text-center">
               
            </td>
             
        </tr>
        <tr>
            <td class="text-center">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
             
        </tr>
         <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Not a member? &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" href="Registration.aspx">Register</asp:HyperLink>
            </td>
            
             
        </tr>
        </table>



</asp:Content>
