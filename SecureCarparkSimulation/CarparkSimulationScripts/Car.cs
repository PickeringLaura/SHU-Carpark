using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureCarparkSimulation.CarparkSimulationScripts
{
    class Car
    {
        string _reg;
        string _password;

        public void SetReg(string reg)
        {
            _reg = reg;
        }

        public void SetPass(string pass)
        {
            _password = pass;
        }

        public Car(string _reg, string _password)
        {
            _reg = "";
            _password = "";
        }

        public bool ValidateInformation(string reg, string password)
        {
            if (_reg.Equals(reg) && _password.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
