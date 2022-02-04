using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVTLabW03Crud.Models.Entities
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; }
        public Rating Rating { get; set; }
        public int Year { get; set; }

    }
}
