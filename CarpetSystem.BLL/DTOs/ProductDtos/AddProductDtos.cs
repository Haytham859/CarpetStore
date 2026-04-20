using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.BLL.DTOs.ProductDtos
{
    public class AddProductDtos
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public double Width { get; set; }
        public double Height { get; set; }

        public int CategoryId { get; set; }
    }
}
