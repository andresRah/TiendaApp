namespace Tienda.Services.ManualCode.Interface
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.UI;
    using Tienda.DTO.ManualCode.DTO;

    public partial interface IProviderServices : IDisposable
    {
        /// <summary>
        /// Servicio que devuelve el DTO de la entidad Provider (Provider) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id del DTO requerida</param>
        /// <returns>La DTO con el Id dado por parametro</returns>
        ProviderDTO Get(int id);

        DataSourceResult GetAll(DataSourceRequest request);

        void Update(string id, ProviderDTO entity);

        ProviderDTO Insert(ProviderDTO entity, string user);

        void Delete(int id, string user);

        IEnumerable<ProviderDTO> GetProviderByDate(string Ciudad, DateTime FechaInicial, DateTime FechaFinal);
    }
}