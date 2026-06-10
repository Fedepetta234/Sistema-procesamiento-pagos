abstract public class Pago
{
    private string titular;
    private double montoOriginal;

    public string Titular{get{return this.titular;} set {this.titular = value;}}
    public double MontoOriginal{get{return this.montoOriginal;} set {this.montoOriginal = value;}}

    public Pago(string titular, double montoOriginal)
    {
        this.Titular = titular;
        this.MontoOriginal = montoOriginal;
    }

    public abstract void CostoAdicionales();

}
