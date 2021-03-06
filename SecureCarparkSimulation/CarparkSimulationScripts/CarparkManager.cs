﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureCarparkSimulation.CarparkSimulationScripts
{
    class CarparkManager
    {
        static CarparkManager _instance = new CarparkManager();

        //Getter for the static instance of the carpark, to allow accessibility for other "screens"
        public static CarparkManager Instance
        {
            get
            {
                return _instance;
            }
        }

        Carpark[] carparks;
        readonly string[] CARPARKNAMES = { "Applebys", "Mayfair", "North-East", "Denim", "Wheatfield" };

        CarparkManager()
        {
            carparks = new Carpark[5];
            for (int i = 0; i < 5; i++)
            {
                carparks[i] = new Carpark(CARPARKNAMES[i], CARPARKNAMES[i].Length * 10);
            }
        }

        public Carpark GetCarpark(int index)
        {
            return Instance.carparks[index];
        }

        public Carpark GetCarpark(string carpark)
        {
            int index = Array.IndexOf(CARPARKNAMES, carpark);
            return Instance.carparks[index];
        }

    }
}
