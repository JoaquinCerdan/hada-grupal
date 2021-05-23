using System;

namespace iqueaWeb
{
    public partial class Formulario_web15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENoferta en = new ENoferta(Convert.ToInt32(TextBox3.Text), Convert.ToDateTime(TextBox4.Text));
            en.createOferta();
        }

    }
}