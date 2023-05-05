using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_5
{
    class Album
    {
        int id;
        string nombre;
        string fechaCreacion;
        List<Foto> imagenes;
        int cont;

        public Album(int id, string nombre, string fechaCreacion, List<Foto> imagenes, int cont)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
            this.imagenes = imagenes;
            this.Cont = cont;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int Cont { get => cont; set => cont = value; }
        internal List<Foto> Imagenes { get => imagenes; set => imagenes = value; }
        
        
        public void añadir(Foto ima)
        {
            try
            {
                this.imagenes.Add(ima);
                Console.WriteLine("Se añadio la foto");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo añadir la foto",ex);
            }

        }
        public void Mostrar()
        {
            foreach (var item in this.imagenes)
            {
                item.ToString();
            }
        }

        public void VaciarAlbum()
        {

            Console.WriteLine("ESta seguro que quiere vaciar todos los elementos de la lista?: S/N");
            string responde = Console.ReadLine();
            if (responde == "S" || responde == "s")
            {
                imagenes = new List<Foto>();
                this.cont = 0;
                Console.WriteLine("Se han eliminado los objetos correspondiente");
            }
            else
            {
                Console.WriteLine("No se elimno. La cantidad {0} fotos registradas  ", cont);
            }
            Console.ReadKey();
        }
        public void Eliminar(Foto ima)
        {
            imagenes.Remove(ima);
            cont -= 1;
            Console.WriteLine("SE ha eliminado la foto");
            Console.ReadKey();
        }
    }
    
}
