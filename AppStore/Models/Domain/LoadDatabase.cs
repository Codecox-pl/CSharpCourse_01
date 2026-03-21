using Microsoft.AspNetCore.Identity;

namespace AppStore.Models.Domain
{
    public class LoadDatabase
    {
        public static async Task InsertarData(DatabaseContext context, UserManager<ApplicationUser> usuarioManager, RoleManager<IdentityRole> roleManager)
        {
            if(!roleManager.Roles.Any())
            {
                await roleManager.CreateAsync(new IdentityRole("ADMIN"));
            }

            if(!usuarioManager.Users.Any()) 
            {
                var usuario = new ApplicationUser
                {
                    Nombre = "Patrick Luis",
                    Email = "patrick@gmail.com",
                    UserName = "Codecox"
                };

                await usuarioManager.CreateAsync(usuario, "Marzo2026$");
                await usuarioManager.AddToRoleAsync(usuario, "ADMIN");
            }

            if(!context.Categorias.Any()) 
            {
               await context.Categorias.AddRangeAsync(
                     new Categoria { Nombre = "Componente"},
                      new Categoria { Nombre = "Discos" },
                       new Categoria { Nombre = "Perifericos" },
                        new Categoria { Nombre = "Pantallas" },
                         new Categoria { Nombre = "Graficas" }
                    );            
            }


            if(!context.Productos.Any()) 
            {
                await context.Productos.AddRangeAsync(
                      new Producto { 
                          NombrePro = "Mouse Gamer Razer x1", 
                          Precio = 168.10m, 
                          Descripcion = "Producto ideal para personas amantes de los juegos",
                          Cantidad = 10            
                      },
                      new Producto
                      {
                          NombrePro = "Pantalla LG 27' OLED",
                          Precio = 598.10m,
                          Descripcion = "Producto ideal para personas amantes de los juegos",
                          Cantidad = 5
                      }
                    );
              
            }

            if (!context.CategoriaProductos.Any())
            {
               await context.CategoriaProductos.AddRangeAsync(
                      new CategoriaProducto { CategoriaId = 3, ProductoId = 1},
                      new CategoriaProducto { CategoriaId = 4 , ProductoId = 2}
                    );
            }

           await context.SaveChangesAsync();
        }


    }
}
