using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ActivoFijo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public TipoActivo TipoActivo { get; set; }
        public MetodoDepreciacion MetodoDepreciacion { get; set; }
            
        public string Mostrar()
        {
            return $@"Nombre: {Nombre}     Valor: {ValorActivo}   Fecha de adquisicion: {FechaAdquisicion}       Tipo de Activo: {TipoActivo}";
        }
        public void depreciacion()
        {

        }
    }
}
