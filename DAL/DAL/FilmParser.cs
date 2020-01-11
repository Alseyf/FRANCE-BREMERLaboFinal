using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class FilmParser
    {
        public FilmParser()
        {

        }


        public static DonneeFilm ConvertTextFilmToObject(string textFilm)
        {
            string[] filmDetails;
            string[] actorDetails;
            DonneeFilm df = new DonneeFilm();

            char[] delimiters = { '\u2023' };
            filmDetails = textFilm.Split(delimiters);
            delimiters[0] = '\u2016';

            try
            {
                df.film.IdFilm = int.Parse(filmDetails[0]);
                df.film.Title = filmDetails[1];
                string[] date = filmDetails[3].Split('-');
                df.film.ReleaseDate = new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
                df.film.Runtime = int.Parse(filmDetails[7]); //Erreur avec le 904e film
                df.film.Posterpath = filmDetails[9];
                df.film.VoteAverage = float.Parse(filmDetails[5]);

                if (filmDetails.Length == 15)
                {
                    actorDetails = filmDetails[14].Split(delimiters);
                    foreach (string s in actorDetails)
                    {
                        if (s.Length > 0)
                        {
                            string[] actorDetailsDetails = s.Split('\u2024');
                            if(actorDetailsDetails.Length >= 2)
                                df.actor.Add(new Actor(Convert.ToInt32(actorDetailsDetails[0]),actorDetailsDetails[1]));
                            int i = 2;
                            while (actorDetailsDetails.Length >= i+1)
                                df.character.Add(new Character(actorDetailsDetails[i++]));
                        }
                    }
                }
            }
            catch (FormatException ie)
            {
                Console.WriteLine(ie.Message);
                return null;
            }

            return df;
        }

    }
}