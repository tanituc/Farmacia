using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IPresentadorMedicamentos
    {
        void guardarMedicamento(int id_PrincipioActivo, string nombreComercial, int id_Laboratorio,
            double monto);
    }
}
