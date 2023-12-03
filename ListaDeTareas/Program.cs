namespace ListaDeTareas;

internal class Program
{
    static void Main(string[] args)
    {
        int id = 1;
        ListaTareas listaTareas = new ListaTareas();
        int idConsulta = 0;

        while (true)
        {
            Console.WriteLine("Bienvenidos a la lista de tareas: ¿Que quieres hacer? \n" +
                "1. Agregar Tareas \n" +
                "2. Cambiar Tareas de Estado \n" +
                "3. Eliminar Tareas \n" +
                "4. Mostrar Tareas \n" +
                "5. Salir");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4)
                {
                    if (opcion == 1)
                    {
                        try
                        {
                            Tarea tarea = new Tarea();
                            tarea.Id = id;
                            id++;
                            Console.WriteLine("Añada una Descripcion");
                            tarea.Description = Console.ReadLine();
                            tarea.Completada = false;
                            listaTareas.AgregarTarea(tarea);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error añadiendo");
                        }
                    }

                    if (opcion == 2)
                    {
                        try
                        {
                            Tarea tarea = new Tarea();
                            Console.WriteLine("Ingrese la id de la tarea");
                            int.TryParse(Console.ReadLine(), out idConsulta);
                            listaTareas.CambiarEstadoTarea(idConsulta);

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error cambiando de estado");
                        }
                    }

                    if (opcion == 3)
                    {
                        try
                        {
                            Tarea tarea = new Tarea();
                            Console.WriteLine("Ingrese la id de la tarea a eliminar");
                            int.TryParse(Console.ReadLine(), out idConsulta);
                            listaTareas.EliminarTarea(idConsulta);

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error eliminando");
                        }
                    }
                    if (opcion == 4)
                    {

                        listaTareas.MostrarTareas();
                    }

                    if (opcion == 5)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Seleccione una opcion valida");
                }

            }
            else
            {
                Console.WriteLine("Agrega un valor valido");
            }





        }
    }
}