using System;

namespace cs_1._2_CalculaTriplo
{
    class Program
    {
        static void Main(string[] args) //comando de início do programa
        {
            double Num, Triplo; //declaração das variáveis do programa            
            Console.Clear(); //comando "LimpaTela" limpa a tela do monitor de vídeo
            //{Entrada dos dados}
            Console.WriteLine("Digite um número: "); //mensagem para que o usuário saiba o que deve fazer
            Num = double.Parse(Console.ReadLine()); //leitura do número para a memória
            //{Processamento}
            Triplo = Num * 3; //calcula o triplo e armazena o resultado na variável Triplo
            // {Saída da informação}
            Console.WriteLine(""); //apenas salta uma linha na tela do monitor de vídeo
            Console.WriteLine("O Triplo de " + Num + " é " + Triplo); //exibe o resultado            
        }//comando de fim do programa
    }
}
