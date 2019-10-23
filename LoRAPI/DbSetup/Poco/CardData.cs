using LoRAPI.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI.DbSetup.Poco
{
    public partial class CardData
    {
        [JsonIgnore]
        public int ID { get; set; }

        [JsonProperty("associatedCards")]
        public object[] AssociatedCards { get; set; }

        [JsonProperty("associatedCardRefs")]
        public object[] AssociatedCardRefs { get; set; }

        [JsonProperty("assets")]
        public Asset[] Assets { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("regionRef")]
        public RegionRef? RegionRef { get; set; }

        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("health")]
        public int Health { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("descriptionRaw")]
        public string DescriptionRaw { get; set; }

        [JsonProperty("flavorText")]
        public string FlavorText { get; set; }

        [JsonProperty("artistName")]
        public string ArtistName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cardCode")]
        public string CardCode { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("keywordRefs")]
        public KeywordsRef[] KeywordRefs { get; set; }

        [JsonProperty("spellSpeed")]
        public string SpellSpeed { get; set; }

        [JsonProperty("spellSpeedRef")]
        public SpellSpeedRef? SpellSpeedRef { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("rarityRef")]
        public RarityRef? RarityRef { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("supertype")]
        public string Supertype { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("collectible")]
        public bool Collectible { get; set; }
    }

    public partial class Asset
    {
        [JsonProperty("gameAbsolutePath")]
        public Uri GameAbsolutePath { get; set; }

        [JsonProperty("fullAbsolutePath")]
        public Uri FullAbsolutePath { get; set; }
    }

    public partial class CardData
    {
        public static CardData FromJson(string json) => JsonConvert.DeserializeObject<CardData>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CardData self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
