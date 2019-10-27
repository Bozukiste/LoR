using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LoRAPI.Data.Repositories;
using LoRAPI.Data.Translators;
using LoRAPI.DTO;
using LoRAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LoRAPI.Controllers
{
    [ApiController]
    [Route("api/card")]
    public class LorController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IDataRepository<Card> _cardRepository;

        private readonly ILogger<LorController> _logger;

        public LorController(ILogger<LorController> logger, IMapper pMapper, IDataRepository<Card> pRepository)
        {
            _logger = logger;
            _mapper = pMapper;
            _cardRepository = pRepository;
        }

        //[Route("GetCardById")]
        //[HttpGet("{id}", Name = "GetCardById")]
        //public IActionResult GetCardById([FromQuery(Name = "id")]long id)
        //{
        //    var card = _cardRepository.GetById(id);

        //    if (card == null)
        //    {
        //        return NotFound("Card not found");
        //    }

        //    return Ok(CardTranslator.Translate(card));
        //}

        [Route("GetCardById")]
        [HttpGet("{id}", Name = "GetCardById")]
        public async Task<IActionResult> GetCardsByIds([FromQuery(Name = "id")]long[] pIds)
        {
            var cards = _cardRepository.GetMultipleById(pIds);

            if (cards == null || cards.Count() == 0)
            {
                return NotFound("No card was found");
            }

            return Ok(CardTranslator.Translate(cards));
        }
    }
}
