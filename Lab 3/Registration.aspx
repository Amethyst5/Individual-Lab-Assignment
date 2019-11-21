<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Lab_3.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   

    <table align="center" style="width: 50%; background-color: #FFFFFF">
        <tr>
            <td class="text-center" style="color: purple; font-size: large"><strong>REGISTRATION</strong></td>
        </tr>
    </table>

   

    <table align="center" style="width: 50%; background:linear-gradient(to bottom, #33ccff 0%, #ff99cc 100%) ;">
          <!--#FF66CC -->
        <tr>
            <td class="modal-sm" style="width: 153px; height: 40px; text-align: center;"><strong>
                <asp:Label ID="Label3" runat="server" Text="First Name" Style="color: #000000" CssClass="auto-style1"></asp:Label>
            </strong>:</td>
            <td style="width: 131px; height: 40px;">
                <asp:TextBox ID="txtFn0" runat="server"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 401px; height: 40px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtFn0" ErrorMessage="First name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </tr>
        <tr>
             <td class="modal-sm" style="width: 153px; text-align: center;"><strong>
                <asp:Label ID="Label4" runat="server" Text="Last Name" Style="color: #000000"></asp:Label>
                :</strong></td>
            <td style="width: 131px">
                <asp:TextBox ID="txtLn0" runat="server"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 401px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtLn0" ErrorMessage="Last Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 153px; height: 40px; text-align: center;"><strong>
                <asp:Label ID="Label1" runat="server" Text="Username" Style="color: #000000" CssClass="auto-style1"></asp:Label>
            </strong>:</td>
            <td style="width: 131px; height: 40px;">
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 401px; height: 40px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUser" ErrorMessage="Username is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </tr>
        <tr>
             <td class="modal-sm" style="color: #000000; width: 153px; text-align: center;"><strong>Email Address:</strong></td>
            <td style="width: 131px">
                <asp:TextBox ID="txtEmail0" runat="server" TextMode="Email"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 401px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txtEmail0" ErrorMessage="Email address is required" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtEmail0" ErrorMessage="Invalid email address" ForeColor="#3333CC" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            &nbsp;<asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
           <td class="modal-sm" style="width: 153px; text-align: center;"><span style="color: #000000">&nbsp;<strong>Date of Birth:&nbsp;&nbsp;</strong></span></td>
            <td style="width: 131px">
                <!--  <asp:TextBox ID="txtDob0" runat="server" TextMode="Date"></asp:TextBox>-->
                <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="date"></asp:TextBox>
                &nbsp;
                <td class="modal-sm" style="width: 401px">
               
                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server"
                    ControlToValidate="Textbox1" ErrorMessage="Must be 18 or older to register" ForeColor="Red"></asp:RequiredFieldValidator>

                &nbsp;<asp:RangeValidator ID="RangeValidator2" runat="server"
                    ControlToValidate="Textbox1" Type="Date" MaximumValue="01/01/2001" MinimumValue="01/01/1980" ErrorMessage="Must be 18 or older to register" ForeColor="#3333CC"></asp:RangeValidator>
              
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 153px; text-align: center;"><span style="color: #000000">&nbsp;<strong>Phone Number:</strong></span></td>
            <td style="width: 131px">
                <asp:TextBox ID="txtNum0" runat="server" TextMode="Phone"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 401px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="txtNum0" ErrorMessage="Must be a valid phone number ie. ###-###-####" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtNum0" ErrorMessage="Invalid phone number" ForeColor="#3333CC" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
           <td class="modal-sm" style="width: 153px; text-align: center;"><span style="color: #000000">&nbsp;</span><strong><span style="color: #000000">Password:&nbsp;&nbsp;&nbsp;</span><span style="color: #FFFFFF">&nbsp;</span></strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td style="width: 131px">
                <asp:TextBox ID="txtP3" runat="server" TextMode="Password"></asp:TextBox>
                <ajaxToolkit:PasswordStrength ID="txtP3_PasswordStrength" runat="server" BehaviorID="txtP3_PasswordStrength" TargetControlID="txtP3" HelpStatusLabelID="Label6" DisplayPosition="RightSide" StrengthIndicatorType="Text" 

PreferredPasswordLength="8" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" PrefixText="Strength : "/>
                </ajaxToolkit:PasswordStrength>
           
            </td>
            <td class="modal-sm" style="width: 401px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="txtP3" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtP3" Display="Dynamic" ErrorMessage="Password must be 8-10 characters long with at least one numeric,&lt;/br&gt;one upper case character and one special character." ForeColor="Red" ValidationExpression="(?=^.{8,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="color: #000000; width: 153px; text-align: center;"><strong>Confirm Password:</strong></td>
            <td style="width: 131px">
                <asp:TextBox ID="txtP4" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 401px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="Password must match" ControlToValidate="txtP4" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtP3" ControlToValidate="txtP4" ErrorMessage="Passwords does not match" ForeColor="#3333CC"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
           <td class="modal-sm" style="width: 153px">&nbsp;</td>
            <td style="width: 131px">
                <asp:Button ID="Button2" runat="server" Text="Register" Width="134px" OnClick="Button2_Click" />
            </td>
            <td class="modal-sm" style="width: 401px">&nbsp;</td>
        </tr>
        <tr>
           <td class="modal-sm" style="width: 153px; text-align: center;"><strong>
                <asp:Label ID="lblRegisteredUsers0" runat="server" Text="Registered Users" Style="color: #000000"></asp:Label>
            </strong></td>
            <td style="width: 131px">&nbsp;</td>
            <td class="modal-sm" style="width: 401px">&nbsp;</td>
        </tr>
        <tr>
           <td>&nbsp;</td>
        </tr>
    </table>

   

</asp:Content>
