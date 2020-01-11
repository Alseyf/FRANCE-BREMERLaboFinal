using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DonneeFilm
    {
        public Film film;
        public List<Actor> actor;
        public List<Character> character;

        public DonneeFilm()
        {
            film = new Film();
            actor = new List<Actor>();
            character = new List<Character>();
        }
    }
}
