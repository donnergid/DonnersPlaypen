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
        Guild gRef = null; 
        // need association with the wowhead profile 

        public void AddMember(string tmpGName, string tmpName, string tmpRace, string tmpClass, string tmpSpec, string tmpRealm)
        {
            guildName = tmpGName;
            charName = tmpName;
            charRace = tmpRace;
            charClass = tmpClass;
            charSpec = tmpSpec;
            charRealm = tmpRealm;

            //
            //add logging stub
            // 

            //
            // Use tmpbGName provided by user to search the gmMain guild list object. 
            // 

            foreach (Guild g in GuildLIst.gmMain)
            {
                if (g.gName == tmpGName)
                {
                    gRef = g;
                }
            }
        }
    }
}
