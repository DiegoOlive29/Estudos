using System;

//Interfaces são semelhantes a classes abstratas porem elas só implementão metodos ou os prototipos dos metodos.
//Uma classe pode herdar mais de uma interface. 
// não pode ter contrutor ou destrutor




public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}
public interface Esportivo{
    void velMax(int a);

}



 class Carro:Veiculo,Esportivo{
     public bool ligado;
    public void ligar(){
        ligado= true;
    }
    public void desligar(){
        ligado = false;
    }
    public void info(){
        Console.WriteLine("O carro esta {0}",ligado);
    }
    public Carro(){
       
    }
    public int velM;
    public void velMax(int a){
        if(a >0){
        velM = a;
        }else{
            velM =100;
        }
    }
}
class Index{
  static void Main(){
        Carro c1 = new Carro();
    }

}
