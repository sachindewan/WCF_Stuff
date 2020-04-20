using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SampleWcfService
{
    public class User : IUser, IUserDetails
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

        public List<string> GetUserDetals()
        {
            var users = new object[] { "Sachin", "riyan rajput", "gaurav singh", "monu", "monu band", "sandeep", "kapil", "sarvesh", "kuldeep" };
            List<string> lstString = new List<string>();
            foreach (var item in users)
            {
                lstString.Add(item.ToString());
            }
            return lstString;
        }

        public string WelcomeUser(string userName)
        {
            return "wolcome " + userName;
        }
    }
}
