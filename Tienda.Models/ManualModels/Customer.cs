namespace Tienda.Models.ManualModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Customer
    {

        #region Constructor

        /// <summary>
        /// Metodo constructor de la entidad: Customer
        /// </summary>
        public Customer()
        {

        }
        #endregion

        #region Properties

        // ************************************
        // * PROPERTIES
        // ************************************

        /// <summary>
        /// Propiedad que representa la llave primaria de la entidad: Intencion
        /// </summary>
        [Key]
        public int CustomerId { get; set; }

        /// <summary>
        /// Propiedad CustomerFirstName (CustomerFirstName)
        /// </summary>
        [DisplayName("FirstName")]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Propiedad CustomerLastName (CustomerLastName)
        /// </summary>
        [DisplayName("LastName")]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Propiedad BirthDate (BirthDate)
        /// </summary>
        [DisplayName("BirthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Propiedad CustomerToContactPhone (CustomerToContactPhone)
        /// </summary>
		[DisplayName("ContactPhone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Propiedad CustomerToContactPhone (CustomerToContactPhone)
        /// </summary>
		[DisplayName("CreditLimit")]
        public decimal CreditLimit { get; set; }
        #endregion

        #region Targets

        // ************************************
        // * TARGETS
        // ************************************

        /// <summary>
        /// Relación Ventas (Sales)
        /// </summary>
        [DisplayName("Sales")]
        [InversePropertyAttribute("Customer")]
        public virtual ICollection<Sales> Sales { get; set; }

        #endregion

        #region Sources

        // ************************************
        // * SOURCES
        // ************************************
        #endregion

        #region Auditoria

        /// <summary>
        /// Fecha en que se creo la entidad
        /// </summary>
        [DisplayName("Fecha de Creación")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Fecha en que se creo la entidad
        /// </summary>
        [DisplayName("Fecha de Actualización")]
        public DateTime UpdateTime { get; set; }

        #endregion
    }
}
