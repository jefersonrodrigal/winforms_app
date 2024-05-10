using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroApp.Models
{
    public class Operator
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Function { get; set; }

        
        public int StepY { get; set; }
        
        
        public int IncressY { get; set; }
        
        
        public int MaxY { get; set; }

      
        public int StepX { get; set; }
    }
}
