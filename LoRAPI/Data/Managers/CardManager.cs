using AutoMapper;
using LoRAPI.Data.Repositories;
using LoRAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI.Data.Managers
{
    public class CardManager : IDataRepository<Card>
    {
        private readonly CardContext _cardContext;

        private readonly IMapper _mapper;

        public CardManager(CardContext pCardContext, IMapper pMapper)
        {
            _cardContext = pCardContext;
            _mapper = pMapper;
        }

        public void Add(Card pEntity)
        {
            _cardContext.Cards.Add(pEntity);
            _cardContext.SaveChanges();
        }

        public void Delete(Card pEntity)
        {
            _cardContext.Remove(pEntity);
            _cardContext.SaveChanges();
        }

        public Card Get(long pId)
        {
            return _cardContext.Cards.FirstOrDefault(c => c.CardId == pId);
        }

        public IEnumerable<Card> GetAll()
        {
            return _cardContext.Cards.ToList();
        }

        public void Update(Card pDbEntity, Card pEntity)
        {
            pDbEntity = _mapper.Map<Card>(pEntity);
            _cardContext.SaveChanges();
        }
    }
}
