using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.DAL.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Description {  get; set; }
        public decimal Price { get; set; }
        public string ImageUrl {  get; set; }
        public double width { get; set; }
         public double height { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
