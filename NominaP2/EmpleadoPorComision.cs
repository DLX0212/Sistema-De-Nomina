using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmpleadoPorComision : Empleado
{
    public decimal VentasBrutas {  get; set; }
    public decimal TarifaComision { get; set; }

    public EmpleadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        VentasBrutas = ventasBrutas;
        TarifaComision = tarifaComision;
    }

    public override decimal CalcularPago()
    {
        return VentasBrutas * TarifaComision;
    }
    public override string ObtenerInformacion()
    {
        return base.ObtenerInformacion() + $" Por Comision, Ventas: ${VentasBrutas:F2} - Comision: {TarifaComision}";
    }
}