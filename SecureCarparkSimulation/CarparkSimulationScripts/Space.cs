using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureCarparkSimulation.CarparkSimulationScripts
{
    public class Space
    {
        int _id;
        int _floor;
        bool _allocated;
        string _reg;
        string _password;

        public Space(int id, int floor)
        {
            _id = id;
            _floor = floor;
            _allocated = false;
            _reg = "";
            _password = "";
        }

        public void SetReg(string reg)
        {
            _reg = reg;
        }

        public void SetPass(string pass)
        {
            _password = pass;
        }

        public bool IsAllocated()
        {
            return _allocated;
        }

        public bool ValidateInformation(string reg, string password)
        {
            if(_reg.Equals(reg) && _password.Equals(password))
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
