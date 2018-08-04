using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIDAdministrationLegacy
{
    class GuildMember
    {

        GuildMember()
        {
            Guild tmpGuild = new Guild();
            currentGuild = tmpGuild; 
        }

        string charName = null;
        string charRace = null;
        string charClass = null;
        string charSpec = null;
        string locale = null; // Eventually this will be replaced with a Locale obj pulling from Wow APIs. 
        Guild currentGuild; 
        
        // Need to add in a obj that defines talants. 
    }

    class Guild
    {
        string guildName;
        string realmName; 
    }
}
