using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace WebPrimerCRUD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Inicio()
        {
            string cadenaConexion = "server=localhost;database=Generacion23;user=sa;password=1234";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            string query = "SELECT idAlumno, nombre, apellidoPaterno, apellidoMaterno, edad, correo FROM Alumno";
            //Crear objeto SqlDataReader
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            //Creando un objeto DataTable
            DataTable tabla = new DataTable();
            //Ejecuta el query y el reusltado lo almacena en la tabla
            adapter.Fill(tabla);

            conexion.Close();
            //Pasando el modelo a la vista
            return View("Principal",tabla);
        }

        public ActionResult Conectar() 
        {
            /*
            Datos necesario para la cadena de conexion:
            -Servidor 
            -Nombre de la base de datos
            -Usuario
            -Contraseña
            */

            string cadenaConexion = "server=localhost;database=Generacion23;user=sa;password=1234";

            //Creando un objeto de la clase SqlConnection
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();

            string mensaje = "";

            if (conexion.State == ConnectionState.Open)
            {
                mensaje = "Conexion Exitosa";
            }
            else
            {
                mensaje = "Fallo la conexion";
            }
            
            conexion.Close();
            TempData["mensaje"] = mensaje;
            return RedirectToAction("Inicio");
        }

        public ActionResult IrAgregar() {
            return View("VistaAgregar");
        }

        public ActionResult Agregar(string nombre, string paterno, string materno, int edad, string correo) {
            
            string cadenaConexion = "server=localhost; database=Generacion23;user=sa; password=1234";
            //Crear la conexion
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            //Declarando el query que vamos a ejecutar
            string query = $"insert into Alumno (nombre, apellidoPaterno, apellidoMaterno, edad, correo) "+ 
            $" values ('{nombre}','{paterno}','{materno}', '{edad}', '{correo}')";
            //Crear el objeto de la clase SqlCommand
            SqlCommand comando = new SqlCommand(query,conexion);
            //Ejecutamos el query 
            comando.ExecuteNonQuery();
            //Cerrar Conexion
            
            conexion.Close();

            TempData["mensaje"] = $"{nombre} se ha insertado correctamente";

            //return View("Principal");

            //Redigiriendo a la accion Inicio
            return RedirectToAction("Inicio");
        }

        public ActionResult Eliminar(int idAlumno)
        {
            //Cadena de conexion
            string cadenaConexion = "server=localhost;database=Generacion23;user=sa;password=1234";
            //Creamos objeto de SqlConnection y abrimos la conexion
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            //Query a ejecutar
            string query = $"delete Alumno where idAlumno={idAlumno}";
            //Creamos objeto de SqlCommand para poder ejecutar el query
            SqlCommand comando = new SqlCommand(query, conexion);
            //Ejecutamos el query 
            comando.ExecuteNonQuery();
;            //Cerrar la conexion
            conexion.Close();

            TempData["mensaje"] = $"Se elimino correctamente el alumnos con id {idAlumno}";
            //Redirigimos a la accion Inicio
            return RedirectToAction("Inicio");
        }

        public ActionResult ObtenerParaEditar(int idAlumno) {
            string cadenaConexion = "server=localhost;database=Generacion23;user=sa;password=1234";
            SqlConnection conexion = new SqlConnection( cadenaConexion);
            conexion.Open();

            string query = $"select idAlumno, nombre, apellidoPaterno, apellidoMaterno, edad, correo from Alumno where idAlumno={idAlumno}";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            DataTable tabla = new DataTable();

            adapter.Fill(tabla); //Ejecuta el query y el resultado lo almacena en el objeto tabla

            DataRow filaAlumno = tabla.Rows[0];

            conexion.Close();

            return View("VistaEditar", filaAlumno);
        }

        public ActionResult Editar(int idAlumno, string nombre, string paterno, string materno, int edad, string correo) 
        {
            string cadenaConexion = "server=localhost;database=Generacion23;user=sa;password=1234";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            string query = $"update Alumno set nombre = '{nombre}', apellidoPaterno='{paterno}', apellidoMaterno='{materno}'," +
                $" edad='{edad}', correo='{correo}' where idAlumno={idAlumno}";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();

            TempData["mensaje"] = $"El alumno con id {idAlumno} se edito correctamente";

            return RedirectToAction("Inicio");

        }


    }
}