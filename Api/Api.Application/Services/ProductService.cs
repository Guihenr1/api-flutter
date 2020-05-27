using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Application.DTOs.Product;
using Api.Application.Interfaces;
using Api.Domain.Interfaces;
using AutoMapper;
using System.Linq;

namespace Api.Application.Services
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;
        readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            var result = await _productRepository.GetAll();
            return _mapper.ProjectTo<ProductDTO>(result.AsQueryable());
        }
    }
}