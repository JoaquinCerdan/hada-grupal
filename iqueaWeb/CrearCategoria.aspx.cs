﻿using System;

namespace iqueaWeb
{
    public partial class Formulario_web31 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENCategoria en = new ENCategoria(TextBox2.Text, TextBox3.Text);
            en.createCategoria();
        }
    }
}