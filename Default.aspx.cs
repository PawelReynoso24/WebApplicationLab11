using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLab11
{
    public partial class _Default : Page
    {
        static public List<Nota> NotasTemp = new List<Nota>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAgregarNota_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Curso = TextBoxCurso.Text;
            nota.Punteo = Convert.ToInt16(TextBoxPunteo.Text);

            NotasTemp.Add(nota);
        }
    }
}