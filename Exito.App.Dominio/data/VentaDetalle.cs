namespace Exito.App.Dominio
{
    public class VentaDetalle
    {
        public int Id {get; set;}
        public Venta Venta {get; set;}
        public Consola Consola {get; set;}
        public int Cantidad {get; set;}

    }

}