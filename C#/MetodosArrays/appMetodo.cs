using System;

class Aula24{
    static void Main(){
       int num =10;
       dobrar(ref num);
       Console.WriteLine(num);
    }

// metodo void não retorna nada.
    static void hello(){
        Console.WriteLine("Hello word");
    }
// estrutura do metodo, nome, parametros, tipo, tipo de retorno. 

    static void soma (int n1, int n2){
        int res = n1 + n2;
        
        Console.WriteLine("A soma de {0} e {1} é :{2}",n1,n2,res);
    }

//  Metodos  com retorno deve ter o tipo do seu retorno informado. 
    static int somaRetorno (int n1, int n2){
        int res = n1 + n2;
        return res;
    }

//  uso de ref na função fará com que o valor do parametro usado sejá alterado na sua origem. 
    static void dobrar(ref int valor){
        valor*=2;
    }
}

