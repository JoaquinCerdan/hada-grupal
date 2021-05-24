using System;

namespace iqueaWeb
{
    public partial class Formulario_web18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ENArticulo en = new ENArticulo(TextBox5.Text, Convert.ToDouble(TextBox6.Text), TextBox7.Text, Convert.ToInt32(TextBox8.Text));
            en.createArticulo();
        }
    }
}