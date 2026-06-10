public class Transferencia : Pago
{
    public Transferencia(string titular, double montoOriginal, double montoTotal) : base(titular, montoOriginal, montoTotal)
    {
    }

    public override void CostoAdicionales()
    {
        double comision = MontoOriginal * 0.05;
        MontoTotal = MontoOriginal + comision;
    }
}