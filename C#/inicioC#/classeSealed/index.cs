using System;

// sealed defini que a classe não pode ser herdada. 

sealed class Veiculo{
}



class Index{

    static void Main(){
        Carro carro1 = new Carro();

        Console.WriteLine(carro1.getVelatual());
 
    }
}