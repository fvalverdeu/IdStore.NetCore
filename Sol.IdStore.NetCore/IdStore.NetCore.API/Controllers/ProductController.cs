using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdStore.NetCore.Application.Contracts.Queries;
using IdStore.NetCore.Application.Contracts.Responses;
using IdStore.NetCore.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdStore.NetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<CustomResponse<IEnumerable<ProductResponse>>>> GetAll([FromQuery] ProductQuery filter)
        {
            IEnumerable<ProductResponse> productResponse = await _productService.GetAllAsync(filter);
            if (productResponse == null)
            {
                CustomResponse badResponse = new CustomResponse
                {
                    Code = "400",
                    Message = "No hay productos"
                };
                return BadRequest(badResponse);
            }
            CustomResponse<IEnumerable<ProductResponse>> response = new CustomResponse<IEnumerable<ProductResponse>>
            {
                Code = "200",
                Message = "Solicitud exitosa!!",
                Data = productResponse
            };
            return Ok(response);
        }
    }

}
