namespace Tienda.Services.ManualCode.Interface
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.UI;
    using Tienda.DTO.ManualCode.DTO;

    public partial interface IPurchaseServices : IDisposable
    {
        /// <summary>
        /// Servicio que devuelve el DTO de la entidad Purchase (Purchase) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id del DTO requerida</param>
        /// <returns>La DTO con el Id dado por parametro</returns>
        PurchaseDTO Get(int id);

        DataSourceResult GetAll(DataSourceRequest request);

        void Update(string id, PurchaseDTO entity);

        PurchaseDTO Insert(PurchaseDTO entity, string user);

        void Delete(int id, string user);

        IEnumerable<PurchaseDTO> GetPurchaseByDate(string Ciudad, DateTime FechaInicial, DateTime FechaFinal);
    }
}