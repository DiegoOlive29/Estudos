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

        Console.WriteLine("getLowerBound");
        int menorIndeceVetor =vetor1.GetLowerBound(0);
        int MenorindiceMatriz_d1= matriz.GetLowerBound(1);
        Console.WriteLine("menor indice do vetor1 {0}",menorIndeceVetor);

        Console.WriteLine("_____________________________________________");

        Console.WriteLine("GetUpperBound");
        int MaiorIndeceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_d1 = matriz.GetUpperBound(1);
        Console.WriteLine("menor indice do vetor1 {0}",MaiorIndeceVetor);

        Console.WriteLine("_____________________________________________");

        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da pisção 3 do vetor1 {0}",valor0);

        Console.WriteLine("_____________________________________________");
        Console.WriteLine("IndexOf: entrega a primeira aparição do valor mencionado, buscando em um array, lastIndexOf entrega a ultima aparição.");
        Console.WriteLine("Reverse, altera a onder dos valores do array deixando ao contrario");
        Console.WriteLine("Sort, altera a onder dos valores do array deixanto em ordem crescente.");  
    }

}