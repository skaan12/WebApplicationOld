using BLL.Services.Abstracts;
using DAL.Repositories.Abstracts;
using MODEL.Abstract.Interfaces;
using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concretes
{
    public class JoinService<T, TKey1, TKey2> : IJoinService<T, TKey1, TKey2> where T : class, IJoinEntity<TKey1, TKey2>,new()
    {
        private readonly IJoinRepository<T, TKey1, TKey2> _joinRepository;

        public JoinService(IJoinRepository<T,TKey1,TKey2> joinRepository)
        {
            _joinRepository = joinRepository;
            
        }
        public async Task AddAsync(T entity)
        {
            await _joinRepository.AddAsync(entity);
        }        

        public IEnumerable<T> GetAll()
        {
            return _joinRepository.GetAll().ToList();
        }

        public async Task<T> GetByIdAsync(TKey1 firstId, TKey2 secondId)
        {
            return await _joinRepository.GetByIdsAsync(firstId, secondId);
        }

        public async Task RemoveAsync(T entity)
        {
            await _joinRepository.RemoveAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _joinRepository.UpdateAsync(entity);
        }
        public async Task AddMultipleArtistForFilmAsync(TKey1 filmId, List<TKey2> artistIds, string? role = null)
        {
            foreach (var artistId in artistIds) 
            {
                var existingEntity = await _joinRepository.GetByIdsAsync(filmId, artistId);
                if (existingEntity != null) 
                {
                    Console.WriteLine($"Duplicate skipped: FilmID={filmId},ArtistID={artistId}");
                    continue;
                }

                var entity = new T
                {
                    FirstID = filmId,
                    SecondID = artistId
                };
                if (entity is IFilmArtist filmArtistEntity) 
                {
                    filmArtistEntity.Role = role;
                }
                await _joinRepository.AddAsync(entity);
            }
        }

    }
}
