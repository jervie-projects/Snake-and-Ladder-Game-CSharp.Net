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
    internal class PlayerLocationClass
    {
        public static void PlayerOneMove(int PlayerLocation, PictureBox pbPlayerOne)
        {
            switch (PlayerLocation)
            {
                case 1:
                    pbPlayerOne.Location = new Point(79, 458);
                    break;
                case 2:
                    pbPlayerOne.Location = new Point(156, 458);
                    break;
                case 3:
                    pbPlayerOne.Location = new Point(230, 458);
                    break;
                case 4:
                    pbPlayerOne.Location = new Point(306, 458);
                    break;
                case 5:
                    pbPlayerOne.Location = new Point(381, 458);
                    break;
                case 6:
                    pbPlayerOne.Location = new Point(456, 458);
                    break;
                case 7:
                    pbPlayerOne.Location = new Point(528, 458);
                    break;
                case 8:
                    pbPlayerOne.Location = new Point(603, 458);
                    break;
                case 9:
                    pbPlayerOne.Location = new Point(676, 458);
                    break;
                case 10:
                    pbPlayerOne.Location = new Point(675, 408);
                    break;
                case 11:
                    pbPlayerOne.Location = new Point(603, 408);
                    break;
                case 12:
                    pbPlayerOne.Location = new Point(529, 408);
                    break;
                case 13:
                    pbPlayerOne.Location = new Point(453, 408);
                    break;
                case 14:
                    pbPlayerOne.Location = new Point(384, 408);
                    break;
                case 15:
                    pbPlayerOne.Location = new Point(306, 408);
                    break;
                case 16:
                    pbPlayerOne.Location = new Point(229, 408);
                    break;
                case 17:
                    pbPlayerOne.Location = new Point(159, 408);
                    break;
                case 18:
                    pbPlayerOne.Location = new Point(81, 408);
                    break;
                case 19:
                    pbPlayerOne.Location = new Point(4, 408);
                    break;
                case 20:
                    pbPlayerOne.Location = new Point(3, 357);
                    break;
                case 21:
                    pbPlayerOne.Location = new Point(80, 357);
                    break;
                case 22:
                    pbPlayerOne.Location = new Point(156, 357);
                    break;
                case 23:
                    pbPlayerOne.Location = new Point(231, 357);
                    break;
                case 24:
                    pbPlayerOne.Location = new Point(303, 357);
                    break;
                case 25:
                    pbPlayerOne.Location = new Point(380, 357);
                    break;
                case 26:
                    pbPlayerOne.Location = new Point(453, 357);
                    break;
                case 27:
                    pbPlayerOne.Location = new Point(527, 357);
                    break;
                case 28:
                    pbPlayerOne.Location = new Point(604, 357);
                    break;
                case 29:
                    pbPlayerOne.Location = new Point(680, 357);
                    break;
                case 30:
                    pbPlayerOne.Location = new Point(677, 306);
                    break;
                case 31:
                    pbPlayerOne.Location = new Point(601, 306);
                    break;
                case 32:
                    pbPlayerOne.Location = new Point(528, 306);
                    break;
                case 33:
                    pbPlayerOne.Location = new Point(456, 306);
                    break;
                case 34:
                    pbPlayerOne.Location = new Point(379, 306);
                    break;
                case 35:
                    pbPlayerOne.Location = new Point(307, 306);
                    break;
                case 36:
                    pbPlayerOne.Location = new Point(234, 306);
                    break;
                case 37:
                    pbPlayerOne.Location = new Point(155, 306);
                    break;
                case 38:
                    pbPlayerOne.Location = new Point(82, 306);
                    break;
                case 39:
                    pbPlayerOne.Location = new Point(7, 306);
                    break;
                case 40:
                    pbPlayerOne.Location = new Point(5, 256);
                    break;
                case 41:
                    pbPlayerOne.Location = new Point(80, 256);
                    break;
                case 42:
                    pbPlayerOne.Location = new Point(157, 256);
                    break;
                case 43:
                    pbPlayerOne.Location = new Point(228, 256);
                    break;
                case 44:
                    pbPlayerOne.Location = new Point(307, 256);
                    break;
                case 45:
                    pbPlayerOne.Location = new Point(378, 256);
                    break;
                case 46:
                    pbPlayerOne.Location = new Point(453, 256);
                    break;
                case 47:
                    pbPlayerOne.Location = new Point(528, 256);
                    break;
                case 48:
                    pbPlayerOne.Location = new Point(602, 256);
                    break;
                case 49:
                    pbPlayerOne.Location = new Point(676, 256);
                    break;
                case 50:
                    pbPlayerOne.Location = new Point(678, 206);
                    break;
                case 51:
                    pbPlayerOne.Location = new Point(606, 206);
                    break;
                case 52:
                    pbPlayerOne.Location = new Point(530, 206);
                    break;
                case 53:
                    pbPlayerOne.Location = new Point(453, 206);
                    break;
                case 54:
                    pbPlayerOne.Location = new Point(379, 206);
                    break;
                case 55:
                    pbPlayerOne.Location = new Point(305, 206);
                    break;
                case 56:
                    pbPlayerOne.Location = new Point(231, 206);
                    break;
                case 57:
                    pbPlayerOne.Location = new Point(158, 206);
                    break;
                case 58:
                    pbPlayerOne.Location = new Point(81, 206);
                    break;
                case 59:
                    pbPlayerOne.Location = new Point(7, 206);
                    break;
                case 60:
                    pbPlayerOne.Location = new Point(7, 154);
                    break;
                case 61:
                    pbPlayerOne.Location = new Point(83, 154);
                    break;
                case 62:
                    pbPlayerOne.Location = new Point(156, 154);
                    break;
                case 63:
                    pbPlayerOne.Location = new Point(230, 154);
                    break;
                case 64:
                    pbPlayerOne.Location = new Point(305, 154);
                    break;
                case 65:
                    pbPlayerOne.Location = new Point(380, 154);
                    break;
                case 66:
                    pbPlayerOne.Location = new Point(453, 154);
                    break;
                case 67:
                    pbPlayerOne.Location = new Point(528, 154);
                    break;
                case 68:
                    pbPlayerOne.Location = new Point(602, 154);
                    break;
                case 69:
                    pbPlayerOne.Location = new Point(675, 154);
                    break;
                case 70:
                    pbPlayerOne.Location = new Point(676, 104);
                    break;
                case 71:
                    pbPlayerOne.Location = new Point(600, 104);
                    break;
                case 72:
                    pbPlayerOne.Location = new Point(526, 104);
                    break;
                case 73:
                    pbPlayerOne.Location = new Point(456, 104);
                    break;
                case 74:
                    pbPlayerOne.Location = new Point(382, 104);
                    break;
                case 75:
                    pbPlayerOne.Location = new Point(306, 104);
                    break;
                case 76:
                    pbPlayerOne.Location = new Point(228, 104);
                    break;
                case 77:
                    pbPlayerOne.Location = new Point(159, 104);
                    break;
                case 78:
                    pbPlayerOne.Location = new Point(83, 104);
                    break;
                case 79:
                    pbPlayerOne.Location = new Point(7, 104);
                    break;
                case 80:
                    pbPlayerOne.Location = new Point(7, 54);
                    break;
                case 81:
                    pbPlayerOne.Location = new Point(82, 54);
                    break;
                case 82:
                    pbPlayerOne.Location = new Point(155, 54);
                    break;
                case 83:
                    pbPlayerOne.Location = new Point(232, 54);
                    break;
                case 84:
                    pbPlayerOne.Location = new Point(306, 54);
                    break;
                case 85:
                    pbPlayerOne.Location = new Point(381, 54);
                    break;
                case 86:
                    pbPlayerOne.Location = new Point(456, 54);
                    break;
                case 87:
                    pbPlayerOne.Location = new Point(529, 54);
                    break;
                case 88:
                    pbPlayerOne.Location = new Point(602, 54);
                    break;
                case 89:
                    pbPlayerOne.Location = new Point(678, 54);
                    break;
                case 90:
                    pbPlayerOne.Location = new Point(677, 3);
                    break;
                case 91:
                    pbPlayerOne.Location = new Point(603, 3);
                    break;
                case 92:
                    pbPlayerOne.Location = new Point(530, 3);
                    break;
                case 93:
                    pbPlayerOne.Location = new Point(455, 3);
                    break;
                case 94:
                    pbPlayerOne.Location = new Point(381, 3);
                    break;
                case 95:
                    pbPlayerOne.Location = new Point(305, 3);
                    break;
                case 96:
                    pbPlayerOne.Location = new Point(232, 3);
                    break;
                case 97:
                    pbPlayerOne.Location = new Point(161, 3);
                    break;
                case 98:
                    pbPlayerOne.Location = new Point(79, 3);
                    break;
                case 99:
                    pbPlayerOne.Location = new Point(10, 3);
                    break;
                default:
                    pbPlayerOne.Location = new Point(10, 3);
                    break;
            }
        }

        public static void PlayerTwoMove(int PlayerLocation, PictureBox pbPlayerTwo)

        {
            switch (PlayerLocation)
            {
                case 1:
                    pbPlayerTwo.Location = new Point(111, 458);
                    break;
                case 2://snake 1 end tile-3
                    pbPlayerTwo.Location = new Point(182, 458);
                    break;

                case 3://ladder 1 start tile-4
                    pbPlayerTwo.Location = new Point(257, 458);
                    break;
                case 4://snake 2 end tile-5
                    pbPlayerTwo.Location = new Point(337, 458);
                    break;
                case 5:
                    pbPlayerTwo.Location = new Point(407, 458);
                    break;
                case 6:
                    pbPlayerTwo.Location = new Point(484, 458);
                    break;
                case 7:
                    pbPlayerTwo.Location = new Point(554, 458);
                    break;
                case 8:
                    pbPlayerTwo.Location = new Point(630, 458);
                    break;
                case 9:
                    pbPlayerTwo.Location = new Point(711, 458);
                    break;
                case 10:
                    pbPlayerTwo.Location = new Point(711, 408);
                    break;
                case 11:
                    pbPlayerTwo.Location = new Point(630, 408);
                    break;
                case 12://ladder 2 start tile-13
                    pbPlayerTwo.Location = new Point(558, 408);
                    break;
                case 13:
                    pbPlayerTwo.Location = new Point(482, 408);
                    break;
                case 14:
                    pbPlayerTwo.Location = new Point(409, 408);
                    break;
                case 15:
                    pbPlayerTwo.Location = new Point(335, 408);
                    break;
                case 16:
                    pbPlayerTwo.Location = new Point(259, 408);
                    break;
                case 17://snake 3 end tile-18
                    pbPlayerTwo.Location = new Point(185, 408);
                    break;
                case 18:
                    pbPlayerTwo.Location = new Point(110, 408);
                    break;
                case 19:
                    pbPlayerTwo.Location = new Point(35, 408);
                    break;

                case 20:
                    pbPlayerTwo.Location = new Point(36, 357);
                    break;
                case 21:
                    pbPlayerTwo.Location = new Point(111, 357);
                    break;
                case 22:
                    pbPlayerTwo.Location = new Point(187, 357);
                    break;
                case 23:
                    pbPlayerTwo.Location = new Point(260, 357);
                    break;
                case 24://ladder 1 end tile-25
                    pbPlayerTwo.Location = new Point(337, 357);
                    break;
                case 25:
                    pbPlayerTwo.Location = new Point(406, 357);
                    break;
                case 26://snake 2 start tile-27
                    pbPlayerTwo.Location = new Point(484, 357);
                    break;
                case 27:
                    pbPlayerTwo.Location = new Point(558, 357);
                    break;
                case 28:
                    pbPlayerTwo.Location = new Point(631, 357);
                    break;
                case 29:
                    pbPlayerTwo.Location = new Point(711, 357);
                    break;

                case 30://snake 4 end- tile-31
                    pbPlayerTwo.Location = new Point(711, 306);
                    break;
                case 31:
                    pbPlayerTwo.Location = new Point(632, 306);
                    break;
                case 32://ladder 3 start tile-33
                    pbPlayerTwo.Location = new Point(556, 306);
                    break;
                case 33:
                    pbPlayerTwo.Location = new Point(484, 306);
                    break;
                case 34:
                    pbPlayerTwo.Location = new Point(408, 306);
                    break;
                case 35:
                    pbPlayerTwo.Location = new Point(338, 306);
                    break;
                case 36:
                    pbPlayerTwo.Location = new Point(263, 306);
                    break;
                case 37:
                    pbPlayerTwo.Location = new Point(186, 306);
                    break;
                case 38:
                    pbPlayerTwo.Location = new Point(110, 306);
                    break;
                case 39://snake 1 start tile-40
                    pbPlayerTwo.Location = new Point(35, 306);
                    break;

                case 40://snake 5 end tile-41
                    pbPlayerTwo.Location = new Point(33, 256);
                    break;
                case 41://ladder 4 start tile-42
                    pbPlayerTwo.Location = new Point(108, 256);
                    break;
                case 42://snake 3 start tile-43
                    pbPlayerTwo.Location = new Point(186, 256);
                    break;
                case 43:
                    pbPlayerTwo.Location = new Point(260, 256);
                    break;
                case 44://snake 6 end tile-45
                    pbPlayerTwo.Location = new Point(333, 256);
                    break;
                case 45://ladder 2 end tile-46
                    pbPlayerTwo.Location = new Point(408, 256);
                    break;
                case 46:
                    pbPlayerTwo.Location = new Point(482, 256);
                    break;
                case 47:
                    pbPlayerTwo.Location = new Point(557, 256);
                    break;
                case 48://ladder 3 end tile-49
                    pbPlayerTwo.Location = new Point(634, 256);
                    break;
                case 49://ladder 5 start tile-50
                    pbPlayerTwo.Location = new Point(711, 256);
                    break;

                case 50:
                    pbPlayerTwo.Location = new Point(711, 206);
                    break;
                case 51:
                    pbPlayerTwo.Location = new Point(629, 206);
                    break;
                case 52://snake 7 end tile-53
                    pbPlayerTwo.Location = new Point(558, 206);
                    break;
                case 53://snake 4 start tile-54
                    pbPlayerTwo.Location = new Point(484, 206);
                    break;
                case 54:
                    pbPlayerTwo.Location = new Point(408, 206);
                    break;
                case 55:
                    pbPlayerTwo.Location = new Point(333, 206);
                    break;
                case 56:
                    pbPlayerTwo.Location = new Point(259, 206);
                    break;
                case 57://snake 8 end tile-58
                    pbPlayerTwo.Location = new Point(185, 206);
                    break;
                case 58:
                    pbPlayerTwo.Location = new Point(111, 206);
                    break;
                case 59:
                    pbPlayerTwo.Location = new Point(37, 206);
                    break;


                case 60:
                    pbPlayerTwo.Location = new Point(37, 154);
                    break;
                case 61://ladder 6 start tile-62
                    pbPlayerTwo.Location = new Point(112, 154);
                    break;
                case 62://ladder 4 end tile-63
                    pbPlayerTwo.Location = new Point(182, 154);
                    break;
                case 63:
                    pbPlayerTwo.Location = new Point(257, 154);
                    break;
                case 64:
                    pbPlayerTwo.Location = new Point(335, 154);
                    break;
                case 65://snake 6 start tile-66
                    pbPlayerTwo.Location = new Point(410, 154);
                    break;
                case 66:
                    pbPlayerTwo.Location = new Point(483, 154);
                    break;
                case 67:
                    pbPlayerTwo.Location = new Point(552, 154);
                    break;
                case 68://ladder 5 end tile-69
                    pbPlayerTwo.Location = new Point(629, 154);
                    break;
                case 69:
                    pbPlayerTwo.Location = new Point(711, 154);
                    break;

                case 70:
                    pbPlayerTwo.Location = new Point(711, 104);
                    break;
                case 71:
                    pbPlayerTwo.Location = new Point(629, 104);
                    break;
                case 72:
                    pbPlayerTwo.Location = new Point(556, 104);
                    break;
                case 73://ladder 7 start tile-74
                    pbPlayerTwo.Location = new Point(483, 104);
                    break;
                case 74:
                    pbPlayerTwo.Location = new Point(410, 104);
                    break;
                case 75://snake 8 start tile-76
                    pbPlayerTwo.Location = new Point(334, 104);
                    break;
                case 76:
                    pbPlayerTwo.Location = new Point(260, 104);
                    break;
                case 77:
                    pbPlayerTwo.Location = new Point(188, 104);
                    break;
                case 78:
                    pbPlayerTwo.Location = new Point(110, 104);
                    break;
                case 79:
                    pbPlayerTwo.Location = new Point(38, 104);
                    break;

                case 80:
                    pbPlayerTwo.Location = new Point(38, 54);
                    break;
                case 81:
                    pbPlayerTwo.Location = new Point(106, 54);
                    break;
                case 82:
                    pbPlayerTwo.Location = new Point(186, 54);
                    break;
                case 83:
                    pbPlayerTwo.Location = new Point(260, 54);
                    break;
                case 84:
                    pbPlayerTwo.Location = new Point(332, 54);
                    break;
                case 85:
                    pbPlayerTwo.Location = new Point(404, 54);
                    break;
                case 86:
                    pbPlayerTwo.Location = new Point(483, 54);
                    break;
                case 87:
                    pbPlayerTwo.Location = new Point(558, 54);
                    break;
                case 88://snake 7 start tile-89
                    pbPlayerTwo.Location = new Point(634, 54);
                    break;
                case 89:
                    pbPlayerTwo.Location = new Point(711, 54);
                    break;

                case 90:
                    pbPlayerTwo.Location = new Point(711, 3);
                    break;
                case 91://ladder 7 end tile-92
                    pbPlayerTwo.Location = new Point(634, 3);
                    break;
                case 92:
                    pbPlayerTwo.Location = new Point(557, 3);
                    break;
                case 93:
                    pbPlayerTwo.Location = new Point(486, 3);
                    break;
                case 94:
                    pbPlayerTwo.Location = new Point(410, 3);
                    break;
                case 95:
                    pbPlayerTwo.Location = new Point(334, 3);
                    break;
                case 96:
                    pbPlayerTwo.Location = new Point(259, 3);
                    break;
                case 97:
                    pbPlayerTwo.Location = new Point(183, 3);
                    break;
                case 98://snake 5 start tile-99
                    pbPlayerTwo.Location = new Point(106, 3);
                    break;
                case 99:
                    pbPlayerTwo.Location = new Point(40, 3);
                    break;
                default:
                    pbPlayerTwo.Location = new Point(40, 3);
                    break;
            }
        }

    }
}