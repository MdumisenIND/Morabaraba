using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ThinkLib;

namespace Morabaraba
{
    class Gameplay
    {
        private PlayerMark[] positionValue;
        Turtle Rabs;
        public bool ValidFirstClick;

        public void DrawBoard(Canvas playground)
        {
            Rabs = new Turtle(playground, 80, 80);

            Rabs.BrushWidth = 4;

            for (int i = 0; i < 3; i++)
            {
                Rabs.Goto(80 * (i + 1), 80 * (i + 1));
                for (int x = 0; x < 4; x++)
                {
                    Rabs.Forward(480 - (i * 160));
                    Rabs.Right(90);
                }

            }
            Rabs.Goto(80, 80);
            Rabs.Heading = 90;

            for (int i = 0; i < 4; i++)
            {

                Rabs.Forward(240);
                Rabs.Left(90);
                Rabs.Forward(160);
                Rabs.Right(90);
                Rabs.Forward(80);
                Rabs.Right(45);
                Rabs.Forward(Math.Sqrt(160 * 160 * 2));
                Rabs.Left(135);
            }

        }
        public void ValueBind(PlayerMark[] lstbtn)
        {
            positionValue = lstbtn;
        }

        public bool CheckAgainst(int index)
        {
            bool move = false;
            if (index > 2 && index < 21)
            {
                if (index % 3 == 0)
                {
                    if (positionValue[index + 1] != PlayerMark.Empty && positionValue[index - 3] != PlayerMark.Empty && positionValue[index + 3] != PlayerMark.Empty)
                    {
                        move = false;
                    }
                    else
                    {
                        move = true;
                    }
                }
                else if ((index - 1) % 3 == 0)
                {
                    if (positionValue[index - 3] != PlayerMark.Empty && positionValue[index + 1] != PlayerMark.Empty && positionValue[index + 3] != PlayerMark.Empty && positionValue[index + -1] != PlayerMark.Empty)
                    {
                        move = false;
                    }
                    else
                    {
                        move = true;
                    }
                }
                else if ((index + 1) % 3 == 0)
                {
                    if (positionValue[index - 3] != PlayerMark.Empty && positionValue[index + 3] != PlayerMark.Empty && positionValue[index - 1] != PlayerMark.Empty)
                    {
                        move = false;
                    }
                    else
                    {
                        move = true;
                    }
                }
            }
            else if (index < 3)
            {
                if (index == 0)
                {
                    if (positionValue[21] != PlayerMark.Empty && positionValue[index + 1] != PlayerMark.Empty && positionValue[index + 3] != PlayerMark.Empty)
                    {
                        move = false;
                    }
                    else
                    {
                        move = true;
                    }
                }
                else if (index == 1)
                {
                    if (positionValue[22] != PlayerMark.Empty && positionValue[index + 1] != PlayerMark.Empty && positionValue[index + 3] != PlayerMark.Empty && positionValue[index - 1] != PlayerMark.Empty)
                    {
                        move = false;
                    }
                    else
                    {
                        move = true;
                    }
                }
                else
                {
                    if (positionValue[23] != PlayerMark.Empty && positionValue[index + 1] != PlayerMark.Empty && positionValue[index + 3] != PlayerMark.Empty)
                    {
                        move = false;
                    }
                    else
                    {
                        move = true;
                    }
                }
            }
            else
            {
                if (index == 21)
                {
                    if (positionValue[0] != PlayerMark.Empty && positionValue[index + 1] != PlayerMark.Empty && positionValue[index - 3] != PlayerMark.Empty)
                    {
                        move = false;
                    }
                    else
                    {
                        move = true;
                    }
                }
                else if (index == 22)
                {
                    if (positionValue[1] != PlayerMark.Empty && positionValue[index + 1] != PlayerMark.Empty && positionValue[index - 3] != PlayerMark.Empty && positionValue[index - 1] != PlayerMark.Empty)
                    {
                        move = false;
                    }
                    else
                    {
                        move = true;
                    }
                }
                else
                {
                    if (positionValue[2] != PlayerMark.Empty && positionValue[index - 1] != PlayerMark.Empty && positionValue[index - 3] != PlayerMark.Empty)
                    {
                        move = false;
                    }
                    else
                    {
                        move = true;
                    }
                }
            }
            return move;
        }

        public bool ValidSecondClick(int previous, int current)
        {

            if (current % 3 == 0)
            {
                if (current == 0)
                {
                    if (previous == 21 || previous == 1 || previous == 3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (current == 21)
                {
                    if (previous == 22 || previous == 18 || previous == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (previous == current - 3 || previous == current + 1 || previous == current + 3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            else if ((current - 1) % 3 == 0)
            {
                if (current == 1)
                {
                    if (previous == 22 || previous == 2 || previous == 4 || previous == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (current == 22)
                {
                    if (previous == 19 || previous == 23 || previous == 1 || previous == 21)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (previous == current - 3 || previous == current + 1 || previous == current + 3 || previous == current - 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }

            else
            {
                if (current == 2)
                {
                    if (previous == 23 || previous == 1 || previous == 5)
                    {

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (current == 23)
                {
                    if (previous == 22 || previous == 20 || previous == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (previous == current - 3 || previous == current - 1 || previous == current + 3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool IsItCapture(int index)
        {
            if (index > 2 && index < 6 ||
                index > 8 && index < 12 ||
                index > 14 && index < 18)
            {
                if (index % 3 == 0)
                {
                    if (positionValue[index] == positionValue[index - 3] && positionValue[index] == positionValue[index + 3] ||
                    positionValue[index] == positionValue[index + 1] && positionValue[index] == positionValue[index + 2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if ((index - 1) % 3 == 0)
                {
                    if (positionValue[index] == positionValue[index - 3] && positionValue[index] == positionValue[index + 3] ||
                    positionValue[index] == positionValue[index - 1] && positionValue[index] == positionValue[index + 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (positionValue[index] == positionValue[index - 3] && positionValue[index] == positionValue[index + 3] ||
                    positionValue[index] == positionValue[index - 1] && positionValue[index] == positionValue[index - 2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }



            }

            else if (index > 20 && index < 24)
            {
                if (positionValue[index] == positionValue[index - 21] && positionValue[index] == positionValue[index - 3] ||
                    positionValue[index] == positionValue[21] && positionValue[index] == positionValue[22] && positionValue[index] == positionValue[23])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else if (index >= 0 && index < 3)
            {
                if (positionValue[index] == positionValue[index + 21] && positionValue[index] == positionValue[(index + 21) - 3] ||
                    positionValue[index] == positionValue[index + 3] && positionValue[index] == positionValue[index + 6] ||
                    positionValue[index] == positionValue[0] && positionValue[index] == positionValue[1] && positionValue[index] == positionValue[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                if (index % 3 == 0)
                {
                    if (index == 18)
                    {
                        if (positionValue[index] == positionValue[index - 3] && positionValue[index] == positionValue[index - 6] ||
                        positionValue[index] == positionValue[index + 3] && positionValue[index] == positionValue[0] ||
                        positionValue[index] == positionValue[index + 1] && positionValue[index] == positionValue[index + 2])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if ((positionValue[index] == positionValue[index - 3] && positionValue[index] == positionValue[index - 6]) ||
                        positionValue[index] == positionValue[index + 3] && positionValue[index] == positionValue[+6] ||
                        positionValue[index] == positionValue[index + 1] && positionValue[index] == positionValue[index + 2])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }




                }

                else if ((index - 1) % 3 == 0)
                {

                    if (index == 19)
                    {
                        if (positionValue[index] == positionValue[index - 3] && positionValue[index] == positionValue[index - 6] ||
                        positionValue[index] == positionValue[index + 3] && positionValue[index] == positionValue[1] ||
                        positionValue[index] == positionValue[index + 1] && positionValue[index] == positionValue[index - 1])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (positionValue[index] == positionValue[index - 3] && positionValue[index] == positionValue[index - 6] ||
                        positionValue[index] == positionValue[index + 3] && positionValue[index] == positionValue[index + 6] ||
                        positionValue[index] == positionValue[index + 1] && positionValue[index] == positionValue[index - 1])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }


                }

                else
                {

                    if (index == 20)
                    {
                        if (positionValue[index] == positionValue[index - 3] && positionValue[index] == positionValue[index - 6] ||
                        positionValue[index] == positionValue[index + 3] && positionValue[index] == positionValue[2] ||
                        positionValue[index] == positionValue[index - 1] && positionValue[index] == positionValue[index - 2])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (positionValue[index] == positionValue[index - 3] && positionValue[index] == positionValue[index - 6] ||
                        positionValue[index] == positionValue[index + 3] && positionValue[index] == positionValue[index + 6] ||
                        positionValue[index] == positionValue[index - 1] && positionValue[index] == positionValue[index - 2])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
            }
        }
    }
}
