namespace WebInacap.Models
{
    public class SedeCarrera
    {
        public int SedeId { get; set; } 
        public Sede Sede { get; set; }

        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }
  
    }
}
