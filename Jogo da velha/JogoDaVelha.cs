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
using System.Reflection.Metadata.Ecma335;




public class  ForcaJogo
{   List<string>JogoForcaSemSeparacao=new List<string>();
    List<string>JogoForcaFilme=new List<string>();
    List<string>JogoForcaJogo=new List<string>();
    List<string>JogoForcaPaís=new List<string>();
 
    public ForcaJogo()
    {
        
        string Path=@"C:\Users\55119\Downloads\Vscode projetos\DotNetVSCode\DESAFIOS_EXERCICIOS C#\JogoDaForca.csv";
        
        string[] Line= File.ReadAllLines(Path);
        
            foreach (var item in Line)
            {
                 string[]columns=item.Split(';');

                foreach (var item2 in columns)
                {
                    JogoForcaSemSeparacao.Add(item2);
                }
            }
		/*Projeto não possui escalabilidade ainda.*/
	    
            JogoForcaFilme.Add(JogoForcaSemSeparacao[0]);//Loop de 3 em 3
            JogoForcaFilme.Add(JogoForcaSemSeparacao[3]);
            JogoForcaFilme.Add(JogoForcaSemSeparacao[6]);
            JogoForcaFilme.Add(JogoForcaSemSeparacao[9]);

            JogoForcaJogo.Add(JogoForcaSemSeparacao[1]);//Loop de 3 em 3
            JogoForcaJogo.Add(JogoForcaSemSeparacao[4]);
            JogoForcaJogo.Add(JogoForcaSemSeparacao[7]);
            JogoForcaJogo.Add(JogoForcaSemSeparacao[10]);

            JogoForcaPaís.Add(JogoForcaSemSeparacao[2]);//Loop de 3 em 3
            JogoForcaPaís.Add(JogoForcaSemSeparacao[5]);
            JogoForcaPaís.Add(JogoForcaSemSeparacao[8]);
            JogoForcaPaís.Add(JogoForcaSemSeparacao[11]);


    }



    public  string EmbaralhaPalavra()
    {
        Random random=new Random();
       
       
        int aleatorio=random.Next(0,JogoForcaSemSeparacao.Count);
       
       if(JogoForcaFilme.Contains(JogoForcaSemSeparacao[aleatorio]))
       {
        Console.WriteLine("\nClasse selecionada.\n   FILME.\n");
       }

        if(JogoForcaJogo.Contains(JogoForcaSemSeparacao[aleatorio]))
       {
        Console.WriteLine("\nClasse selecionada.\n   JOGO.\n");
       }

        if(JogoForcaPaís.Contains(JogoForcaSemSeparacao[aleatorio]))
       {
        Console.WriteLine("\nClasse selecionada.\n   PAÍS.\n");
       }
       
       return JogoForcaSemSeparacao[aleatorio];
        
    }

        public int Jogo(string? Word,string PalavraOriginal)
        {int Tentativas=3;
        
         Console.WriteLine(" Adivinhe a palavra sublinhada em 6 Tentativas.");
         

         char[] PalavraChar=Word!.ToCharArray();
         

        
         string PalavraParaRemocao=PalavraOriginal;   
         int Vitoria=0;
         
        
         while(Vitoria==0 )
         {   

            
            foreach (var item in PalavraChar)
            {
                Console.Write(item);
            }

            Console.Write("\n-Número de Tentativas:"+Tentativas+"\nDigite uma letra: ");
            Char C=Console.ReadKey().KeyChar;

            Console.WriteLine();
            /*WHILE fará repetição enquanto houver letras do char do usuario contido na palavra.*/
            if(PalavraParaRemocao.Contains(char.ToLower(C)) || PalavraParaRemocao.Contains(char.ToUpper(C)))
            {
                while(PalavraParaRemocao.Contains(char.ToLower(C)) || PalavraParaRemocao.Contains(char.ToUpper(C)))
                {
                    if(PalavraParaRemocao.Contains(char.ToLower(C)))
                    {
                        PalavraChar[PalavraParaRemocao.IndexOf(char.ToLower(C))]=char.ToLower(C);

                         int al=PalavraParaRemocao.IndexOf(char.ToLower(C));
                         char[] teste=PalavraParaRemocao.ToCharArray();
                            teste[al]=' ';
                            string? teste2=new string(teste);
                            PalavraParaRemocao=teste2;
                    }

                     else if(PalavraParaRemocao.Contains(char.ToUpper(C)))
                    {
                        PalavraChar[PalavraParaRemocao.IndexOf(char.ToUpper(C))]=char.ToUpper(C);

                        int al=PalavraParaRemocao.IndexOf(char.ToUpper(C));
                        char[] teste=PalavraParaRemocao.ToCharArray();
                        teste[al]=' ';
                        string? teste2=new string(teste);
                         PalavraParaRemocao=teste2;
                    }    
                }
                
            }

           
            else
            {

                
                Console.WriteLine($"\n\n{C} Era uma Letra Errada.\nTente com outra.");
                Tentativas--;
            }
            
            
            string Comparador=new string(PalavraChar);
           if(Comparador.ToUpper()==PalavraOriginal.ToUpper() && Tentativas>0)
            {
                Vitoria=1;
            }  

            else if(Tentativas<=0)
            {
                Vitoria=-1;
            }
            
            Console.Clear();//Deixa mais legivel na hora de digitar a letra.
         }

         return Vitoria;
        }


        public string? PalavraDica(string Palavra)
        {
            Random random=new Random();
            int b=Palavra.Length-1;
            int a=random.Next(1,b-1);
            int c=0;
            var Adivinhacao= new string('_',Palavra.Length);

            char[] ch=Palavra.ToCharArray();
            char[] Comparador=Palavra.ToCharArray();
            

            char cI=ch[0];
            char cF=ch[b];
            char cAleatorio=ch[a];
            

            ch=Adivinhacao.ToCharArray();
            ch[0]=cI;
            ch[b]=cF;
            ch[a]=cAleatorio;

            foreach (var item in Comparador)
            {
                if(Comparador[c]==' ')
                {
                    ch[c]=' ';
                }

                c++;
            }
            var Word= new string(ch);
                
                

            return Word;
        }
}
 

class Exercicios
{
      


    static void Main(string[] args)
    {   
        ForcaJogo fj=new ForcaJogo();
      
        string a=fj.EmbaralhaPalavra();
    
        
        string? aleatorio=fj.PalavraDica(a);
        int V=fj.Jogo(aleatorio,a);


        if(V==1)
        Console.WriteLine("\nParabéns você venceu!!!\nA palavra era: {0}",a);

        else
        Console.WriteLine("\nInfelizmente você perdeu.\nMais sorte na próxima.\nA palavra era: {0}",a);

	Console.ReadKey();

    }

}
    
    
