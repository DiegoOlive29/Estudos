using System;

class Veiculo{
    
    //Classe base

    public int rodas;
    public int velMax;

    private bool ligado;

    public void desligado(){
        ligado = false;
    }

    public void ligar(){
        ligado = true;
    }

    public string getLigado(){
        if(ligado){
            return "sim";


        }else{
            return "não";
        }
    }

   
}


class Carro:Veiculo{
    
        public string nome;
        public string cor ; 


    public Carro(string nome, string cor){
        desligado();
        rodas  = 4 ;
        velMax = 150 ; 
    
        this.nome = nome;
        this.cor  = cor;


        
    }
}

class Index
{
    static void Main(){
         Carro c1 = new Carro("Creta", "Preto");

         Console.WriteLine("Cor.................: {0}.", c1.cor);
         Console.WriteLine("Nome................: {0}.", c1.nome);
         Console.WriteLine("Rodas...............: {0}.", c1.rodas);
         Console.WriteLine("Velociadade maxima..: {0}.", c1.velMax);
         Console.WriteLine("Ligado..............: {0}.", c1.getLigado());
         
       
    }

}