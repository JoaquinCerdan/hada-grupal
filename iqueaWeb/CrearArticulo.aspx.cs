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
        //Cuando se pulsa el boton, se crea el articulo
        protected void Button2_Click(object sender, EventArgs e)
        {
            ENArticulo en = new ENArticulo();
            en.stringNombre = TextBox1.Text;
            en.stringDescripcion = TextBox5.Text;
            if (TextBox6.Text != "")
            {
                en.doublePrecio = double.Parse(TextBox6.Text);
            }
            else
            {
                return;
            }
            en.stringImagen = TextBox7.Text;
            if (TextBox8.Text != "")
            {
                en.intStock = Convert.ToInt32(TextBox8.Text);
            }
            else
            {
                return;
            }
            en.intCategoria =Convert.ToInt32(Categoria.SelectedValue);
            en.stringTemporada = Temporada.SelectedValue;

            bool creado = en.createArticulo();
            if (creado)
            {
                etiqueta.Text = "Creado correctamente ";
            }
            else
            {
                etiqueta.Text = "Error al crear el artículo";
            }
            
        }

    }
}