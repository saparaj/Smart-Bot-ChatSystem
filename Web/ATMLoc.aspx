<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ATMLoc.aspx.cs" Inherits="ATMLoc" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   
<table class="ATMtabular" width="500">
<tr>
<td width="65%"></td>
<td align="center">
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Mumbai</asp:ListItem>
        <asp:ListItem>Pune</asp:ListItem>
    </asp:DropDownList>
    <br /><asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />
    </td>
</tr>

<tr>
<td rowspan="5"><center>
<div style="display:block; height:180px; overflow:scroll; width:65%" >
    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        Width="193px" Font-Size="Small">
        <RowStyle ForeColor="#000066" />
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    </div></center>
    </td>
<td ></td>
</tr>
<tr>

<td rowspan="3" align="center">
    
    <asp:TextBox ID="txtarea" runat="server" Width="132px">Enter Area</asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Search" onclick="Button2_Click" />
    </td>
</tr>
<tr>

<td></td>
</tr>
<tr>

<td></td>
</tr>
<tr>
<td></td>
<td>&nbsp;</td>
</tr>
</tr>
<tr>
<td></td>
<td>&nbsp;</td>
</tr>
</tr>
<tr>
<td></td>
<td>&nbsp;</td>
</tr>
<tr>
<td></td>
<td>&nbsp;</td>
</tr>
<tr>
<td></td>
<td>&nbsp;</td>
</tr>
<tr>
<td></td>
<td>&nbsp;</td>
</tr>

</table>

</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    </asp:Content>
