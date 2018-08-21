﻿namespace Tienda.Services.ManualCode.Interface
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.UI;
    using Tienda.DTO.ManualCode.DTO;

    public partial interface IBalanceServices : IDisposable
    {
        /// <summary>
        /// Servicio que devuelve el DTO de la entidad Balance (Balance) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id del DTO requerida</param>
        /// <returns>La DTO con el Id dado por parametro</returns>
        BalanceDTO Get(int id);

        DataSourceResult GetAll(DataSourceRequest request);

        void Update(string id, BalanceDTO entity);

        BalanceDTO Insert(BalanceDTO entity, string user);
            
        void Delete(int id, string user);

        IEnumerable<BalanceDTO> GetBalanceByDate(string Ciudad, DateTime FechaInicial, DateTime FechaFinal);
    }
}