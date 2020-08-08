using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDND.Class
{
    class CharacterStats
    {



        //numbered stats from 10-whatever number they achieve
        private readonly int strength;
        private readonly int Dexterity;
        private readonly int Constitution;
        private readonly int Intelligence;
        private readonly int Wisdom;
        private readonly int Charisma;

        public int StrGS { get; set; }

        public int DexGS { get; set; }

        public int ConGS { get; set; }

        public int IntGS { get; set; }

        public int WisGS { get; set; }

        public int ChaGS { get; set; }
    }
}
