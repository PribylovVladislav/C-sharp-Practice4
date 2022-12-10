namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of rows:");
            int rowCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the count of columns:");
            int columnCount = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[rowCount, columnCount];
            string strA = "";
            int[,] matrixB = new int[rowCount, columnCount];
            string strB = "";
            int[,] matrixC = new int[rowCount, columnCount];
            string strC = "";
            int sum = 0; 

            Random rand = new Random();
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrixA[i, j] = rand.Next(100);
                    strA += $"{matrixA[i, j]} ";
                    matrixB[i, j] = rand.Next(100);
                    strB += $"{matrixB[i, j]} ";
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    strC += $"{matrixC[i, j]} ";
                }
                strA += "\n";
                strB += "\n";
                strC += "\n";
            }
            Console.WriteLine("Matrix A:\n" + strA);
            Console.WriteLine("Matrix B:\n" + strB);
            Console.WriteLine("Matrix A + B:\n" + strC);
        }
    }
}