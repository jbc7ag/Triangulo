using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tringulo.Clases;
using Tringulo.Models;
using System.Web.Http.Description;

/*
 * Servicio que recibe 3 parametros y valida si corresponden a un triangulo.
 * 
 * Jessica Barrientos
 * 06/06/2017
 * 
 * **/

namespace Tringulo.Controllers
{
  
    [RoutePrefix("Triangulo")]
    public class TrianguloController : ApiController
    {

        public Result GET()
        {
         
            return new Result("La URL debe contener valores correctos. Ejemplo: ws.compusoluciones.com/Reto/Triangulo/3/5/5 ");

        }


        [Route("{a}/{b}/{c}")]
        public Result GETLados(int a, int b,int c)
        {

            Triangulo oTriangulo = new Triangulo();
            return oTriangulo.validar(a, b, c);
       
        }

    }
}
