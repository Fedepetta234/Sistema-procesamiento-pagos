public class Efectivo : Pago
{
    public Efectivo(string titular, double montoOriginal) : base(titular, montoOriginal)
    {
    }

    public override void CostoAdicionales()
    {
        double comision = MontoOriginal;
        MontoOriginal = comision;
    }
}