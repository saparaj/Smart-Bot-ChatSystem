<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
<tr>
<td>
 <table class="intabular">
 <tr>
<td align="center" colspan="2">
<h2>Expert Login</h2>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
</td>
</tr>
<tr>
<td class="style1" rowspan="2" >
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Login" />
    </td>
<td class="style1" rowspan="2">
    <asp:Button ID="Button4" runat="server" Text="Cancel" onclick="Button4_Click" />
    <br />
    </td>
    </tr>
     </table>
</td>
<td>
</td>
<td>
</td>
<td>
</td>
<td>
</td>
<td>
</td>
<td>
</td>
<td>
</td>
<td>
</td>



<td>
    <table class="intabular">
<tr>
<td align="center" colspan="2">
<h2>User Login</h2>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
</td>
</tr>
<tr>
<td class="style1">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
    </td>
<td class="style1">
    <asp:Button ID="Button2" runat="server" Text="Cancel" onclick="Button2_Click" />
    <br />
    </td>
    </tr>
     </table>
     
     
</td>
</tr>
</table>
<br />
<a href="Register.aspx" style="text-decoration:bone; color:white">
    <b style="font-size: large; font-style: normal; font-weight: bolder; background-color: #000000;">Not a registered user?</b></a>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style1
        {
            height: 34px;
        }
    </style>
</asp:Content>
