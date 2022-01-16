using POOGame.src.Entities;

class Program 
{
    static void Main(string[] args) 
    {

        Heroi Arus = new Heroi("Arus", "Guerreiro");
        Mago Wedge = new Mago("Wedge", "Mago negro");
        Inimigo KingMummy = new Inimigo("KingMummy", "Zumbi");   
      

        Arus.Atacar();
        KingMummy.Atacar();


        System.Console.WriteLine(Arus.valorUltimoAtaque); // O método "ToString" é chamado por padrão quando nenhum outro método é declarado;
        System.Console.WriteLine(KingMummy.valorUltimoAtaque);
        // System.Console.WriteLine(Wedge.Atacar(30)); // O Mago tem uma "sobrecarga". Pode atacar com o mesmo método, porém, com 2 assinatuas diferentes: Com ou sem bônus;


    }

}
