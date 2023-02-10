using System;

class Veiculo{

    public int velAtual;

    private int velMax;

    protected bool ligado;


    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;

    }
    public int getVelMax(){
        return velMax;
    }
    public string getLigado(){
        return (ligado? "sim": "não");
    }
}

class Carro:Veiculo{ //derivado de veiculo
    public string nome;
    public Carro(string nome, int vM):base(vM){
        this.nome =nome;
        ligado = true;
        
    }
}

class index{

    static void Main(){
        Carro c1= new Carro ("Celta",120);
        Console.WriteLine("Nome do carro : {0}",c1.nome);
        Console.WriteLine("Vel.maxima : {0}", c1.getVelMax());
        Console.WriteLine("O carro esta ligado ? {0}", c1.getLigado());


    }
}