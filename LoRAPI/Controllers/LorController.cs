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

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            var card = _cardRepository.Get(id);

            if (card == null)
            {
                return NotFound("Card not found");
            }

            return Ok(CardTranslator.Translate(card));
        }
    }
}
