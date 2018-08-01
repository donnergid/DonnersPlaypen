using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIDAdministration
{
    class GuildMember
    {
        string guildName = null; 
        string charName = null;
        string charRace = null; 
        string charClass = null;
        string charSpec = null;
        string charRealm = null; 
        // need association with the wowhead profile 

        public static GuildMember AddMember(string tmpGName, string tmpName, string tmpRace, string tmpClass, string tmpSpec, string tmpRealm)
        {
            GuildMember gmTemp = new GuildMember();

            gmTemp.guildName = tmpGName;
            gmTemp.charName = tmpName;
            gmTemp.charRace = tmpRace;
            gmTemp.charClass = tmpClass;
            gmTemp.charSpec = tmpSpec;
            gmTemp.charRealm = tmpRealm;
                        
            // Add a logging file. 
            return gmTemp; 
            
        }
    }
}
