using aula004_logica.calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula006_Explicacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Explicação conteudo variaveis"
            //variaveis
            sbyte _sbyte_de  = -128, _sbyte_ate = 127;
            byte _byte_de = 0, _byte = 255;

            //Int16
            short _short_de = -32768, _short_ate = 32767;
            
            //Uint
            ushort _ushot_de = 0, _ushor_ate = 65535;
           
            //Int32
            int _int_de = -2147483648, int_ate = 2147483647;

            //uint32
            uint _uint_de = 0, _uint_ate = 4294967295;

            //Int64
            long _long_de = -9223372036854775808, _long_ate = 9223372036854775807;
            Int64 _Int64_de = -9223372036854775808, _Int64_ate = 9223372036854775807;

            //UInt64
            ulong _ulong_de = 0,  _ulong_ate = 18446744073709551615;
            #endregion

            string str = "";

            string[] strArr = {"A","B","C","D"};

            foreach (string s in strArr)
            {
                Console.WriteLine(s);
            }
                            
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine($"Contador: {i}, valor:{strArr[i]}");
            }

            //int array
            int[] intArray = new int[2];
            intArray[0] = 1;
            intArray[1] = 0;

            //multidimensional
            string[,] tabuleiroXadrez = new string[8, 8];

            tabuleiroXadrez[0, 0] = "A1";
            tabuleiroXadrez[0, 1] = "A2";

            tabuleiroXadrez[7, 6] = "H7";
            tabuleiroXadrez[7, 7] = "H8";

            //generics
            List<string> listStrings = new List<string>();
            listStrings.Add("A");
            listStrings.Add("B");
            listStrings.Add("C");
            listStrings.Add("D");
            listStrings.Add("E");

            foreach (var s in listStrings)
            {
                Console.WriteLine(s);
            }
                List<Int64> numers = new List<long>();
            numers.Add(525);
            numers.Add(526);
            numers.Add(528);
            numers.Add(529);

            numers.Insert(2, 527);

            foreach (var s in numers)
            {
                Console.WriteLine(s);
            }

            //Lista de Objetos
            List<Calculadora> cauladors = new List<Calculadora>();

            Console.ReadKey();
        }
    }
}
