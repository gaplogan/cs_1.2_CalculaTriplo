using System;

namespace cs_1._2_CalculaTriplo
{
    class Program
    {
        static void Main(string[] args) //comando de in�cio do programa
        {
            double Num, Triplo; //declara��o das vari�veis do programa            
            Console.Clear(); //comando "LimpaTela" limpa a tela do monitor de v�deo
            //{Entrada dos dados}
            Console.WriteLine("Digite um n�mero: "); //mensagem para que o usu�rio saiba o que deve fazer
            Num = double.Parse(Console.ReadLine()); //leitura do n�mero para a mem�ria
            //{Processamento}
            Triplo = Num * 3; //calcula o triplo e armazena o resultado na vari�vel Triplo
            // {Sa�da da informa��o}
            Console.WriteLine(""); //apenas salta uma linha na tela do monitor de v�deo
            Console.WriteLine("O Triplo de " + Num + " � " + Triplo); //exibe o resultado            
        }//comando de fim do programa
    }
}
