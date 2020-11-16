using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação \n soma subtração divisão ou multiplicação ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite um numero");
            float num1 = float.Parse( Console.ReadLine());
            
            Console.WriteLine("Digite outro");
            float num2 = float.Parse( Console.ReadLine());

            float result = 0 ;

            switch(operacao){
                case  "soma" :
                    result = num1+num2;
                    break;

                case "subtracao" :
                    result = num1-num2;
                    break;

                case "divisao" :
                    result = num1/num2;
                    break;

                case "multiplicacao" : 
                    result = num1*num2;
                    break;
            

                default:
                    Console.WriteLine("operacao invalida"); 
                    break;
                    
            }
            
        }
    }
}
