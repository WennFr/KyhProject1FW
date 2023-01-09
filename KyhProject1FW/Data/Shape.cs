using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Data
{
    public class Shape
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TypeOfShape { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
