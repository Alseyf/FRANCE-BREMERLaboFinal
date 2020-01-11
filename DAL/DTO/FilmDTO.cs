using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FilmDTO
    {
        public int IdFilm { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float VoteAverage { get; set; }
        public int Runtime { get; set; }
        public string Posterpath { get; set; }
        public ObservableCollection<CharacterDTO> Characters { get; set; }

        public FilmDTO() 
        {
            Title = "c'est un test";
        }

        public override string ToString()
        {
            return  "Title: " + Title +",ReleaseDate: "+ ReleaseDate+",VoteAverage: "+VoteAverage+", Runtime: " + Runtime + ", PosterPath: " + Posterpath;
        }
    }
}
