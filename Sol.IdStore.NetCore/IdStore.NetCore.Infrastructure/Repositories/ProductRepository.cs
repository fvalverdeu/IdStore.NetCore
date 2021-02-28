using Dapper;
using IdStore.NetCore.Application.Contracts.Queries;
using IdStore.NetCore.Application.Interfaces.Repositories;
using IdStore.NetCore.Domain.Entities;
using IdStore.NetCore.Infrastructure.ExecuteCommands;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace IdStore.NetCore.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IExecuters _executers;

        public ProductRepository(IConfiguration configuration, IExecuters executers)
        {
            _configuration = configuration;
            _executers = executers;
        }

        public async Task<IEnumerable<ProductEntity>> Get(ProductQuery filter)
        {
            var sql = "USP_PRODUCT_LIST";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Status", filter.Status, DbType.Boolean, ParameterDirection.Input);
            var result = await _executers.ExecuteCommand(
                    filter.CodCompany,
                    conn => conn.QueryAsync<ProductEntity>(
                        sql,
                        parameters,
                        commandType: CommandType.StoredProcedure
                    )
            );
            _executers.CloseConnection();
            return result;
        }
    }
}
