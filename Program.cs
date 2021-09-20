using System;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Pedra; 2 - Papel; 3 - Tesoura");
            Console.WriteLine("Informe primeira mão:");
            string value1 = Console.ReadLine();
            Console.WriteLine("Informe segunda mão:");
            string value2 = Console.ReadLine();

            //int[,] matriz = { { 0, 1, 0 }, { 0, 0, 1 }, { 1, 0, 0 } };
            if (int.TryParse(value1, out int v1) && int.TryParse(value2, out int v2))
            {
                string[,] matrizresult = { { "Empate", "Segunda mão vence", "Primeira mão vence" }, { "Primeira mão vence", "Empate", "Segunda mão vence" }, { "Segunda mão vence", "Primeira mão vence", "Empate" } };
                Console.Write(matrizresult[v1 - 1, v2 - 1]);
                //if (matriz[v1-1,v2-1] == 1)
                //{
                //    Console.WriteLine("Segunda mão vence");
                    
                //}else if (matriz[v2-1, v1-1] == 1)
                //{
                //    Console.WriteLine("Primeira mão vence");
                //}
                //else
                //{
                //    Console.WriteLine("Empate");
                //}
            }

            //bool pedra1=false;
            //bool papel1 = false;
            //bool tesoura1 = false;
            //switch (value1)
            //{
            //    case "1":
            //        pedra1 = true;
            //        break;
            //    case "2":
            //        papel1 = true;
            //        break;
            //    case "3":
            //        tesoura1 = true;
            //        break;
            //}
            //bool pedra2 = false;
            //bool papel2 = false;
            //bool tesoura2 = false;
            //switch (value2)
            //{
            //    case "1":
            //        pedra2 = true;
            //        break;
            //    case "2":
            //        papel2 = true;
            //        break;
            //    case "3":
            //        tesoura2 = true;
            //        break;
            //}
            //if((pedra1 && pedra2)||(papel1 && papel2)||(tesoura1 && tesoura2))
            //{
            //    Console.WriteLine("Empate");
            //}else if ((pedra1 && tesoura2) || (tesoura1 && papel2) || (papel1 && pedra2))
            //{
            //    Console.WriteLine("Primeira mão vence");
            //}
            //else
            //{
            //    Console.WriteLine("Segunda mão vence");
            //}
            Console.ReadLine();
        }
    }
}
