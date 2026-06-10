public class Tarjeta : Pago
{
    public Tarjeta(string titular, double montoOriginal, double montoTotal) : base(titular, montoOriginal, montoTotal)
    {
    }

    public override void CostoAdicionales()
    {
        double comision = MontoOriginal * 0.02;
        
        MontoTotal = MontoOriginal + comision;
    }
}