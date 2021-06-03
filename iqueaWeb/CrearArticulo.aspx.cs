using System;

namespace iqueaWeb
{
    public partial class Formulario_web18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["codigo"] == null)
            {
                //si no hay alguien logeado se le envia directamente a la pagina de login
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ENArticulo en = new ENArticulo();
            en.stringNombre = TextBox1.Text;
            en.stringDescripcion = TextBox5.Text;
            en.doublePrecio = double.Parse(TextBox6.Text);
            en.stringImagen = TextBox7.Text;
            en.intStock = int.Parse(TextBox8.Text);
            
            en.intCategoria =   int.Parse( Categoria.SelectedValue);
            

            if (Temporada.SelectedValue=="0")
            {
                en.stringTemporada = "sencillo";
            } else if (Temporada.SelectedValue=="1"){
                en.stringTemporada = "clasico";

            } else
            {
                en.stringTemporada = "moderno";
            }



            bool creado = en.createArticulo();
            if (creado)
            {
                etiqueta.Text = "Creado correctamente ";
            }
            else
            {
                etiqueta.Text = "error "+ en.stringNombre+ en.stringDescripcion+ en.doublePrecio+ en.stringImagen+en.intStock+en.intCategoria+en.stringTemporada;
            }
        }
    }
}