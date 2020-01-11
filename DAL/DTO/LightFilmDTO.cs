using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LightFilmDTO
    {
        public string Title { get; set; }
        public float VoteAverage { get; set; }


        public LightFilmDTO()
        {

        }

        public override string ToString()
        {
            return "Title: " + Title +  ",VoteAverage: " + VoteAverage ;
        }

        public string Pouet()
        {
            return "g ps compris";
        }
    }
}
