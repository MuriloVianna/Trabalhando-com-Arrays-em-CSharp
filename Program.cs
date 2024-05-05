using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ForEachArray();
        }

        static void Arrays()
        {
            var meuArray = new int[2];      //declarando um array
            meuArray[0] = 12;               //atribuindo valores
            meuArray[1] = 36;
            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);

            var meuArray2 = new int[4] { 16, 84, 98, 5 };       //outra forma de atribuir valores
            Console.WriteLine(meuArray2[0]);
            Console.WriteLine(meuArray2[1]);
            Console.WriteLine(meuArray2[2]);
            Console.WriteLine(meuArray2[3]);
        }

        static void PercorrendoArray()
        {
            var meuArray = new int[5] { 55, 7, 4, 61, 5 };

            for (var index = 0; index < meuArray.Length; index++)      //meuArray.Length pega o tamanho do array
            {                                                          //for percorre o array escrevendo na tela cada valor 
                Console.WriteLine(meuArray[index]);
            }
        }

        static void ForEachArray()  //ForEach vai percorrer todos os itens 
        {
            var meuArray = new int[5] { 55, 7, 4, 61, 5 };

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}