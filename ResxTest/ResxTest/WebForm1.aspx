<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ResxTest.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:right;">
                <asp:DropDownList ID="ddLang" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddLang_SelectedIndexChanged">
                    <asp:ListItem Value="en-US" Text="English" />
                    <asp:ListItem Value="fr-FR" Text="français" />
                    <asp:ListItem Value="hi-IN" Text="हिंदी" />
                </asp:DropDownList>
            </div>
            <table>
                <tr>
                    <td><asp:Label ID="lblName" runat="server"/></td>
                    <td><asp:TextBox ID="txtName" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblAddress" runat="server" /></td>
                    <td><asp:TextBox ID="txtAddress" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblState" runat="server" /></td>
                    <td><asp:TextBox ID="txtState" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblCountry" runat="server" /></td>
                    <td><asp:TextBox ID="txtCountry" runat="server" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" /> &nbsp; &nbsp;
                        <asp:Button ID="btnCancel" runat="server" />
                    </td>
                </tr>
            </table>
</asp:Content>
