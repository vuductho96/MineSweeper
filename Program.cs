using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the minefield
            string[,] map = {
                {"*", ".", ".", "."},
                {".", ".", ".", "."},
                {".", "*", ".", "."},
                {".", ".", ".", "."}
            };

            // Get the dimensions of the minefield
            int height = map.GetLength(0);
            int width = map.GetLength(1);

            // Iterate over each cell in the minefield
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // If the cell contains a mine, output an asterisk
                    if (map[y, x] == "*")
                    {
                        Console.Write("*");
                    }
                    // Otherwise, count the number of neighboring mines and output the count
                    else
                    {
                        // Start with a count of 0
                        int count = 0;

                        // Iterate over the cells surrounding the current cell
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            for (int dx = -1; dx <= 1; dx++)
                            {
                                // Calculate the coordinates of the neighboring cell
                                int yy = y + dy;
                                int xx = x + dx;

                                // Check if the neighboring cell is within the minefield
                                bool isWithinField = xx >= 0 && xx < width && yy >= 0 && yy < height;

                                // If the neighboring cell is within the minefield and contains a mine, increment the count
                                if (isWithinField && map[yy, xx] == "*")
                                {
                                    count++;
                                }
                            }
                        }

                        // Output the count for the current cell
                        Console.Write(count);
                    }
                }
                Console.WriteLine();
            }

            // Wait for the user to press a key before exiting
            Console.ReadLine();
        }
    }
}
