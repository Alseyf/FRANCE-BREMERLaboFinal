using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CharacterActor
    {
        //    [Key, Column(Order = 0)]
        //    public virtual Film leFilm { get; set; }
        //    [Key, Column(Order = 1)]
        //    public virtual Actor lActor { get; set; }
        //    [Key, Column(Order = 2)]
        //    public virtual Character leCharacter { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int FilmRefId { get; set; }
        [ForeignKey("FilmRefId")]
        public virtual Film leFilm { get; set; }
        public int ActordRefId { get; set; }
        [ForeignKey("ActordRefId")]
        public virtual Actor lActor { get; set; }
        public int CharacterdRefId { get; set; }
        [ForeignKey("CharacterdRefId")]
        public virtual Character leCharacter { get; set; }

        public CharacterActor()
        {

        }

        public CharacterActor(int i,Actor a, Character c, Film f)
        {
            Id = i;
            leFilm = f;
            lActor = a;
            leCharacter = c;
        }
    }
}
