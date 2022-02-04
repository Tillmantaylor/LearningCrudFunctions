using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVTLabW03Crud.Models.Entities;

namespace TVTLabW03Crud.Services
{
    public class DbVideoGameRepository : IVideoGameRepository
    {
        private readonly VideoGameDbContext _db;

        public DbVideoGameRepository(VideoGameDbContext db)
        {
            _db = db;
        }

        public VideoGame Create(VideoGame videogame)
        {
            _db.VideoGames.Add(videogame);
            _db.SaveChanges();
            return videogame;
        }

        public void Delete(int id)
        {
            var videogameToDelete = Read(id);
            _db.VideoGames.Remove(videogameToDelete);
            _db.SaveChanges();
        }

        public VideoGame Read(int id)
        {
            return _db.VideoGames.FirstOrDefault(v => v.Id == id);
        }

        public ICollection<VideoGame> ReadAll()
        {
            return _db.VideoGames.ToList();
        }

        public void Update(int oldId, VideoGame videogame)
        {
            var videogameToUpdate = Read(oldId);
            videogameToUpdate.Title = videogame.Title;
            videogameToUpdate.Genre = videogame.Genre;
            videogameToUpdate.Developer = videogame.Developer;
            videogameToUpdate.Rating = videogame.Rating;
            videogameToUpdate.Year = videogame.Year;
            _db.SaveChanges();
        }
    }
}
