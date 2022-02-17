using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System.Classes
{
    public class ParkingArea
    {
        private string _name;

        public ParkingArea(string name)
        {
              _name = name;
        }

        /*
         public void listenFromTerminal(){}
        */

        public Boolean CheckPairing()
        {
            return true;
        }

        public Boolean CheckRegistered()
        {
            return true;
        }

        public ParkingTransaction GenerateTransaction(string cID, int terminalID, Boolean result, DateTime dateTime)
        {
            return new ParkingTransaction(cID, terminalID, result, dateTime);
        }

        public void TransformToOperator()
        {

        }

        public double ComputeBill()
        {
            return 1.5;
        }

        public void Activate()
        {

        }
    }
}
