using POOGame.src.Entities;

class Program 
{
    static void Main(string[] args) 
    {

        Heroi Arus = new Heroi("Arus", "Guerreiro");
        Mago Wedge = new Mago("Wedge", "Mago negro");
        Inimigo KingMummy = new Inimigo("KingMummy", "Zumbi");   
      

        System.Console.WriteLine(Arus.Atacar());  
        System.Console.WriteLine(KingMummy.Atacar());      
        

        if(Arus.valorUltimoAtaque == KingMummy.valorUltimoAtaque){
            Console.WriteLine(" Empate, ambos deramdano de" + Arus.valorUltimoAtaque);            
        }else if(Arus.valorUltimoAtaque > KingMummy.valorUltimoAtaque){
            KingMummy.recberDano(Arus.valorUltimoAtaque - KingMummy.valorUltimoAtaque);
            System.Console.WriteLine(Arus.nome + " Venceu esse round");
        }else{
            Arus.recberDano(KingMummy.valorUltimoAtaque - Arus.valorUltimoAtaque);
            System.Console.WriteLine(KingMummy.nome + " Venceu esse round");
        }


       // System.Console.WriteLine(Arus.valorUltimoAtaque); // O método "ToString" é chamado por padrão quando nenhum outro método é declarado;
       // System.Console.WriteLine(KingMummy.valorUltimoAtaque);
       // System.Console.WriteLine(Wedge.Atacar(30)); // O Mago tem uma "sobrecarga". Pode atacar com o mesmo método, porém, com 2 assinatuas diferentes: Com ou sem bônus;


    }

}
