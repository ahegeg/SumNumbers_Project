<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SumNumbers.aspx.cs" Inherits="SumNumbers_Web.SumNumbers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td><asp:Label ID="lblNum1" runat="server" Text="Number 1"></asp:Label></td>
            <td><asp:TextBox ID="txtNum1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblNum2" runat="server" Text="Number 2"></asp:Label></td>
            <td><asp:TextBox ID="txtNum2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSum" runat="server"  Text="Sum" OnClick="btnSum_Click"/>
            </td>
        </tr>

    </table>    
    
 
</asp:Content>
