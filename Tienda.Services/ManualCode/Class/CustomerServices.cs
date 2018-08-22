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

    public partial class CustomerServices : ICustomerServices, IDisposable
    {
        /// <summary>
        /// Contexto Factory que obtiene el contexto.
        /// </summary>
        private readonly TiendaDbContext _dbContextScopeFactory;

        /// <summary>
        /// Repositorio que permite el acceso a las entidades: Customer (Customer)
        /// </summary>
        static ICustomerRepository _repository;

        /// <summary>
        /// Boleano con el cual se controla si se estan desechando los servicios
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Repositorio que permite el acceso a las entidades: Customer (Customer)
        /// </summary>
        partial void SetEntityExtras(ref Customer entity, CustomerDTO dto);

        public CustomerServices()
        {
            this._dbContextScopeFactory = new TiendaDbContext();
            _repository = new CustomerRepository(this._dbContextScopeFactory);
            this.OnCreated();
        }

        /// <summary>
        /// Metodo para extender el Constructor para los servicios de la entidad: Customer (Customer)
		/// </summary>
		partial void OnCreated();


        /// <summary>
        /// Servicio que devuelve el DTO de la entidad Customer (Customer) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id del DTO requerida</param>
        /// <returns>La DTO con el Id dado por parametro</returns>
        public CustomerDTO Get(int id)
        {
            using (_dbContextScopeFactory)
            {
                Customer entity = _repository.Get(id);
                return GetDTO(entity);
            }
        }

        /// <summary>
        /// Obtiene todos los registros de Customers realizando filtros mediante la URL
        /// </summary>
        public virtual DataSourceResult GetAll(DataSourceRequest request)
        {
            using (this._dbContextScopeFactory)
            {
                return _repository.GetAll()
                .Select(o => new CustomerDTO()).ToDataSourceResult(request);
            }
        }

        /// <summary>
        /// Servicio que permite insertar una nueva entidad: Customer (Customer)
        /// </summary>
        /// <param name="entity">DTO de la entidad a insertar</param>
        /// <param name="user">Usuario que ejecuta la inserción</param>
        /// <returns>Se devulve el DTO de la entidad creada con el id asignado</returns>
		public CustomerDTO Insert(CustomerDTO dto, string user)
        {
            using (var dbContextScope = new TiendaDbContext())
            {
                Customer entity = GetEntity(dto);
                entity = _repository.Insert(entity, user);
                dbContextScope.SaveChanges();
                return GetDTO(entity);
            }
        }

        /// <summary>
        /// Actualiza un Customer por medio del id
        /// </summary>
        public void Update(string id, CustomerDTO entity)
        {
            using (var dbContextScope = new TiendaDbContext())
            {
                _repository.Update(this.GetEntity(entity), id);
                dbContextScope.SaveChanges();
            }
        }

        /// <summary>
        /// Servicio que elimina una entidad Customer (Customer) dado su Id
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
        /// Servicio que devuelve una colección de DTOs para las entidades  Customer (Customer) que cumplen con el predicado pasado por parametro
        /// </summary>
        /// <param name="predicate">Predicado (Expresión lamda) con el filtro que se quiere aplicar</param>
        /// <param name="showDeleted">Boleano que indica si se devuelven o no entidades eliminadas</param>
        /// <returns>Coleccion de entidades que cumplen con el predicado</returns>
		public virtual IEnumerable<CustomerDTO> Where(Expression<Func<Customer, bool>> predicate)
        {
            using (_dbContextScopeFactory)
            {
                return _repository.Where(predicate)
                            .Select(o => new CustomerDTO()
                            {
                                CustomerId = o.CustomerId
                                //Name = o.Name ?? "",
                                //RegularExpresion = o.RegularExpresion ?? "",
                            }).ToList();
            }
        }

        /// <summary>
        /// Retorna un rango de valores agrupados por ciudad para fechas determinadas
        /// </summary>
        public IEnumerable<CustomerDTO> GetCustomerByDate(string Ciudad, DateTime FechaInicial, DateTime FechaFinal)
        {
            using (_dbContextScopeFactory)
            {
                var Customers = _repository.Where(o => o.CreateTime >= FechaInicial &&
                                                      o.UpdateTime <= FechaFinal).
                                               Select(o => new CustomerDTO()
                                               {
                                                   CustomerId = o.CustomerId
                                               }).AsEnumerable();
                return Customers.ToList();
            }
        }

        private Customer GetEntity(CustomerDTO dto)
        {
            using (_dbContextScopeFactory)
            {
                Customer entity = null;
                if (dto.CustomerId > 0)
                {
                    entity = _repository.Get(dto.CustomerId);
                }
                if (entity == null)
                {
                    entity = new Customer();
                }
                entity.CustomerId = dto.CustomerId;

                this.SetEntityExtras(ref entity, dto);

                return entity;
            }
        }

        /// <summary>
        /// Metodo que dada una entidad devuelve su DTO
        /// </summary>
        /// <param name="entity">Entidad de la cual se requiere el DTO</param>
        /// <returns>DTO para la entidad pasada por parametro</returns>
		private CustomerDTO GetDTO(Customer entity)
        {
            CustomerDTO dto = new CustomerDTO();
            dto.CustomerId = entity.CustomerId;
            this.SetDTOExtras(entity, ref dto);

            return dto;
        }

        /// <summary>
        /// Metodo utilizado para asignar propiedades adicionales de un dto en el codigo manual
        /// </summary>
        /// <param name="entity">Entidad de la cual se toman las propiedades</param>
        /// <param name="dto">DTO en el cual se asignaron las propiedades adicionales</param>
        partial void SetDTOExtras(Customer entity, ref CustomerDTO dto);

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