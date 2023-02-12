using Sudoku.Shared;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Sudoku.Norvig
{
    public class NorvigSolver : ISudokuSolver
    {
        public SudokuGrid Solve(SudokuGrid s)
        {
            

        }
    }
    
    
using System;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sudoku = new int[9, 9] {
                {5, 3, 0, 0, 7, 0, 0, 0, 0},
                {6, 0, 0, 1, 9, 5, 0, 0, 0},
                {0, 9, 8, 0, 0, 0, 0, 6, 0},
                {8, 0, 0, 0, 6, 0, 0, 0, 3},
                {4, 0, 0, 8, 0, 3, 0, 0, 1},
                {7, 0, 0, 0, 2, 0, 0, 0, 6},
                {0, 6, 0, 0, 0, 0, 2, 8, 0},
                {0, 0, 0, 4, 1, 9, 0, 0, 5},
                {0, 0, 0, 0, 8, 0, 0, 7, 9}
            };

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(sudoku[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

}
