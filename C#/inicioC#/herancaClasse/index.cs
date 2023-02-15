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

    virtual public void info(){
        Console.WriteLine("Metodo Virtual");
    }

    public void setRodas(int n){
    if(n<0){
    this.rodas  = 0;

    }
    if(n>40){
    this.rodas  = 40;
    
    }else{
    this.rodas = n;
    }
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
    override public void info(){
        Console.WriteLine("Metodo Virtual reescrito");
    }
}

class CarroCombate:Carro{
    public int monicao;
    
    public CarroCombate():base("Carro Combate","Verde"){
        monicao =100;
        setRodas(6);

    }
}

class Index
{
    static void Main(){
        Carro c1 = new Carro("Creta", "Preto");
        CarroCombate cC1 = new CarroCombate();

        Console.WriteLine("Cor.................: {0}.", c1.cor);
        Console.WriteLine("Nome................: {0}.", c1.nome);
        Console.WriteLine("Rodas...............: {0}.", c1.getRodas());
        Console.WriteLine("Velociadade maxima..: {0}.", c1.velMax);
        Console.WriteLine("Ligado..............: {0}.", c1.getLigado());
        Console.WriteLine("......................................");
        Console.WriteLine("Cor.................: {0}.", cC1.cor);
        Console.WriteLine("Nome................: {0}.", cC1.nome);
        Console.WriteLine("Rodas...............: {0}.", cC1.getRodas());
        Console.WriteLine("Velociadade maxima..: {0}.", cC1.velMax);
        Console.WriteLine("Ligado..............: {0}.", cC1.getLigado());
        Console.WriteLine("Ligado..............: {0}.", cC1.monicao);
        c1.info();
    }

}