using AutoMapper;
using LoRAPI.DbSetup.Poco;
using LoRAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<CardData, Card>(MemberList.None);
        }
    }
}
