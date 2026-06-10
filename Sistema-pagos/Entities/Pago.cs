abstract public class Pago
{
    private string titular;
    private double montoOriginal;
    private double montoTotal;

    public string Titular{get{return this.titular;} set {this.titular = value;}}
    public double MontoOriginal{get{return this.montoOriginal;} set {this.montoOriginal = value;}}
    public double MontoTotal{get{return this.montoTotal;} set {this.montoTotal = value;}}

    public Pago(string titular, double montoOriginal, double montoTotal)
    {
        this.Titular = titular;
        this.MontoOriginal = montoOriginal;
        this.MontoTotal = montoTotal;
    }

    public abstract void CostoAdicionales();

}
