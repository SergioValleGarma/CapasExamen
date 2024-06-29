using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class DRegion
    {
        public List<Region> Listar(Region region)
        {
            List<Region> roles = new List<Region>();

            using (var connection = new SqlConnection(Conexion.cadena))
            {
                //Usar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("sp_ReadRegions", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
                parameter.Value = region.RegionName;
                cmd.Parameters.Add(parameter);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //Recorrer el data reader
                while (reader.Read())
                {

                    int RegionId = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;
                    string RegionName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";
                    bool Enabled = reader["Enabled"] != DBNull.Value ? Convert.ToBoolean(reader["Enabled"]) : false;

                    roles.Add(new Region { RegionId = RegionId, RegionName = RegionName, Enabled = Enabled });


                }
                reader.Close();
            }
            return roles;

        }

        public void CrearRegion(Region region)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_CreateRegin",connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new("@RegionName", SqlDbType.VarChar, 50) { Value = region.RegionName };
                cmd.Parameters.Add(parameter);

                SqlParameter parameter2 = new("@Enabled", SqlDbType.Bit) { Value = true };
                cmd.Parameters.Add(parameter2);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void EditarRegion(Region region)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new("sp_UpdateRegion", connection) { CommandType = CommandType.StoredProcedure };
                SqlParameter parameter0 = new("@RegionId", SqlDbType.Int) { Value = region.RegionId };
                cmd.Parameters.Add(parameter0);
                SqlParameter parameter1 = new("@RegionName", SqlDbType.VarChar, 50) { Value = region.RegionName };
                cmd.Parameters.Add(parameter1);
                SqlParameter parameter2 = new("@Enabled", SqlDbType.Bit) { Value = true};
                cmd.Parameters.Add(parameter2);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(Region region)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new("sp_DeleteRegion", connection) { CommandType = CommandType.StoredProcedure };
                SqlParameter parameter0 = new("@RegionId", SqlDbType.Int) { Value = region.RegionId };
                cmd.Parameters.Add(parameter0);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
