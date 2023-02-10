using System;    


    // definir o tipo de visualização 

// public, Publica sem restrição de visualizção 
// abstract : Classe-base para outras classes, não podem ser usadas para gerar objetos
// sealed classe não pode ser herdada
// static classe não permite a instaciação de objetos e seus membros. 

    // especificador Acesso: onde um membro da classse pode ser acessado 
    // public: sem restrição de acesso 
    // private: so pode ser acessado pela prorpia classe
    // protected: podem ser acessados na pripria classe e nas classes derivadas
    // abstract: os metodos não tem implementação somente os cabeçalhos
    // sealed: o metood não pode ser redefinido 
    // vitual: o metodo po ser redefinido em uma classe derivada 
    // static: o metodo pdoe ser chamado mesmo sem a instaciação de um objeto.

public class Player {

    public int vida;
    public bool vivo;
    public string nome;

    //metodo contrutor, precisa ter o nome da classe.
     public Player(){
        vida = 100;
        vivo = true;
        nome = "Player";
    }
    public Player(string n){
        vida = 100;
        vivo = true;
        nome = n;
    }
     public Player(string n, int v, bool s){
        vida = v;
        vivo = s;
        nome = n;
    }



    public void info(){
        Console.WriteLine("Nome do jogador é {0}!",nome);
        Console.WriteLine("Quantidade de vida do jogador {0}.",vida);
        Console.WriteLine("Status do jogador: {0}\n",vivo);

    }

    // ~Player (){
    //     Console.WriteLine("Jogador {0} foi eliminado.",nome);
    // }

}

class Index{
    static void Main(){
        Player p1 = new Player();
        Player p2 = new Player("Luan");
        Player p3 = new Player("Pedro",90,true);


        Inimigo i1 = new Inimigo("Doido");

        Inimigo.alerta =true;

        p1.info();

        p2.info();

        p3.info();

    }
}

static public class Jogador{
    
}

public class Inimigo   {
    static public bool alerta;

    public string nome;

    public Inimigo(string n){
        alerta = false;
        nome = n;
    }

    public void info(){
        Console.WriteLine("Nome do inimigo é {0}!",nome);
        Console.WriteLine("Status do inimigo  {0}.",alerta);
    }
}