using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLab11
{
    public partial class Update : System.Web.UI.Page
    {
        static List<Nota> NotasTemp = new List<Nota>();
        static List<Alumno> AlumnoTemp = new List<Alumno>();
        static List<Universidad> UniversidadTemp = new List<Universidad>();

        static string carne;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se crea una lista con la misma estructura que tienen los datos en el archivo
            //List<Dato> lista = new List<Dato>();

            //El nombre del archivo a utilizar
            string archivo = Server.MapPath("Datos.json");

            //Se abre el archivo
            StreamReader jsonStream = File.OpenText(archivo);

            //Se Lee todo el contenido del archivo y el contenido leído se guarda en una variable cualquiera de tipo string.
            //aquí no se necesitan ciclos pues el método ReadToEnd() lee todo el contenido de una sola vez.
            string json = jsonStream.ReadToEnd();

            //Se cierra el archivo
            jsonStream.Close();

            //Se deserializa (convierte) la cadena json guardada en la variable, en la estructura que tiene la lista a donde se van a cargar los datos
            UniversidadTemp = JsonConvert.DeserializeObject<List<Universidad>>(json);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            carne = TextBox1.Text;
            bool encontrado = false;

            foreach (var universidad in UniversidadTemp)
            {
                AlumnoTemp = universidad.Alumnos;

                Alumno alumno = universidad.Alumnos.Find(c => c.Carne == carne);

                if (alumno != null)
                {
                    TextBox2.Text = alumno.Nombre;
                    TextBox3.Text = alumno.Apellido;
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                TextBox2.Text = "";
                TextBox3.Text = "";
                Response.Write("<script>alert('No se encuentra')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (var universidad in UniversidadTemp)
            {
                //AlumnoTemp = universidad.Alumnos;

                int alumno = universidad.Alumnos.FindIndex(c => c.Carne == carne);

                if (alumno > -1)
                {
                    universidad.Alumnos[alumno].Nombre = TextBox2.Text;
                    universidad.Alumnos[alumno].Apellido = TextBox3.Text;

                    Guardar();
                }
            }
        }
    }
}