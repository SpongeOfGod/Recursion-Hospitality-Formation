namespace TP3
{
    public class HospitalLine
    {
        PriorityQueue<Paciente, int> priorityQueue = new PriorityQueue<Paciente, int>();
        int priority = 0;
        public void Update() 
        {
            int valorMinimo = 1;
            int valorMaximo = 0;

            Console.WriteLine($"\nEscriba el minimo valor de prioridad para los pacientes (si ingresa un valor no valido, sera 1): ");

            valorMinimo = int.Parse(Console.ReadLine());

            if(valorMinimo < 1) 
            {
                valorMinimo = 1;
            }

            Console.WriteLine($"\nEscriba el maximo valor de prioridad para los pacientes: ");

            valorMaximo = int.Parse(Console.ReadLine());

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
            while(priorityQueue.TryDequeue(out Paciente paciente, out int priority)) 
            {
                Console.WriteLine($"\n Atendiendo a paciente: {paciente.nombre}, de prioridad: {priority}. Llego {paciente.order}.");
            }
        }
    }
}
