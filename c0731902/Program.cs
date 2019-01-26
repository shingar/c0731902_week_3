using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0731902
{
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
            Alst.VillageName = "Alst";
            Maeland = new village();
            Maeland.VillageName = "Maeland";
            Maeland.isAstrildHere = true;
            Schenig = new village();
            Schenig.VillageName = "Schenig";

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;
        }
        public void WalkAround()
        {
            village CurrentVillage = this.Maeland;
            village NextVillage;
            NextVillage = CurrentVillage.NextVillage;
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


}
