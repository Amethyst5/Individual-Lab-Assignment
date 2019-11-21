<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SuccessOrder.aspx.cs" Inherits="Lab_3.WebForm26" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            <title>SuccessOrder</title>

    <br />
<h1 style="font-size: 48px; text-align: center;" class="auto-style1"><span class="newStyle1">Your order was successfully placed !!</span></h1>
     <br />


    <h1 style="font-size: 48px; text-align: center;" class="auto-style1"><span class="newStyle1">Go to Your Orders to review</span></h1>

   <center> <asp:Button ID="Button1" runat="server" Text="Orders" OnClick="Button1_Click" /> &nbsp; </center>

    <img src="" />

</asp:Content>
