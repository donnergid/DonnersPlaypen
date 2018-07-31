using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIDAdministration
{
    class GuildMember
    {
        string charName = null;
        string charRace = null; 
        string charClass = null;
        string charSpec = null;
        string charRealm = null; 
        // need association with the wowhead profile 

        private void addMember(string tmpName, string tmpRace, string tmpClass, string tmpSpec, string tmpRealm)
        {
            charName = tmpName;
            charRace = tmpRace;
            charClass = tmpClass;
            charSpec = tmpSpec;
            charRealm = tmpRealm; 


        }
    }
}
