
namespace Exito.App.Dominio
{
    public class Empleado
    {
        public int EmpleadoId {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Usuario {get; set;}
        public string Clave {get; set;}
    
        public Rol Rol {get; set;} 
        public Sucursal Sucursal {get; set;}
    }

}