//Directivas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public interface IRepositorios
    {
        //contratos o firmas para los metodos Formador        
        Formador AddFormador(Productos productos);
        IEnumerable<Productos> GetAllFormadores();         
        Formador GetFormador(int? idProductos);
        Formador UpdateFormador(Productos productos);
        void DeleteFormador(int idProductos); 
    }
    
 }
