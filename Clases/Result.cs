using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tringulo.Clases
{
    public class Result
    {

        public String Resultado{get;set;}

        public Result() {

            this.Resultado = "";
        
        }
        public Result(string sMessage)
        {

            this.Resultado = sMessage;

        }
    }
}