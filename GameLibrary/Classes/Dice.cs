using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Classes
{
    public class Dice : Random
    {
        private Dice() { }

        private static Dice instance = null;

        public static Dice GetInstance()
        {
            if (instance == null)
            {
                instance = new Dice();
            }
            return instance;
        }
    }
}
