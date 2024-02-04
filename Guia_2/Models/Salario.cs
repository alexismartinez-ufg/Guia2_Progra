namespace Guia_2.Models
{
    public class Salario
    {
        public int DiasLaborados { get; set; }
        public decimal CalcularSalario(int diaslab, decimal valordia) => diaslab * valordia;

    }
}
