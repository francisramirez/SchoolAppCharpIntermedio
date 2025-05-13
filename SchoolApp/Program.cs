using SchoolApp.Entidades;

namespace SchoolApp
{
    internal class Program
    {
        static void Main(string[] args) 
        {


            Console.Write("Ingrese el número de filas (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas (m): ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            // Cargar la matriz con datos ingresados por el usuario
            Console.WriteLine("\nIngrese los elementos de la matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Intercambiar la primera fila con la segunda si hay al menos 2 filas
            if (n >= 2)
            {
                for (int j = 0; j < m; j++)
                {
                    int temp = matriz[0, j];
                    matriz[0, j] = matriz[1, j];
                    matriz[1, j] = temp;
                }
            }

            // Imprimir la matriz resultante
            Console.WriteLine("\nMatriz resultante:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
