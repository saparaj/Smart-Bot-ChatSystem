<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BranchLoc.aspx.cs" Inherits="BranchLoc" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center><h2>Branch Locator</h2></center>
<table>
<tr>
<td>
City:&nbsp;
    <asp:DropDownList ID="ddlcity" runat="server">
        <asp:ListItem>Mumbai</asp:ListItem>
        <asp:ListItem>Pune</asp:ListItem>
    </asp:DropDownList>
&nbsp;</td>
<td>
&nbsp;
Station:&nbsp;
    <asp:TextBox ID="txtstation" runat="server"></asp:TextBox>
&nbsp;</td>
<td>
&nbsp;
Area:&nbsp;&nbsp;
    <asp:TextBox ID="txtarea" runat="server"></asp:TextBox>
&nbsp;</td>
</tr>
<tr>
<td colspan="3">

    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />

</td>
</tr>
<tr>
<td colspan="3">

    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>

</td>
</tr>


</table>
</asp:Content>