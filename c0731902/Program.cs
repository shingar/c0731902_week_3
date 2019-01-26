using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0731902
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class countryside
    {
        village Alst;
        village Maeland;
        village Schenig;
        public void InitializeMap()
        {
            Alst = new village();
            Maeland = new village();
            Maeland.isAstrildHere = true;
            village Schenig = new village();

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;
        }
        public void WalkAround()
        {
            village InitialVillage = this.Maeland;
        }

    }
    class village
    {
        public village PreviousVillage;
        public village NextVillage;
        public string VillageName;
        public bool isAstrildHere = false;
        public village()
        {

        }


    }