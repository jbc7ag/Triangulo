using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tringulo.Clases;


namespace Tringulo.Models
{
    public class Triangulo
    {



        public Triangulo() {

       
        }

        public Result validar(int a, int b, int c)
        {

            Result oResult = new Result();


            //Validamos los lados del triangulo;

            //a + b > c  
            //b + c > a
            //c + a > b

            if( (a + b > c) && (b + c > a) && (c + a > b ) ){

                oResult.Resultado = "Si es triángulo";
            }
            else{

                oResult.Resultado = "No es triángulo";
                
            }


            return oResult;

        
        }

    }
}