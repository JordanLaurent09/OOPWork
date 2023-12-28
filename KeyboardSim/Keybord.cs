using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardSim
{
    public class Keybord
    {
        public delegate void Press(string key); // Делегат, помогающий реализовать событие KeyPressed

        public event Press KeyPressed; // Событие, реагирующее на нажатие клавиши


        // Методы по эмуляции нажатия клавиши

        public void PressKeyB()
        {
            KeyPressed("B");
        }

        public void PressKeyA()
        {
            KeyPressed("A");
        }

        public void PressKeyC()
        {
            KeyPressed("C");
        }

        public void PressKeyD()
        {
            KeyPressed("D");
        }

        public void PressKeyE()
        {
            KeyPressed("E");
        }

        public void PressKeyF()
        {
            KeyPressed("F");
        }

        public void PressKeyG()
        {
            KeyPressed("G");
        }

        public void PressKeyH()
        {
            KeyPressed("H");
        }

        public void PressKeyI()
        {
            KeyPressed("I");
        }

        public void PressKeyJ()
        {
            KeyPressed("J");
        }

        public void PressKeyK()
        {
            KeyPressed("K");
        }

        public void PressKeyL()
        {
            KeyPressed("L");
        }

        public void PressKeyM()
        {
            KeyPressed("M");
        }

        public void PressKeyN()
        {
            KeyPressed("N");
        }

        public void PressKeyO()
        {
            KeyPressed("O");
        }

        public void PressKeyP()
        {
            KeyPressed("P");
        }

        public void PressKeyQ()
        {
            KeyPressed("Q");
        }

        public void PressKeyR()
        {
            KeyPressed("R");
        }

        public void PressKeyS()
        {
            KeyPressed("S");
        }

        public void PressKeyT()
        {
            KeyPressed("T");
        }

        public void PressKeyU()
        {
            KeyPressed("U");
        }

        public void PressKeyV()
        {
            KeyPressed("V");
        }
        public void PressKeyW()
        {
            KeyPressed("W");
        }

        public void PressKeyX()
        {
            KeyPressed("X");
        }

        public void PressKeyY()
        {
            KeyPressed("Y");
        }

        public void PressKeyZ()
        {
            KeyPressed("Z");
        }

        public void PressKey0()
        {
            KeyPressed("0");
        }

        public void PressKey1()
        {
            KeyPressed("1");
        }

        public void PressKey2()
        {
            KeyPressed("2");
        }

        public void PressKey3()
        {
            KeyPressed("3");
        }
        public void PressKey4()
        {
            KeyPressed("4");
        }

        public void PressKey5()
        {
            KeyPressed("5");
        }

        public void PressKey6()
        {
            KeyPressed("6");
        }

        public void PressKey7()
        {
            KeyPressed("7");
        }

        public void PressKey8()
        {
            KeyPressed("8");
        }

        public void PressKey9()
        {
            KeyPressed("9");
        }
    }
}
