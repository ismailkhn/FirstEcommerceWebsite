using AutoMapper;
using Entities;
using Entities.DTOS;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductServices _productServices;

        private IMapper Mapper
        {
            get;
        }

        // GET: api/<ProductController>

        public ProductController(ProductServices productServices, IMapper mapper)
        {
            _productServices = productServices;
            Mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<ProductListDTO> Get(string? q,int? categoryId)
        {
            List<Product> products = _productServices.GetAll(q,categoryId);
            var productMap=Mapper.Map<List<ProductListDTO>>(products);

            return productMap;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ProductDetailDto? Get(int id)
        {
            Product pro = _productServices.GetById(id);
            ProductDetailDto proMap=Mapper.Map<ProductDetailDto>(pro);

            return proMap ;
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] ProductCreateDTO value)
        {
            var productMap = Mapper.Map<Product>(value);
            _productServices.Add(productMap);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
