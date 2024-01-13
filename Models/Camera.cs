using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Models
{
   public class Camera
    {
        
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        public int NumarCamera { get; set; }
        public string? Detalii { get; set; }
    }
}
