using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDND.Class
{
    class CharacterStats
    {
        //Modifiers 
        private readonly int strMod = 0;
        private readonly int dexMod = 0;
        private readonly int conMod = 0;
        private readonly int intMod = 0;
        private readonly int wisMod = 0;
        private readonly int chaMod = 0;

        public int StrModGS { get; set; }

        public int DexModGS { get; set; }

        public int ConModGS { get; set; }

        public int IntModGS { get; set; }

        public int WisModGS { get; set; }

        public int ChaModGS { get; set; }

        //stats
        private readonly int strength = 8;
        private readonly int dexterity = 8;
        private readonly int constitution = 8;
        private readonly int intelligence = 8;
        private readonly int wisdom = 8;
        private readonly int charisma = 8;
        //stats getter/setter
        public int StrGS { get; set; }

        public int DexGS { get; set; }

        public int ConGS { get; set; }

        public int IntGS { get; set; }

        public int WisGS { get; set; }

        public int ChaGS { get; set; }
    }
}
