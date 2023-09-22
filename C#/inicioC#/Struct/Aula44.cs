using System;

//  Struct não é uma class 

struct Cart{
    public string marca;
    public string modelo;
    public string cor;

    public Cart(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
}

class Aula44 {
    static void Main(){
        Cart c1;

        c1.marca="VW";
        c1.modelo="Gol";
        c1.cor="Vermelho";

        Console.WriteLine("Marca :{0}", c1.marca);
        Console.WriteLine("Modelo :{0}", c1.modelo);
        Console.WriteLine("Cor :{0}", c1.cor);

    }
}