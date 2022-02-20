using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLogin.DAL
{
    class LoginComands
    {
        public bool temp = false;
        public string mensage = "";
        SqlCommand cmd = new SqlCommand();
        Conection conectionUser = new Conection();
        SqlDataReader DataReader;
        public bool VerificadLogin(String login, String password)
        {
            //Verificar no bando de dados SQL se o usuario já existe cadastrado no sistema
            cmd.CommandText = "select * from logins where mail = @login and passwordUser = @password";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                cmd.Connection = conectionUser.Conecting();
                DataReader = cmd.ExecuteReader();
                if (DataReader.HasRows) //está verificando se o usuario existe, se existir o fluxo irá continuar para o login, caso não encontrado as linhas criadas no bd irá retornar erro.
                {
                    temp = true;
                }
                conectionUser.Desconecting();
                DataReader.Close();
            }
            catch (Exception)
            {
                this.mensage = "Error at conections to database!";
            }
            return temp;
        }

        public string RegisterUser(String mail, String password, String confirmPassword)
        {
            temp = false;

            if (password.Equals(confirmPassword))
            {
                cmd.CommandText = "insert into logins values (@m,@p);";
                cmd.Parameters.AddWithValue("@m", mail);
                cmd.Parameters.AddWithValue("@p", password);

                try
                {
                    cmd.Connection = conectionUser.Conecting();
                    cmd.ExecuteNonQuery();
                    conectionUser.Desconecting();
                    this.mensage = "cadaster sucesseful";
                    temp = true;
                }
                catch (SqlException)
                {

                    this.mensage = "Error to conecting database";
                }
            }else
            {
                this.mensage = "Password Incorrect";
            }
            return mensage;
        }
    }
}
