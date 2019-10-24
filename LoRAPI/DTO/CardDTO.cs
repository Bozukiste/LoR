using LoRAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI.DTO
{
    public class CardDTO
    {
        public long CardId { get; set; }

        public string RiotId { get; set; }

        public RegionRef? RegionRef { get; set; }

        public int Attack { get; set; }

        public int Cost { get; set; }

        public int Health { get; set; }

        public string Description { get; set; }

        public string FlavorText { get; set; }

        public string Name { get; set; }

        public KeywordsRef[] KeywordsRefs { get; set; }

        public SpellSpeedRef? SpellSpeed { get; set; }

        public RarityRef? Rarity { get; set; }

        public int? SubType { get; set; }

        public int? SuperType { get; set; }

        public int? Type { get; set; }

        public bool Collectable { get; set; }

        public string[] CardVisualLinks { get; set; }

        public string[] FullArtworkLinks { get; set; }

        public bool Legacy { get; set; }
    }
}
