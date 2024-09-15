/*
1 - Somar

2 - Subtrair

3 - Multiplicar

4 - Dividir

0 - Sair
*/
namespace Calculadora{

    class Menu{
    
        static public void Main(){
        
            double resultado = 0.00;
            int escolha;
            
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine("Versão da Aplicação: 1.0");
            Console.WriteLine("Qual seu nome? ");
            string userName = Console.ReadLine()!;
            Console.WriteLine("Ok, "+ userName+"," +" escolha o tipo de calculo abaixo.");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            
            escolha = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informe um primeiro valor");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe um segundo valor");
            double value2 = Convert.ToDouble(Console.ReadLine());

            if(escolha == 1){
            resultado = value1 + value2;
            Console.WriteLine(userName+", "+"o resultado é "+resultado);
            }
            else if(escolha == 2){
            resultado = value1 - value2;
            Console.WriteLine(userName+", "+"o resultado é "+resultado);
            }
            else if(escolha == 3){
            resultado = value1 * value2;
            Console.WriteLine(userName+", "+"o resultado é "+resultado);
            }
            else if(escolha == 4){
                if(value2 != 0){
                    resultado = value1 / value2;
                    Console.WriteLine(userName+", "+"o resultado é "+resultado);
                }
                else{
                    Console.WriteLine("O divisor não pode ser 0");
                }
            }




            

        }

    }

}