public class Tarjeta : Pago
{
    public Tarjeta(string titular, double montoOriginal) : base(titular, montoOriginal)
    {
    }

    public override void CostoAdicionales()
    {
        double comision = MontoOriginal * 0.02;
        MontoOriginal += comision;
    }
}