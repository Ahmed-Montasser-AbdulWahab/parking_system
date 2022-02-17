using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System.Classes
{
    public enum Status
    {
        online,
        offline
    }
    public class Operator
    {
        private string userName;
        private string password;
        private Status status;

        public Boolean Register() { return true; }
        public void Login() { }
        public void Logout() { }
        public Boolean checkCredentials() { return true; }
    }
}
