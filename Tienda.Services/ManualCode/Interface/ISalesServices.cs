namespace Tienda.Services.ManualCode.Interface
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.UI;
    using Tienda.DTO.ManualCode.DTO;

    public partial interface ISalesServices : IDisposable
    {
        /// <summary>
        /// Servicio que devuelve el DTO de la entidad Sales (Sales) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id del DTO requerida</param>
        /// <returns>La DTO con el Id dado por parametro</returns>
        SalesDTO Get(int id);

        DataSourceResult GetAll(DataSourceRequest request);

        void Update(string id, SalesDTO entity);

        SalesDTO Insert(SalesDTO entity, string user);

        void Delete(int id, string user);

        IEnumerable<SalesDTO> GetSalesByDate(string Ciudad, DateTime FechaInicial, DateTime FechaFinal);
    }
}