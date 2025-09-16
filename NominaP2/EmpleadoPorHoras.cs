using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmpleadoPorHoras : Empleado
{
    public decimal SueldoPorHora { get; set; }
    public int HorasTrabajadas { get; set; }

    public EmpleadoPorHoras(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal sueldoPorHora, int horasTrabajadas) : base(primerNombre, apellidoPaterno, numeroSeguroSocial) 
    {
        SueldoPorHora = sueldoPorHora;
        HorasTrabajadas = horasTrabajadas;

    }

    public override decimal CalcularPago()
    {
        if (HorasTrabajadas <= 40)
        {
            return SueldoPorHora * HorasTrabajadas;
        }
        else
        {
            decimal pagoRegular = SueldoPorHora * 40;
            decimal horasExtra = HorasTrabajadas - 40;
            decimal pagoHorasExtras = SueldoPorHora * 1.5m + horasExtra;
            return pagoRegular + pagoHorasExtras;

        }
    }
    public override string ObtenerInformacion()
    {
         return base.ObtenerInformacion() + $" Por Horas, Salario: ${SueldoPorHora:F2}/hora - {HorasTrabajadas}";
    }
}