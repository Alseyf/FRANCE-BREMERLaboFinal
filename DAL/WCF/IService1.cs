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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<FilmDTO> GetListFilmsByIdActor(int id);

        [OperationContract]
        ObservableCollection<CharacterDTO> GetListCharacterByIdActorAndIdFilm(int idAct, int idFilm);

        [OperationContract]
        List<FilmDTO> FindListFilmByPartialActorName(string s);

        [OperationContract]
        List<LightFilmDTO> GetFavoriteFilms();

        [OperationContract]
        FullActorDTO GetFullActorDetailsByIdActor(int id);

        [OperationContract]
        bool InsertCommentOnActorId(int id, CommentDTO commDTO);

        [OperationContract]
        List<FullActorDTO> GetFullActor(int limite);

        [OperationContract]
        ObservableCollection<CommentDTO> GetComments(int id);

        [OperationContract]
        List<FullActorDTO> FindActorByPartialName(string s, int limite);
        
    }
}
