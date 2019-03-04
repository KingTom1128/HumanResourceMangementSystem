using HRMDSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
    public class LoginUser
    {
        private string username;
        private string password;

        public LoginUser(string un, string pwd)
        {
            username = un;
            password = pwd;
        }

        public LoginResult IsValid()
        {
            OperatorService opServ = new OperatorService();
            Operator op = opServ.GetOperator(username);
            if (op == null)
            {
                return LoginResult.UserNameError;
            }
            else if (op.Password != password)
            {
                return LoginResult.PasswordError;
            }
            else if (op.IsDeleted)
            {
                return LoginResult.DeletedError;
            }
            else if (op.IsLocked)
            {
                return LoginResult.LockedError;
            }
            else
            {
                return LoginResult.OK;
            }
        }

        public enum LoginResult { OK, UserNameError, PasswordError ,DeletedError, LockedError}
    }
}
