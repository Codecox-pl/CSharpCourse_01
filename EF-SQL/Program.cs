

using EF_SQL;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

    //var tiendas = db.Tienda.Include(x => x.CategoriaLista).AsNoTracking();

    //foreach (var tienda in tiendas)
    //{
    //    Console.WriteLine(tienda.Nombre);
    //    foreach (var categoria in tienda.CategoriaLista)
    //    {
    //        Console.WriteLine("----" + categoria.Nombre);
    //    }
    //}
    // -------------

    //Relacion Muchos a Muchos
    //var productos = db.Producto.Include(x => x.Categorias).ThenInclude(xi => xi.Categoria);

    //foreach (var producto in productos)
    //{
    //    Console.WriteLine(producto.NombrePro);
    //    foreach (var cate in producto.Categorias)
    //    {
    //        Console.WriteLine("----" + cate.Categoria.Nombre);
    //    }
    //}
    //----------

    //Agregar datos en EFCORE

    //Console.WriteLine("Cuantos Productos quieres agregar?");
    //int cant =int.Parse(Console.ReadLine()!);

    //for (int i = 1; i < cant; i++)
    //{
    //    Console.WriteLine("Ingrese el nombre del producto");
    //    string npro = Console.ReadLine()!;
    //    Console.WriteLine("Ingrese la descripcion");
    //    string dpro = Console.ReadLine()!;
    //    Console.WriteLine("Ingrese la cantidad");
    //    int cpro = int.Parse(Console.ReadLine()!);
    //    Console.WriteLine("Ingrese el precio");
    //    decimal ppro = decimal.Parse(Console.ReadLine()!);

    //    var nuevoProducto = new Producto
    //    {
    //        NombrePro = npro,
    //        Descripcion = dpro,
    //        Cantidad = cpro,
    //        Precio = ppro
    //    };

    //    db.Add(nuevoProducto);
    //    db.Add(nuevoProducto);
    //}

    //var estadoTransaccion = db.SaveChanges();
    //Console.WriteLine("Estado ====>" + estadoTransaccion);

    //var nuevoProducto = new Producto
    //{
    //    NombrePro = "Audifonos",
    //    Descripcion = "Audifonos Gamer",
    //    Cantidad = 10,
    //    Precio = 110.2m
    //};
    //----------

    //Actualizar datos en EF CORE

    //var producto = db.Producto.Single(x => x.NombrePro == "Teclado");
    //if ( producto != null )
    //{
    //    producto.Descripcion = "Teclado RGB MECANINO";
    //    var estadoTransaccion = db.SaveChanges();
    //    Console.WriteLine("Estado de transaccion ===>" + estadoTransaccion);
    //}
    //----------

    //Eliminar data EF CORE

    var producto = db.Producto.Single(X => X.ProductoId ==  6);
    if ( producto != null )
    {
        db.Remove( producto );
        var estadoTransaccion = db.SaveChanges();
        Console.WriteLine("Estado de transaccion ===>" + estadoTransaccion);
    }
}
