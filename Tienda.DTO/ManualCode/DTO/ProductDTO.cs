namespace Tienda.DTO.ManualCode.DTO
{
    using System;
    using System.ComponentModel;

    public partial class ProductDTO
    {
        [DisplayName("ProductId")]
        public int ProductId { get; set; }
    }
}