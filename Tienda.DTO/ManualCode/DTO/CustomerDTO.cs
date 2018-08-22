namespace Tienda.DTO.ManualCode.DTO
{
    using System;
    using System.ComponentModel;

    public partial class CustomerDTO
    {
        [DisplayName("CustomerId")]
        public int CustomerId { get; set; }
    }
}
