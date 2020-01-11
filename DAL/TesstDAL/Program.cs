using System;
using System.Collections.Generic;
using System.IO;
using DAL;

namespace ConsoleDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("1) Load les 1000 premiers films dans la db.");
                Console.WriteLine("2) Afficher x Films à partir du y film");
                Console.WriteLine("3) Quitter");
                Console.Write("Choix : ");
                String ki = Console.ReadLine();
                switch (int.Parse(ki))
                {
                    case 1 :
                        
                        //StreamReader sr = new StreamReader("C:\\Users\\benja\\Dropbox\\2019-2020 DOSSIER\\C#\\movies_v2.txt");
                        StreamReader sr = new StreamReader("C:\\Users\\denys\\Dropbox\\2019-2020 DOSSIER\\C#\\movies_v2.txt");

                            for (int j = 0; j < 1000; j++)
                            {
                                using (DALManager dbmanager = new DALManager())
                                {
                                    DonneeFilm newDonneeFilm = FilmParser.ConvertTextFilmToObject(sr.ReadLine());
                                    foreach (Actor a in newDonneeFilm.actor)
                                        dbmanager.addActor(a);
                                    List<Character> listCharacter = new List<Character>();
                                    foreach (Character a in newDonneeFilm.character)
                                    {
                                        Character newC = dbmanager.addCharacter(a);
                                        listCharacter.Add(newC);
                                    }
                                    dbmanager.addFilm(newDonneeFilm.film);
                                    for (int i = 0; i < newDonneeFilm.actor.Count; i++)
                                    {
                                        dbmanager.addCharacterActor(j, newDonneeFilm.character[i], newDonneeFilm.actor[i], newDonneeFilm.film);
                                    }
                                }
                                Console.WriteLine(j);
                            }
                            sr.Close();
                        using (DALManager dbmanager = new DALManager())
                        {
                            Film f = new Film();
                            dbmanager.addFilm(f);
                        }
                        break;
                    case 2:
                        Console.Write("\nx = ");
                        String kiX = Console.ReadLine();
                        Console.Write("y = ");
                        String kiY = Console.ReadLine();
                        Console.Write("\n");
                        using (DALManager dbmanager = new DALManager())
                        {
                            List<Film> listfilm = dbmanager.GetNFilmsAfter(int.Parse(kiY), int.Parse(kiX));
                            foreach (Film f in listfilm)
                                Console.WriteLine(f.ToString());
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        //ICollection<Film> test = DALAcess.GetListFilmsByIdActor(15);
                        //ICollection<Film> test = DALAcess.FindListFilmByPartialActorName("i");
                        ICollection<Character> test = DALAcess.GetListCharacterByIdActorAndIdFilm(3130, 5);
                        Comment com = new Comment();
                        com.Id = 1;
                        com.Rate = 3;
                        com.Content = "C'est pas mal";
                        com.avatar = "Le gros troll";
                        com.IdActor=(62);
                        DALAcess.InsertCommentOnActorId(1, com);
                        //ICollection<Film> test = DALAcess.GetFavoriteFilms();
                        //foreach (Character f in test)
                        //    Console.WriteLine(f.ToString());

                        break;
                    default:
                        choix = 0;
                        break;
                }
            }
        }
    }
}
