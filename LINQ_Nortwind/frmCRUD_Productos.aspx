<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCRUD_Productos.aspx.cs" Inherits="LINQ_Nortwind.frmCRUD_Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top: 31px">
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Productos&nbsp;</p>
            <p>Nombre Producto:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtNombreProducto"/> &nbsp;&nbsp; ID Proveedor:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtIdProveedor"/>&nbsp;&nbsp; ID Categoria:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtIdCategoria"/> &nbsp;&nbsp; </p>
            <p>Cantidad por Unidad:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtCantidad"/> &nbsp;&nbsp; Precio de unidad:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtPrecio"/> &nbsp;&nbsp; Unidad en stock:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtStock"/> &nbsp;&nbsp; </p>
            <p>Unidades en orden:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtUnidadOrden"/> &nbsp;&nbsp; Nivel de Re-orden:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtReOrden"/> &nbsp;&nbsp; Descontinuados:&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" Id="txtDescontinuado"/> &nbsp;&nbsp;</p>
            <p>&nbsp;</p>
            <p>
                <asp:Button Text="Agregar" runat="server" id="btnAgregar" OnClick="btnAgregar_Click"/>
                <asp:Button Text="Eliminar" runat="server" id="btnEliminar" OnClick="btnEliminar_Click"/>
                <asp:Button Text="Actualizar" runat="server" id="btnActualizar" OnClick="btnActualizar_Click"/>
            &nbsp;&nbsp; Consultar continuidad:
                <asp:DropDownList ID="dplContinuidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dplContinuidad_SelectedIndexChanged">
                    <asp:ListItem>Seleccionar...</asp:ListItem>
                    <asp:ListItem>Continuado</asp:ListItem>
                    <asp:ListItem>Descontinuados</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp; Consultar por Proveedores:
                <asp:DropDownList ID="ddlProveedor" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </p>
            <p>&nbsp;Buscar por Nombre de Producto:&nbsp;&nbsp; <asp:TextBox runat="server" id="txtBuscar" Width="185px"/>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                &nbsp;&nbsp;</p>
            <p>&nbsp;</p>
                <asp:GridView runat="server" ID="gvProducto">
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
