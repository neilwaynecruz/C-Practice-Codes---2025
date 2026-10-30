// ==================================================
// ACTIVE PATTERN: HOLLOW SQUARE
// ==================================================
// Puwede mong palitan ang value na 7 kung gusto mo ng
// mas maliit o mas malaking square.
int squareSize = 7;

// Ito ang loop para sa bawat row o pahalang na line.
for (int row = 1; row <= squareSize; row++)
{
    // Ito naman ang loop para sa bawat column o pwesto sa line.
    for (int column = 1; column <= squareSize; column++)
    {
        // Kapag nasa gilid, star ang ipapakita.
        // Kapag nasa loob, space lang para maging hollow ang square.
        if (row == 1 || row == squareSize || column == 1 || column == squareSize)
        {
            Console.Write(" * ");
        }
        else
        {
            Console.Write("   ");
        }
    }

    // Tapos na ang isang row, kaya lipat na sa susunod na line.
    Console.WriteLine();
}

// ==================================================
// OTHER PATTERN EXAMPLES
// ==================================================
// Naka-comment ang mga nasa ibaba para hollow square lang ang
// lumabas kapag ni-run ang program. Alisin ang // kung gusto
// mong subukan ang isang pattern.

// PYRAMID
// int[] starCounts = { 1, 3, 5, 8, 10 };
//
// for (int line = 0; line < starCounts.Length; line++)
// {
//     for (int space = 0; space < 4 - line; space++)
//     {
//         Console.Write(" ");
//     }
//
//     for (int star = 0; star < starCounts[line]; star++)
//     {
//         Console.Write("*");
//     }
//
//     Console.WriteLine();
// }

// INVERTED TRIANGLE
// int triangleRows = 5;
//
// for (int row = triangleRows; row >= 1; row--)
// {
//     for (int space = 0; space < triangleRows - row; space++)
//     {
//         Console.Write(" ");
//     }
//
//     for (int star = 0; star < (row * 2) - 1; star++)
//     {
//         Console.Write("*");
//     }
//
//     Console.WriteLine();
// }

// DIAMOND
// int diamondRows = 5;
//
// for (int row = 1; row <= diamondRows; row++)
// {
//     for (int space = 0; space < diamondRows - row; space++)
//     {
//         Console.Write(" ");
//     }
//
//     for (int star = 0; star < (row * 2) - 1; star++)
//     {
//         Console.Write("*");
//     }
//
//     Console.WriteLine();
// }
//
// for (int row = diamondRows - 1; row >= 1; row--)
// {
//     for (int space = 0; space < diamondRows - row; space++)
//     {
//         Console.Write(" ");
//     }
//
//     for (int star = 0; star < (row * 2) - 1; star++)
//     {
//         Console.Write("*");
//     }
//
//     Console.WriteLine();
// }

// HOLLOW DIAMOND
// int hollowDiamondRows = 5;
//
// for (int row = 1; row <= hollowDiamondRows; row++)
// {
//     for (int space = 0; space < hollowDiamondRows - row; space++)
//     {
//         Console.Write(" ");
//     }
//
//     for (int position = 1; position <= (row * 2) - 1; position++)
//     {
//         if (position == 1 || position == (row * 2) - 1)
//         {
//             Console.Write("*");
//         }
//         else
//         {
//             Console.Write(" ");
//         }
//     }
//
//     Console.WriteLine();
// }
//
// for (int row = hollowDiamondRows - 1; row >= 1; row--)
// {
//     for (int space = 0; space < hollowDiamondRows - row; space++)
//     {
//         Console.Write(" ");
//     }
//
//     for (int position = 1; position <= (row * 2) - 1; position++)
//     {
//         if (position == 1 || position == (row * 2) - 1)
//         {
//             Console.Write("*");
//         }
//         else
//         {
//             Console.Write(" ");
//         }
//     }
//
//     Console.WriteLine();
// }
