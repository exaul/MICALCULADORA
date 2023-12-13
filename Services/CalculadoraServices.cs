using MICALCULADORA.Models;
using MICALCULADORA.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICALCULADORA.Services
{
    public class CalculadoraServices : ICalculadoraServices
    {
       
        private bool Validarnumero(int N)
        {
            if(N == 0) return false;
            return true;
        }
        public int CalcularDosNumeros(int N1, int N2, Operaciones.Operacion operacion)
        { 
           if(!Validarnumero(N1))
            {  return 0; }
            if (!Validarnumero(N1))
            { return 0; }
            switch (operacion)
            {
                case Operaciones.Operacion.suma: return N1 + N2;
                case Operaciones.Operacion.resta: return N1 - N2;
                case Operaciones.Operacion.multiplicacion: return N1 * N2;
                case Operaciones.Operacion.Division: return N1 / N2;
                default: return 0;

            }
        }
        public int SumarDosNumeros(int N1, int N2)
        {
            if (!Validarnumero(N1))
            { return 0; }
            if (!Validarnumero(N1))
            { return 0; }
            return N1 + N2;
        }
    }
}
