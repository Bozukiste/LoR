using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI.Models
{
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CardId { get; set; }

        public string RiotId { get; set; }

        public int? RegionRef { get; set; }

        public int Attack { get; set; }

        public int Cost { get; set; }

        public int Health { get; set; }

        public string Description { get; set; }

        public string FlavorText { get; set; }

        public string Name { get; set; }

        public string KeywordsRefs { get; set; }

        public int? SpellSpeed { get; set; }

        public int? Rarity { get; set; }

        public int? SubType { get; set; }

        public int? SuperType { get; set; }

        public int? Type { get; set; }

        public bool Collectable { get; set; }

        public string CardVisualLink { get; set; }

        public string FullArtworkLink { get; set; }

        public bool Legacy { get; set; }
    }
}
