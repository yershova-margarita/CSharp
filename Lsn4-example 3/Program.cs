﻿int[,] pic = new int[,]
{
    
}

void PrintImage(int[,] image)
{
    for (int rows = 0; rows < image.GetLength(0); rows++)
    {
        for (int cols = 0; cols < image.GetLength(1); cols++)
        {
            // Console.Write($"{image[rows, cols]} ");
            if(image[i,j] == 0) Console.Write(" ")
            else Console.Write("+")
        }
        Console.WriteLine();
    }
}

PrintImage(pic);