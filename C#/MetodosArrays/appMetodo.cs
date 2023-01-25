using System;

class Aula24{
    static void Main(){
        int r, v1 ,v2;
        v1=Convert.ToInt32(Console.ReadLine());
        v2=Convert.ToInt32(Console.ReadLine());
        
        
        r = somaRetorno(v1,v2);
        Console.WriteLine(r);
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

    static int somaRetorno (int n1, int n2){
        int res = n1 + n2;
        return res;
    }
}