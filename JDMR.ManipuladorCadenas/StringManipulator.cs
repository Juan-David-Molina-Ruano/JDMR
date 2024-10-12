using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDMR.ManipuladorCadenas
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            //implementa la inversión de la cadena
            return new string(input.Reverse().ToArray());
        }

        public string RemoveSpaces(string input)
        {
            //implementa la eliminación de espacios
            return input.Replace(" ", "");
        }
    }
}
