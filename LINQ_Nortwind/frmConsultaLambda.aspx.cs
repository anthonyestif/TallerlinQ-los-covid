using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_Nortwind
{
    public partial class frmConsultaLambda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            //if (Page.IsPostBack)
            // {
            ////DropDownList1.DataSource = from p in northwind.Products select p;
            ///DropDownList1.DataTextField = "unidad de medida";
            //// DropDownList1.DataValueField = "unidad de medida";
            ///DropDownList1.DataBind();
            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (NortWindDataContext northwind = new NortWindDataContext())
            {
                int nro = int.Parse(TxtNro.Text);
                var consulta = northwind.Products.Where(P => P.ProductID > nro);
                GridView1.DataSource = consulta;
                GridView1.DataBind();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (NortWindDataContext northwind = new NortWindDataContext())
            {
                int nro = int.Parse(TxtNro2.Text);
                var consulta = northwind.Products.Where(C => C.CategoryID == nro);
                GridView1.DataSource = consulta;
                GridView1.DataBind();


            }
        }

        //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //  using (northwindDataContext northwind = new northwindDataContext())
        ///{
        // var consulta = northwind.Products.Where(P => P.QuantityPerUnit == DropDownList1.SelectedValue);
        ///GridView1.DataSource = consulta;
        ///GridView1.DataBind();
        // }
        //}
    }
}