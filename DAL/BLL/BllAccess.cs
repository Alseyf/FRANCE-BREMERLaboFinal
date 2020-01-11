using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllAccess
    {
        public static List<FullActorDTO> GetFullActor(int limite)
        {
            List<FullActorDTO> listFull = new List<FullActorDTO>();

            ICollection<Actor> listActor = DALAcess.GetFullActor();

            for (int i = limite; i < limite + 10 ; i++)
            {
                if (listActor.Count() == i)
                    break;
                listFull.Add(GetFullActorDetailsByIdActor(listActor.ElementAt(i).IdActor));
            }

            return listFull;

        }
        public static List<FilmDTO> GetListFilmsByIdActor(int id)
        {
            ICollection<Film> listFilm;
            List<FilmDTO> listFilmDTO = new List<FilmDTO>();
            listFilm = DALAcess.GetListFilmsByIdActor(id);

            if (listFilm != null)
            {

                foreach (var item in listFilm)
                {
                    ICollection<FilmDTO> listfDTO = new List<FilmDTO>();


                    listFilmDTO.Add(new FilmDTO
                    {
                        Title = item.Title,
                        ReleaseDate = item.ReleaseDate,
                        VoteAverage = item.VoteAverage,
                        Runtime = item.Runtime,
                       
                             Posterpath= "http://image.tmdb.org/t/p/w185" + item.Posterpath

                });
                }
                return listFilmDTO;
            }
            return null;
        }


        public static ObservableCollection<CharacterDTO> GetListCharacterByIdActorAndIdFilm(int idAct, int idFilm)
        {
            ICollection<Character> listchar;
            ObservableCollection<CharacterDTO> listcharDTO = new ObservableCollection<CharacterDTO>();
            listchar = DALAcess.GetListCharacterByIdActorAndIdFilm(idAct,idFilm);

            if (listchar != null)
            {

                foreach (var item in listchar)
                {
                    ICollection<FilmDTO> listfDTO = new List<FilmDTO>();

                    listcharDTO.Add(new CharacterDTO
                    {
                        CharacterName = item.CharacterName
                    });
                }
                return listcharDTO;
            }
            return null;

        }

        public static List<FilmDTO> FindListFilmByPartialActorName(string s)
        {
            ICollection<Film> listFilm;
            List<FilmDTO> listFilmDTO = new List<FilmDTO>();
            listFilm = DALAcess.FindListFilmByPartialActorName(s);

            if (listFilm != null)
            {

                foreach (var item in listFilm)
                {
                    ICollection<FilmDTO> listfDTO = new List<FilmDTO>();

                    listFilmDTO.Add(new FilmDTO
                    {
                        Title = item.Title,
                        ReleaseDate = item.ReleaseDate,
                        VoteAverage = item.VoteAverage,
                        Runtime = item.Runtime,
                        Posterpath = item.Posterpath,

                    });
                }
                return listFilmDTO;
            }
            return null;

        }

        public static List<LightFilmDTO> GetFavoriteFilms()
        {
            ICollection<Film> listFilm;
            List<LightFilmDTO> listFilmDTO = new List<LightFilmDTO>();
            listFilm = DALAcess.GetFavoriteFilms();

            if (listFilm != null)
            {

                foreach (var item in listFilm)
                {
                    ICollection<FilmDTO> listfDTO = new List<FilmDTO>();

                    listFilmDTO.Add(new LightFilmDTO
                    {
                        Title = item.Title,
                        VoteAverage = item.VoteAverage

                    });
                }
                return listFilmDTO;
            }
            return null;
        }

        public static FullActorDTO GetFullActorDetailsByIdActor(int id)
        {
            FullActorDTO faDTO = new FullActorDTO();
            Actor a = DALAcess.GetActorById(id);

            faDTO.Name = a.Name;
            faDTO.idActor = a.IdActor;

            var listFilm = DALAcess.GetListFilmsByIdActor(id);

            foreach (Film f in listFilm)
            {
                FilmDTO filmDTO = new FilmDTO();

                filmDTO.Title = f.Title;
                filmDTO.Runtime = f.Runtime;
                if (f.Posterpath != null)
                    filmDTO.Posterpath = "http://image.tmdb.org/t/p/w185" + f.Posterpath;
                filmDTO.ReleaseDate = f.ReleaseDate;
                filmDTO.Characters = BllAccess.GetListCharacterByIdActorAndIdFilm(id, f.IdFilm);
                faDTO.idActor = id;
                faDTO.Film.Add(filmDTO);
            }

            return faDTO;
        }

        public static List<FullActorDTO> FindActorByPartialName(string actorName,int limite)
        {
            List<FullActorDTO> listFull = new List<FullActorDTO>();

            ICollection<Actor> listActor = DALAcess.FindActorByPartialName(actorName);

            for (int i = limite; i < limite + 10; i++)
            {
                if (listActor.Count() == i)
                    break;
                listFull.Add(GetFullActorDetailsByIdActor(listActor.ElementAt(i).IdActor));
            }

            return listFull;

        }

        public static bool InsertCommentOnActorId(int id, CommentDTO commDTO)
        {
            Comment comm = new Comment
            {
                avatar = commDTO.avatar,
                Content = commDTO.Content,
                Date = commDTO.Date,
                Rate = commDTO.Rate
            };
            bool isInserted = DALAcess.InsertCommentOnActorId(id, comm);

            if (isInserted) return true;
            else return false;
        }

        public static ObservableCollection<CommentDTO> GetComments(int id)
        {
            ObservableCollection<CommentDTO> listComment = new ObservableCollection<CommentDTO>();

            var list = DALAcess.GetComments(id);

            foreach (Comment c in list)
            {
                CommentDTO co = new CommentDTO();
                co.avatar = c.avatar;
                co.Content = c.Content;
                co.Rate = c.Rate;
                co.Date = c.Date;

                listComment.Add(co);
            }

            return listComment;

        }
    }
}
