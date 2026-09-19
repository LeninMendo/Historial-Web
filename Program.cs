ListaDoble historial = new ListaDoble();
NodoDoble paginaActual = null;

int opcion = 0;

while (opcion != 6)
{
    Console.WriteLine("\n=== APLICACIÓN: HISTORIAL DE NAVEGACIÓN WEB ===");
    if (paginaActual != null)
    {
        Console.WriteLine("PÁGINA ACTUAL: " + paginaActual.Dato.Titulo + " (" + paginaActual.Dato.Url + ")");
    }
    else
    {
        Console.WriteLine("PÁGINA ACTUAL: Ninguna");
    }

    Console.WriteLine("-----------------------------------------------\n" + 
        "1. Visitar nueva página (Agregar al final)\n" + 
        "2. Retroceder (Atrás)\n" + 
        "3. Avanzar (Adelante)\n" + 
        "4. Mostrar historial completo (Adelante y Atrás)\n" + 
        "5. Eliminar página del historial\n" + 
        "6. Salir\n");
    Console.Write("Seleccione una opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese la URL: ");
            string url = Console.ReadLine();
            Console.WriteLine("Ingrese el título de la página: ");
            string titulo = Console.ReadLine();

            PaginaWeb nuevaPagina = new PaginaWeb(url, titulo);
            historial.AgregarAlFinal(nuevaPagina);
            paginaActual = historial.Cola;
            break;

        case 2:
            if (paginaActual != null && paginaActual.Anterior != null)
            {
                paginaActual = paginaActual.Anterior;
                Console.WriteLine("Retrocediste a: " + paginaActual.Dato.Titulo);
            }
            else
            {
                Console.WriteLine("No hay páginas anteriores en el historial.");
            }
            break;

        case 3:
            if (paginaActual != null && paginaActual.Siguiente != null)
            {
                paginaActual = paginaActual.Siguiente;
                Console.WriteLine("Avanzaste a: " + paginaActual.Dato.Titulo);
            }
            else
            {
                Console.WriteLine("No hay páginas siguientes en el historial.");
            }
            break;

        case 4:
            historial.ImprimirAdelante();
            historial.ImprimirAtras();
            break;

        case 5:
            Console.WriteLine("Ingrese la URL a eliminar: ");
            string urlEliminar = Console.ReadLine();
            historial.Eliminar(urlEliminar);
            paginaActual = historial.Cola;
            break;

        case 6:
            Console.WriteLine("Saliendo de la simulación...");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;

    }
}