using System;

public abstract class Empleado
{
    public String PrimerNombre { get; set; }
    public String ApellidoPaterno { get; set; }
    public String NumeroSeguroSocial { get; set; }


    public Empleado(String primerNombre, String apellidoPaterno, String numeroSeguroSocial)
    {
        PrimerNombre = primerNombre;
        ApellidoPaterno = apellidoPaterno;
        NumeroSeguroSocial = numeroSeguroSocial;
    }

    //Metodos
    public abstract decimal CalcularPago();

    public virtual string ObtenerInformacion()
    {
        return $"{PrimerNombre} {ApellidoPaterno} {NumeroSeguroSocial}";

    }
}