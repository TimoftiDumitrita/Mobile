using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Models
{
    public class Review
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string? Message { get; set; }
        [Range(1, 5, ErrorMessage = "The rate must be between 1 and 5.")]

        public int Rate { get; set; }
    }
}
