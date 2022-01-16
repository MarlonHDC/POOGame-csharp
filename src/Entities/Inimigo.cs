namespace POOGame.src.Entities
{
    public class Inimigo : Heroi
    {
        public Inimigo(string nome, string classeFantastica) : base(nome, classeFantastica)
        {
            this.nome = nome;
            this.classeFantastica = classeFantastica;
            this.nivel = 1;
            this.pontosDeVida = 80;
            this.pontosDeMagia = 0;
        }

        public override string Atacar(){
            Random dado = new Random();
            int forcaDoAtaque = this.nivel + dado.Next(1,15);
            this.valorUltimoAtaque = forcaDoAtaque;
            return this.nome + "Ataca e da" + forcaDoAtaque + " de dano";

        }
    }
}