namespace Tienda.Data
{
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System;

    /// <summary>
    /// Interface que define el patron Unit of Work
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Metodo que devuelve la entrada dada la entidad
        /// </summary>
        /// <param name="entity">Entidad</param>
        /// <returns>Entrada de la entidad</returns>
        EntityEntry Entry(Object entity);

        /// <summary>
        /// Metodo que salva los cambios efectuados al contexto actual
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Metodo que desecha el contexto de la base de datos
        /// </summary>
        void Dispose();
    }
}

