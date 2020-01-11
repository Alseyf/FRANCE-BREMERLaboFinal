using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDTO
{
    class TestDTO
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("---------------GetListFilmsByIdActor----------------");
            var listFilmDTO = BllAccess.GetListFilmsByIdActor(2);
            foreach (var item in listFilmDTO)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("---------------GetListCharacterByIdActorAndIdFilm----------------");
            var charDTO = BllAccess.GetListCharacterByIdActorAndIdFilm(3130, 5);
            foreach (var item in charDTO)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("---------------FindListFilmByPartialActorName----------------");
            var listFilmDTO2 = BllAccess.FindListFilmByPartialActorName("ai");
            foreach (var item in listFilmDTO2)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("---------------GetFavoriteFilms----------------");
            var listFilmDTO3 = BllAccess.GetFavoriteFilms();
            foreach (var item in listFilmDTO3)
            {
                Console.WriteLine(item.ToString());
            }


            //Console.WriteLine("-------------InsertCommentOnActorId-----------");
            //CommentDTO commDTO = new CommentDTO
            //{
            //    avatar = "Denys",
            //    Content = "Commentaire DTO",
            //    Date = DateTime.Now,
            //    Rate = 5
            //};
            //var isInserted = BllAccess.InsertCommentOnActorId(3, commDTO);
            //if (isInserted)
            //{
            //    Console.WriteLine("Commentaire inséré");
            //    Console.WriteLine(commDTO.ToString());
            //}
            //else 
            //    Console.WriteLine("Erreur lors de l'insertion");

            Console.WriteLine("-------------FullActorDetails-----------");
            BllAccess.GetFullActorDetailsByIdActor(2);



            Console.ReadKey();
        }
    }
}
