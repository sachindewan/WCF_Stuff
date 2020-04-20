using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SampleWcfService
{
    public class User : IUser
    {
        public bool AuthenticateUser(string userName, string password)
        {
            if(userName=="wcf" && password == "sachin@123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string WelcomeUser(string userName)
        {
            return "wolcome " + userName;
        }
    }
}
