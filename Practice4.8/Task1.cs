namespace Task1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of rows:");
            int rowCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the count of columns:");
            int columnCount = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rowCount, columnCount];
            int sum = 0;

            Random rand = new Random();
            for(int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = rand.Next(100);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.WriteLine($"Sum of all elements: {sum}");
        }
    }
}