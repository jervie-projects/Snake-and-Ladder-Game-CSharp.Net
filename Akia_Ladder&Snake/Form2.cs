using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akia_Ladder_Snake
{
    public partial class Form2 : Form
    {
        public int DiceNumber = 0;
        public int PlayerOneLocation = 0;
        public int PlayerTwoLocation = 0;
        public bool playerturn = false;
        public int playerturnCount = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pbPlayerOne.Location = new Point(4, 458);
            pbPlayerTwo.Location = new Point(39, 458);
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int RandomDiceNumber = rn.Next(1, 7);
            #region Dice
            switch (RandomDiceNumber)
            {
                case 1:
                    pbDiceOne.Visible = true;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = false;
                    break;
                case 2:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = true;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = false;
                    break;
                case 3:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = true;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = false;
                    break;
                case 4:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = true;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = false;
                    break;
                case 5:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = true;
                    pbDiceSix.Visible = false;
                    break;
                case 6:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = true;
                    break;
            }
            #endregion 
            playerturnCount++;
            if (playerturnCount % 2 == 0)
            {
                playerturn = true;
            }
            else if (!(playerturnCount % 2 == 0))
            {
                playerturn = false;
            }
            if (playerturn == false)
            {
                PlayerOneLocation = PlayerOneLocation + RandomDiceNumber;
                PlayerLocationClass.PlayerOneMove(PlayerOneLocation, pbPlayerOne);
                //snakes case: 26, 39, 42, 53, 65, 75, 88, 98
                switch (PlayerOneLocation)
                {
                    case 26:
                        PlayerLocationClass.PlayerOneMove(4, pbPlayerOne);
                        PlayerOneLocation = 4;
                        break;
                    case 39:
                        PlayerLocationClass.PlayerOneMove(2, pbPlayerOne);
                        PlayerOneLocation = 2;
                        break;
                    case 42:
                        PlayerLocationClass.PlayerOneMove(17, pbPlayerOne);
                        PlayerOneLocation = 17;
                        break;
                    case 53:
                        PlayerLocationClass.PlayerOneMove(30, pbPlayerOne);
                        PlayerOneLocation = 30;
                        break;
                    case 65:
                        PlayerLocationClass.PlayerOneMove(44, pbPlayerOne);
                        PlayerOneLocation = 44;
                        break;
                    case 75:
                        PlayerLocationClass.PlayerOneMove(57, pbPlayerOne);
                        PlayerOneLocation = 57;
                        break;
                    case 88:
                        PlayerLocationClass.PlayerOneMove(52, pbPlayerOne);
                        PlayerOneLocation = 52;
                        break;
                    case 98:
                        PlayerLocationClass.PlayerOneMove(40, pbPlayerOne);
                        PlayerOneLocation = 40;
                        break;
                }

                //ladder case: 3, 12, 32, 41, 49, 61, 73...(+1 to all start)..(-1 end)
                switch(PlayerOneLocation)
                {
                    case 3:
                        PlayerLocationClass.PlayerOneMove(24, pbPlayerOne);
                        PlayerOneLocation = 24;
                        break;
                    case 12:
                        PlayerLocationClass.PlayerOneMove(45, pbPlayerOne);
                        PlayerOneLocation = 45;
                        break;
                    case 32:
                        PlayerLocationClass.PlayerOneMove(48, pbPlayerOne);
                        PlayerOneLocation = 48;
                        break;
                    case 41:
                        PlayerLocationClass.PlayerOneMove(62, pbPlayerOne);
                        PlayerOneLocation = 62;
                        break;
                    case 49:
                        PlayerLocationClass.PlayerOneMove(68, pbPlayerOne);
                        PlayerOneLocation = 68;
                        break;
                    case 61:
                        PlayerLocationClass.PlayerOneMove(80, pbPlayerOne);
                        PlayerOneLocation = 80;
                        break;
                    case 73:
                        PlayerLocationClass.PlayerOneMove(91, pbPlayerOne);
                        PlayerOneLocation = 91;
                        break;
                }
                if (PlayerOneLocation >= 99)
                {
                    PlayerLocationClass.PlayerOneMove(99, pbPlayerOne);
                    MessageBox.Show("Player One Wins!");
                    btnRollDice.Enabled = false;
                }
            }


            else if (playerturn == true)
            {
                PlayerTwoLocation = PlayerTwoLocation + RandomDiceNumber;
                PlayerLocationClass.PlayerTwoMove(PlayerTwoLocation, pbPlayerTwo);
                //snakes case: 26, 39, 42, 53, 65, 75, 88, 98
                switch (PlayerTwoLocation)
                {
                    case 26:
                        PlayerLocationClass.PlayerTwoMove(4, pbPlayerTwo);
                        PlayerTwoLocation = 4;
                        break;
                    case 39:
                        PlayerLocationClass.PlayerTwoMove(2, pbPlayerTwo);
                        PlayerTwoLocation = 2;
                        break;
                    case 42:
                        PlayerLocationClass.PlayerTwoMove(17, pbPlayerTwo);
                        PlayerTwoLocation = 17;
                        break;
                    case 53:
                        PlayerLocationClass.PlayerTwoMove(30, pbPlayerTwo);
                        PlayerTwoLocation = 30;
                        break;
                    case 65:
                        PlayerLocationClass.PlayerTwoMove(44, pbPlayerTwo);
                        PlayerTwoLocation = 44;
                        break;
                    case 75:
                        PlayerLocationClass.PlayerTwoMove(57, pbPlayerTwo);
                        PlayerTwoLocation = 57;
                        break;
                    case 88:
                        PlayerLocationClass.PlayerTwoMove(52, pbPlayerTwo);
                        PlayerTwoLocation = 52;
                        break;
                    case 98:
                        PlayerLocationClass.PlayerTwoMove(40, pbPlayerTwo);
                        PlayerTwoLocation = 40;
                        break;
                }

                //ladder case: 3, 12, 32, 41, 49, 61, 73...(+1 to all start)..(-1 end)
                switch (PlayerTwoLocation)
                {
                    case 3:
                        PlayerLocationClass.PlayerTwoMove(24, pbPlayerTwo);
                        PlayerTwoLocation = 24;
                        break;
                    case 12:
                        PlayerLocationClass.PlayerTwoMove(45, pbPlayerTwo);
                        PlayerTwoLocation = 45;
                        break;
                    case 32:
                        PlayerLocationClass.PlayerTwoMove(48, pbPlayerTwo);
                        PlayerTwoLocation = 48;
                        break;
                    case 41:
                        PlayerLocationClass.PlayerTwoMove(62, pbPlayerTwo);
                        PlayerTwoLocation = 62;
                        break;
                    case 49:
                        PlayerLocationClass.PlayerTwoMove(68, pbPlayerTwo);
                        PlayerTwoLocation = 68;
                        break;
                    case 61:
                        PlayerLocationClass.PlayerTwoMove(80, pbPlayerTwo);
                        PlayerTwoLocation = 80;
                        break;
                    case 73:
                        PlayerLocationClass.PlayerTwoMove(91, pbPlayerTwo);
                        PlayerTwoLocation = 91;
                        break;
                }

                if (PlayerTwoLocation >= 99)
                {
                    PlayerLocationClass.PlayerTwoMove(99, pbPlayerTwo);
                    MessageBox.Show("Player Two Wins!");
                    btnRollDice.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            PlayerOneLocation = 0;
            PlayerTwoLocation = 0;

            pbDiceOne.Visible = true;
            pbDiceTwo.Visible = false;
            pbDiceThree.Visible = false;
            pbDiceFour.Visible = false;
            pbDiceFive.Visible = false;
            pbDiceSix.Visible = false;

            pbPlayerOne.Location = new Point(4, 458);
            pbPlayerTwo.Location = new Point(39, 458);

            btnRollDice.Enabled = true;
        }
    }
}
