using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System.Classes
{
    public class Terminal
    {
        private int _terminalID;
        private Boolean _service = false; //Online 1 or Offline 0
        private Boolean _direction; //Entry 1 or Exit 0

        public Terminal(int terminalID, Boolean direction)
        {
            _terminalID = terminalID;
            _direction = direction;
        }

        public Boolean Service { get { return this._service; } set { this._service = value; } }
        public Boolean Direction { get { return this._direction; } set { this._direction = value; } }
        public int TerminalID { get { return this._terminalID; } }

        public Boolean IsThereAVehicle()
        {
            return true;
        }

        public string GetFaceID() //Invoke Python Script
        {
            return "Face";
        }

        public string GetLP() //Invoke Python Script
        {
            return "LP";
        }

        public void sendCID_ToServer()
        {

        }

        public void ControlGate()
        {

        }
    }
}
