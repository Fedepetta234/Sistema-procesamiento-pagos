class Program
{
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
            op = int.Parse(Console.ReadLine());

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

    static void ProcesarPago()
    {
        
    }
}
