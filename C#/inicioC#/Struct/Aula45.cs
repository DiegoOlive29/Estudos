using System;

//  Struct não é uma class 

struct Cart{
    
    public string modelo;
    public string cor;

   public void info(){
    Console.WriteLine("Marca.: {0}",this.modelo);
    Console.WriteLine("Cor...: {0}",this.cor);
    Console.WriteLine("........................");

    }

    

}

class Aula44 {
    static void Main(){
        Cart[] carros =new Cart[5];
        carros[0].modelo="hrv";
        carros[0].cor="Vermelho";

        carros[1].modelo="Gol";
        carros[1].cor="Vermelho";

        carros[2].modelo="WRV";
        carros[2].cor="Vermelho";
       
        carros[3].modelo="fusca";
        carros[3].cor="azul";
        
        carros[4].modelo="jeta";
        carros[4].cor="azul";

        for (int i = 0; i < carros.Length; i++)
        {
                 carros[i].info();
        };
   

    }
}