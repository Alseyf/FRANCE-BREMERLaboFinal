using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Film
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdFilm { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float VoteAverage { get; set; }
        public int Runtime { get; set; }
        public string Posterpath { get; set; }
        public ICollection<CharacterActor> CharacterActors { get; set; }
        public virtual List<Comment> Comments { get; set; }

        public Film()
        {
            IdFilm = 0;
            Title = "test";
            ReleaseDate = DateTime.Now;
            VoteAverage = 5;
            Runtime = 1;
            Posterpath = "";
            Comments = new List<Comment>();
        }

            
        public override string ToString()
        {
            return "Id: " + IdFilm + ", Title: " + Title + ", Runtime: " + Runtime + ", PosterPath: " + Posterpath;
        }

    }
}
