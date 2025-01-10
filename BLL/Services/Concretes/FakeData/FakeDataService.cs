using BLL.Services.Abstracts.FakeData;
using DAL.Repositories.Abstracts;
using MODEL.Abstract.BaseEntities;
using MODEL.Abstract.Enums;
using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concretes.FakeData
{
    public class FakeDataService<T> : IFakeDataService<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;

        public FakeDataService(IRepository<T> repository)
        {
            _repository = repository?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task AddFakeDataAsync(int count)
        {
            if (typeof(T) == typeof(Artist))
            {
                var faker = new Bogus.Faker<Artist>()
                    .RuleFor(a => a.Name, a => a.Name.FullName())                    
                    .RuleFor(a => a.Biography, a => a.Lorem.Paragraph())
                    .RuleFor(a => a.CreatedDate, a => DateTime.Now)
                    .RuleFor(a => a.Status, a => DataStatus.Active);

                var fakeArtist = faker.Generate(count).Cast<T>().ToList();
                await _repository.CreateRangeAsync(fakeArtist);
            }
            else
            {
                throw new InvalidOperationException($"{typeof(T).Name} için fake data desteklenmiyor.");
            }
        }
    }
}
