using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System.Classes
{
    public class Gate
    {
        //ClosedState => 0 ,OpenedState => 1
        private Boolean state = false;
        public Boolean State { get { return state; } }

        public Boolean Open()
        {
            state = true;
            return this.state;
        }

        public Boolean Close()
        {
            state = false;
            return this.state;
        }
    }
}
