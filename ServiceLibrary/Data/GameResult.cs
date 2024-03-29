﻿using System.ComponentModel.DataAnnotations;

namespace ServiceLibrary.Data
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
        public int AmountOfRounds { get; set; }
        [Required]
        public double AveragePlayerWinsPercentage { get; set; }
        [Required]
        public DateTime DateOfGameResult { get; set; }
        [Required]
        public bool IsActive { get; set; }
       
        

    }
}
