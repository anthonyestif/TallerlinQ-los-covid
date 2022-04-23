using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_Nortwind
{
    public partial class frmCRUD_Productos : System.Web.UI.Page
    {
        private NortWindDataContext productos = new NortWindDataContext();
        private IList<Products> Listar()
        {
            var consulta = from C in productos.Products
                           select C;

            return consulta.ToList();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvProducto.DataSource = Listar();
                gvProducto.DataBind();
                ddlProveedor.DataSource = from p in productos.Products select p.ProductID;
                ddlProveedor.DataBind();

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Products producto = new Products();
            producto.ProductName = txtNombreProducto.Text.Trim();
            producto.SupplierID = int.Parse(txtIdProveedor.Text.Trim());
            producto.CategoryID = int.Parse(txtIdCategoria.Text.Trim());
            producto.QuantityPerUnit = txtCantidad.Text.Trim();
            producto.UnitPrice = int.Parse(txtPrecio.Text.Trim());
            producto.UnitsInStock = Int16.Parse(txtStock.Text.Trim());
            producto.UnitsOnOrder = Int16.Parse(txtUnidadOrden.Text.Trim());
            producto.ReorderLevel = Int16.Parse(txtReOrden.Text.Trim());
            producto.Discontinued = bool.Parse(txtDescontinuado.Text.Trim());
            productos.Products.InsertOnSubmit(producto);

            try
            {
                productos.SubmitChanges();
                gvProducto.DataSource = Listar();
                gvProducto.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            
            var codigo = (from C in productos.Products
                          where C.ProductName.Contains(txtNombreProducto.Text.Trim())
                          select C).First();
            productos.Products.DeleteOnSubmit(codigo);
            try
            {
                productos.SubmitChanges();
                gvProducto.DataSource = Listar();
                gvProducto.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            
            Products producto = productos.Products.Single(C => C.ProductName == txtNombreProducto.Text.Trim());
            producto.SupplierID = int.Parse(txtIdProveedor.Text.Trim());
            producto.CategoryID = int.Parse(txtIdCategoria.Text.Trim());
            producto.QuantityPerUnit = txtCantidad.Text.Trim();
            producto.UnitPrice = int.Parse(txtPrecio.Text.Trim());
            producto.UnitsInStock = Int16.Parse(txtStock.Text.Trim());
            producto.UnitsOnOrder = Int16.Parse(txtUnidadOrden.Text.Trim());
            producto.ReorderLevel = Int16.Parse(txtReOrden.Text.Trim());
            producto.Discontinued = bool.Parse(txtDescontinuado.Text.Trim());
            try
            {
                productos.SubmitChanges();
                gvProducto.DataSource = Listar();
                gvProducto.DataBind();
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
                var consulta = from p in productos.Products
                               select p;
                gvProducto.DataSource = consulta;
                gvProducto.DataBind();

            }
            else
            {
                var consulta = from p in productos.Products
                               where p.ProductName == nro
                               select p;
                gvProducto.DataSource = consulta;
                gvProducto.DataBind();
            }

        }

        //DropDownList de COntinuidad
        protected void dplContinuidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = dplContinuidad.SelectedIndex;
            if (indice == 0) //es el V001
            {
                var consulta = from B in productos.Products
                               select B;
                gvProducto.DataSource = consulta;
                gvProducto.DataBind();
            }
            else if (indice == 1)
            {
                var consulta = from B in productos.Products
                               where B.Discontinued == false
                               select B;
                gvProducto.DataSource = consulta;
                gvProducto.DataBind();
            }
            else if (indice == 2)
            {
                var consulta = from B in productos.Products
                               where B.Discontinued == true
                               select B;
                gvProducto.DataSource = consulta;
                gvProducto.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nro = int.Parse(ddlProveedor.SelectedValue.ToString());
            var consulta = productos.Products.Where(p => p.ProductID == nro);
            gvProducto.DataSource = consulta;
            gvProducto.DataBind();
        }

        //ropDownList de Proveedores

    }
}