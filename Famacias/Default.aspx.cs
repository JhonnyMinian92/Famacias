using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Famacias
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btning_Click(object sender, EventArgs e)
        {
            try {
                string nombres = txtnom.Text;
                string descrip = txtdesc.Text;
                string precio = txtprec.Text;

                string cadena = "Data Source=JHONNY\\SQLEXPRESS;Initial Catalog=farmacia;Integrated Security=True";
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                
                //Guardar Nuevos
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "infarmaco";

                com.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombres;
                com.Parameters.Add("@Descrip", SqlDbType.NVarChar).Value = descrip;
                com.Parameters.Add("@Precio", SqlDbType.NVarChar).Value = precio;

                com.ExecuteScalar();

                con.Close();
            }
            catch (Exception ex) { Response.Write("tiene error: "+ex.Message); }

        }

        protected void DatosFarmacos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnactual_Click(object sender, EventArgs e)
        {
            try {

                string cadena = "Data Source=JHONNY\\SQLEXPRESS;Initial Catalog=farmacia;Integrated Security=True";
                SqlConnection con = new SqlConnection(cadena);
                con.Open();

                //Presentar Almacenados
                SqlDataAdapter query = new SqlDataAdapter("select * from farmaco",con);
                DataSet datos = new DataSet();
                query.Fill(datos, "dbo.farmaco");

                DatosFarmacos.DataSource = datos;
                DatosFarmacos.DataBind();

                con.Close();
            }
            catch (Exception ex) { Response.Write("tiene error: " + ex.Message); }
        }
    }
}