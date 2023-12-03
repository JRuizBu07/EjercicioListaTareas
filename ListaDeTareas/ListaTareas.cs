using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas
{
    internal class ListaTareas
    {
        private readonly ICollection<Tarea> Tareas = new Collection<Tarea>();

        public void AgregarTarea(Tarea tarea)
        {
            try
            {
                Tareas.Add(tarea);
                Console.WriteLine("Tarea Añadida correctamente");
            }
            catch
            {
                Console.WriteLine("Error en servidor");
            }
        }

        public void MostrarTareas()
        {
            if (Tareas is not null)
            {
                foreach (var item in Tareas)
                {
                    var completado = item.Completada ? "Si" : "No";
                    Console.WriteLine("Tarea #" + item.Id + " Descripcion: " + item.Description + " ¿Esta Completada?: " + completado);
                }
            }
            else
            {
                Console.WriteLine("No hay tareas que mostrar");
            }
        }

        public void CambiarEstadoTarea(int id)
        {
            if (Tareas is not null)
            {
                try
                {
                    Tarea tarea = Tareas.First(x => x.Id == id);
                    tarea.Completada = !tarea.Completada;
                    Console.WriteLine("Cambio de estado exitoso");
                }
                catch
                {
                    Console.WriteLine("Error interno");
                }
            }

        }

        public void EliminarTarea(int id)
        {
            if (Tareas is not null)
            {
                try
                {
                    Tarea tarea = Tareas.First(x => x.Id == id);
                    Tareas.Remove(tarea);
                    Console.WriteLine("Eliminado correctamente");
                }
                catch { Console.WriteLine("Error interno"); }
            }
        }
    }
}
