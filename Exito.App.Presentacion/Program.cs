using System;
using Exito.App.Dominio;
using Exito.App.Persistencia;

namespace Exito.App.Presentacion
{
    class Program
    {
        Exito.App.Persistencia.AppContext _context = new Exito.App.Persistencia.AppContext();
        static void Main(string[] args)
        {
           Program p = new Program();
           p.GuardarRol();
           p.GuardarSucursal();
           p.GuardarEmpleado();
        }


        void GuardarRol(){
            RolRepository rolRepository = new RolRepository(this._context);
            Rol rol = new Rol();
            rol.Nombre = "Administrador_Ventas";
            rolRepository.Save(rol);
        }
        void GuardarSucursal(){
            SucursalRepository sucursalRepository = new SucursalRepository(this._context);
            Sucursal sucursal = new Sucursal();
            sucursal.Nombre = "Some sucursal";
            sucursalRepository.Save(sucursal);
        }
        void GuardarEmpleado(){
            EmpleadoRepository empleadoRepository = new EmpleadoRepository(this._context);
            Empleado empleado = new Empleado(){
                Nombre = "Andres",
                Apellido = "Ramirez",
                Usuario = "222222",
                Clave = "222222",
                Cedula = "222222",
                RolId = 2,
                SucursalId = 2

            };
        
            
            empleadoRepository.Save(empleado);
        }
    }
}
