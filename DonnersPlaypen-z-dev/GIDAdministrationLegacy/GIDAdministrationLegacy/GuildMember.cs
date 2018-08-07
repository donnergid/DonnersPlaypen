using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIDAdministrationLegacy
{
    class GuildMember
    {
        public GuildMember()
        {
            Guild tmpGuild = new Guild();
            currentGuild = tmpGuild;
        }

        public GuildMember(string chName, string rName, string clName, string spName, string chLocale, string chGuild, string tmpRealm)
        {
            charName = chName;
            charRace = rName;
            charClass = clName;
            charSpec = spName;
            locale = chLocale;

            Guild tmpGuild = new Guild();
            currentGuild = tmpGuild;

            currentGuild.guildName = chGuild;
            currentGuild.realmName = tmpRealm; 
        }
        
        public string charName = null;
        public string charRace = null;
        public string charClass = null;
        public string charSpec = null;
        public string locale = null; // Eventually this will be replaced with a Locale obj pulling from Wow APIs. 
        public Guild currentGuild; 
        
        // Need to add in a obj that defines talants. 
    }

    class Guild
    {
        public string guildName = null;
        public string realmName = null; 
    }

    class infoStorage
    {
        public static List<GuildMember> gidMain = new List<GuildMember>();
    }
}
