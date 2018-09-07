namespace TiendaApp.Controllers
{
    using Kendo.Mvc.UI;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Tienda.Services.ManualCode.Class;
    using Tienda.Services.ManualCode.Interface;

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
