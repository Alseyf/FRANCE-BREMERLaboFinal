using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public class ActorViewModel : FullActorDTO
    {
        public ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public ActorViewModel()
        {

        }
        public ActorViewModel (FullActorDTO fullActorDTO)
        {
            Name = fullActorDTO.Name;
            Film = fullActorDTO.Film;
            idActor = fullActorDTO.idActor;
        }

        public string TxtActorName 
        {
            get
            {
                var nb= client.GetComments(idActor).Count();
                var tat = client.GetComments(idActor);
                int total = 0;
                foreach (var t in tat)
                {
                    total += t.Rate;
                }
                string retour = this.Name;

                if (total != 0)
                    retour+=(" " + (float)total / nb + "(" + nb + ")");
                return retour; 
            }
        }

        public string txtCharacters
        {
            get
            {
                foreach(FilmDTO c in this.Film)
                {
                    return c.Characters.ToString();
                }
                return null;
            }
        }


        public List<string> TxtFilmTitle
        {
            get 
            {
                List<string> listTitle = new List<string>();
                foreach (FilmDTO f in this.Film)
                {
                    listTitle.Add(f.Title);
                }

                return listTitle;
            }
        }
    }
}
