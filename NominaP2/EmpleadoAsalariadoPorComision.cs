using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EmpleadoAsalariadoPorComision : Empleado
{
    public decimal VentasBrutas { get; set; }
    public decimal TarifaComision { get; set; }
    public decimal SalarioBase { get; set; }

    public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        VentasBrutas = ventasBrutas;
        TarifaComision = tarifaComision;
        SalarioBase = salarioBase;
    }

    public override decimal CalcularPago()
    {
        decimal comision = VentasBrutas * TarifaComision;
        decimal bono = SalarioBase * 0.10m;
        return comision + SalarioBase + bono;
    }

    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() +
               $" Asalariado + Comision, Salario: ${SalarioBase:F2}, Ventas: ${VentasBrutas:F2}";
    }
}

