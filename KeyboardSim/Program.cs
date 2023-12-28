using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Keybord keybord = new Keybord();

            Handler handler = new Handler();

            keybord.KeyPressed += handler.EmulationMessage;

            Console.WriteLine("Введите букву или цифру:");

            string key = Console.ReadLine();

            switch (key)
            {
                case "A":
                    keybord.PressKeyA();
                    break;
                case "B":
                    keybord.PressKeyB();
                    break;
                case "C":
                    keybord.PressKeyC();
                    break;
                case "D":
                    keybord.PressKeyD();
                    break;
                case "E":
                    keybord.PressKeyE();
                    break;
                case "F":
                    keybord.PressKeyF();
                    break;
                case "G":
                    keybord.PressKeyG();
                    break;
                case "H":
                    keybord.PressKeyH();
                    break;
                case "I":
                    keybord.PressKeyI();
                    break;
                case "J":
                    keybord.PressKeyJ();
                    break;
                case "K":
                    keybord.PressKeyK();
                    break;
                case "L":
                    keybord.PressKeyL();
                    break;
                case "M":
                    keybord.PressKeyM();
                    break;
                case "N":
                    keybord.PressKeyN();
                    break;
                case "O":
                    keybord.PressKeyO();
                    break;
                case "P":
                    keybord.PressKeyP();
                    break;
                case "Q":
                    keybord.PressKeyQ();
                    break;
                case "R":
                    keybord.PressKeyR();
                    break;
                case "S":
                    keybord.PressKeyS();
                    break;
                case "T":
                    keybord.PressKeyT();
                    break;
                case "U":
                    keybord.PressKeyU();
                    break;
                case "V":
                    keybord.PressKeyV();
                    break;
                case "W":
                    keybord.PressKeyW();
                    break;
                case "X":
                    keybord.PressKeyX();
                    break;
                case "Y":
                    keybord.PressKeyY();
                    break;
                case "Z":
                    keybord.PressKeyZ();
                    break;
                case "0":
                    keybord.PressKey0();
                    break;
                case "1":
                    keybord.PressKey1();
                    break;
                case "2":
                    keybord.PressKey2();
                    break;
                case "3":
                    keybord.PressKey3();
                    break;
                case "4":
                    keybord.PressKey4();
                    break;
                case "5":
                    keybord.PressKey5();
                    break;
                case "6":
                    keybord.PressKey6();
                    break;
                case "7":
                    keybord.PressKey7();
                    break;
                case "8":
                    keybord.PressKey8();
                    break;
                case "9":
                    keybord.PressKey9();
                    break;
            }


        }
    }
}
