using LABORATORIO1_EvelynOneydaReyesMorales.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO1_EvelynOneydaReyesMorales.NEGOCIO
{
    public class ClsPersona
    {
        public string? Persona(Persona per)
        {
            double pro = per.peso;
            double Formula = pro / Math.Pow(per.altura, 2);
            if (Formula >= 25)
            {
                return ("Tiene sobre peso");

            }
            else
            {
               return("Su peso es ideal");
            }
            
            
        }
        public String PersonaEdad(Persona per) 
        {
            if(per.edad >= 18)
            {
                return "Usted es mayor de edad";
            }
            else
            {
                return "Usted es menor de edad";

            }
        
        
        }  
  
    }
}


