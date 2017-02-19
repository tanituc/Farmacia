using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL;
using Servicios.Medicamento.DTOs;

namespace Servicios.Medicamento
{
    public class MedicamentoServicio 
    {
         public void Insertar(PrincipioActivoDto dto)
         {
             using (var context = new ModeloFarmaciaContainer())
             {
                var principioActivoNuevo = new DAL.Medicamento();

                 principioActivoNuevo.Descripcion = dto.Descripcion;
                 principioActivoNuevo.Indicacion = dto.Indicacion;

                 context.Medicamentos.Add(principioActivoNuevo);
                 context.SaveChanges();
             }
         }

        
    }
}
