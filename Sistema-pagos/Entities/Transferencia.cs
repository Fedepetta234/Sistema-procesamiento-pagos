public class Transferencia : Pago
{
    public Transferencia(string titular, double montoOriginal) : base(titular, montoOriginal)
    {
    }

    public override void CostoAdicionales()
    {
        double comision = MontoOriginal * 0.05;
        MontoOriginal += comision;
    }
}