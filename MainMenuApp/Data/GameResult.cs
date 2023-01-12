using System.ComponentModel.DataAnnotations;

namespace MainMenuApp.Data
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
