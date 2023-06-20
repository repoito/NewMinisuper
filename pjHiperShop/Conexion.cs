using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjHiperShop
{
    public class Conexion
    {

        public static SqlConnection ObtenerConexion()
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["constring"].ToString();
                SqlConnection cn = new SqlConnection(connectionString);
                return cn;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #region"Login"
        //public static bool Logueo(string user, string pass)
        //{
        //    SqlConnection cn = ObtenerConexion();
        //    try
        //    {
        //        string sql = "SELECT * FROM Empleados WHERE ";
        //        SqlCommand cmd = new SqlCommand(sql, cn);
        //        cn.Open();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }

        //}
        #endregion
    }
}
