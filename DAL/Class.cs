using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Apruebo.DAL
{
    public class BD
    {
        string ipServer = "TI-VC-0619";
        string databaseName = "proyecto_inacap";

        public string getConexion(string tipo)
        {
            switch (tipo)
            {
                case "SQL":
                    //  return "Server=" + ipServer + ";Database=" + databaseName + ";User Id=profe;Password=Inacap..2020;";
                    return "Server=" + ipServer + ";Database=" + databaseName + ";Trusted_Connection=True;;";
                case "ORACLE":
                    return "";
                default:
                    return "";
            }

        }
        public DataTable getDataTable(string query, string con)
        {
            /*Invocamos la Conexión*/
            SqlConnection conexion = new SqlConnection(con);
            /*Pasamos el Sql Connection + la Query*/

            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            /*Creamos el DataTable*/
            DataTable dt = new DataTable();
            /*lo Llenamos*/
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                //ALGO
            }
            /*retornamos el DT*/
            return dt;
        }
    }
}