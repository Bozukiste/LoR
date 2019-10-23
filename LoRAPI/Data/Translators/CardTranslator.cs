using LoRAPI.DbSetup.Poco;
using LoRAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI.Data.Translators
{
    public class CardTranslator
    {
        private const char JOIN_CHAR = ';';
        public static Card Translate(CardData pData)
        {
            return new Card
            {
                CardId = pData.ID,
                Attack = pData.Attack,
                CardVisualLink = string.Join(JOIN_CHAR, pData.Assets.Select(asset => asset.GameAbsolutePath)),
                Collectable = pData.Collectible,
                Cost = pData.Cost,
                Description = pData.Description,
                FlavorText = pData.FlavorText,
                FullArtworkLink = string.Join(JOIN_CHAR, pData.Assets.Select(asset => asset.FullAbsolutePath)),
                Health = pData.Health,
                KeywordsRefs = pData.KeywordRefs != null && pData.KeywordRefs.Any() ? string.Join(JOIN_CHAR, pData.KeywordRefs.Select(kwr => kwr.ToString())) : null,
                Legacy = false,
                Name = pData.Name,
                Rarity = pData.RarityRef != null ? (int)pData.RarityRef : new int?(),
                RegionRef = pData.RegionRef != null ? (int)pData.RegionRef : new int?(),
                RiotId = pData.CardCode,
                SpellSpeed = pData.SpellSpeedRef != null ? (int)pData.SpellSpeedRef : new int?(),
            };
        }
    }
}
