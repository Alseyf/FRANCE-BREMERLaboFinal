using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Character
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdCharacter { get; set; }
        public string CharacterName { get; set; }
        public ICollection<CharacterActor> CharacterActors { get; set; }
        public Character()
        {

        }

        public Character(string n)
        {
            CharacterName = n;
        }

        public override string ToString()
        {
            return "Id: " + IdCharacter + ", CharacterName: " + CharacterName ;
        }
    }
}
