﻿using System.Collections.Generic;

namespace SharprWowApi.Models.Zone
{
    public class Boss
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UrlSlug { get; set; }

        public string Description { get; set; }

        public int ZoneId { get; set; }

        public bool AvailableInNormalMode { get; set; }

        public bool AvailableInHeroicMode { get; set; }

        public int Health { get; set; }

        public int HeroicHealth { get; set; }

        public int Level { get; set; }

        public int HeroicLevel { get; set; }

        public int JournalId { get; set; }

        public IEnumerable<Npc> Npcs { get; set; }

        public Location Location { get; set; }
    }
}
