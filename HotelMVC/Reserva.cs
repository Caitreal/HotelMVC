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
    
    public partial class Reserva
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reserva()
        {
            this.PagoReserva = new HashSet<PagoReserva>();
        }
    
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public int NumeroNoches { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> UsuarioId { get; set; }
        public Nullable<int> HabitacionId { get; set; }
        public Nullable<int> CantidadPersonas { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Habitacion Habitacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoReserva> PagoReserva { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
