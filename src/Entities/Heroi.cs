namespace POOGame.src.Entities
{
    public class Heroi
    {

        public Heroi(string nome, string classeFantastica)
        {
            // Método construtor para criar os personagens com características pré-estabelecidas;
            this.nome = nome;
            this.classeFantastica = classeFantastica;
            this.nivel = 1;
            this.pontosDeVida = 50;
            this.pontosDeMagia = 100;
        }
        public string nome { get; set;}
        public int nivel { get; set;}
        public int pontosDeVida { get; set;}
        public int pontosDeMagia {get; set; }
        public string classeFantastica {get; set; }
        public int valorUltimoAtaque { get; set; }

        // Usando "override" para subscrever (Polimorfismo) o método "ToString"; 
        public override string ToString(){ 
            return "Meu nome é " + this.nome + "\n"
            + "Nível: " + this.nivel + "\n"
            + "Classe: " + this.classeFantastica + "\n"
            + "Ponto de Vida " + this.pontosDeVida + "\n"
            +"Ponto de magia: " + this.pontosDeMagia + "\n" ;
        }
        // Fazendo os personagens atacar;
        public virtual string Atacar(){ // "Virtual" permite a subscrição na classe Mago;
            Random dado = new Random(); // "Randon" cria números aleatórios;
            int forcaDoAtaque = this.nivel + dado.Next(10,20);
            this.valorUltimoAtaque = forcaDoAtaque;
            return this.nome + " Ataca com a sua espada e da " + 
                   forcaDoAtaque + " de  dano";
            
            
        }

        public void recberDano(int danoRecebido){
            this.pontosDeVida = pontosDeVida - danoRecebido;
        }
        
    }
}