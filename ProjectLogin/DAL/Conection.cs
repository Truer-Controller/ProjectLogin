using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLogin.DAL
{
    class Conection
    {
        SqlConnection conection = new SqlConnection();
        public Conection()
        {           
            conection.ConnectionString = @"Data Source=DESKTOP-K0PUMKN\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True";
        }
        public SqlConnection Conecting()
        {
            if (conection.State == System.Data.ConnectionState.Closed)
            {
                conection.Open();
            }
            return conection;
        }
        public void Desconecting()
        {
            if (conection.State == System.Data.ConnectionState.Open)
            {
                conection.Close();
            }
        }

        
    }
}
