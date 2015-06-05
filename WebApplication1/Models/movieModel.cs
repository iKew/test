using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class movieModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime reciverDate { get; set; }
        public string Genre { get; set; }
        public decimal price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<movieModel> Movies { get; set; }
    }
}