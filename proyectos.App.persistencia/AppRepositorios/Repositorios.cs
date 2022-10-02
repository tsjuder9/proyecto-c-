using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Entidades;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public class Repositorios : IRepositorios
    {
       private readonly AppContext _appContext;

       public Repositorios(AppContext appContext)
        {
            _appContext = appContext;
        }
        //AQUÍ CADA UNO DE LOS MÉTODOS DEL CRUD, REFERENCIADOS EN LA INTERFACE
         //SIGUIENTE DIAPOSITIVA

        Productos IRepositorios.AddProductos(Productos productos)
        {
        try
         {
            var ProductosAdicionado = _appContext.productos.Add( productos );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return ProductosAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Productos> IRepositorios.GetAllProductos()
        {
            return _appContext.productos;
        }

       Productos IRepositorios.GetProductos(int? idProductos)
       {
            return _appContext.productos.FirstOrDefault(p => p.id == idProductos);
       }

       Productos IRepositorios.UpdateProductos(Productos productos)
        {
            var ProductosEncontrado = _appContext.productos.FirstOrDefault(p => p.id == productos.id);
            if (ProductosEncontrado != null)
            {
                FormadorEncontrado.identificacion  = productos.nutrientes;
                FormadorEncontrado.nombre          = productos.nombre;
                FormadorEncontrado.mail            = productos.calorias;
                FormadorEncontrado.movil           = productos.movil;
                FormadorEncontrado.vigente         = productos.vigente;
                _appContext.SaveChanges();
            }
            return ProductosEncontrado;
        }

        void IRepositorios.DeleteFormador(int idProductos)
        {
            var ProductosEncontrado = _appContext.productos.FirstOrDefault(p => p.id == idProductos);
            if (ProductosEncontrado == null)
                return;
            _appContext.productos.Remove(ProductosEncontrado);
            _appContext.SaveChanges();
        }

    }
}
