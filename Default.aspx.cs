using Newtonsoft.Json;
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
        static List<Universidad> UniversidadTemp = new List<Universidad>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Guardar()
        {
            //Suponiendo que la List llamada lista ya contiene datos

            //Se serializa (convierte) la lista en formato Json y se guarda en una variable de tipo string
            string json = JsonConvert.SerializeObject(UniversidadTemp);

            //El nombre del archivo
            string archivo = Server.MapPath("Datos.json");

            //Se escribe la variable que contiene el json al archivo en un solo paso
            //con WriteAllText se escribe todo de un solo
            System.IO.File.WriteAllText(archivo, json);
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

        protected void ButtonAgregarUniconsusAlumnos_Click(object sender, EventArgs e)
        {
            Universidad universidad = new Universidad();
            universidad.Nombre = DropDownList1.SelectedValue;
            universidad.Alumnos = AlumnoTemp.ToArray().ToList();

            UniversidadTemp.Add(universidad);

            Guardar();
        }
    }
}