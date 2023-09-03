void ColumnAverage(double[,] matrix)
{
    double[] averages = new double[matrix.GetLength(1)]; //1 columns 0 rows
    double columnAvg = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            columnAvg += matrix[j, i];
        }
        columnAvg /= (matrix.GetLength(1) - 1);
        averages[i] = columnAvg;
        columnAvg = 0;
    }
    Console.WriteLine($"Averages of each column equal {string.Join(", ", averages)}"); 
}
double[,] mat = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
ColumnAverage(mat);