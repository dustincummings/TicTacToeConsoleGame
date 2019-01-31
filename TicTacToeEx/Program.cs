using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeEx
{
    class Program
    {
        //the playfield
        static char[,] playField =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' },
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; //Player 1 starts
            int input = 0;
            bool inputCorrect = true;
      
            //Run code as long as the program runs
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                SetField();
                #region
                //Check winning condition
                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                        || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                        || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                        )
                    {
                        if (playerChar == 'X')
                            Console.WriteLine("\n Player 2 is the winner!!!");
                        else
                            Console.WriteLine("\n Player 1 is the winner!!!");

                        Console.WriteLine("Press any key to reset game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("Draw!!!");
                        Console.WriteLine("Press any key to reset game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }

                #endregion
                #region
                //Test if field is taken
                do
                {
                    Console.WriteLine($"\nPlayer {player}: Choose your square ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter the number you want to choose!");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please choose another number!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion
                //switch (player) Insted of using this long switch case we used a method for both players
                //{
                //    case 1://player 1's turn
                //    {
                //        switch (input)
                //        {
                //            case 1: playField[0, 0] = 'X'; break;
                //            case 2: playField[0, 1] = 'X'; break;
                //            case 3: playField[0, 2] = 'X'; break;
                //            case 4: playField[1, 0] = 'X'; break;
                //            case 5: playField[1, 1] = 'X'; break;
                //            case 6: playField[1, 2] = 'X'; break;
                //            case 7: playField[2, 0] = 'X'; break;
                //            case 8: playField[2, 1] = 'X'; break;
                //            case 9: playField[2, 2] = 'X'; break;
                //        }
                //        break;
                //    }
                //    case 2://player 2's turn
                //    {
                //        switch (input)
                //        {
                //            case 1: playField[0, 0] = 'O'; break;
                //            case 2: playField[0, 1] = 'O'; break;
                //            case 3: playField[0, 2] = 'O'; break;
                //            case 4: playField[1, 0] = 'O'; break;
                //            case 5: playField[1, 1] = 'O'; break;
                //            case 6: playField[1, 2] = 'O'; break;
                //            case 7: playField[2, 0] = 'O'; break;
                //            case 8: playField[2, 1] = 'O'; break;
                //            case 9: playField[2, 2] = 'O'; break;
                //        }
                //        break;
                //    }

                //}

            } while (true);
        }
        public static void ResetField()
        {
            char[,] playFieldInital =
            {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' },
            };
            playField = playFieldInital;
            SetField();
            turns = 0;
        }
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  | {2} ", playField[0, 0], playField[0, 1], playField[0, 2]);//TODO replace numbers with variables
            Console.WriteLine("_____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  | {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);//TODO replace numbers with variables
            Console.WriteLine("_____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  | {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);//TODO replace numbers with variables
            Console.WriteLine("     |     |    ");
            turns++;

            //Console.WriteLine($"  {playField[2, 0]}  |  {playField[2, 1]}  | {playField[2, 2]} ");// This line is the same as line35

        }
        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
        }
    }
}
