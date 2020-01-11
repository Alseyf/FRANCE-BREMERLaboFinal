using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CharacterDTO
    {
        public string CharacterName { get; set; }

        public CharacterDTO()
        {

        }

        public override string ToString()
        {
            return "CharacterName: " + CharacterName;
        }
    }
}
