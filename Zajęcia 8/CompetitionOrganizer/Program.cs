﻿using System;
using System.Collections.Generic;
using CompetitionOrganizer.Data;
using CompetitionOrganizer.Data.Models;
using CompetitionOrganizer.Data.Repositories;

namespace CompetitionOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var competitionRepository = new CompetitionRepository();
            competitionRepository.AddCompetition(new Competition()
            {
                Name = "Champions League",
                StarDateTime = DateTime.Today,
                Matches = new List<Match>()
                {
                    new Match()
                    {
                        Date = DateTime.Today.AddDays(4)
                    },
                    new Match()
                    {
                        Date = DateTime.Today.AddDays(5)
                    }
                }
            });

            foreach (var competition in competitionRepository.Competitions)
            {
                Console.WriteLine($"{competition.Name}, date: {competition.StarDateTime}, matches count: {competition.Matches.Count}");
            }
            Console.ReadKey();
        }
    }
}
