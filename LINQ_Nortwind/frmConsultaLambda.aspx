<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmConsultaLambda.aspx.cs" Inherits="LINQ_Nortwind.frmConsultaLambda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    Expresiones lambda<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" />
            <asp:TextBox ID="TxtNro" runat="server" Width="128px"></asp:TextBox>
            consultar producto por ID
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Consultar" />
            <asp:TextBox ID="TxtNro2" runat="server"></asp:TextBox>
            cosultar producto por categoria<br />
&nbsp;<asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
</asp:Content>
