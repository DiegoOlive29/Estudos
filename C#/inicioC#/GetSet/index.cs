using System;

// sealed defini que a classe não pode ser herdada. 

sealed class Carro
{

    private int[] velMax = new int[5]{80,120,160,240,300};

    public int this [int i]
    {
        get
        {
            return velMax[i];
        }
        //poder ser colocado somente um dos dois 
        set
        {
            if (value < 0)
            {
                velMax[i] = 0;
            }
            else if (value > 300)
            {
                velMax[i] = 300;
            }
            else
            {
                velMax[i] = value;
            }
        }
    }

     public Carro(){}
   
}



class Index
{

    static void Main()
    {
        Carro carro1 = new Carro();

        carro1[4] = 200;

        Console.WriteLine("velocidade:{0}",carro1[4]);

    }
}