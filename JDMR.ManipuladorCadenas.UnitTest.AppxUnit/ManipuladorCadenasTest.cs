using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDMR.ManipuladorCadenas.UnitTest.AppxUnit
{
    public class ManipuladorCadenasTest
    {
        [Fact]
        public void ReverseStringTest()
        {
            StringManipulator stringManipulator = new StringManipulator();

            string cadena = "Hola Mundo";

            string resultado = stringManipulator.ReverseString(cadena);

            Assert.Equal("odnuM aloH", resultado);
        }

        [Fact]
        public void RemoveSpacesTest()
        {
            StringManipulator stringManipulator = new StringManipulator();

            string cadena = "Hola mundo !";

            string resultado = stringManipulator.RemoveSpaces(cadena);

            Assert.Equal("Holamundo!", resultado);

        }
    }
}
