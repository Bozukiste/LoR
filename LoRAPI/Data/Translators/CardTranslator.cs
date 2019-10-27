using LoRAPI.DbSetup.Poco;
using LoRAPI.DTO;
using LoRAPI.Enums;
using LoRAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI.Data.Translators
{
    public static class CardTranslator
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

        public static IEnumerable<CardDTO> Translate(IEnumerable<Card> pCards)
        {
            foreach (var card in pCards)
            {
                yield return Translate(card);
            }
        }

        public static CardDTO Translate(Card pCard)
        {
            return new CardDTO
            {
                CardId = pCard.CardId,
                Attack = pCard.Attack,
                Collectable = pCard.Collectable,
                CardVisualLinks = pCard.CardVisualLink.Split(JOIN_CHAR),
                FullArtworkLinks = pCard.FullArtworkLink.Split(JOIN_CHAR),
                Cost = pCard.Cost,
                Description = pCard.Description,
                FlavorText = pCard.FlavorText,
                Health = pCard.Health,
                KeywordsRefs = pCard.GetKeywordsRefs().ToArray(),
                Legacy = pCard.Legacy,
                Name = pCard.Name,
                Rarity = pCard.GetRarity(),
                RegionRef = pCard.GetRegionRef(),
                SpellSpeed = pCard.GetSpellSpeed(),
                RiotId = pCard.RiotId
            };
        }
    }

    public static class TranslationExtensions
    {
        private const char SPLIT_CHAR = ';';
        public static IEnumerable<KeywordsRef> GetKeywordsRefs(this Card pCard)
        {
            if (!string.IsNullOrEmpty(pCard.KeywordsRefs))
            {
                foreach (var keyword in pCard.KeywordsRefs.Split(';'))
                {
                    if (Enum.TryParse(keyword, true, out KeywordsRef kwRef))
                    {
                        yield return kwRef;
                    }
                } 
            }
        }

        public static RegionRef? GetRegionRef(this Card pCard)
        {
            return pCard.RegionRef != null ? (RegionRef)pCard.RegionRef : new RegionRef?();
        }

        public static SpellSpeedRef? GetSpellSpeed(this Card pCard)
        {
            return pCard.SpellSpeed != null ? (SpellSpeedRef)pCard.RegionRef : new SpellSpeedRef?();
        }

        public static RarityRef? GetRarity(this Card pCard)
        {
            return pCard.Rarity != null ? (RarityRef)pCard.Rarity : new RarityRef?();
        }
    }
}
