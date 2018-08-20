namespace Tienda.Models.ManualModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Category
    {

        #region Constructor

        /// <summary>
        /// Metodo constructor de la entidad: Category
        /// </summary>
        public Category()
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
        public int CategoryId { get; set; }

        /// <summary>
        /// Propiedad Description (Description)
        /// </summary>
        [DisplayName("Description")]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Propiedad Description (Description)
        /// </summary>
        [DisplayName("Description")]
        public string Description { get; set; }

        ///// <summary>
        ///// Propiedad TotalInvestment (TotalInvestment)
        ///// </summary>
        //[DisplayName("TotalInvestment")]
        //public decimal TotalInvestment{ get; set; }

        #endregion

        #region Targets

        // ************************************
        // * TARGETS
        // ************************************

        /// <summary>
        /// Relación Ciudades (Cities)
        /// </summary>
        [DisplayName("Productos")]
        [InversePropertyAttribute("Category")]
        public virtual ICollection<Product> Products { get; set; }
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
