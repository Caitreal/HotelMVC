//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class PagoReserva
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public int Pago { get; set; }
        public System.DateTime FechaPago { get; set; }
    
        public virtual Reserva Reserva { get; set; }
    }
}
