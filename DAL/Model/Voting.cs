using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Voting
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } 
        public int Age { get; set; }

        public string FatherName { get; set; }
    }
}
