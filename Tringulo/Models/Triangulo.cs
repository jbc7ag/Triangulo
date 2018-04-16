using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tringulo.Clases;


namespace Tringulo.Models
{
    public class Triangulo
    {

        public int ladoA { get; set; }
        public int ladoB { get; set; }
        public int ladoC { get; set; }


        public Triangulo() {

       
        }

        override
        public string ToString()
        {

            return ladoA + " " + ladoB + " " + ladoC;
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