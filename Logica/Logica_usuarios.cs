using ProyectoWebFinal.Models;
using System;
using System.Data;
using System.Data.SqlClient;

public class Logica_usuarios
{
    public usuario encontrarUsuarios(string nombreUsuario, string clave)
    {
        usuario objeto = new usuario();
        using (SqlConnection conexion = new SqlConnection("Data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\bacos\\Downloads\\ProyectoWebFinalLAVENGANZA\\proyectoweb.mdf;Integrated Security=True;Connect Timeout=30"))
        {
            string consulta = "SELECT nombre_usuario as Nombres, id_usuario as Id, Contrasena as Clave, id_rol as IdRol FROM usuario WHERE nombre_usuario = @pnombre_usuario AND Contrasena = @pclave";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.Add("@pnombre_usuario", SqlDbType.VarChar, 50).Value = nombreUsuario;
            comando.Parameters.AddWithValue("@pclave", clave);
            comando.CommandType = CommandType.Text;
            SqlCommand comando2 = new SqlCommand(consulta, conexion);
            comando2.Parameters.AddWithValue("@pnombre_usuario", nombreUsuario);
            comando2.Parameters.AddWithValue("@pclave", clave);
            comando2.CommandType = CommandType.Text;
            conexion.Open();
            using (SqlDataReader datos = comando.ExecuteReader())
            {
                while (datos.Read())
                {
                    objeto = new usuario()
                    {
                        nombre_usuario = datos["Nombres"].ToString(),
                        id_usuario = (int)datos["Id"],
                        Contrasena = datos["Clave"].ToString(),
                        id_rol = (int)datos["IdRol"],
                    };
                }
            }
        }
        return objeto;
    }
}

