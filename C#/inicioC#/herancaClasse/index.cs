using System;

class Veiculo{
    
    //Classe base

    private int rodas;
    public int velMax;

    private bool ligado;


    public Veiculo(int rodas){
        this.rodas =rodas;
    }

    public void desligado(){
        ligado = false;
    }

    public void ligar(){
        ligado = true;
    }

    public string getLigado(){
        return (ligado? "sim": "não");
       
    }

    public int getRodas(){
        return rodas;
    }

   
}


class Carro:Veiculo{
    
        public string nome;
        public string cor ; 


    public Carro(string nome, string cor):base(4){
        desligado();
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
         Console.WriteLine("Rodas...............: {0}.", c1.getRodas());
         Console.WriteLine("Velociadade maxima..: {0}.", c1.velMax);
         Console.WriteLine("Ligado..............: {0}.", c1.getLigado());
         
       
    }

}