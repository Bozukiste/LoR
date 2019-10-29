using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI
{
    public static class AutoMapperConfig
    {
        private static IMapper Mapper;

        public static IMapper GetMapper()
        {
            if (Mapper == null)
            {
                InitializeMapper();
            }

            return Mapper;
        }

        private static void InitializeMapper()
        {
            var profilesTypes = typeof(AutoMapperConfig).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Profile)));
            var profilesList = new List<Profile>();

            foreach (var profileType in profilesTypes)
            {
                var profile = Activator.CreateInstance(profileType) as Profile;

                if (profile != null)
                {
                    profilesList.Add(profile);
                }
            }

            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfiles(profilesList);
            });

            mapperConfig.AssertConfigurationIsValid();

            Mapper = mapperConfig.CreateMapper();
        }
    }
}
