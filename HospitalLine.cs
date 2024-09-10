namespace TP3
{
    public class HospitalLine
    {
        PriorityQueue<Paciente, int> priorityQueue = new PriorityQueue<Paciente, int>();
        int priority = 0;

        public void Update()
        {
            int valorMinimo = 1;
            int valorMaximo = 2;

            Console.WriteLine($"\nEscriba el valor mínimo de prioridad para los pacientes (si ingresa un valor no válido, será 1): ");
            valorMinimo = int.Parse(Console.ReadLine());

            if (valorMinimo < 1)
            {
                valorMinimo = 1;
            }

            Console.WriteLine($"\nEscriba el valor máximo de prioridad para los pacientes (si ingresa un valor no válido, será 2): ");
            valorMaximo = int.Parse(Console.ReadLine());

            if (valorMaximo < valorMinimo)
            {
                Console.WriteLine("\nError: El valor máximo es menor que el valor mínimo.");
                return;
            }

            CrearPacientes(valorMinimo, valorMaximo);

            Console.WriteLine("\n-------------------------------------------" +
                              "\n           ATENDIENDO PACIENTES" +
                              "\n-------------------------------------------");

            AtenderClientes();
        }

        private void CrearPacientes(int valorMinimo, int valorMaximo)
        {
            for (int i = 0; i < 19; i++)
            {
                Random random = new Random();
                Paciente paciente = new Paciente();

                int randomName = random.Next(0, Paciente.nombresPosibles.Length);
                paciente.nombre = Paciente.nombresPosibles[randomName];
                paciente.order = i + 1;

                priority = random.Next(valorMinimo, valorMaximo);

                priorityQueue.Enqueue(paciente, priority);
            }
        }

        private void AtenderClientes()
        {
            while (priorityQueue.TryDequeue(out Paciente paciente, out int priority))
            {
                Console.WriteLine($"\n Atendiendo al paciente {paciente.nombre} (de prioridad {priority}): Llegó {paciente.order}.");
            }

        }
    }
}
