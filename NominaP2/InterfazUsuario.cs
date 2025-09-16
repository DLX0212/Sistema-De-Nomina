using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InterfazUsuario
{
    private GestorEmpleados gestor;

    public InterfazUsuario()
    {
        gestor = new GestorEmpleados();
    }

    public void IniciarAplicacion()
    {
        Console.WriteLine("SISTEMA DE GESTION DE NOMINA");

        bool continuar = true;
        while (continuar)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarEmpleado();
                    break;
                case "2":
                    gestor.MostrarTodosLosEmpleados();
                    break;
                case "3":
                    ActualizarEmpleado();
                    break;
                case "4":
                    gestor.GenerarReportePagos();
                    break;
                case "5":
                    continuar = false;
                    Console.WriteLine("Hasta Luego");
                    break;
                default:
                    Console.WriteLine("Opcion invalida. Por favor, seleccione una opcion del 1 al 5");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    private void MostrarMenu()
    {
        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine("1. Agregar Empleado");
        Console.WriteLine("2. Ver Todos los Empleados");
        Console.WriteLine("3. Actualizar Informacion de Empleado");
        Console.WriteLine("4. Generar Reporte de Pagos");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opcion: ");
    }

    private void AgregarEmpleado()
    {
        Console.Clear();
        Console.WriteLine("AGREGAR NUEVO EMPLEADO");
        Console.WriteLine("Seleccione el tipo de empleado:");
        Console.WriteLine("1. Empleado Asalariado");
        Console.WriteLine("2. Empleado por Horas");
        Console.WriteLine("3. Empleado por Comision");
        Console.WriteLine("4. Empleado Asalariado por Comision");
        Console.Write("Tipo (1-4): ");

        string tipoEmpleado = Console.ReadLine();

        switch (tipoEmpleado)
        {
            case "1":
                CrearEmpleadoAsalariado();
                break;
            case "2":
                CrearEmpleadoPorHoras();
                break;
            case "3":
                CrearEmpleadoPorComision();
                break;
            case "4":
                CrearEmpleadoAsalariadoPorComision();
                break;
            default:
                Console.WriteLine("Tipo de empleado invalido");
                break;
        }
    }

    private void CrearEmpleadoAsalariado()
    {
        Console.Write("Primer nombre: ");
        string primerNombre = Console.ReadLine();

        Console.Write("Apellido paterno: ");
        string apellidoPaterno = Console.ReadLine();

        Console.Write("Numero de Seguro Social: ");
        string numeroSeguroSocial = Console.ReadLine();

        Console.Write("Salario semanal: $");
        if (decimal.TryParse(Console.ReadLine(), out decimal salarioSemanal))
        {
            var empleado = new EmpleadoAsalariado(primerNombre, apellidoPaterno,numeroSeguroSocial, salarioSemanal);
            gestor.AgregarEmpleado(empleado);
        }
        else
        {
            Console.WriteLine("Salario invalido");
        }
    }

    private void CrearEmpleadoPorHoras()
    {
        Console.Write("Primer nombre: ");
        string primerNombre = Console.ReadLine();

        Console.Write("Apellido paterno: ");
        string apellidoPaterno = Console.ReadLine();

        Console.Write("Numero de Seguro Social: ");
        string numeroSeguroSocial = Console.ReadLine();

        Console.Write("Sueldo por hora: $");
        if (!decimal.TryParse(Console.ReadLine(), out decimal sueldoPorHora))
        {
            Console.WriteLine("Sueldo por hora invalido");
            return;
        }

        Console.Write("Horas trabajadas: ");
        if (!int.TryParse(Console.ReadLine(), out int horasTrabajadas))
        {
            Console.WriteLine("Horas trabajadas invalidas");
            return;
        }

        var empleado = new EmpleadoPorHoras(primerNombre, apellidoPaterno,numeroSeguroSocial, sueldoPorHora, horasTrabajadas);
        gestor.AgregarEmpleado(empleado);
    }

    private void CrearEmpleadoPorComision()
    {
        Console.Write("Primer nombre: ");
        string primerNombre = Console.ReadLine();

        Console.Write("Apellido paterno: ");
        string apellidoPaterno = Console.ReadLine();

        Console.Write("Numero de Seguro Social: ");
        string numeroSeguroSocial = Console.ReadLine();

        Console.Write("Ventas brutas: $");
        if (!decimal.TryParse(Console.ReadLine(), out decimal ventasBrutas))
        {
            Console.WriteLine("Ventas brutas invalidas");
            return;
        }

        Console.Write("Tarifa de comision en decimal: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal tarifaComision))
        {
            Console.WriteLine("Tarifa de comision invalida");
            return;
        }

        var empleado = new EmpleadoPorComision(primerNombre, apellidoPaterno,numeroSeguroSocial, ventasBrutas, tarifaComision);
        gestor.AgregarEmpleado(empleado);
    }

    private void CrearEmpleadoAsalariadoPorComision()
    {
        Console.Write("Primer nombre: ");
        string primerNombre = Console.ReadLine();

        Console.Write("Apellido paterno: ");
        string apellidoPaterno = Console.ReadLine();

        Console.Write("Numero de Seguro Social: ");
        string numeroSeguroSocial = Console.ReadLine();

        Console.Write("Ventas brutas: $");
        if (!decimal.TryParse(Console.ReadLine(), out decimal ventasBrutas))
        {
            Console.WriteLine("Ventas brutas invalidas");
            return;
        }

        Console.Write("Tarifa de comision en decimal: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal tarifaComision))
        {
            Console.WriteLine("Tarifa de comision invalida");
            return;
        }

        Console.Write("Salario base: $");
        if (!decimal.TryParse(Console.ReadLine(), out decimal salarioBase))
        {
            Console.WriteLine("Salario base invalido");
            return;
        }

        var empleado = new EmpleadoAsalariadoPorComision(primerNombre, apellidoPaterno,numeroSeguroSocial, ventasBrutas,tarifaComision, salarioBase);
        gestor.AgregarEmpleado(empleado);
    }

    private void ActualizarEmpleado()
    {
        gestor.MostrarTodosLosEmpleados();

        if (gestor.ContarEmpleados() == 0) return;

        Console.Write($"\nSeleccione el empleado a actualizar (1-{gestor.ContarEmpleados()}): ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0)
        {
            gestor.ActualizarEmpleado(indice - 1);
        }
        else
        {
            Console.WriteLine("Numero de empleado invalido");
        }
    }
}
