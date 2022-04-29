using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLab11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static List<Nota> NotasTemp = new List<Nota>();
        static List<Alumno> AlumnoTemp = new List<Alumno>();
        static List<Universidad> UniversidadTemp = new List<Universidad>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;

            foreach(var universidad in UniversidadTemp)
            {
                AlumnoTemp = universidad.Alumnos;

                Alumno alumno = AlumnoTemp.Find(c => c.Carne == TextBox1.Text);

                if(alumno != null)
                {
                    TextBox2.Text = alumno.Nombre;
                    TextBox3.Text = alumno.Apellido;
                    encontrado = true;
                }
            }

            if(!encontrado)
            {
                TextBox2.Text = "";
                TextBox3.Text = "";
                Response.Write("<script>alert('Mensaje a mostrar')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (var universidad in UniversidadTemp)
            {
                AlumnoTemp = universidad.Alumnos;

                Alumno alumno = AlumnoTemp.Find(c => c.Carne == TextBox1.Text);
                AlumnoTemp.Remove(alumno);

            }
        }
    }
}