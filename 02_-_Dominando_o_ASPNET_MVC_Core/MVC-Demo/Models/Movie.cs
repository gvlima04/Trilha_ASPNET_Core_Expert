using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Gender { get; set; }
        public decimal Value { get; set; }
        public int Rating { get; set; }    
    
    }
}