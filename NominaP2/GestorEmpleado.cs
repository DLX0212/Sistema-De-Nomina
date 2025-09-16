using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GestorEmpleados
{
    private List<Empleado> empleados;

    public GestorEmpleados()
    {
        empleados = new List<Empleado>();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        empleados.Add(empleado);
        Console.WriteLine($"Empleado {empleado.ObtenerInformacion()} agregado exitosamente");
    }

    public void MostrarTodosLosEmpleados()
    {
        Console.WriteLine("\n LISTA DE EMPLEADOS");
        if (empleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados");
            return;
        }

        for (int i = 0; i < empleados.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {empleados[i].ObtenerInformacion()}");
        }
    }

    public void GenerarReportePagos()
    {
        Console.WriteLine("\nREPORTE SEMANAL DE PAGOS");
        if (empleados.Count == 0)
        {
            Console.WriteLine("No hay empleados para procesar");
            return;
        }

        decimal totalPagos = 0;

        foreach (var empleado in empleados)
        {
            decimal pago = empleado.CalcularPago();
            totalPagos += pago;

            Console.WriteLine($"Empleado: {empleado.ObtenerInformacion()}");
            Console.WriteLine($"Pago Semanal: ${pago:F2}");
        }

        Console.WriteLine($"TOTAL A PAGAR ESTA SEMANA: ${totalPagos:F2}");
        Console.WriteLine($"NUMERO DE EMPLEADOS: {empleados.Count}");
    }

    public bool ActualizarEmpleado(int indice)
    {
        if (indice < 0 || indice >= empleados.Count)
        {
            Console.WriteLine("Indice de empleado invalido.");
            return false;
        }

        var empleado = empleados[indice];
        Console.WriteLine($"\nActualizando: {empleado.ObtenerInformacion()}");

        switch (empleado)
        {
            case EmpleadoAsalariado asalariado:
                Console.Write($"Nuevo salario semanal (actual: ${asalariado.SalarioSemanal:F2}): ");
                if (decimal.TryParse(Console.ReadLine(), out decimal nuevoSalario))
                {
                    asalariado.SalarioSemanal = nuevoSalario;
                    Console.WriteLine("Salario actualizado exitosamente");
                }
                break;

            case EmpleadoPorHoras porHoras:
                Console.Write($"Nuevas horas trabajadas (actual: {porHoras.HorasTrabajadas}): ");
                if (int.TryParse(Console.ReadLine(), out int nuevasHoras))
                {
                    porHoras.HorasTrabajadas = nuevasHoras;
                    Console.WriteLine("Horas actualizadas exitosamente");
                }
                break;

            case EmpleadoPorComision porComision:
                Console.Write($"Nuevas ventas brutas (actual: ${porComision.VentasBrutas:F2}): ");
                if (decimal.TryParse(Console.ReadLine(), out decimal nuevasVentas))
                {
                    porComision.VentasBrutas = nuevasVentas;
                    Console.WriteLine("Ventas actualizadas exitosamente");
                }
                break;

            case EmpleadoAsalariadoPorComision asalariadoComision:
                Console.Write($"Nuevas ventas brutas (actual: ${asalariadoComision.VentasBrutas:F2}): ");
                if (decimal.TryParse(Console.ReadLine(), out decimal ventasAC))
                {
                    asalariadoComision.VentasBrutas = ventasAC;
                    Console.WriteLine("Ventas actualizadas exitosamente");
                }
                break;
        }

        return true;
    }

    public int ContarEmpleados()
    {
        return empleados.Count;
    }

    //Test
    public List<Empleado> ObtenerEmpleados()
    {
        return new List<Empleado>(empleados);
    }
}
