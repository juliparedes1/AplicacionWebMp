using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApplication1
{
    public partial class ListaPokemons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio n1 = new PokemonNegocio();
            dgvPokemons.DataSource = n1.listarConSp();
            dgvPokemons.DataBind();
            
        }
    }
}