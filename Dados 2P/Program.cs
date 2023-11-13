//Metodo Com uso de classes.


public class RolarDado
{
    Random r=new Random();
    
    private int Rounds {get;set;}
    private int CondicaoEspecial {get;set;}
    public string? NomePLayer1 { get; set; }
    public string? NomePLayer2 { get; set; }

      int P1NumeroDoDado;
      int P2NumeroDoDado;

        int PlacarP1=0;
        int PlacarP2=0;

    public void ValidacaoDeNome()
    {
        Console.Write("Digite o nome do jogador 1: ");
        NomePLayer1= Console.ReadLine();

        Console.Write("\nDigite o nome do jogador 2: ");
        NomePLayer2= Console.ReadLine();


        while(NomePLayer1!.Equals(NomePLayer2,StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("\nDigite um nome diferente para o segundo jogador.");
            NomePLayer2= Console.ReadLine();
        }
    }


    public void SelecaoDeRounds()
    {
        Console.Write("\nDigite o Número de Rounds\nOpções: 3, 6 e 9.\nEscolha: ");
        int a=Convert.ToInt32(Console.ReadLine());

        switch(a)
        {
            case 3:
                Rounds=a;
                 Console.Write($"\nSerão jogados {a} Rounds.\nE em caso de empate Vem a prorrogação. ");
            break;

             case 6:
                Rounds=a;
                Console.Write($"\nSerão jogados {a} Rounds.\nE em caso de empate Vem a prorrogação. ");
            break;

             case 9:
                Rounds=a;
                Console.Write($"\nSerão jogados {a} Rounds.\nE em caso de empate Vem a prorrogação. ");
            break;

            default:
                Rounds=3;
                Console.Write("\nPor padrão serão jogados {Rounds} Rounds.\nE em caso de empate Vem a prorrogação. ");
            break;
        }
    }


    public int JogoEmCondicaoNormal()
    {   Console.Write("\nSerão Sorteados os números nos dados.\nQuem obtiver o maior número ganha aquele Round.\nPressione Qualquer Tecla Para começar.");
     Console.ReadKey();
        while(Rounds>0)
        {
            P1NumeroDoDado=r.Next(1,6);
            P2NumeroDoDado=r.Next(1,6);

            Console.WriteLine($"\nNúmero de Rounds restantes:[{Rounds}].");
            if(P1NumeroDoDado>P2NumeroDoDado)
            {
                 Console.WriteLine($"\n{NomePLayer1} Tirou o número {P1NumeroDoDado}.\n{NomePLayer2} Tirou o número {P2NumeroDoDado}.\nPortanto o vencedor desse Round foi {NomePLayer1}.");
                    PlacarP1++;
                    Console.WriteLine($"PLacar atual:[{PlacarP1}][{PlacarP2}]");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
            }
            else if(P2NumeroDoDado>P1NumeroDoDado)
            {
                Console.WriteLine($"\n{NomePLayer1} Tirou o número {P1NumeroDoDado}.\n{NomePLayer2} Tirou o número {P2NumeroDoDado}.\nPortanto o vencedor desse Round foi {NomePLayer2}.");
                    PlacarP2++;
                    Console.WriteLine($"PLacar atual:[{PlacarP1}][{PlacarP2}]");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\n{NomePLayer1} Tirou o número {P1NumeroDoDado}.\n{NomePLayer2} Tirou o número {P2NumeroDoDado}.\nPortanto, Round Empatado.");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
            }


                Rounds--;

               if(Rounds==0 & PlacarP1==PlacarP2)
               {
                CondicaoEspecial=1;
               }

               
        }
            return CondicaoEspecial;
    }




    public void Prorrogacao_E_Declaracao_De_Vitoria(int empate)
    {
        if(empate==1)
        {   Console.WriteLine("O jogo proseguirá até seu desempate.");
            while(PlacarP1==PlacarP2)
            {
                P1NumeroDoDado=r.Next(1,6);
                P2NumeroDoDado=r.Next(1,6);

                if(P1NumeroDoDado>P2NumeroDoDado)
            {
                 Console.WriteLine($"\n{NomePLayer1} Tirou o número {P1NumeroDoDado}.\n{NomePLayer2} Tirou o número {P2NumeroDoDado}.\nPortanto o vencedor desse Round foi {NomePLayer1}.");
                    PlacarP1++;
                    Console.WriteLine($"PLacar atual:[{PlacarP1}][{PlacarP2}]");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
            }
            else if(P2NumeroDoDado>P1NumeroDoDado)
            {
                Console.WriteLine($"\n{NomePLayer1} Tirou o número {P1NumeroDoDado}.\n{NomePLayer2} Tirou o número {P2NumeroDoDado}.\nPortanto o vencedor desse Round foi {NomePLayer2}.");
                    PlacarP2++;
                    Console.WriteLine($"PLacar atual:[{PlacarP1}][{PlacarP2}]");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\n{NomePLayer1} Tirou o número {P1NumeroDoDado}.\n{NomePLayer2} Tirou o número {P2NumeroDoDado}.\nPortanto, Round Empatado.");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
            }

            }
        }

        else
        {
             if(PlacarP1>PlacarP2){
                Console.WriteLine($"\nParabéns {NomePLayer1}, vôce venceu!!.\nPlacar final[{PlacarP1}]|[{PlacarP2}]");
                
            }

             else{
                Console.WriteLine($"\nParabéns {NomePLayer2}, vôce venceu!!.\nPlacar final[{PlacarP1}]|[{PlacarP2}]");
                
            }
        }

    }


}






class JogoDado
{
    static void Main(string[] args)
    {

        RolarDado game=new RolarDado();

        game.ValidacaoDeNome();

        game.SelecaoDeRounds();

        int Auxiliar=game.JogoEmCondicaoNormal();

        game.Prorrogacao_E_Declaracao_De_Vitoria(Auxiliar);

    }
}

