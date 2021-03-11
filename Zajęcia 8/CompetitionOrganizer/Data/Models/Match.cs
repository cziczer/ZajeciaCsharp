using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompetitionOrganizer.Data.Models
{
    class Match
    {
        [Required]
        public int MatchId { get; set; }
        public DateTime Date { get; set; }

        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }

        public string Day { get; set; }
    }
}
