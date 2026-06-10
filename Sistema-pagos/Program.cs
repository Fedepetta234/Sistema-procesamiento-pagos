class Program
{
    static List<Efectivo> efectivos = new List<Efectivo>();
    static List<Transferencia> transferencias = new List<Transferencia>();
    static List<Tarjeta> tarjetas = new List<Tarjeta>();


    static void Main()
    {
        int op;
        do
        {
            Console.WriteLine("--Menu--");
            Console.WriteLine("1. Ingresar datos");
            Console.WriteLine("2. Mostrar datos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            op = int.Parse(Console.ReadLine() ?? "0");

            switch (op)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }while (op != 0);
    }

    static void CargarTitular()
    {
        Console.Write("Ingresar Titular: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese el monto original :");
        double monto = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione el tipo de pago:");
        Console.WriteLine("1. Efectivo");
        Console.WriteLine("2. Transferencia");
        Console.WriteLine("3. Tarjeta");
        int tipoPago = int.Parse(Console.ReadLine());
        
        switch (tipoPago){
            case 1:
                MetodoEfectivo();
                break;
            case 2:
                MetodoTransferencia();
                break;
            case 3:
                MetodoTarjeta();
                break;
             default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
        }
    }

    static void Efectivo()
    {
        
    }
}

