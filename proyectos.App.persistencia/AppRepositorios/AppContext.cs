using System;
using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Entidades;

namespace Proyectos.App.Persistencia
{    
    public class AppContext : DbContext
    {
        //poner aqui los modelos un DbSet por cada clase o tabla
        public DbSet<Comprasd> comprasd {get; set;}
        public DbSet<Productos> productos {get; set;}
        public DbSet<Cliente> cliente {get; set;}
        public DbSet<Arbol> arbol {get; set;}

        //crear el deContext para la creación y conexión con la Base de Datos en SQLServer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder
           .UseSqlServer("Server=localhost; user id=sa; password=12345; Initial Catalog=BDProyectos84;");            
            }
        }      

    }
}
