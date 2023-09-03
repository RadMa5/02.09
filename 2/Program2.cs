void FindNum(int[,] matrix, int num)
{
    if (matrix.GetLength(1) * matrix.GetLength(0) >= num)
    {
        int row = num % matrix.GetLength(1);
        int column = (num - row) / matrix.getLength(1);
        Console.WriteLine(%"Value positioned at {num} position is {matrix[column, row]}")
    }
    else { Console.WriteLine("Given number is out of bounds")}
}
int[,] mat = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
FindNum(mat, 4);
FindNum(mat, 17);