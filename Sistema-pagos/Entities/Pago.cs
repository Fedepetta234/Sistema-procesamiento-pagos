abstract public class Pago
{
    private string titular;
    private double montoOriginal;

    public string Tirular{get{return this.titular;} set {this.titular = value;}}
    public double MontoOriginal{get{return this.montoOriginal;} set {this.montoOriginal = value;}}

    public Pago(string titular, double montoOriginal)
    {
        this.Tirular = titular;
        this.MontoOriginal = montoOriginal;
    }

    public abstract void CostoAdicionales();

}
