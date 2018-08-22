namespace Tienda.Data.ManualCode.Data.Interface
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Tienda.Models.ManualModels;

    /// <summary>
    /// Repositorio para acceder a la entidad: Category (Category)
    /// </summary>
    public partial interface ICategoryRepository
    {
        /// <summary>
        /// Metodo que devuelve la entidad Category (Category) con el Id dado por parametro
        /// </summary>
        /// <param name="id">Id de la etidad requerida</param>
        /// <returns>La Entidad con el Id dado por parametro</returns>
        Category Get(int id);

        /// <summary>
        /// Metodo que devuelve una Colección con todas las entidades Category (Category)
        /// </summary>
        ///
        /// <returns>Colección con todas las entidades</returns>
        IQueryable<Category> GetAll();

        /// <summary>
        /// Metodo que devuelve una colección de entidades  Category (Category) que cumplen con el predicado pasado por parametro
        /// </summary>
        /// <param name="predicate">Predicado (Expresión lamda) con el filtro que se quiere aplicar</param>
        ///
        /// <returns>Coleccion de entidades que cumplen con el predicado</returns>
        IQueryable<Category> Where(Expression<Func<Category, bool>> predicate);

        /// <summary>
        /// Metodo que permite insertar una nueva entidad: Category (Category)
        /// </summary>
        /// <param name="entity">Entidad a insertar</param>
        /// <param name="user">Usuario que ejecuta la inserción</param>
        /// <returns>Se devulve la entidad creada con el id asignado</returns>
        Category Insert(Category entity, string user);

        /// <summary>
        /// Metodo que actualiza la entidad Category (Category) con los datos pasados por parametro
        /// </summary>
        /// <param name="entity">Entidad a actualizar</param>
        /// <param name="user">Usuario que actualiza la entidad</param>
        void Update(Category entity, string user);

        /// <summary>
        /// Metodo que elimina una entidad Category (Category) dado su Id
        /// </summary>
        /// <param name="id">Id de la entidad a eliminar</param>
        /// <param name="user">Usuario que elimina la entidad</param>
        void Delete(int id, string user);

        /// <summary>
        /// Metodo que devuelve la entidad Category (Category) con el Id dado por parametro y las entidades relacionadas
        /// que son especificadas por medio de expresiones lamda
        /// </summary>
        /// <typeparam name="T">Tipo del elemento de la relación que se espera</typeparam>
        /// <param name="id">Id de la entidad a devolver</param>
        /// <param name="associations">Expresiones lamda con las entidades relacionadas que se requiere devolver</param>
        /// <returns>Entidad con el id pasado por parametro y las entidades relacionadas</returns>
        Category GetWithInclude<T>(int id, params Expression<Func<Category, object>>[] associations) where T : class;

        /// <summary>
        /// Metodo que devuelve una Colección con todas las entidades Category (Category)
        /// y las entidades relacionadas que son especificadas por medio de expresiones lamda
        /// </summary>
        /// <typeparam name="T">Tipo del elemento de la relación que se espera</typeparam>
        /// <param name="associations">Expresiones lamda con las entidades relacionadas que se requiere devolver</param>
        /// <returns>Coleccion de entidades con sus entidades relacionadas</returns>
        IQueryable<Category> IncludeMultiple<T>(params Expression<Func<Category, object>>[] associations) where T : class;

        /// <summary>
        /// Metodo que salva los cambios en la base de datos y que cumple con el patron repositorio
        /// </summary>
        void SaveChanges();
    }
}