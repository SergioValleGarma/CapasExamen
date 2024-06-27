using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRegion
    {
        public void Registrar(string Nombre, bool Activo)
        {

            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("USP_InsertRole", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                parameter.Value = Nombre;
                command.Parameters.Add(parameter);

                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter2.Value = Activo;
                command.Parameters.Add(parameter2);

                command.ExecuteNonQuery();

            }
        }
    }
}
