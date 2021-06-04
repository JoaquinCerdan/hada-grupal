using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iqueaWeb
{
    public partial class Results : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string absolutepath = HttpContext.Current.Request.Url.AbsoluteUri;
            string category = Request.QueryString["srch"];
            

            etiqueta.Text = category;

            search(category);
        }

        public void search(string searchString)
        {

            ENArticulo art = new ENArticulo();
            if(art.getArticulos(searchString) == true)
            {

            }


        }
    }
}