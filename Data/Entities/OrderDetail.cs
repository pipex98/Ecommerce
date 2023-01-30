﻿using System.ComponentModel.DataAnnotations;

namespace ecommerce.Data.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public Order Order { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public Product Product { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public float Quantity { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Valor")]
        public decimal Value => Product == null ? 0 : (decimal)Quantity * Product.Price;

    }
}
