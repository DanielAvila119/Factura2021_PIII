using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Factura_2021.Modelos.DAO
{
    public class Conexión
    {
        protected SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["FacturaConexion"].ConnectionString);
    }
}
