using IdStore.NetCore.Application.Contracts;
using IdStore.NetCore.Application.Contracts.Queries;
using IdStore.NetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdStore.NetCore.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductEntity>> Get(ProductQuery filter);
        //Task<OperationEntity> Create(ProductoRequest filter);
        ////Task<OperationEntity> CreateBarCode(ProductoBarCodeRequest requests);
        //Task<OperationResponse> CreateBarCodes(ProductoBarCodeDetailRequest request, EnumDbConnName CodCompany);
        //Task<OperationResponse> DeleteBarCodeByItemCode(string ItemCode, EnumDbConnName CodCompany);
    }
}
