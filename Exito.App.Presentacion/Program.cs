using System;
using System.Collections.Generic;
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
            //    p.GuardarRol();
            //    p.GuardarSucursal();
            //    p.GuardarEmpleado();
            p.guardarControl();
            p.listarControles();
            // p.actulizarControl();
        }


        void GuardarRol()
        {
            RolRepository rolRepository = new RolRepository(this._context);
            Rol rol = new Rol();
            rol.Nombre = "Administrador_Ventas";
            rolRepository.Save(rol);
        }
        void GuardarSucursal()
        {
            SucursalRepository sucursalRepository = new SucursalRepository(this._context);
            Sucursal sucursal = new Sucursal();
            sucursal.Nombre = "Some sucursal";
            sucursalRepository.Save(sucursal);
        }
        void GuardarEmpleado()
        {
            EmpleadoRepository empleadoRepository = new EmpleadoRepository(this._context);
            Empleado empleado = new Empleado()
            {
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

        void guardarControl()
        {
            ControlRepository controlRepository = new ControlRepository(this._context);
            Control control = new Control
            {
                Nombre = "Control neme",
                Version = "1.2",
                Fabricante = "Gamesatrt",
                precioCompra = 90,
                precioVenta = 30,
                Cantidad = 3
            };
            controlRepository.Save(control);
        }

        void actulizarControl()
        {
            ControlRepository controlRepository = new ControlRepository(this._context);
            Control control = new Control
            {
                Id = 1,
                Nombre = "Control",
                Version = "1.3",
                Fabricante = "Gamesatrt",
                precioCompra = 100,
                precioVenta = 30,
                Cantidad = 3
            };

        }
        void listarControles()
        {
            ControlRepository controlRepository = new ControlRepository(this._context);
            List<Control> controles = controlRepository.FindAll();
            foreach (Control control in controles)
            {
                Console.WriteLine($"{control.Nombre} precio: {control.precioCompra}");

            }

        }
    }
}
