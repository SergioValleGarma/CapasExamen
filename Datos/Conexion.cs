using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class Conexion
    {
        public static string cadena1 = "Server=DESKTOP-KSJLU0B\\SQLNET;" +
                        "Initial Catalog=WICMonitoriaDBDev; Integrated Security=True;trustservercertificate=True";

        public static string cadena = "Server=DESKTOP-KSJLU0B\\SQLNET;" +
                       "Initial Catalog=WICMonitoriaDBDev;trustservercertificate=True;" +
            "User ID=UserMonitoria;Password=123456;";
    }
}
