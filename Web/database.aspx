<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="database.aspx.cs" Inherits="database" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <style type="text/css">
        .style7
       {
           width: 160px;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2 style="color: #FFFFFF; background-color: #000080;">      
        Database Details</h2>
<table class="intabular" style="width: 102%; height: 116px;">
<tr>
<td class="style7">
<asp:Button ID="Button1" runat="server" Text="Saving Account" Font-Bold="True" 
        Font-Size="Medium" onclick="Button1_Click" />
</td>
<td rowspan="7">
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
<tr>
<td class="style7">
<asp:Button ID="Button2" runat="server" Text="Salary Account" Font-Bold="True" 
        Font-Size="Medium" onclick="Button2_Click" />
</td>
</tr>
<tr>
<td class="style7">
<asp:Button ID="Button3" runat="server" Text="Personal Loan" Font-Bold="True" 
        Font-Size="Medium" onclick="Button3_Click" />
</td>
</tr>
<tr>
<td class="style7">
<asp:Button ID="Button4" runat="server" Text="Home Loan" Font-Bold="True" 
        Font-Size="Medium" onclick="Button4_Click" />
</td>
</tr>
<tr>
<td class="style7">
<asp:Button ID="Button5" runat="server" Text="Car Loan" Font-Bold="True" 
        Font-Size="Medium" onclick="Button5_Click" />
</td>
</tr>
<tr>
<td class="style7">
<asp:Button ID="Button6" runat="server" Text="Cheque" Font-Bold="True" 
        Font-Size="Medium" onclick="Button6_Click" />
</td>
</tr>
<tr>
<td class="style7">
<asp:Button ID="Button7" runat="server" Text="ATM and Debit" Font-Bold="True" 
        Font-Size="Medium" onclick="Button7_Click" />
</td>
</tr>
<tr>
<td colspan="2">
<asp:Button ID="Button8" runat="server" Text="Back" Font-Bold="True" 
        Font-Size="Medium" onclick="Button8_Click" />
</td>
</tr>
</table>
</asp:Content>

