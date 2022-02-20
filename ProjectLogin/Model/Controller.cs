using ProjectLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLogin.Model
{
    public class Controller
    {
        public bool temp;
        public string mensage = "";
        public bool Acess(String login, String password)
        {
            LoginComands loginInstant = new LoginComands();
            temp = loginInstant.VerificadLogin(login, password);
            if (!loginInstant.mensage.Equals(""))
            {
                this.mensage = loginInstant.mensage;
            }
            return temp;
        }
        public string CadasterUsuer(String mail, String password, String confirmPassword)
        {
            LoginComands loginInstant = new LoginComands();
            this.mensage = loginInstant.RegisterUser(mail, password, confirmPassword);
            if (loginInstant.temp)
            {
                this.temp = true;
            }
            return mensage;
        }
    }
}
