using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDND.Class
{
    class CharacterRace : CharacterStats
    {
        public string Dragonborn(string title)
        {
            title = "Dragonborn";    
            StrModGS = 2;
            ChaModGS = 1;
            return title;
        }

    }
}
