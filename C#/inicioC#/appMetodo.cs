using System;

class Aula24{
    static void Main(){
      int divid, divis, quoc, rest;

      divid= 10;
      divis= 5;
      quoc=dividir(divid,divis,out rest);

      Console.WriteLine("{0}/{1}: quociente- {2} e resto={3}",divid,divis,quoc,rest);
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
    

    static int dividir(int dividendo, int divisor,out int resto ){

            int quociente;

            quociente = dividendo/divisor;
            resto = dividendo%divisor;

            return quociente;
    }


}

