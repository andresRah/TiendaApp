namespace Tienda.Data.ManualCode.Data.Class
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Tienda.Data.ManualCode.Data.Interface;
    using Tienda.Models.ManualModels;

    public partial class CategoryRepository : ICategoryRepository
    {
        /// <summary>
        /// Localizador de contextos en el ambiente
        /// </summary>
        private readonly TiendaDbContext _ambientDbContextLocator;

        /// <summary>
        /// Contexto de la base de datos
        /// </summary>
        private TiendaDbContext Context
        {
            get
            {
                var dbContext = _ambientDbContextLocator;

                if (dbContext == null)
                    throw new InvalidOperationException("No ambient DbContext of type <TiendaDbContext found. This means that this repository method has been called outside of the scope of a DbContextScope. A repository must only be accessed within the scope of a DbContextScope, which takes care of creating the DbContext instances that the repositories need and making them available as ambient contexts. This is what ensures that, for any given DbContext-derived type, the same instance is used throughout the duration of a business transaction. To fix this issue, use IDbContextScopeFactory in your top-level business logic service method to create a DbContextScope that wraps the entire business transaction that your service method implements. Then access this repository within that scope. Refer to the comments in the IDbContextScope.cs file for more details.");

                return dbContext;
            }
        }

        /// <summary>
        /// Constructor del Repositorio de la entidad: Category (Category)
        /// </summary>
        /// <param name="unitOfWork">Contexto de la base de datos</param>
        public CategoryRepository(TiendaDbContext ambientDbContextLocator)
        {
            if (ambientDbContextLocator == null) throw new ArgumentNullException("ambientDbContextLocator");
            _ambientDbContextLocator = ambientDbContextLocator;
            this.OnCreated();
        }

        /// <summary>
        /// Metodo para extender el Constructor para el repositorio de la entidad: Solicitante (Solicitante)
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// Metodo que permite insertar una nueva entidad: Solicitante (Solicitante)
        /// </summary>
        /// <param name="entity">Entidad a insertar</param>
        /// <param name="user">Usuario que ejecuta la inserción</param>
        /// <returns>Se devulve la entidad creada con el id asignado</returns>
        public Category Insert(Category entity, string user)
        {
            try
            {
                entity.CreateTime = DateTime.UtcNow;
                entity.UpdateTime = DateTime.UtcNow;
                Context.Set<Category>().Add(entity);
                Context.ChangeTracker.DetectChanges();
                return entity;
            }
            catch (Exception e)
            {
                throw new Exception("Error al Insertar Category");
            }
        }

        /// <summary>
        /// Metodo que actualiza la entidad Category (Category) con los datos pasados por parametro
        /// </summary>
        /// <param name="entity">Entidad a actualizar</param>
        /// <param name="user">Usuario que actualiza la entidad</param>
        public void Update(Category entity, string user)
        {
            try
            {
                Context.Entry(entity).State = EntityState.Modified;
                entity.UpdateTime = DateTime.UtcNow;
                Context.ChangeTracker.DetectChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Error al Actualizar Category");
            }
        }

        /// <summary>
        /// Metodo que elimina una entidad Category (Category) dado su Id
        /// </summary>
        /// <param name="id">Id de la entidad a eliminar</param>
        /// <param name="user">Usuario que elimina la entidad</param>
        public virtual void Delete(int id, string user)
        {
            var entity = this.Get(id);
            if (entity != null)
            {
                try
                {
                    this.Context.Set<Category>().Remove(entity);

                }
                catch (Exception e)
                {
                    throw new Exception("Error al Eliminar Category");
                }
            }
            else
            {
                throw new Exception("El elemento no existe");
            }
        }

        /// <summary>
        /// Metodo que devuelve la entidad Category (Category) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id de la etidad requerida</param>
        /// <returns>La Entidad con el Id dado por parametro</returns>
        public Category Get(int id)
        {
            try
            {
                return Context.Set<Category>().Find(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al cargar Category");
            }
        }

        /// <summary>
        /// Metodo que devuelve una colección de entidades  Solicitante (Solicitante) que cumplen 
        /// con el predicado pasado por parametro
        /// </summary>
        /// <param name="predicate">Predicado (Expresión lamda) con el filtro que se quiere aplicar</param>
        ///
        /// <returns>Coleccion de entidades que cumplen con el predicado</returns>
        public virtual IQueryable<Category> Where(Expression<Func<Category, bool>> predicate)
        {
            try
            {
                if (true)
                {
                    return Context.Set<Category>().Where(predicate);
                }

                return Context.Set<Category>().Where(predicate);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Filtrar Category");
            }
        }

        /// <summary>
        /// Metodo que devuelve una Colección con todas las entidades Category (Category)
        /// </summary>
        ///
        /// <returns>Colección con todas las entidades</returns>
        public virtual IQueryable<Category> GetAll()
        {
            try
            {
                return Context.Set<Category>();
            }
            catch (Exception e)
            {
                throw new Exception("Error al cargar todos Category");
            }
        }

        /// <summary>
        /// Metodo que devuelve la entidad Category (Category) con el Id dado por parametro y las entidades relacionadas
        /// que son especificadas por medio de expresiones lamda
        /// </summary>
        /// <typeparam name="T">Tipo del elemento de la relación que se espera</typeparam>
        /// <param name="id">Id de la entidad a devolver</param>
        /// <param name="associations">Expresiones lamda con las entidades relacionadas que se requiere devolver</param>
        /// <returns>Entidad con el id pasado por parametro y las entidades relacionadas</returns>
        public Category GetWithInclude<T>(int id, params Expression<Func<Category, object>>[] associations) where T : class
        {
            try
            {
                var source = (IQueryable<Category>)Context.Set<Category>();
                if (associations != null)
                {
                    foreach (Expression<Func<Category, object>> path in associations)
                        source = source.Include<Category, object>(path);
                }
                return source.SingleOrDefault(e => e.CategoryId == id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al cargar incluido Category");
            }
        }

        /// <summary>
        /// Metodo que devuelve una Colección con todas las entidades Category (Category)
		/// y las entidades relacionadas que son especificadas por medio de expresiones lamda
        /// </summary>
        /// <typeparam name="T">Tipo del elemento de la relación que se espera</typeparam>
        /// <param name="associations">Expresiones lamda con las entidades relacionadas que se requiere devolver</param>
        /// <returns>Coleccion de entidades con sus entidades relacionadas</returns>
		public IQueryable<Category> IncludeMultiple<T>(params Expression<Func<Category, object>>[] associations) where T : class
        {
            try
            {
                var source = (IQueryable<Category>)Context.Set<Category>();
                if (associations != null)
                {
                    foreach (Expression<Func<Category, object>> path in associations)
                        source = source.Include<Category, object>(path);
                }
                return source;
            }
            catch (Exception e)
            {
                throw new Exception("Error al filtrar Insertar Category");
            }
        }

        /// <summary>
        /// Metodo que salva los cambios en la base de datos y que cumple con el patron repositorio
        /// </summary>
        public void SaveChanges()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (DbUpdateException dbEx)
            {
                //foreach (var validationErrors in dbEx.Entries)
                //{
                //    foreach (var validationError in validationErrors.Collections)
                //    {
                //        // Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                //    }
                //}
            }
        }
    }
}