using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmpleadoAsalariado : Empleado
{
    public decimal SalarioSemanal { get; set; }

    public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        SalarioSemanal = salarioSemanal;
    }

    public override decimal CalcularPago()
    {
        return SalarioSemanal;
    }

    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() + $" Asalariado, Salario: ${SalarioSemanal:F2}";
    }
}