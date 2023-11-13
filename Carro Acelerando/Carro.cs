using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Net.Mail;
using System.ComponentModel;
using Ajuda;
using System.Reflection.Metadata.Ecma335;




public abstract class Car
{
    public virtual string? Modelo{get;set;}
    public virtual string? Marca{get;set;}
    public double velocidadeAtual=0;
    public virtual double VelMax{get;set;}
    public double acelerar=50;


}        
    
    public class Porsche:Car
    {
    public override string Marca
    {
        get { return "Porsche"; }
        
    }

     public override string Modelo
    {
        get { return "Porsche 917"; }
        
    }

    public override double VelMax
    {
        get { return 355.858; } 
    }

    public void aceleracao(ConsoleKeyInfo c)
    {
        while(c.Key == ConsoleKey.UpArrow)
        {
            velocidadeAtual+=acelerar;
		
		if(velocidadeAtual>VelMax)
		{
			Console.WriteLine($"\nVelocidade Máxima atingida:{VelMax}Km/h");
			velocidadeAtual=VelMax;
		}

		
		else
            Console.WriteLine("\nVelocidade atual: "+velocidadeAtual+"Km/h");

            c=Console.ReadKey();
        }

    }

    public void frear(ConsoleKeyInfo c)
    {
        while (c.Key == ConsoleKey.DownArrow && velocidadeAtual>0)
        {
         double f= velocidadeAtual*(13.6/100);
         velocidadeAtual=velocidadeAtual-f;
            Console.WriteLine("\nVelocidade atual: "+velocidadeAtual+"Km/h");

            c=Console.ReadKey();
        }
        
        
            
    }
}


class Exercicios
{
      


    static void Main(string[] args)
    {    
     Porsche porsche917=new Porsche();

     Console.WriteLine("Marca do carro: "+porsche917.Marca+".\nModelo do Carro: "+porsche917.Modelo);
     Console.WriteLine();

     Console.WriteLine("Pressione UpArrow para acelerar o carro.\nPressione UpDown para desacelerar o carro.\nPressione Esc para fechar o programa.\n ");

      Console.WriteLine("Velocidade atual: "+porsche917.velocidadeAtual);
        
        ConsoleKeyInfo Cki;
        do
        {
            Console.WriteLine("\nPressione a tecla: ");
            ConsoleKeyInfo controle = Console.ReadKey();

            if (controle.Key == ConsoleKey.UpArrow)
                porsche917.aceleracao(controle);

            if (controle.Key == ConsoleKey.DownArrow)
                porsche917.frear(controle);

                else
                Console.WriteLine("\nNenhuma das teclas pressionadas.\n");


            Cki = Console.ReadKey();

        } while (Cki.Key != ConsoleKey.Escape);

    }
        
        

    }  

        /* Implemente uma classe chamada “Carro” com atributos para armazenar a marca, o modelo e a velocidade atual do carro. Adicione métodos para acelerar, frear e exibir a velocidade
    
        



    

    








 





/*Desafio Rolar dado.
 Console.Write("Digite o nome do jogador 1: ");
        string NomePLayer1= Console.ReadLine();

        Console.Write("\nDigite o nome do jogador 2: ");
        string NomePLayer2= Console.ReadLine();


        while(NomePLayer1==NomePLayer2)
        {
            Console.WriteLine("Digite um nome diferente para o segundo jogador.");
            NomePLayer2= Console.ReadLine();
        }

        Random random=new Random();

        int P1G;
        int P2G;
        int Rounds=0;

        int RP1=0;
        int Rp2=0;

        Console.WriteLine("O programa sorteará um numero aleatorio para cada jogador. Aquele que tiver 3 vitórias ganha.");
        Console.WriteLine("Pressione qualquer tecla para começar.");
        Console.ReadKey();
        

        while(Rounds<3)
        {

           P1G= random.Next(1,6);
           P2G=random.Next(1,6);

           if(P1G>P2G)
           {
            Console.WriteLine($"\n{NomePLayer1} Tirou o número {P1G}.\n{NomePLayer2} Tirou o número {P2G}.\nPortanto o vencedor desse Round foi {NomePLayer1}.");
            RP1++;
             Console.WriteLine($"PLacar atual:[{RP1}][{Rp2}]");
             Console.WriteLine("Pressione qualquer tecla para continuar.");
             Console.ReadKey();
             Thread.Sleep(1000);
           }
           else if(P2G>P1G)
           {
             Console.WriteLine($"\n{NomePLayer1} Tirou o número {P1G}.\n{NomePLayer2} Tirou o número {P2G}.\nPortanto o vencedor desse Round foi {NomePLayer2}.");
             Rp2++;
             Console.WriteLine($"PLacar atual:[{RP1}][{Rp2}]");
             Console.WriteLine("Pressione qualquer tecla para continuar.");
             Console.ReadKey();
             Thread.Sleep(1000);
           }
           else{
            Console.WriteLine($"\n{NomePLayer1} Tirou o número {P1G}.\n{NomePLayer2} Tirou o número {P2G}.\nPortanto Round Empatado.");
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Thread.Sleep(1000);
           }


            if(Rp2==3){
                Console.WriteLine($"\nParabéns {NomePLayer2}, vôce venceu!!.\nPlacar final[{RP1}]|[{Rp2}]");
                Rounds=3;
            }

             if(RP1==3){
                Console.WriteLine($"\nParabéns {NomePLayer1}, vôce venceu!!.\nPlacar final[{RP1}]|[{Rp2}]");
                Rounds=3;
            }
           

        }*/

/*Calculadora
        static int Potenciacao(int a,int b)
        {
            if(b==0)
            {
                return 1;
            }

            return a*Potenciacao(a,b-1);
        }



    static void Main(string[] args)
    {   
        int decisão;
        int sair=0;
        while(sair==0)
        {
                Console.Write("\nDigite um número para efetuar uma operação: ");
                int N1= Convert.ToInt32(Console.ReadLine());

                Console.Write("\nDigite outro número para efetuar uma operação: ");
                int N2= Convert.ToInt32(Console.ReadLine());


                Console.Write("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Resto da divisão\n6 - Potenciação\n0 - Sair\nOpção escolhida:");
                decisão =Convert.ToInt32(Console.ReadLine());

                switch(decisão)
                {
                    case 0:
                    Console.WriteLine("A opção sair foi selecionada.");
                    sair=1;
                    break;
                    
                    case 1:
                    Console.WriteLine($"Soma selecionada.\nResultado:{N1+N2}");
                    break;

                    case 2:
                    Console.WriteLine($"Subtração selecionada.\nResultado:{N1-N2}");
                    break;

                    case 3:
                    Console.WriteLine($"Multiplicação selecionada.\nResultado:{N1*N2}");
                    break;

                    case 4:
                    if(N1==0 | N2==0)
                    {  
                         Console.WriteLine("Não existe divisão por zero.");
                    }
                    else
                    {
                        decimal divisao=N1/N2;
                    Console.WriteLine($"Divisão selecionada.\nResultado:{divisao}");
                    }
                    break;

                      case 5:
                    if(N1==0 | N2==0)
                    {  
                         Console.WriteLine("Não existe divisão por zero.");
                    }
                    else
                    {
                        decimal divisaoR=N1%N2;
                    Console.WriteLine($"Resto da divisão selecionada.\nResultado:{divisaoR}");
                    }
                    break;


                    case 6:
                    Console.WriteLine($"Potenciação selecionada.\n{N1} elevado a {N2}.\nResultado:{Potenciacao(N1,N2)}");
                    break;

                    default:
                    Console.WriteLine("Digite um dos números mencionados.");
                    break;  
                }*/

/*Calcula media

int repetidor=1;
        int repetidorMinMax=3;
        List<int> lista=new List<int>(10);
        int Confirmacao;
        int confirmRepeticao;
       

            while(repetidor<=repetidorMinMax)
            {
                Console.Write("Digite os valores para calcularmos a média: ");
                lista.Add(int.Parse(Console.ReadLine()));

                if(repetidor==3)
                {
                    Console.WriteLine("Deseja continuar a inserir valores?\nCaso Sim, digite 1, do contrario digite qualquer coisa.");
                    Confirmacao=int.Parse(Console.ReadLine());

                    switch(Confirmacao)
                    {
                        case 1:
                        Console.Write($"Digite o número limite de notas.\nLimite: ");
                        
                        confirmRepeticao=int.Parse(Console.ReadLine());
                        if(confirmRepeticao>3 && confirmRepeticao<=10){

                        
                        repetidorMinMax=confirmRepeticao;
                        Console.WriteLine($"Muito bem. O limite de notas foi aumentado para {repetidorMinMax}.");
                        }
                        else
                        {
                            Console.WriteLine("Pelo fato do número digitado ser menor que três/ou Maior que 10.\nO limite continua 3.");
                            Thread.Sleep(2000);
                        }
                        break;

                        default:
                        Console.WriteLine("Muito bem. O limite de notas continua 3.");
                        break;
                    }
                }
                repetidor++;
            }
               
            //foreach(int n in lista) usei foreach como meio de computar a media,pórem o metodo sum e average não é necessario executar nenhum outro laço de repetição.
    
            Console.WriteLine($"\nO valor de todas as notas somadas na Lista: {lista.Sum()}");
            Console.WriteLine($"A média é: {lista.Average()}");
*/

/*Conversão moedas
enum Moedas{nada,Dólar, Euro, Iene, LibraEsterlina}
    static void Main(string[] args)
    {
        Console.Write(" Valor em Real(R$) Que será convertida: ");
        string b =(Console.ReadLine());

        b=b.Replace('.',',');//Caso o usuario utilize o ponto.

        Console.WriteLine("\nInforme de acordo com o digito qual a moeda que deseja converter:\n|1-dólar($)|\n|2-euro(€)|\n|3-iene(¥)|\n|4-libra esterlina(£)|");
        int moeda= int.Parse(Console.ReadLine());

        Dictionary<int,double> Valor=new Dictionary<int, double>();

        Valor.Add(1,4.50);
        Valor.Add(2,6.20);
        Valor.Add(3,0.052);
        Valor.Add(4,6.95);
        

        if(moeda>0 && moeda<5)
        {
        Moedas n=(Moedas)moeda;
        Console.Write(n);
        Console.Write($" vale: "+Valor[moeda]+$" em relação a R$1,00.\n A quantia de R${b} equivale À ");

        var Real= Convert.ToDouble(b);
        Console.WriteLine(Real/Valor[moeda] + $" em {n}.\n");

        }
        else
        {
            Console.WriteLine("\nO Digito/Texto não confere com o esperado.\n Tente inserir o valor correto.\n");
        }
    }*/