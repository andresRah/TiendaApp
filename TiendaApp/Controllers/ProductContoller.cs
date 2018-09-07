namespace TiendaApp.Controllers
{
    using Kendo.Mvc.UI;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Tienda.Models.ManualModels;
    using Tienda.Services.ManualCode.Class;
    using Tienda.Services.ManualCode.Interface;
    using TiendaApp.Models;

    [Produces("application/json")]
    [Route("api/Product")]
    [ApiController]
    public class ProductContoller : ControllerBase
    {
        static IProductServices _services;

        public ProductContoller()
        {
            _services = new ProductServices();
        }

        [HttpGet]
        public DataSourceResult Get([DataSourceRequest] DataSourceRequest request)
        {
            DataSourceResult result = _services.GetAll(request);

            //var results = Enumerable.Range(0, 50).Select(i => new OrderViewModel
            //{
            //    OrderID = i,
            //    Freight = i * 10,
            //    OrderDate = new DateTime(2016, 9, 15).AddDays(i % 7),
            //    ShipName = "ShipName " + i,
            //    ShipCity = "ShipCity " + i
            //});

            //var dsResult = result.ToDataSourceResult(request);
            //return Json(dsResults);

            return result;
        }
    }
}
