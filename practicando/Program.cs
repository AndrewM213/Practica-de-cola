using practicando;

cala C = new cala();
int op = 0;
do
{
    //int opc;
    Console.WriteLine("\n=== MENÚ DE OPCIONES ===");
    Console.WriteLine("Agregar cliente");
    Console.WriteLine("Mostrar");
    Console.WriteLine("Cuantas personas hay");
    Console.WriteLine("terminar");
    Console.WriteLine("elija una opcion");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            string nombre;
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            C.Agregar_nombre(nombre);
            break;
        case 2:
            Console.WriteLine(C.ToString());
            break;
        case 3:
            Console.WriteLine("En la fila hay: " + C.Tamaño() + "personas");
            break;
        case 4:
            Console.WriteLine("cerrando programa");
             
            break;
    }
} while (op != 4);