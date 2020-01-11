using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCF.ServiceReference1;

namespace TestWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();


                var listFilmDTO = client.GetFavoriteFilms();

                foreach (LightFilmDTO item in listFilmDTO)
                {
                    Console.Write(item.Title+" ");
                    Console.WriteLine(item.VoteAverage);

                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
