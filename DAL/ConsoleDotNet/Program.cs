
using System;
using System.Collections.Generic;
using DAL;

namespace ConsoleDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DALManager dbmanager = new DALManager())
            {
                //FilmParser.LoadFilm(dbmanager, "C:\\Users\\benja\\Dropbox\\2019-2020 DOSSIER\\C#\\movies_v2");
                dbmanager.addFilm(new Film());
            }

            using (DALManager dbmanager = new DALManager())
            {
                List<Film> listfilm = dbmanager.GetNFilmsAfter(0, 5);

                foreach (Film f in listfilm)
                    Console.WriteLine(f.ToString());
                Console.ReadKey();
            }
        }
    }
}
