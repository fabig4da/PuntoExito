namespace Exito.App.Dominio
{
    public class CompraDetalle
    {
        public int Id {get; set;}
        public Compra Compra {get; set;}
        public Consola Consola {get; set;}
        public int Cantidad {get; set;}

    }

}