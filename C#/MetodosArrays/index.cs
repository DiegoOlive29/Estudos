using System;    

class index
{
    static void Main(){
        int[] vetor1=new int[5];
        int[] vetor2=new int[5];
        int[] vetor3=new int[5];
        int[] vetor4=new int[5];
        int[,] matriz=new int[2,5]{{11,22,00,44,55},{23,32,43,34,00}};

        Random random = new Random();

        for(int i=0; i<vetor1.Length;i++){
            vetor1[i]=random.Next(50);

        }
        Console.WriteLine("Elementos do Vetor1");
        
        foreach(int n in vetor1){
            Console.WriteLine(n);
           
        }
        Console.WriteLine("BinarySearch");
        int procurando =33;
        int pos=Array.BinarySearch(vetor1,procurando);
        Console.WriteLine("Valor {0} está na posição {1}",procurando,pos);
        Console.WriteLine("_____________________________________________");

        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach(int n in vetor2){
            Console.WriteLine(n);
            }

        Console.WriteLine("_____________________________________________");

        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int n in vetor3){
            Console.WriteLine(n);
            }

        Console.WriteLine("_____________________________________________");


    }

}