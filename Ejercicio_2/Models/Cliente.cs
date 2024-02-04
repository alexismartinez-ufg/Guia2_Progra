namespace Ejercicio_2.Models
{
    public class Cliente
    {
        public string DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string TipoCuenta { get; set; }
        public string NIT { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal MontoDisponible { get; set; }
        public string Sucursal { get; set; }

        public Cliente(string dui, string nombre, string apellidos, string tipoCuenta, string nit, string numeroCuenta, decimal montoDisponible, string sucursal)
        {
            DUI = dui;
            Nombre = nombre;
            Apellidos = apellidos;
            TipoCuenta = tipoCuenta;
            NIT = nit;
            NumeroCuenta = numeroCuenta;
            MontoDisponible = montoDisponible;
            Sucursal = sucursal;
        }

        /// <summary>
        /// Ayuda a validar que el modelo completo sea valido
        /// para poder realizar acciones sobre este
        /// </summary>
        /// <param name="model">Modelo a evaluar si esta completo o falta información</param>
        /// <returns></returns>
        public static bool IsModelComplete(Cliente model)
        {
            return model != null 
                && !string.IsNullOrEmpty(model.DUI)
                && !string.IsNullOrEmpty(model.Nombre)
                && !string.IsNullOrEmpty(model.Apellidos)
                && !string.IsNullOrEmpty(model.TipoCuenta)
                && !string.IsNullOrEmpty(model.NIT)
                && !string.IsNullOrEmpty(model.NumeroCuenta)
                && !string.IsNullOrEmpty(model.Sucursal);
        }
    }
}
