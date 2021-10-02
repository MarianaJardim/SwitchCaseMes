using System;

namespace UsandoSwitchCaseMes
{
    class Program
    {
        static void Main(string[] args)
        {


            int mes = 0;

            Console.WriteLine("Digite o mês na qual deseja saber a quantidade de dias");
            mes = Convert.ToInt16(Console.ReadLine());

            switch (mes)
            {
                case 1:

                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
                break;

                case 3: 

                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
                break;

                case 5: 

                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
                break;

                case 7:

                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
                break;

                case 8:

                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
                break;

                case 10:

                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
                break;

                case 12: 

                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
                break;

                case 2:

                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 28 dias, porém se for ano bissexto esse mês terá 29 dias!");
                break;

                default:

                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 30 dias!");
                break;

            }


        }
    }
}
