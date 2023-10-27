using FullStackApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase

    {
        private readonly FullStackDbContext _productDBcontext;
        public ProductController(FullStackDbContext productDbContext)
        {
            _productDBcontext = productDbContext;
        }
    }
}
