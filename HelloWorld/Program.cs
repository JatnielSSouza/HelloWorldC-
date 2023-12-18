using System;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hello World!");

            sbyte x = 100;

            Console.WriteLine(x);


            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F'; //Representação de um caractere.
            Console.WriteLine(genero);

            char letra = '\u0041'; //Código unicode.
            Console.WriteLine(letra);

            float n1 = 4.5f; //Necessário f no final para indicar dados do tipo float.
            Console.WriteLine(n1);

            double n2 = 4.5; //Não precisa de indicação.
            Console.WriteLine(n2);

            int n3 = 5;
            Console.WriteLine(n3);

            string nome = "Maria"; //Representação de string necessita de aspas duplas.
            Console.WriteLine(nome);

            //object = a dados genéricos:
            object obj1 = "NomePessoa"; //Objeto do tipo string.
            Console.WriteLine(obj1);

            object obj2 = 4.5f; //Objeto do tipo float.
            Console.WriteLine(obj2);

            int n4 = int.MinValue; //Valor mínimo da variável (dado) do tipo inteiro.
            Console.WriteLine(n4);

            int n5 = int.MaxValue; //Valor máximo da variável (dado) do tipo inteiro.
            Console.WriteLine(n5);







        }
    }
}

