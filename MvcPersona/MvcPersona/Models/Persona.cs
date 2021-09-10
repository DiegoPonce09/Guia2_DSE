using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcPersona.Models
{
    public class Persona
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
    }
    public class PersonaDBContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
    }
}