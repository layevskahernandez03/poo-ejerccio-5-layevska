using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Album n1 = new Album(1, "Paisajes", 211122, new List<Foto>());



            n1.AniadirFoto(new Foto(2, 5, 2007, "Bosque"));
            n1.AniadirFoto(new Foto(3, 99, 2009, "Praderas"));
            n1.AniadirFoto(new Foto(4, 11, 2023, "Montañas"));

            n1.Mostar();
            n1.TamanoAlbum();
            Console.ReadKey();


        }
    }
}

}
