public class Efectivo : Pago
{
    public Efectivo(string titular, double montoOriginal, double montoTotal) : base(titular, montoOriginal, montoTotal)
    {
    }

    public override void CostoAdicionales()
    {
        double comision = MontoOriginal;
        MontoTotal = MontoOriginal;
    }
}