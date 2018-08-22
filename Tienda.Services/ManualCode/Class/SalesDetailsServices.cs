namespace Tienda.Services.ManualCode.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Kendo.Mvc.UI;
    using Kendo.Mvc.Extensions;
    using Tienda.Models.ManualModels;
    using Tienda.DTO.ManualCode.DTO;
    using Tienda.Services.ManualCode.Interface;
    using Tienda.Data;
    using Tienda.Data.ManualCode.Data.Class;
    using Tienda.Data.ManualCode.Data.Interface;
    using System.Linq.Expressions;

    public partial class SalesDetailsServices : ISalesDetailsServices, IDisposable
    {
        /// <summary>
        /// Contexto Factory que obtiene el contexto.
        /// </summary>
        private readonly TiendaDbContext _dbContextScopeFactory;

        /// <summary>
        /// Repositorio que permite el acceso a las entidades: SalesDetails (SalesDetails)
        /// </summary>
        static ISalesDetailsRepository _repository;

        /// <summary>
        /// Boleano con el cual se controla si se estan desechando los servicios
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Repositorio que permite el acceso a las entidades: SalesDetails (SalesDetails)
        /// </summary>
        partial void SetEntityExtras(ref SalesDetails entity, SalesDetailsDTO dto);

        public SalesDetailsServices()
        {
            this._dbContextScopeFactory = new TiendaDbContext();
            _repository = new SalesDetailsRepository(this._dbContextScopeFactory);
            this.OnCreated();
        }

        /// <summary>
        /// Metodo para extender el Constructor para los servicios de la entidad: SalesDetails (SalesDetails)
		/// </summary>
		partial void OnCreated();


        /// <summary>
        /// Servicio que devuelve el DTO de la entidad SalesDetails (SalesDetails) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id del DTO requerida</param>
        /// <returns>La DTO con el Id dado por parametro</returns>
        public SalesDetailsDTO Get(int id)
        {
            using (_dbContextScopeFactory)
            {
                SalesDetails entity = _repository.Get(id);
                return GetDTO(entity);
            }
        }

        /// <summary>
        /// Obtiene todos los registros de SalesDetailss realizando filtros mediante la URL
        /// </summary>
        public virtual DataSourceResult GetAll(DataSourceRequest request)
        {
            using (this._dbContextScopeFactory)
            {
                return _repository.GetAll()
                .Select(o => new SalesDetailsDTO()).ToDataSourceResult(request);
            }
        }

        /// <summary>
        /// Servicio que permite insertar una nueva entidad: SalesDetails (SalesDetails)
        /// </summary>
        /// <param name="entity">DTO de la entidad a insertar</param>
        /// <param name="user">Usuario que ejecuta la inserción</param>
        /// <returns>Se devulve el DTO de la entidad creada con el id asignado</returns>
		public SalesDetailsDTO Insert(SalesDetailsDTO dto, string user)
        {
            using (var dbContextScope = new TiendaDbContext())
            {
                SalesDetails entity = GetEntity(dto);
                entity = _repository.Insert(entity, user);
                dbContextScope.SaveChanges();
                return GetDTO(entity);
            }
        }

        /// <summary>
        /// Actualiza un SalesDetails por medio del id
        /// </summary>
        public void Update(string id, SalesDetailsDTO entity)
        {
            using (var dbContextScope = new TiendaDbContext())
            {
                _repository.Update(this.GetEntity(entity), id);
                dbContextScope.SaveChanges();
            }
        }

        /// <summary>
        /// Servicio que elimina una entidad SalesDetails (SalesDetails) dado su Id
        /// </summary>
        /// <param name="id">Id de la entidad a eliminar</param>
        /// <param name="user">Usuario que elimina la entidad</param>
        public virtual void Delete(int id, string user)
        {
            using (var dbContextScope = new TiendaDbContext())
            {
                _repository.Delete(id, user);
                dbContextScope.SaveChanges();
            }
        }

        /// <summary>
        /// Servicio que devuelve una colección de DTOs para las entidades  SalesDetails (SalesDetails) que cumplen con el predicado pasado por parametro
        /// </summary>
        /// <param name="predicate">Predicado (Expresión lamda) con el filtro que se quiere aplicar</param>
        /// <param name="showDeleted">Boleano que indica si se devuelven o no entidades eliminadas</param>
        /// <returns>Coleccion de entidades que cumplen con el predicado</returns>
		public virtual IEnumerable<SalesDetailsDTO> Where(Expression<Func<SalesDetails, bool>> predicate)
        {
            using (_dbContextScopeFactory)
            {
                return _repository.Where(predicate)
                            .Select(o => new SalesDetailsDTO()
                            {
                                SalesDetailsId = o.SalesDetailsId
                                //Name = o.Name ?? "",
                                //RegularExpresion = o.RegularExpresion ?? "",
                            }).ToList();
            }
        }

        /// <summary>
        /// Retorna un rango de valores agrupados por ciudad para fechas determinadas
        /// </summary>
        public IEnumerable<SalesDetailsDTO> GetSalesDetailsByDate(string Ciudad, DateTime FechaInicial, DateTime FechaFinal)
        {
            using (_dbContextScopeFactory)
            {
                var SalesDetailss = _repository.Where(o => o.CreateTime >= FechaInicial &&
                                                      o.UpdateTime <= FechaFinal).
                                               Select(o => new SalesDetailsDTO()
                                               {
                                                   SalesDetailsId = o.SalesDetailsId
                                               }).AsEnumerable();
                return SalesDetailss.ToList();
            }
        }

        private SalesDetails GetEntity(SalesDetailsDTO dto)
        {
            using (_dbContextScopeFactory)
            {
                SalesDetails entity = null;
                if (dto.SalesDetailsId > 0)
                {
                    entity = _repository.Get(dto.SalesDetailsId);
                }
                if (entity == null)
                {
                    entity = new SalesDetails();
                }
                entity.SalesDetailsId = dto.SalesDetailsId;

                this.SetEntityExtras(ref entity, dto);

                return entity;
            }
        }

        /// <summary>
        /// Metodo que dada una entidad devuelve su DTO
        /// </summary>
        /// <param name="entity">Entidad de la cual se requiere el DTO</param>
        /// <returns>DTO para la entidad pasada por parametro</returns>
		private SalesDetailsDTO GetDTO(SalesDetails entity)
        {
            SalesDetailsDTO dto = new SalesDetailsDTO();
            dto.SalesDetailsId = entity.SalesDetailsId;
            this.SetDTOExtras(entity, ref dto);

            return dto;
        }

        /// <summary>
        /// Metodo utilizado para asignar propiedades adicionales de un dto en el codigo manual
        /// </summary>
        /// <param name="entity">Entidad de la cual se toman las propiedades</param>
        /// <param name="dto">DTO en el cual se asignaron las propiedades adicionales</param>
        partial void SetDTOExtras(SalesDetails entity, ref SalesDetailsDTO dto);

        /// <summary>
        /// Metodo que desecha los servicios
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Metodo que desecha los servicios
        /// </summary>
        /// <param name="disposing">Boleano con el cual se controla si se estan desechando los servicios</param>
        protected virtual void Dispose(bool disposing)
        {
            this.disposed = true;
        }

        /// <summary>
        /// Metodo que devuelve una respuesta HTTP con la información de la excepción generada
        /// </summary>
        /// <param name="e">Execpción</param>
        /// <param name="controller">Controladora</param>
        /// <param name="action">Accion donde se genera la excepcion</param>
        /// <returns>Respuesta HTTP con la Excepcion</returns>
        private void GetErrorMessage(Exception e, string controller, string action, string detail = "")
        {
            string message = String.Format("Error Interno: {0} <br> Controladora: {1} <br> Acción: {2} <br> {3}", e.Message, controller, action, detail);
            //Logger.Error(message);
        }
    }
}