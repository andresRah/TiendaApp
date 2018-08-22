namespace Tienda.Services.ManualCode.Interface
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.UI;
    using Tienda.DTO.ManualCode.DTO;

    public partial interface ICustomerServices : IDisposable
    {
        /// <summary>
        /// Servicio que devuelve el DTO de la entidad Customer (Customer) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id del DTO requerida</param>
        /// <returns>La DTO con el Id dado por parametro</returns>
        CustomerDTO Get(int id);

        DataSourceResult GetAll(DataSourceRequest request);

        void Update(string id, CustomerDTO entity);

        CustomerDTO Insert(CustomerDTO entity, string user);

        void Delete(int id, string user);

        IEnumerable<CustomerDTO> GetCustomerByDate(string Ciudad, DateTime FechaInicial, DateTime FechaFinal);
    }
}