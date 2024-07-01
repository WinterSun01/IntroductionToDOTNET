using System;

class TicTacToe
{
    static char[] Board = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
    static int Player = 1;

    static void Main()
    {
        int Move;
        int NumberMoves = 0;

        while (true)
        {
            Console.Clear();
            PrintBoard();

            Console.WriteLine($"Игрок номер {Player}, введите номер от 1 до 9: ");

            try
            {
                Move = Convert.ToInt32(Console.ReadLine());

                //проверка корректности
                if (Move >= 1 && Move <= 9 && Board[Move - 1] != 'X' && Board[Move - 1] != 'O')
                {
                    Board[Move - 1] = Player == 1 ? 'X' : 'O';
                    NumberMoves++;
       
                    if (CheckWin())
                    {
                        Console.Clear();
                        PrintBoard();
                        Console.WriteLine($"Игрок номер {Player} победил!");
                        break;
                    }

                    if (NumberMoves == 9)
                    {
                        Console.Clear();
                        PrintBoard();
                        Console.WriteLine("Ничья!");
                        break;
                    }

                    Player = Player == 1 ? 2 : 1;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод, пожалуйста, введите число от 1 до 9!");
            }
        }
    }


    //для печати игрового поля
    static void PrintBoard()
    {
        Console.WriteLine(" {0} | {1} | {2} ", Board[0], Board[1], Board[2]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", Board[3], Board[4], Board[5]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", Board[6], Board[7], Board[8]);
    }

    //для проверки выигрышных комбинаций
    static bool CheckWin()
    {
        char PlayerSymbol = Player == 1 ? 'X' : 'O';

        int[,] WinPositions = 
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8},
            {2, 4, 6}
        };

        for (int i = 0; i < WinPositions.GetLength(0); i++)
        {
            int pos1 = WinPositions[i, 0];
            int pos2 = WinPositions[i, 1];
            int pos3 = WinPositions[i, 2];

            if (Board[pos1] == PlayerSymbol && Board[pos2] == PlayerSymbol && Board[pos3] == PlayerSymbol)
            {
                return true;
            }
        }

        return false;
    }
}
