using DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FullActorDTO : ActorDTO
    {
        public ObservableCollection<FilmDTO> Film { get; set; }
        public int idActor;

        public FullActorDTO()
        {

            Film = new ObservableCollection<FilmDTO>();
        }

        public override string ToString()
        {
            return Name;
        }

        public float CalculVote()
        {
            int nb = DALAcess.GetComments(idActor).Count();
            var tat = DALAcess.GetComments(idActor);
            int total = 0;
            foreach (var t in tat)
            {
                total += t.Rate;
            }
            float retour=0;

            if (total != 0)
                retour = total / nb;
            return retour;
      
        }
    }
}
