using AutoMapper;
using IdStore.NetCore.Application.Contracts.Responses;
using IdStore.NetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdStore.NetCore.Application.MappingProfiles
{
    public class DomainToResponseProfile: Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<ProductEntity, ProductResponse>();
        }
    }
}
