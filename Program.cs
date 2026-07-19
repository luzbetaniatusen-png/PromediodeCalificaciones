namespace PromediodeCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Cantidad de estudiantes: ");

            n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)

            {

                Console.Write("Nombre: ");

                string nombre = Console.ReadLine();

                Console.Write("Nota 1: ");

                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Nota 2: ");

                double n2 = double.Parse(Console.ReadLine());

                Console.Write("Nota 3: ");

                double n3 = double.Parse(Console.ReadLine());

                Console.Write("Nota 4: ");

                double n4 = double.Parse(Console.ReadLine());

                double promedio = (n1 + n2 + n3 + n4) / 4;

                string estatus;

                if (promedio >= 70)

                {
                    estatus = "Aprobado";
                }

                else

                {
                    estatus = "Reprobado";
                }
                Console.WriteLine();
                Console.WriteLine("Nombre\t\tNota1\tNota2\tNota3\tNota4\tPromedio\tEstatus");

                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(nombre + "\t\t" + n1 + "\t" + n2 + "\t" + n3 + "\t" + n4 + "\t" + 
                promedio.ToString() + "\t\t" + estatus);

            }

            Console.WriteLine();



        }
    }
}
