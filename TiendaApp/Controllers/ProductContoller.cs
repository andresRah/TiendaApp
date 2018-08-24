namespace TiendaApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductContoller : ControllerBase
    {
        static IProductServices _services;

        public ProductContoller()
        {
            _services = new ProductServices();
        }

        [HttpGet]
        public async Task<ActionResult<DataSourceResult>> Get([DataSourceRequest] DataSourceRequest request)
        {
            DataSourceResult result = _services.GetAll(request);
            return result;
        }



    }
}
