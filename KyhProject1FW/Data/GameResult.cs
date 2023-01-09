using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Data
{
    public class GameResult
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NumberOfPlayerWins { get; set; }
        [Required]
        public int NumberOfComputerWins { get; set; }
        [Required]
        public int AveragePlayerWins { get; set; }
        [Required]
        public DateTime DateOfGameResult { get; set; }

       


    }
}
