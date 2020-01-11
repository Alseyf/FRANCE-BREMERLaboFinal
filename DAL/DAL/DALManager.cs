using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALManager : IDisposable
    {
        private FilmDBContext fDB;
        public DALManager()
        {
             fDB = new FilmDBContext();
        }

        public void Dispose()
        {
            fDB.Dispose();
        }

        public bool addFilm(Film f)
        {
            Film e = fDB.Films.Find(f.IdFilm);
            if (e != null && e.IdFilm == f.IdFilm)
                return false;
            else
            {
                fDB.Films.Add(f);
                fDB.SaveChanges();
                return true;
            }
        }

        public bool addActor(Actor a)
        {
            Actor e = fDB.Actors.Find(a.IdActor);
            if (e != null && e.IdActor == a.IdActor)
                return false;
            else
            {
                fDB.Actors.Add(a);
                fDB.SaveChanges();
                return true;
            }
        }

        public Character addCharacter(Character a)
        {
            Character e = fDB.Characters.Find(a.IdCharacter);
            if (e != null && e.IdCharacter == a.IdCharacter)
                return e;
            else
            {
                Character ret = fDB.Characters.Add(a);
                fDB.SaveChanges();
                return ret;
            }
        }

        public bool addCharacterActor(int i,Character c, Actor a, Film f)
        {
            if (fDB.CharacterActors.Any(x => x.lActor.IdActor == a.IdActor && x.leCharacter.IdCharacter == c.IdCharacter && x.leFilm.IdFilm == f.IdFilm))
                return false;
            else
            {
                try
                {
                    CharacterActor ca = new CharacterActor(i, a, c, f);
                    fDB.CharacterActors.Add(ca);
                    fDB.SaveChanges();
                    return true;
                }
                catch(DbUpdateException)
                {
                    return false;
                }
            }
        }

        public List<Film> GetNFilmsAfter(int skip, int take)
        {
            var liste = (from f in fDB.Films
                         select f).OrderBy(Film => Film.IdFilm).Skip(skip).Take(take).ToList();

            return liste;
        }
    }
}
