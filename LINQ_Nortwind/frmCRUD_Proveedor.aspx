<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCRUD_Proveedor.aspx.cs" Inherits="LINQ_Nortwind.frmCRUD_Proveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top: 31px">
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Proveedores</p>
            <p>ID Proveedor:&nbsp; <asp:TextBox runat="server" Id="txtIdProveedor"/>&nbsp;&nbsp;Nombre Compañia:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtCompania"/> &nbsp;&nbsp; Nombre contacto:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtNombreContacto"/>&nbsp;&nbsp; </p>
            <p>Titulo de Contacto:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtTitleContacto"/> &nbsp;&nbsp; Direccion:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtDireccion"/> &nbsp;&nbsp; Ciudad:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtCiudad"/> &nbsp;&nbsp; Region:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtRegion"/> </p>
            <p>Codigo Postal:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtPostal"/> &nbsp;&nbsp; Pais:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtPais"/> &nbsp;&nbsp; Telefono:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtTelefono"/> &nbsp;&nbsp; Fax:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtFax"/> </p>
            <p>Pagina web:&nbsp;&nbsp;<asp:TextBox ID="txtPaginaWeb" runat="server" Width="226px"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button Text="Agregar" runat="server" id="btnAgregar" OnClick="btnAgregar_Click"/>
                <asp:Button Text="Eliminar" runat="server" id="btnEliminar" OnClick="btnEliminar_Click"/>
                <asp:Button Text="Actualizar" runat="server" id="btnActualizar" OnClick="btnActualizar_Click"/>
            &nbsp;&nbsp; Consultar Pais:
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="height: 22px">
                </asp:DropDownList>
&nbsp;&nbsp; Consultar por Titulo del Contacto:
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
            </p>
            <p>&nbsp;Buscar por Nombre de Compañia:&nbsp;&nbsp; <asp:TextBox runat="server" id="txtBuscar" Width="185px"/>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                &nbsp;&nbsp;</p>
            <p>&nbsp;</p>
                <asp:GridView runat="server" ID="gvProveedor">
            </asp:GridView>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>

            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
</asp:Content>
