using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALAcess
    {
        public static ICollection<Actor> GetFullActor()
        {
            var context = new FilmDBContext();

            try
            {

                var listActor = new List<Actor>(
                        from a in context.Actors
                        orderby a.Name

                        select a
                    );
                return listActor;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static ICollection<Film> GetListFilmsByIdActor(int id)
        {
            var context = new FilmDBContext();
            
            try
            {

                var listFilm = new List<Film>(
                        from ca in context.CharacterActors
                        join f in context.Films on ca.FilmRefId equals f.IdFilm

                        where ca.ActordRefId == id
                        select f
                    ).Distinct().ToList();
                return listFilm;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
        

        public static ICollection<Character> GetListCharacterByIdActorAndIdFilm(int idActor, int idFilm)
        {
            var context = new FilmDBContext();
            
            try
            {

                var listCharacter = new List<Character>(
                        from ca in context.CharacterActors
                        join c in context.Characters on ca.CharacterdRefId equals c.IdCharacter

                        where ca.ActordRefId == idActor && ca.FilmRefId == idFilm 
                        select c
                    );
                return listCharacter;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
        
        public static ICollection<Film> FindListFilmByPartialActorName(string actorName)
        {
            var context = new FilmDBContext();
            

            try
            {

                var listFilm = new List<Film>(
                        from ca in context.CharacterActors
                        join f in context.Films on ca.FilmRefId equals f.IdFilm
                        join a in context.Actors on ca.ActordRefId equals a.IdActor

                        where a.Name.Contains(actorName)
                        select f
                    ).Distinct().ToList();
                return listFilm;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }

        public static ICollection<Actor> FindActorByPartialName(string actorName)
        {
            var context = new FilmDBContext();


            try
            {

                var listActor = new List<Actor>(
                        from a in context.Actors
                        orderby a.Name
                        where a.Name.Contains(actorName)
                        select a
                    ).Distinct().ToList();
                return listActor;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public static ICollection<Film> GetFavoriteFilms()
        {
            FilmDBContext context = new FilmDBContext();
            
            try
            {
                var listFilm = new List<Film>(
                        context.Films.OrderByDescending(f => f.VoteAverage).Take(10)
                    ).ToList();
                return listFilm;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }

        public static Actor GetActorById(int id)
        {
            var context = new FilmDBContext();

            try
            {
                var act = new Actor(
                        from a in context.Actors
                        where a.IdActor == id 
                        select a
                    );
                return act;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
        
        public static ICollection<Actor> GetFullActorDetailsByIdActor()
        {
            var context = new FilmDBContext();
            
            try
            {
                //var listFilm = new List<Actor>(
                //        context.Films.OrderByDescending(f => f.VoteAverage).Take(10)
                //    ).ToList();
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
        
        public static Boolean InsertCommentOnActorId(int id,Comment comm)
        {
            var context = new FilmDBContext();
            
            try
            {
                var commentQuery = context.Actors
                                    .Where(a => a.IdActor == id).Single();
                commentQuery.Comments.Add(comm);


                context.Entry<Actor>(commentQuery).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            
        }

        public static ICollection<Comment> GetComments(int id)
        {
            var context = new FilmDBContext();

            try
            {
                var act = new List<Comment>(
                from a in context.Comments
                orderby a.Date
                where a.IdActor == id
                select a
                );
                return act;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
