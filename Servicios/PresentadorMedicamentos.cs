using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class PresentadorMedicamentos : IPresentadorMedicamentos
    {
        public PresentadorMedicamentos()
        {
            
        }

        public void guardarMedicamento(int id_PrincipioActivo, string nombreComercial, int id_Laboratorio, double monto)
        {
            /*Conexion c = new Conexion();
            c.ejecutarQuery("INSERT INTO Medicamentos(nombreComercial,monto,id_PrincipioActivo,idLaboratorio"
                            + " VALUES('" + nombreComercial + "'," + monto + "," + id_PrincipioActivo + ","
                            + id_Laboratorio + ")");
                            */
        }
    }
}
