using Refit;
using Sicsoft.Checkin.Web.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sicsoft.Checkin.Web.Servicios
{
     

    public interface ICrudApi<TEntity, TKey> where TEntity : class
    {
       
        [Post("")]
        Task<TEntity[]> AgregarBulk([Body] TEntity[] payload);

        [Post("")]
        Task<TEntity> Agregar([Body] TEntity payload);
        [Post("")]
        Task<TEntity> CambiarClave([Body] TEntity payload);

        [Get("")]
        Task<TEntity> Login(string email, string clave);

        [Get("")]
        Task<TEntity[]> ObtenerLista<TQuery>(TQuery q);

        [Get("/Compañias")]
        Task<TEntity[]> ObtenerCompañias(string email);


        [Get("/Consultar")]
        Task<TEntity> ObtenerPorId(int id);

        [Put("/Actualizar")]
        Task Editar( [Body]TEntity payload);
 
        [Delete("/Eliminar")]
        Task Eliminar(int id);

        [Delete("/Eliminar")]
        Task EliminarUsuario(int id, string CedulaJuridica);

      

 
    }
}
