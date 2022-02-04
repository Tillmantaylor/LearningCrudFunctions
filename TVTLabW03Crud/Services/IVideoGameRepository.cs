using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVTLabW03Crud.Models.Entities;

namespace TVTLabW03Crud.Services
{
    public interface IVideoGameRepository
    {
        ICollection<VideoGame> ReadAll();

        VideoGame Create(VideoGame videogame);
        VideoGame Read(int id);
        void Update(int oldId, VideoGame videogame);
        void Delete(int id);
    }
}
