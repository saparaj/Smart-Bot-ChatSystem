<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"  CodeFile="Register.aspx.cs" Inherits="_Default" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <table class="intabular">
<tr>
<td colspan="2">
<h2>Register</h2>
</td>
</tr>

<tr>
<td colspan="2">
All fields marked * are compulsary
</td>
</tr>

<tr>
<td>
First Name
</td>
<td>

    <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
        runat="server" ControlToValidate="txtfname" 
        ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z]+$">Enter 
    valid name</asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>
Middle Name
</td>
<td>

    <asp:TextBox ID="txtmname" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
        runat="server" ControlToValidate="txtmname" 
        ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z]+$">Enter 
    valid name</asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>
Last Name
</td>
<td>

    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator3" 
        runat="server" ControlToValidate="txtlname" 
        ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z]+$">Enter 
    valid name</asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>

    <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label>

</td>
<td>

    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:DropDownList>

</td>
</tr>

<tr>
<td>
Email
</td>
<td>

    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator4" 
        runat="server" ErrorMessage="RegularExpressionValidator" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
        ControlToValidate="txtemail">Enter Valid Email</asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>
Contact No
</td>
<td>

    <asp:TextBox ID="txtcontact" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator5" 
        runat="server" ErrorMessage="RegularExpressionValidator" 
        ValidationExpression="^[7-9][0-9]{9}$" ControlToValidate="txtcontact">Enter Valid Contact
    </asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>
City
</td>
<td>

    <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>

</td>
</tr>

<tr>
<td>
Address
</td>
<td>

    <asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine" 
        ontextchanged="txtaddress_TextChanged"></asp:TextBox>

</td>
</tr>


<tr>
<td>
    Username</td>
<td>

    <asp:TextBox ID="txtusername" runat="server" 
        ontextchanged="txtusername_TextChanged"></asp:TextBox>

    *<asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Check" />
    <asp:Label ID="lblusername" runat="server" ForeColor="#3333CC"></asp:Label>
    </td>
</tr>


<tr>
<td>
    Password</td>
<td>

    <asp:TextBox ID="txtpassword" runat="server" Enabled="False" 
        TextMode="Password"></asp:TextBox>

    *</td>
</tr>

<tr>
<td>
Uid
</td>
<td>

    <asp:TextBox ID="txtuid" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>

</td>
</tr>


<tr>
<td colspan="2">

   

    <asp:Label ID="Label1" runat="server" ForeColor="Red" 
        Text="Please enter all required fields" Visible="False"></asp:Label>

   

</td>
</tr>

<tr>
<td colspan="2">

    <asp:Button ID="Button1" runat="server" Text="Register" 
        onclick="Button1_Click" />

</td>
</tr>
</table>
</center>
</asp:Content>
