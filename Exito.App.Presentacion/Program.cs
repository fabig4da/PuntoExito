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
        //    p.GuardarSucursal();
        //    p.GuardarEmpleado();
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
                Nombre = "fabian",
                Apellido = "Garces",
                Usuario = "111111",
                Clave = "111111",
                Rol = new Rol(){
                    RolId = 2,
                },
                Sucursal =new Sucursal() {
                    SucursalId = 2,
                }

            };
            
            empleadoRepository.Save(empleado);
        }
    }
}
