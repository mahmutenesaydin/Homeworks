using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorsAlfabesiOdev
{
    public class Character
    {
        protected char symbol;
        protected string morse;

        public void Display(TextBox txtMorse)
        {
            txtMorse.Text = this.morse;
        }
    }
    public class CharacterFactory
    {
        private Dictionary<char, Character> _characters = new Dictionary<char, Character>();
        public Character this[char key]
        {
            get
            {
                Character character = null;
                if (_characters.ContainsKey(    key))
                {
                    character = _characters[key];
                }
                else
                {
                    string name = this.GetType().Namespace + "." + "Character" + key.ToString();
                    character = (Character)Activator.CreateInstance(Type.GetType(name));
                }
                return character;
            }
        }
    }
    public class CharacterA : Character
    {
        public CharacterA()
        {
            symbol = 'A';
            morse = ".-";
        }
    }
    public class CharacterB : Character
    {
        public CharacterB()
        {
            symbol = 'B';
            morse = "-…";
        }
    }
    public class CharacterC : Character
    {
        public CharacterC()
        {
            symbol = 'C';
            morse = "-.-.";
        }
    }
    public class CharacterD : Character
    {
        public CharacterD()
        {
            symbol = 'D';
            morse = "-..";
        }
    }
    public class CharacterE : Character
    {
        public CharacterE()
        {
            symbol = 'E';
            morse = ".";
        }
    }
    public class CharacterF : Character
    {
        public CharacterF()
        {
            symbol = 'F';
            morse = "..-.";
        }
    }
    public class CharacterG : Character
    {
        public CharacterG()
        {
            symbol = 'G';
            morse = "--.";
        }
    }
    public class CharacterH : Character
    {
        public CharacterH()
        {
            symbol = 'H';
            morse = "....";
        }
    }
    public class CharacterI : Character
    {
        public CharacterI()
        {
            symbol = 'I';
            morse = "..";
        }
    }
    public class CharacterJ : Character
    {
        public CharacterJ()
        {
            symbol = 'J';
            morse = ".---";
        }
    }
    public class CharacterK : Character
    {
        public CharacterK()
        {
            symbol = 'K';
            morse = "-.-";
        }
    }
    public class CharacterL : Character
    {
        public CharacterL()
        {
            symbol = 'L';
            morse = ".-..";
        }
    }
    public class CharacterM : Character
    {
        public CharacterM()
        {
            symbol = 'M';
            morse = "--";
        }
    }
    public class CharacterN : Character
    {
        public CharacterN()
        {
            symbol = 'N';
            morse = "-.";
        }
    }
    public class CharacterO : Character
    {
        public CharacterO()
        {
            symbol = 'O';
            morse = "---";
        }
    }
    public class CharacterP : Character
    {
        public CharacterP()
        {
            symbol = 'P';
            morse = ".--.";
        }
    }
    public class CharacterQ : Character
    {
        public CharacterQ()
        {
            symbol = 'Q';
            morse = "--.-";
        }
    }
    public class CharacterR : Character
    {
        public CharacterR()
        {
            symbol = 'R';
            morse = ".-.";
        }
    }
    public class CharacterS : Character
    {
        public CharacterS()
        {
            symbol = 'S';
            morse = "...";
        }
    }
    public class CharacterT : Character
    {
        public CharacterT()
        {
            symbol = 'T';
            morse = "-";
        }
    }
    public class CharacterU : Character
    {
        public CharacterU()
        {
            symbol = 'U';
            morse = "..-";
        }
    }
    public class CharacterV : Character
    {
        public CharacterV()
        {
            symbol = 'V';
            morse = "...-";
        }
    }
    public class CharacterW : Character
    {
        public CharacterW()
        {
            symbol = 'W';
            morse = ".--";
        }
    }
    public class CharacterX : Character
    {
        public CharacterX()
        {
            symbol = 'X';
            morse = "-..-";
        }
    }
    public class CharacterY : Character
    {
        public CharacterY()
        {
            symbol = 'Y';
            morse = "-.--";
        }
    }
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            symbol = 'Z';
            morse = "--..";
        }
    }

    public class Character1 : Character
    {
        public Character1()
        {
            symbol = '1';
            morse = ".----";
        }
    }
    public class Character2 : Character
    {
        public Character2()
        {
            symbol = '2';
            morse = "..---";
        }
    }
    public class Character3 : Character
    {
        public Character3()
        {
            symbol = '3';
            morse = "...--";
        }
    }
    public class Character4 : Character
    {
        public Character4()
        {
            symbol = '4';
            morse = "....-";
        }
    }
    public class Character5 : Character
    {
        public Character5()
        {
            symbol = '5';
            morse = ".....";
        }
    }
    public class Character6 : Character
    {
        public Character6()
        {
            symbol = '6';
            morse = "-....";
        }
    }
    public class Character7 : Character
    {
        public Character7()
        {
            symbol = '7';
            morse = "--...";
        }
    }
    public class Character8 : Character
    {
        public Character8()
        {
            symbol = '8';
            morse = "---..";
        }
    }
    public class Character9 : Character
    {
        public Character9()
        {
            symbol = '9';
            morse = "----.";
        }
    }
    public class Character0 : Character
    {
        public Character0()
        {
            symbol = '0';
            morse = "-----";
        }
    }
}
