using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodeSmellStudy.Change_Preventers
{
    class Bad
    {
        // These three class doing common behaiver "login management" It need to be
        class SessionManager
        {
            public List<string> Sessions;
            public void ExtendSession(int time) { }
        }

        class LoginManager
        {
            public void Login(string id, string password) { }
        }
        
        class LogoutManager
        {
            public void Logout(string id, string password) { }
        }
    }

    class Good
    {
        class LoginManager
        {
            public List<string> Sessions;

            public void Login(string id, string password) { }
            public void Logout(string id, string password) { }
            public void ExtendSession(int time) { }
        }
    }
}
