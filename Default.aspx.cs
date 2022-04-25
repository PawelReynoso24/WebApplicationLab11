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
        static List<Nota> NotasTemp = new List<Nota>();
        static List<Alumno> AlumnoTemp = new List<Alumno>();
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

        protected void ButtonAgregarUni_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Carne = TextBoxCarne.Text;
            alumno.Nombre = TextBoxNombre.Text;
            alumno.Apellido = TextBoxApellido.Text;
            alumno.Notas = NotasTemp.ToArray().ToList();

            AlumnoTemp.Add(alumno);
        }
    }
}