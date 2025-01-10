using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
using DAL.Context;
using Microsoft.Identity.Client;
using MODEL.Entities.FilmEntities;

namespace DAL.FakeData
{
    public static class FilmFaker
    {
        private static int _filmId = 1;
        private static int _awardId = 1;

        public static List<Film> Films { get; private set; } = new List<Film>();
        public static List<Award> Awards { get; private set; } = new List<Award>();
        public static void Initialize(int filmCount, int awardPerFilm)
        {
            Films = GenerateFilms(filmCount);

            for(int i = 0; i < Films.Count; i++)
            {
                var film = Films[i];
                var awardsForFilm = GenerateAwards(film.ID, awardPerFilm);
                Awards.AddRange(awardsForFilm);
                Console.WriteLine($"Added {awardsForFilm.Count} awards for Film ID {film.ID}");
            }

                //foreach (var film in Films)
                //{
                //    Awards.AddRange(GenerateAwards(film.ID, awardPerFilm));
                //}
        }

        #region Generate Films
        public static List<Film> GenerateFilms (int count)
        {
            var films = new Faker<Film>()
                .RuleFor(f => f.ID, f => _filmId++)
                .RuleFor(f => f.FilmName, f => f.Commerce.ProductName())
                .RuleFor(f => f.OriginalName, f => f.Commerce.ProductName() + "Original")
                .RuleFor(f => f.Director, f => f.Name.FullName())
                .RuleFor(f => f.Category, f => f.PickRandom(new[] { "Action", "Drama", "Scifi", "Comedy", "Horror" }))
                .RuleFor(f => f.Description, f => f.Lorem.Sentence(10))
                .RuleFor(f => f.Actors, f => string.Join(",", f.Make(3, () => f.Name.FullName())))
                .RuleFor(f => f.Year, f => f.Date.Past(30, DateTime.Now).Date)
                .RuleFor(f => f.Language, f => f.PickRandom(new[] { "German", "English", "French", "Spanish" }))
                .RuleFor(f => f.Subtitles, f => f.PickRandom(new[] { "German", "English", "French", "Spanish" }))
                .RuleFor(f => f.TrailerURL, f => f.Internet.Url())
                //.RuleFor(f => f.Awards, f => f.Random.Bool(0.3f) ? f.Lorem.Sentence() : null);
                .RuleFor(f => f.Supplier, f => f.Company.CompanyName())
                .RuleFor(f => f.StockInQuantity, f => f.Random.Int(1, 100))
                .RuleFor(f => f.Status, f => MODEL.Abstract.Enums.DataStatus.Active)
                .Generate(count);

            
            return films;            
               


        }
        #endregion

        



        #region Award Data
        public static List<Award> GenerateAwards(int filmId,int count)
        {
            var faker = new Faker<Award>()
                .RuleFor(a => a.ID, a => _awardId++)
                .RuleFor(a => a.FilmID, _ => filmId)
                .RuleFor(a => a.AwardName, f => f.Company.CatchPhrase())
                .RuleFor(a => a.Category, f => f.PickRandom(new[] { "Best Actor", "Best Film", "Best Director" }))
                .RuleFor(a => a.WinnerName, f => f.Name.FullName())
                .RuleFor(a => a.AwardDate, f => f.Date.Past(5, DateTime.Now));
               
            var awards = faker.Generate(count);

            if(awards.Count == 0)
            {
                throw new Exception($"No awards generated for Film ID: {filmId}");
            }

            return awards;
                
        }
        #endregion
    }
}
