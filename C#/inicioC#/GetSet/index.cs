using System;

// sealed defini que a classe não pode ser herdada. 

sealed class Carro
{
    private int velMAX;

   

    public int vm
    {
        get
        {
            return velMAX;
        }
        //poder ser colocado somente um dos dois 
        set
        {
            if (value < 0)
            {
                velMAX = 0;
            }
            else if (value > 300)
            {
                velMAX = 300;
            }
            else
            {
                velMAX = value;
            }
        }
    }

     public Carro()
    {
        vm = 120;
    }
}



class Index
{

    static void Main()
    {
        Carro carro1 = new Carro();

        carro1.vm = 200;

        Console.WriteLine("velocidade:{0}",carro1.vm);

    }
}