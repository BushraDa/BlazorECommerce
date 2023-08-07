using AutoMapper;
using BlazorECommerce.Server.Dtos;
using BlazorECommerce.Server.Repositories;
using BlazorECommerce.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorECommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IProductRepository _productRepository;
        public IMapper _mapper;

        public ProductsController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public List<Product> Get()
        {
            var data = _productRepository.GetAll();
            return data.ToList();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product? Get(long id)
        {
            var data = _productRepository.GetById(id);
            return data;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public Product Post([FromBody] ProductAddDto dto)
        {
            var prod = _mapper.Map<Product>(dto);
            _productRepository.Create(prod);

            return prod;
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public Product Put(long id, [FromBody] ProductAddDto dto)
        {

            var prod = _productRepository.GetById(id);
            _mapper.Map(dto, prod);
            _productRepository.Update(prod);

            return prod;
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public Product Delete(long id)
        {
            var prod = _productRepository.GetById(id);
            _productRepository.Delete(prod);

            return prod;
        }
    }
}
