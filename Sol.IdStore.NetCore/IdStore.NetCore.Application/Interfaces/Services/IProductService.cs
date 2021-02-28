using IdStore.NetCore.Application.Contracts.Queries;
using IdStore.NetCore.Application.Contracts.Responses;
using IdStore.NetCore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdStore.NetCore.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponse>> GetAllAsync(ProductQuery filter);
        //Task<OperationResponse> CreateAsync(ProductoRequest filter);
        ////Task<OperationResponse> CreateBarCodeAsync(ProductoBarCodeRequest requests);
        //Task<int> CreateBarCodeAsync(ProductoBarCodeCabRequest request);
    }
}
