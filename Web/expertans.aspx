<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="expertans.aspx.cs" Inherits="expertans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 148px;
            text-align: center;
            
        }
        .style2
        {
            text-align: center;
            width: 289px;
        }
        .style5
        {
            text-align: center;
            width: 188px;
        }
       .style6
       {
           height: 35px;
       }
        .style7
        {
            height: 148px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h2 style="color: #FFFFFF; background-color: #000080;">      
        Expert Help</h2>
<table class="intabular" style="width: 2%; height: 116px;">
<tr>
<td align= "center" class="style5"> 
<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
    Text="Find Unanswered Question" Font-Bold="True" Font-Size="Medium" />
 </td>    
  <td align="center" class="style2"> 
    <asp:Label ID="Label2" runat="server" Font-Size="X-Large" ForeColor="Black" 
        Text="Unanswered Question" Font-Bold="True"></asp:Label>
    </td>
  </tr>  
  <tr> 
  <td align="center" class = "style1"> 
    <asp:Label ID="Label3" runat="server" Text="Provide the answer" 
        Font-Size="X-Large" ForeColor="Black"></asp:Label>
</td>
<td class="style7">
       <asp:TextBox ID="TextBox1" runat="server" Width="402px" Height="46px"></asp:TextBox>
       </td>
  </tr> 
   <tr> 
  <td class="style6"> 
    <asp:Button ID="Button4" runat="server" Text="Submit Answer" Font-Bold="True" 
        Font-Size="Medium" onclick="Button4_Click" />

      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

      <asp:Button ID="Button5" runat="server" Text="Skip" Font-Bold="True" 
        Font-Size="Medium" onclick="Button5_Click" />
</td>
<td>
    <asp:Button ID="Button6" runat="server" Text="Delete" Font-Bold="True" 
        Font-Size="Medium" onclick="Button6_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button3" runat="server" Text="Log Out" 
        onclick="Button3_Click" Font-Bold="True" Font-Size="Medium" />
        &nbsp;&nbsp;
        </td>
</tr>
    </table>
<div style="background-color:Blue; color:White">
<asp:Label ID="Label1" runat="server" 
        Text="To see Database Details.."></asp:Label>
        <a href="database.aspx" style="text-decoration:bone; color:white"><b>Click Here</b></a>
    </asp:Content>

