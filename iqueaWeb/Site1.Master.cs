using System;

namespace iqueaWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, System.Web.UI.WebControls.MenuEventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string val = OptionBusqueda.Value;
            if (val == "OptionNombre")
            {
                Response.Redirect("~/Results.aspx?srch=" + txtSearchMaster.Text);
            } else if(val == "OptionPrecio")
            {
                Response.Redirect("~/Results.aspx?price=" + txtSearchMaster.Text);
            }
                
        }

        protected void txtSearchMaster_TextChanged(object sender, EventArgs e)
        {

        }

    }
}