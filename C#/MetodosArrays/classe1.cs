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
    public int vida=100;
    public bool vivo = true;


}

class Index{
    static void Main(){
        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();

        p1.vida =50;
        

        Console.WriteLine("Vida do jogador 1: {0}", p1.vida);

    }
}