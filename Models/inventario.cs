//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWebFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventario
    {
        public int id_inventario { get; set; }
        public int entradas_disponibles { get; set; }
        public int id_evento { get; set; }
        public decimal precio_entrada { get; set; }
    
        public virtual evento evento { get; set; }
    }
}