using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public List<FilmDTO> FindListFilmByPartialActorName(string s)
        {
            return BllAccess.FindListFilmByPartialActorName(s);
        }

        public List<LightFilmDTO> GetFavoriteFilms()
        {
            return BllAccess.GetFavoriteFilms();
        }

        public FullActorDTO GetFullActorDetailsByIdActor(int id)
        {
            return BllAccess.GetFullActorDetailsByIdActor(id);
        }

        public ObservableCollection<CharacterDTO> GetListCharacterByIdActorAndIdFilm(int idAct, int idFilm)
        {
            return BllAccess.GetListCharacterByIdActorAndIdFilm(idAct, idFilm);
        }

        public List<FilmDTO> GetListFilmsByIdActor(int id)
        {
            return BllAccess.GetListFilmsByIdActor(id);
        }

        public bool InsertCommentOnActorId(int id, CommentDTO commDTO)
        {
            return BllAccess.InsertCommentOnActorId(id, commDTO);
        }

        public List<FullActorDTO> GetFullActor(int limite)
        {
            return BllAccess.GetFullActor(limite);
        }

        public ObservableCollection<CommentDTO> GetComments(int id)
        {
            return BllAccess.GetComments(id);
        }

        public List<FullActorDTO> FindActorByPartialName(string s,int limite)
        {
            return BllAccess.FindActorByPartialName(s,limite);
        }

    }
}
