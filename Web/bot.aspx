<%@ Page Language="C#" Async="true" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bot.aspx.cs" Inherits="bot" %>

<%@ Register assembly="ASPNetSpell" namespace="ASPNetSpell" tagprefix="ASPNetSpell" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="up1" runat="server">
<ContentTemplate>
    <script type="text/javascript">

        $(document).ready(function(){
            $("#ctl00_ContentPlaceHolder1_Button1").click(function () {

                var $img = $('#ctl00_ContentPlaceHolder1_ImageButton1');
                var flag = false;
                setTimeout($img.attr('src', 'images/sbty.jpg'), 1000);
                       
            });
        });
    </script>

<%--    <form id="form1" runat="server" defaultbutton="Button1">--%>
<table class="intabular" style="width: 99%">
    <tr>

        <td class="style5">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/sb.jpg" 
                Width="187px" Height="179px" />
        </td>
        <td class="style2">
        <br />
                        <asp:Label ID="Label3" runat="server" Text="Label" Font-Bold="True" 
                            Font-Size="Medium" ForeColor="Red"></asp:Label>
                        <br />
                        <br />
                        <ASPNetSpell:SpellTextBox ID="txtuser" runat="server" Height="33px" 
                            Width="217px"></ASPNetSpell:SpellTextBox>
                        <br />
                        <br />
                        
                       
                        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" 
                            Height="42px" OnClick="Button1_Click" Text="Chat" Width="103px" />
                            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                            Text="Audio" Font-Bold="True" Font-Size="Large" Height="42px" 
                            Width="103px" BackColor="Red" ForeColor="Black" />
                        
                        <ASPNetSpell:SpellButton ID="SpellButton1" runat="server" />
                        
         </td>
         <td>
         <br />
         <br />
         <asp:Label ID="lblbot" runat="server" Font-Size="Large"></asp:Label>
               
                   
               
         
         </td>
            
    </tr>
    <tr>
        <td class="style1" colspan="3" valign="top">
            <br />
        </td>
    </tr>
</table>
<br />
<div style="background-color:Blue; color:White">
    <asp:Label ID="Label2" runat="server" 
        Text="Are You Satisfied with Smart Bot Answers ???"></asp:Label>
        <a href="Feedback.aspx" style="text-decoration:bone; color:white"><b>Click Here</b></a>
<br />
<br />
</div>
<%--</form>--%>
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            height: 16px;
            text-align: left;
        }
        .style2
        {
            width: 289px;
        }
        .style5
        {
            width: 188px;
        }
    </style>
</asp:Content>
