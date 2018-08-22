namespace Tienda.Services.ManualCode.Interface
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.UI;
    using Tienda.DTO.ManualCode.DTO;

    public partial interface IProductServices : IDisposable
    {
        /// <summary>
        /// Servicio que devuelve el DTO de la entidad Product (Product) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id del DTO requerida</param>
        /// <returns>La DTO con el Id dado por parametro</returns>
        ProductDTO Get(int id);

        DataSourceResult GetAll(DataSourceRequest request);

        void Update(string id, ProductDTO entity);

        ProductDTO Insert(ProductDTO entity, string user);

        void Delete(int id, string user);

        IEnumerable<ProductDTO> GetProductByDate(string Ciudad, DateTime FechaInicial, DateTime FechaFinal);
    }
}