using AutoMapper;
using IdStore.NetCore.Application.Contracts.Queries;
using IdStore.NetCore.Application.Contracts.Responses;
using IdStore.NetCore.Application.Interfaces.Repositories;
using IdStore.NetCore.Application.Interfaces.Services;
using IdStore.NetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdStore.NetCore.Application.Services
{
    public class ProductService: IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductResponse>> GetAllAsync(ProductQuery filter)
        {
            IEnumerable<ProductEntity> productEntity = await _unitOfWork.Products.Get(filter);
            if (productEntity == null) return null;
            var productResponse = _mapper.Map<IEnumerable<ProductResponse>>(productEntity);
            return productResponse;
        }
    }
}
