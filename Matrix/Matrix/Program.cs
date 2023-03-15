namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] / 10 <= 0)
                            Console.Write($" {array[i, j]} ");

                        else Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            int n = 6;
            int[,] sqareMatrix = new int[n, n];
            int temp = 1;
            int i = 0;
            int j = 0;


            int[,] FillArray1(int[,] sqareMatrix)
            {
                while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
                {
                    sqareMatrix[i, j] = temp;
                    temp++;
                    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
                        j++;
                    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
                        i++;
                    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
                        j--;
                    else
                        i--;
                }
                return sqareMatrix;

            }

            int[,] FillArray2(int[,] sqareMatrix)
            {
                while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
                {
                    sqareMatrix[i, j] = temp;
                    temp++;
                    if ((j < sqareMatrix.GetLength(1) - 1) && ((i == 0) || (i % 2 == 0)))
                        j++;
                    else if ((j != 0) && (i % 2 == 1))
                        j--;
                    else 
                        i++;
                }
                return sqareMatrix;
            }

            int[,] FillArray3(int[,] sqareMatrix)
            {
                while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
                {
                    sqareMatrix[i, j] = temp;
                    temp++;
                    if ((i < sqareMatrix.GetLength(0) - 1) && ((j == 0) || (j % 2 == 0)))
                        i++;
                    else if ((i != 0) && (j % 2 == 1))
                        i--;
                    else
                        j++;
                }
                return sqareMatrix;
            }

            int[,] FillArray4(int[,] sqareMatrix)
            {
                bool directionUp = true;
                while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
                {
                    sqareMatrix[i, j] = temp;
                    temp++;

                    if (j != 0 && i < sqareMatrix.GetLength(0) - 1 && !directionUp)
                    {
                        j--;
                        i++;
                    }

                    else if (i != 0 && j < sqareMatrix.GetLength(1) - 1 && directionUp)
                    {
                        j++;
                        i--;

                    }

                    else if (j < sqareMatrix.GetLength(1) - 1 && i == 0)
                    {
                        j++;
                        directionUp = false;
                    }

                    else if (j == 0 && i < sqareMatrix.GetLength(0) - 1)
                    {
                        i++;
                        directionUp = true;
                    }

                    else if (i == sqareMatrix.GetLength(0) - 1)
                    {
                        j++;
                        directionUp = true;
                    }

                    else if(j == sqareMatrix.GetLength(1) - 1)
                    {
                        i++;
                        directionUp = false;
                    }
                }
                return sqareMatrix;
            }

            int[,] FillArray5(int[,] sqareMatrix)
            {
                bool directionUp = false;
                j = sqareMatrix.GetLength(1) - 1;
                while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
                {
                    
                    sqareMatrix[i, j] = temp;
                    temp++;


                    if (directionUp && i != 0 && j != 0)
                    {
                        i--;
                        j--;

                    }

                    else if (!directionUp && j != sqareMatrix.GetLength(1) - 1 && i != sqareMatrix.GetLength(0) - 1) 
                    {
                        i++;
                        j++;
                    }

                    else if (j == sqareMatrix.GetLength(1) - 1 && i < sqareMatrix.GetLength(0) - 1)
                    {
                        i++;
                        directionUp = true;
                    }

                    else if (i == 0 && j != 0)
                    {
                        j--;
                        directionUp = false;
                    }

                    else if (j == 0)
                    {
                        i++;
                        directionUp = false;
                    }

                    else if (i == sqareMatrix.GetLength(0) - 1)
                    {
                        j--;
                        directionUp = true;
                    }
                }
                return sqareMatrix;
            }


            PrintArray(FillArray5(sqareMatrix));
        }
    }
}