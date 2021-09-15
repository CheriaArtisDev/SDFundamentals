using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // declaring a variable using camel cased name
            bool isDeclared;

            // initializing a variable
            isDeclared = true;

            // declaring and initializing in one step
            bool isDeclaredInitialized = true;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            // int short byte long int16 int32 int64
            // 2^8
            byte byteExample = 255;
            sbyte sByteExample = -128;

            // 2^16
            short shortExample = 128;
            Int16 int16Example = -32768;

            // 2^32
            int intMax = 2147483647;
            Int32 intMin = -2147483648;
            uint inSignedInt = 2147483648;

            // 2^64
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            //decimal double
            float floatExample = 1.9238575f;
            double doubleExample = 1.9238575d;
            decimal decimalExample = 1.9238575m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);

        }

        //Enum
        private enum PastryTypes { Eclaire, Croissant, Petitfour, Cake, Cupcake }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Enums()
        {
            PastryTypes mPastry = PastryTypes.Croissant;
            PastryTypes anotherOne = PastryTypes.Cake;
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;

            DateTime today = DateTime.Today;

            DateTime specificDate = new DateTime(2021, 9, 14);

            DateTime todayTwo = today;

            var variable = today;
            // variable = 'a';
        }
    }

}
