
//Metodo sem uso de classes.Ficou

class RolarDado
{
    static void Main(string[] args)
    {



Console.Write("Digite o nome do jogador 1: ");
        string? NomePLayer1= Console.ReadLine();

        Console.Write("\nDigite o nome do jogador 2: ");
        string? NomePLayer2= Console.ReadLine();


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
           

        }


    }
}




