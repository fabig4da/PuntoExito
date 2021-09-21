namespace Exito.App.Dominio
{
    public class Compra
    {
        public int CompraId {get; set;}
        public string Fecha {get; set;} 
        public int Total {get; set;}
        public bool Finalizada {get; set;}
        public Empleado Empleado {get; set;}

    }

}