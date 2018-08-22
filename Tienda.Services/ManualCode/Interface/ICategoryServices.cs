namespace Tienda.Services.ManualCode.Interface
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.UI;
    using Tienda.DTO.ManualCode.DTO;

    public partial interface ICategoryServices : IDisposable
    {
        /// <summary>
        /// Servicio que devuelve el DTO de la entidad Category (Category) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id del DTO requerida</param>
        /// <returns>La DTO con el Id dado por parametro</returns>
        CategoryDTO Get(int id);

        DataSourceResult GetAll(DataSourceRequest request);

        void Update(string id, CategoryDTO entity);

        CategoryDTO Insert(CategoryDTO entity, string user);

        void Delete(int id, string user);

        IEnumerable<CategoryDTO> GetCategoryByDate(string Ciudad, DateTime FechaInicial, DateTime FechaFinal);
    }
}