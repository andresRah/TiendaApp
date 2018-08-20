namespace Tienda.Models.ManualModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Provider
    {

        #region Constructor

        /// <summary>
        /// Metodo constructor de la entidad: Category
        /// </summary>
        public Provider()
        {

        }
        #endregion

        #region Properties

        // ************************************
        // * PROPERTIES
        // ************************************

        /// <summary>
        /// Propiedad que representa la llave primaria de la entidad: Proveedor
        /// </summary>
        [Key]
        public int ProviderId { get; set; }

        /// <summary>
        /// Propiedad Name (Name)
        /// </summary>
		[DisplayName("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Propiedad Description (Description)
        /// </summary>
		[DisplayName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Propiedad VisitingDays (VisitingDays)
        /// </summary>
        [DisplayName("VisitingDays")]
        public string VisitingDays { get; set; }

        /// <summary>
        /// Propiedad ContactPerson (ContactPerson)
        /// </summary>
		[DisplayName("ContactPerson")]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Propiedad ContactPhone (ContactPhone)
        /// </summary>
		[DisplayName("ContactPhone")]
        public string ContactPhone { get; set; }

        #endregion

        #region Targets

        // ************************************
        // * TARGETS
        // ************************************

        /// <summary>
        /// Relación Facturas (Invoice)
        /// </summary>
        [DisplayName("Invoices")]
        [InversePropertyAttribute("Provider")]
        public virtual ICollection<Invoice> Invoices { get; set; }
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
