using LoRAPI.Data.Translators;
using LoRAPI.DbSetup.Poco;
using LoRAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI.DbSetup
{
    public static class CardDataPopulator
    {
        public static IEnumerable<Card> Populate()
        {
            var datas = RetreiveFromJson("C:\\Users\\genty\\source\\repos\\LoR\\LoRAPI\\DbSetup\\DbFiles\\set1-en_us.json");
            for(var i = 0; i < datas.Length; i++)
            {
                datas[i].ID = i + 1;
                yield return CardTranslator.Translate(datas[i]);
            }
        }

        private static CardData[] RetreiveFromJson(string pPath)
        {
            using (var file = File.OpenText(pPath))
            {
                var jSerializer = new JsonSerializer();
                return (CardData[])jSerializer.Deserialize(file, typeof(CardData[]));
            }
        }
    }
}
