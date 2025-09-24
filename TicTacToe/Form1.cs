using System;
using System.Windows.Forms;
namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Name: matthew Amorelli
        //Date: November 9, 2021
        //Description: This program is a Game where the user gets to watch a game of tictactoe happen
        //and see if the X player wins or the O player Wins First because the Other player will fill up the board 
        //out of frustration

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            //try statement
            try
            {
                //varables for the size of array
                int GameArrayRows = 3;
                int GameArrayCols = 3;

                //decalring the array
                int[,] GameArray = { { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9} };


                //new random for the random number generator between 1 and 0
                Random randomGame = new Random();

                //assign a random number for each element

                //start the began the game method
                BegainGame(GameArrayRows, GameArrayCols, ref randomGame, GameArray);


                ////test each element if its a X or a O aka 1 or 0
                TestEachElementInArray(GameArray);


                //Display the results
                DisplayTheWinner(GameArray);

            }
            //catch statement
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// this method begans the game by assigning random numbers
        /// </summary>
        /// <param name="GameArrayRows"></param>
        /// <param name="GameArrayCols"></param>
        /// <param name="randomGame"></param>
        /// <param name="GameArray"></param>
        private void BegainGame(int GameArrayRows, int GameArrayCols, ref Random randomGame, int[,] GameArray)
        {
            for (int row = 0; row < GameArrayRows; ++row)
            {
                for (int col = 0; col < GameArrayCols; ++col)
                {
                    int xorO = randomGame.Next(0, 2);
                    GameArray[row, col] = xorO;

                }
            }
        }


        /// <summary>
        /// Test each element in the GameArray
        /// </summary>
        /// <param name="GameArray"></param>
        /// <param name=""></param>
        private void TestEachElementInArray(int[,] GameArray)
        {

            //for each of the elements in the game array, there is a switch statement that is being tested
            //and then if its either  1 or 0 then an X or O gets showen up in the array
            //as well as the  varable gets assign a X or a O
            switch (GameArray[0, 0])
            {
                case 0:
                    labelGame1.Text = "O";

                    break;


                case 1:
                    labelGame1.Text = "X";

                    break;
            }

            switch (GameArray[0, 1])
            {
                case 0:
                    labelGame2.Text = "O";

                    break;


                case 1:
                    labelGame2.Text = "X";

                    break;
            }

            switch (GameArray[0, 2])
            {
                case 0:
                    labelGame3.Text = "O";

                    break;


                case 1:
                    labelGame2.Text = "X";

                    break;
            }


            switch (GameArray[1, 0])
            {
                case 0:
                    labelGame4.Text = "O";

                    break;


                case 1:
                    labelGame4.Text = "X";

                    break;
            }

            switch (GameArray[1, 1])
            {
                case 0:
                    labelGame5.Text = "O";

                    break;


                case 1:
                    labelGame5.Text = "X";

                    break;
            }

            switch (GameArray[1, 2])
            {
                case 0:
                    labelGame6.Text = "O";

                    break;


                case 1:
                    labelGame6.Text = "X";

                    break;
            }

            switch (GameArray[2, 0])
            {
                case 0:
                    labelGame7.Text = "O";

                    break;


                case 1:
                    labelGame7.Text = "X";

                    break;
            }

            switch (GameArray[2, 1])
            {
                case 0:
                    labelGame8.Text = "O";

                    break;


                case 1:
                    labelGame8.Text = "X";

                    break;
            }

            switch (GameArray[2, 2])
            {
                case 0:
                    labelGame9.Text = "O";

                    break;


                case 1:
                    labelGame9.Text = "X";

                    break;
            }


        }

        /// <summary>
        /// this sums up if a row matches
        /// </summary>
        /// <param name="GameArray"></param>
        /// <param name=""></param>
        private void DisplayTheWinner(int[,] GameArray)
        {
            //with each if, it checks if a certain row has all equal matches then shows the winner
            //each comment before it's if statement indicates witch pattern wins

            //top row
            // * * *
            if (GameArray[0, 0] == 1 && GameArray[0, 1] == 1 && GameArray[0, 2] == 1)
            {
                labelTextWinner.Text = "X Wins First!!!";
            }
            else if (GameArray[0, 0] == 0 && GameArray[0, 1] == 0 && GameArray[0, 2] == 0)
            {
                labelTextWinner.Text = "O Wins First!!!";
            }





            //middle row
            // * * * 
            else if (GameArray[1, 0] == 1 && GameArray[1, 1] == 1 && GameArray[1, 2] == 1)
            {
                labelTextWinner.Text = "X Wins First!!!";
            }
            else if (GameArray[1, 0] == 0 && GameArray[1, 1] == 0 && GameArray[1, 2] == 0)
            {
                labelTextWinner.Text = "O Wins First!!!";
            }


            //bottom row
            //* * *
            else if (GameArray[2, 0] == 1 && GameArray[2, 1] == 1 && GameArray[2, 2] == 1)
            {
                labelTextWinner.Text = "X Wins First!!!";
            }
            else if (GameArray[2, 0] == 0 && GameArray[2, 1] == 0 && GameArray[2, 2] == 0)
            {
                labelTextWinner.Text = "O Wins First!!!";
            }



            //diaginal from left top to right bottem
            /*
                *
                    */
            else if (GameArray[1, 0] == 1 && GameArray[1, 1] == 1 && GameArray[2, 2] == 1)
            {
                labelTextWinner.Text = "X Wins First!!!";
            }
            else if (GameArray[1, 0] == 0 && GameArray[1, 1] == 0 && GameArray[2, 2] == 0)
            {
                labelTextWinner.Text = "O Wins First!!!";
            }


            //diaginal from right top to left bottom
            //      *
            //   *
            // *
            else if (GameArray[0, 2] == 1 && GameArray[1, 1] == 1 && GameArray[2, 0] == 1)
            {
                labelTextWinner.Text = "X Wins First!!!";
            }
            else if (GameArray[0, 2] == 0 && GameArray[1, 1] == 0 && GameArray[2, 0] == 0)
            {
                labelTextWinner.Text = "O Wins First!!!";
            }


            /* o col
             *
             */
            else if (GameArray[0, 0] == 1 && GameArray[1, 0] == 1 && GameArray[2, 0] == 1)
            {
                labelTextWinner.Text = "X Wins First!!!";
            }
            else if (GameArray[0, 0] == 1 && GameArray[1, 0] == 1 && GameArray[2, 0] == 1)
            {
                labelTextWinner.Text = "O Wins First!!!";
            }


            /* 1 col
             *
             */

            else if (GameArray[0, 1] == 1 && GameArray[1, 1] == 1 && GameArray[2, 1] == 1)
            {
                labelTextWinner.Text = "X Wins First!!!";
            }

            else if (GameArray[0, 1] == 0 && GameArray[1, 1] == 0 && GameArray[2, 1] == 0)
            {
                labelTextWinner.Text = "O Wins First!!!";
            }


            /* 2 col
             *
             */
            else if (GameArray[0, 2] == 1 && GameArray[1, 2] == 1 && GameArray[2, 2] == 1)
            {
                labelTextWinner.Text = "X Wins First!!!";
            }
            else if (GameArray[0, 2] == 0 && GameArray[1, 2] == 0 && GameArray[2, 2] == 0)
            {
                labelTextWinner.Text = "O Wins First!!!";
            }


            //Special ties
            //if both top and middle rows get tie
            else if (GameArray[0, 0] == 1 && GameArray[0, 1] == 1 && GameArray[0, 2] == 1 && GameArray[1, 0] == 1 && GameArray[1, 1] == 1 && GameArray[1, 2] == 1)
            {
                labelTextWinner.Text = "Tie";
            }
            else if (GameArray[0, 0] == 0 && GameArray[0, 1] == 0 && GameArray[0, 2] == 0 && GameArray[1, 0] == 0 && GameArray[1, 1] == 0 && GameArray[1, 2] == 0)
            {
                labelTextWinner.Text = "Tie";
            }


            //if Both middle and bottom get tie
            else if (GameArray[1, 0] == 1 && GameArray[1, 1] == 1 && GameArray[1, 2] == 1 && GameArray[2, 0] == 1 && GameArray[2, 1] == 1 && GameArray[2, 2] == 1)
            {
                labelTextWinner.Text = "Tie";
            }
            else if (GameArray[1, 0] == 0 && GameArray[1, 1] == 0 && GameArray[1, 2] == 0 && GameArray[1, 1] == 0 && GameArray[1, 2] == 0)
            {
                labelTextWinner.Text = "Tie";
            }


            //if both zero col and first col get a tie
            else if (GameArray[0, 0] == 1 && GameArray[1, 0] == 1 && GameArray[2, 0] == 1 && GameArray[0, 1] == 1 && GameArray[1, 1] == 1 && GameArray[2, 1] == 1)
            {
                labelTextWinner.Text = "Tie";
            }
            else if (GameArray[0, 0] == 0 && GameArray[0, 1] == 0 && GameArray[0, 2] == 0 && GameArray[0, 1] == 0 && GameArray[1, 1] == 0 && GameArray[2, 1] == 0)
            {
                labelTextWinner.Text = "Tie";
            }


            //if Both first col and second col get tie
            else if (GameArray[0, 1] == 1 && GameArray[1, 1] == 1 && GameArray[2, 1] == 1 && GameArray[0, 2] == 1 && GameArray[1, 2] == 1 && GameArray[2, 2] == 1)
            {
                labelTextWinner.Text = "Tie";
            }
            else if (GameArray[0, 1] == 0 && GameArray[1, 1] == 0 && GameArray[2, 1] == 0 && GameArray[0, 2] == 0 && GameArray[1, 2] == 0 && GameArray[2, 2] == 0)
            {
                labelTextWinner.Text = "Tie";
            }

            else
            {
                labelTextWinner.Text = "It's a Tie";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit the game
            Application.Exit();
        }
    }
}
