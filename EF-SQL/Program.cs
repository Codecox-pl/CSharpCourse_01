

using EF_SQL;
using Microsoft.EntityFrameworkCore;

using ( var db = new AppTiendaContext() )
{
    //Imprimir datos 
    //-----------
    //var tiendas = db.Tienda.AsNoTracking();

    //foreach (var tienda in tiendas)
    //{
    //    Console.WriteLine(tienda.Nombre + "----" + tienda.Ubicacion);

    //}
    //-----------

    //Relacion de 1 a 1
    //-----------
    //var tiendas = db.Tienda.Include(x => x.Usuario).AsNoTracking();

    //foreach (var tienda in tiendas)
    //{
    //    Console.WriteLine(tienda.Nombre + "----" + tienda.Usuario!.NombreCompl);
    //}
    //-----------
    //Relacion de 1 a muchos

    var tiendas = db.Tienda.Include(x => x.CategoriaLista).AsNoTracking();

    foreach (var tienda in tiendas)
    {
        Console.WriteLine(tienda.Nombre);
        foreach (var categoria in tienda.CategoriaLista)
        {
            Console.WriteLine("----" + categoria.Nombre);
        }
    }
}
