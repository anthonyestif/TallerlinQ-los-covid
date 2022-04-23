using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_Nortwind
{
    public partial class frmCRUD_Proveedor : System.Web.UI.Page
    {
        private NortWindDataContext proveedores = new NortWindDataContext();
        private IList<Suppliers> Listar()
        {
            var consulta = from C in proveedores.Suppliers
                           select C;

            return consulta.ToList();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvProveedor.DataSource = Listar();
                gvProveedor.DataBind();
                DropDownList1.DataSource = from p in proveedores.Suppliers select p.Country;
                DropDownList1.DataBind();
                DropDownList2.DataSource = from p in proveedores.Suppliers select p.ContactTitle;
                DropDownList2.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Suppliers proveedor = new Suppliers();
            
            proveedor.CompanyName = txtCompania.Text.Trim();
            proveedor.ContactName = txtNombreContacto.Text.Trim();
            proveedor.ContactTitle = txtTitleContacto.Text.Trim();
            proveedor.Address = txtDireccion.Text.Trim();
            proveedor.City = txtCiudad.Text.Trim();
            proveedor.Region = txtRegion.Text.Trim();
            proveedor.PostalCode = txtPostal.Text.Trim();
            proveedor.Country = txtPais.Text.Trim();
            proveedor.Phone = txtTelefono.Text.Trim();
            proveedor.Fax = txtFax.Text.Trim();
            proveedor.HomePage = txtPaginaWeb.Text.Trim();
            proveedores.Suppliers.InsertOnSubmit(proveedor);

            try
            {
                proveedores.SubmitChanges();
                gvProveedor.DataSource = Listar();
                gvProveedor.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var codigo = (from C in proveedores.Suppliers
                          where C.CompanyName.Contains(txtCompania.Text.Trim())
                          select C).First();
            proveedores.Suppliers.DeleteOnSubmit(codigo);
            try
            {
                proveedores.SubmitChanges();
                gvProveedor.DataSource = Listar();
                gvProveedor.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Suppliers proveedor = proveedores.Suppliers.Single(C => C.CompanyName == txtCompania.Text.Trim());
            proveedor.ContactName = txtNombreContacto.Text.Trim();
            proveedor.ContactTitle = txtTitleContacto.Text.Trim();
            proveedor.Address = txtDireccion.Text.Trim();
            proveedor.City = txtCiudad.Text.Trim();
            proveedor.Region = txtRegion.Text.Trim();
            proveedor.PostalCode = txtPostal.Text.Trim();
            proveedor.Country = txtPais.Text.Trim();
            proveedor.Phone = txtTelefono.Text.Trim();
            proveedor.Fax = txtFax.Text.Trim();
            proveedor.HomePage = txtPaginaWeb.Text.Trim();
            try
            {
                proveedores.SubmitChanges();
                gvProveedor.DataSource = Listar();
                gvProveedor.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String nro = (txtBuscar.Text);


            if (nro == "")
            {
                var consulta = from p in proveedores.Suppliers
                               select p;
                gvProveedor.DataSource = consulta;
                gvProveedor.DataBind();

            }
            else
            {
                var consulta = from p in proveedores.Suppliers
                               where p.CompanyName == nro
                               select p;
                gvProveedor.DataSource = consulta;
                gvProveedor.DataBind();
            }
        }
        // ciudades
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var consulta = proveedores.Suppliers.Where(p => p.Country == DropDownList1.SelectedValue);
            gvProveedor.DataSource = consulta;
            gvProveedor.DataBind();
        }
        // titulos de contacto
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var consulta = proveedores.Suppliers.Where(p => p.ContactTitle == DropDownList2.SelectedValue);
            gvProveedor.DataSource = consulta;
            gvProveedor.DataBind();
        }
    }
}