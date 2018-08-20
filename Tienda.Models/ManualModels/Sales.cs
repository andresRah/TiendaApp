namespace Tienda.Models.ManualModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Sales
    {

        #region Constructor

        /// <summary>
        /// Metodo constructor de la entidad: Sale
        /// </summary>
        public Sales()
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
        public int SalesId { get; set; }

        /// <summary>
        /// Propiedad Description (Description)
        /// </summary>
        [DisplayName("Description")]
        [Required]
        public string Description { get; set; } 

        /// <summary>
        /// Propiedad SubTotal (SubTotal)
        /// </summary>
        [DisplayName("SubTotal")]
        [Required]
        public decimal SubTotal { get; set; }
        
        /// <summary>
        /// Propiedad Iva (Iva)
        /// </summary>
        [DisplayName("Iva")]
        [Required]
        public decimal Iva { get; set; }
        #endregion

        #region Targets

        // ************************************
        // * TARGETS
        // ************************************

        /// <summary>
        /// Relación Ventas (Sales)
        /// </summary>
        [DisplayName("SalesDetails")]
        [InversePropertyAttribute("Sales")]
        public virtual ICollection<SalesDetails> SalesDetails { get; set; }
        #endregion

        #region Sources

        // ************************************
        // * SOURCES
        // ************************************

        /// <summary>
        /// Id de la Entidad relacionada: Customer (Customer)
        /// </summary>
        [DisplayName("Customer")]
        [Required]
        public int CustomerId { get; set; }

        /// <summary>
        /// Relación Customer (Customer)
        /// </summary>
        [DisplayName("Customer")]
        [ForeignKey("CustomerId")]
        [InversePropertyAttribute("Sales")]
        public virtual Customer Customer { get; set; }

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