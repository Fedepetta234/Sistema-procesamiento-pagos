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
            Console.WriteLine("\n--Menu--");
            Console.WriteLine("1. Ingresar datos");
            Console.WriteLine("2. Mostrar datos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            op = int.Parse(Console.ReadLine() ?? "0");

            switch (op)
            {
                case 1:
                    CargarTitular();   
                    break;
                case 2:
                    MostrarDatos();
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
        Console.Write("\nIngresar Titular: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el monto original :");
        double monto = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione el tipo de pago:");
        Console.WriteLine("1. Efectivo");
        Console.WriteLine("2. Transferencia");
        Console.WriteLine("3. Tarjeta");
        int tipoPago = int.Parse(Console.ReadLine());
        
        switch (tipoPago){
            case 1:
                efectivos.Add(new Efectivo(nombre, monto, 0.0));
                MetodoEfectivo();
                break;
            case 2:
                transferencias.Add(new Transferencia(nombre, monto, 0.0));
                MetodoTransferencia();
                break;
            case 3:
                tarjetas.Add(new Tarjeta(nombre, monto, 0.0));
                MetodoTarjeta();
                break;
            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    }

    static void MetodoEfectivo()
    {
        foreach (var efectivo in efectivos)
        {
            efectivo.CostoAdicionales(); 
        }    
    }

    static void MetodoTransferencia()
    {
        foreach (var transferencia in transferencias)
        {
           transferencia.CostoAdicionales(); 
        }    
    }

    static void MetodoTarjeta()
    {
        foreach (var tarjeta in tarjetas)
        {
           tarjeta.CostoAdicionales(); 
        }    
    }

    static void MostrarDatos()
    {
        Console.WriteLine("--Sistema de procesamientos de pagos--");
        
        Console.WriteLine("===========================");
        Console.WriteLine("\nEfectivo:");
        foreach (var efectivo in efectivos)
        {
            Console.WriteLine($"Titular: {efectivo.Titular}");
            Console.WriteLine($"Monto Original: {efectivo.MontoOriginal}");
            Console.WriteLine($"Monto Total: {efectivo.MontoTotal}");
        }

        Console.WriteLine("===========================");

        Console.WriteLine("\nTransferencias:");
        foreach (var transferencia in transferencias)
        {
            Console.WriteLine($"Titular: {transferencia.Titular}");
            Console.WriteLine($"Monto Original: {transferencia.MontoOriginal}");
            Console.WriteLine($"Monto Total: {transferencia.MontoTotal}");
        }

        Console.WriteLine("===========================");

        Console.WriteLine("\nTarjetas:");
        foreach (var tarjeta in tarjetas)
        {
            Console.WriteLine($"Titular: {tarjeta.Titular}");
            Console.WriteLine($"Monto Original: {tarjeta.MontoOriginal}");
            Console.WriteLine($"Monto Total: {tarjeta.MontoTotal}");
        }
    }
}

