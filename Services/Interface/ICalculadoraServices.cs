using MICALCULADORA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICALCULADORA.Services.Interface
{
    public interface ICalculadoraServices
    {
        public int SumarDosNumeros(int N1, int N2);
        public int CalcularDosNumeros(int N1, int N2 , Operaciones.Operacion operacion);
    }
}
