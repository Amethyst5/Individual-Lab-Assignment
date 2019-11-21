<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Lab_3.WebForm29" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="font-size: 48px; text-align: center;" class="auto-style1"><span class="newStyle1">ADMIN PAGE</span></h1>



    <table style="width: 50%; background: linear-gradient(to bottom, #33ccff 0%, #ff99cc 100%)" align="center">
        <tr>
            <td class="text-center" style="font-size: x-large"><strong>ACTIONS</strong></td>
        </tr>
        <tr>
            <td style="font-size: medium"><a href="AdminAdd.aspx">ADD PRODUCTS</a> </td>
        </tr>
        <tr>
            <td style="font-size: medium"><a href="AdminEditDelete.aspx">EDIT OR DELETE PRODUCTS</a></td>
        </tr>
        <tr>
            <td></td>
        </tr>
    </table>



</asp:Content>
