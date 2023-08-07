using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }
        static void Menu()
        {
          Console.Clear();
          
          Console.WriteLine("Qual operação deseja realizar?");
          Console.WriteLine("1 - Adição");
          Console.WriteLine("2 - Subtração");
          Console.WriteLine("3 - Divisão");
          Console.WriteLine("4 - Multiplicação");
          Console.WriteLine("5 - Raiz Quadrada");
          Console.WriteLine("6 - Porcentagem");
          Console.WriteLine("0 - Sair");
          Console.WriteLine("----------------");
          Console.WriteLine("Selecione uma opção");

          short res = short.Parse(Console.ReadLine());
           switch(res)
            {
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: RaizQuadrada(); break;
                case 6: Porcentagem(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
          
        }
        static void Adicao(){
           Console.Clear();
           Console.WriteLine("Primeiro valor: ");
           float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Segundo valor: ");
           float v2 = float.Parse(Console.ReadLine());

           Console.WriteLine("");

           float resultado = v1 + v2;
           Console.WriteLine($"O resultado da adição é: {resultado}");

           Console.ReadKey();
           Menu();
        }

        static void Subtracao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Console.ReadKey();
            Menu();

        }
        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Console.ReadKey();
            Menu();
        }
        static void RaizQuadrada(){
           Console.Clear();
           Console.WriteLine("Digite o número: ");
           float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("");

           double raiz = Math.Sqrt(v1);
           Console.WriteLine($"A raiz quadrada é: {raiz}");

           Console.ReadKey();
           Menu();
        
    }
    static void Porcentagem(){
           Console.Clear();
           Console.WriteLine("Digite a %: ");
           float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Digite o valor: ");
           float v2 = float.Parse(Console.ReadLine());

           Console.WriteLine("");

           float resultado = (v1 * v2);
           float porcentagem = resultado / 100;
           Console.WriteLine($"O resultado é: {porcentagem}%");

           Console.ReadKey();
           Menu();
        }
        
}
}

