using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Token_Based_Owin_Athuentication
{
    public class AuthRepository
    {
        public  bool ValidateUser(string username,string password)
        {
            if (username == "satya" && password == "satya")
                return true;
            else
                return false;
        }
            
    }
}