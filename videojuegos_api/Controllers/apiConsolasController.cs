using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using videojuegos_api.Models;

namespace videojuegos_api.Controllers
{
    public class apiConsolasController : ApiController
    {
        //CONEXION A LA BASE
        bd_videojuegos bd = new bd_videojuegos();

        public IEnumerable<consola> Get()
        {
            return bd.consolas;
        }


    }
}
