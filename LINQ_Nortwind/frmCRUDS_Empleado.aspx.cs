using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;    

namespace LINQ_Nortwind
{
    public partial class frmCRUDS : System.Web.UI.Page
    {
        private NortWindDataContext clientes = new NortWindDataContext();
     
        private IList<Customers>Listar()
        {
            var consulta = from C in clientes.Customers 
                           select C;
           
            return consulta.ToList();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvCliente.DataSource = Listar();
                gvCliente.DataBind();
                DropDownList1.DataSource = from p in clientes.Customers select p.City;
                DropDownList1.DataBind();
                DropDownList2.DataSource = from p in clientes.Customers select p.ContactTitle;
                DropDownList2.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Customers cliente = new Customers();
            cliente.CustomerID = txtCodCliente.Text.Trim();
            cliente.CompanyName= txtCompania.Text.Trim();
            cliente.ContactName = txtNombreContacto.Text.Trim();
            cliente.ContactTitle = txtTitleContacto.Text.Trim();
            cliente.Address = txtDireccion.Text.Trim();
            cliente.City = txtCiudad.Text.Trim();
            cliente.Region = txtRegion.Text.Trim();
            cliente.PostalCode = txtPostal.Text.Trim();
            cliente.Country= txtPais.Text.Trim();
            cliente. Phone= txtTelefono.Text.Trim();
            cliente. Fax= txtFax.Text.Trim();
            clientes.Customers.InsertOnSubmit(cliente);

            try
            {
                clientes.SubmitChanges();
                gvCliente.DataSource = Listar();
                gvCliente.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var codigo = (from C in clientes.Customers
                         where C.CustomerID.Contains(txtCodCliente.Text.Trim())
                         select C).First();
            clientes.Customers.DeleteOnSubmit(codigo);
            try
            {
                clientes.SubmitChanges();
                gvCliente.DataSource = Listar();
                gvCliente.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Customers cliente = clientes.Customers.Single(C => C.CustomerID == txtCodCliente.Text.Trim());
            cliente.CompanyName = txtCompania.Text.Trim();
            cliente.ContactName = txtNombreContacto.Text.Trim();
            cliente.ContactTitle = txtTitleContacto.Text.Trim();
            cliente.Address = txtDireccion.Text.Trim();
            cliente.City = txtCiudad.Text.Trim();
            cliente.Region = txtRegion.Text.Trim();
            cliente.PostalCode = txtPostal.Text.Trim();
            cliente.Country = txtPais.Text.Trim();
            cliente.Phone = txtTelefono.Text.Trim();
            cliente.Fax = txtFax.Text.Trim();
            try
            {
                clientes.SubmitChanges();
                gvCliente.DataSource = Listar();
                gvCliente.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String nro =(txtBuscar.Text);

            
            if(nro== "")
            {
                var consulta = from p in clientes.Customers
                               select p;
                gvCliente.DataSource = consulta;
                gvCliente.DataBind();

            }
            else
            {
                var consulta = from p in clientes.Customers
                               where p.ContactName == nro
                               select p;
                gvCliente.DataSource = consulta;
                gvCliente.DataBind();
            }
            
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var consulta = clientes.Customers.Where(p => p.City == DropDownList1.SelectedValue);
            gvCliente.DataSource = consulta;
            gvCliente.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var consulta = clientes.Customers.Where(p => p.ContactName == DropDownList2.SelectedValue);
            gvCliente.DataSource = consulta;
            gvCliente.DataBind();
        }
    }
}