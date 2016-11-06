using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        char dot = '.';
        char star = '*';
        
        int fielfSizeCol = 2 * n + 1;
        int fielfSizeRow = 2 * n -2;
        int midCol = fielfSizeCol / 2;
        int midRow = fielfSizeRow / 2;

        for (int row = 0; row < fielfSizeRow; row++)
        {
            for (int col = 0; col < fielfSizeCol; col++)
            {
                if (row == midRow - (midRow/2) + 1 && col < fielfSizeCol ||
                    row == 0 && col >midCol/2 && col < (midCol + 1 +(midCol / 2))||
                    row < fielfSizeRow && col == midCol ||
                    col + row == midCol/2 +1 ||
                    col + row == fielfSizeRow + midCol/2 
                    )
                {
                    Console.Write(star);
                }
                else
                {
                    
                    Console.Write(dot);
                }
                
            }
            Console.WriteLine();
        }
    }
} 