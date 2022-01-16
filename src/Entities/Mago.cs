namespace POOGame.src.Entities
{
    public class Mago : Heroi // Herança. Tudo que Heroi tem, o Mago tem, porém, com suas particularidades;
    {
        public Mago(string nome, string classeFantastica) : base(nome, classeFantastica)
        {
            this.nome = nome;
            this.classeFantastica = classeFantastica;
            this.nivel = 1;
            this.pontosDeVida = 50;
            this.pontosDeMagia = 100;
        }

        public override string  Atacar() {
            Random dado = new Random();
            int forcaDoAtaque = this.nivel + dado.Next(1,10);

            return this.nome + " Ataca com o seu cajado e da " +
                   forcaDoAtaque + " de dano";            
        }

        public string Atacar(int bonus) {
            Random dado = new Random();
            int forcaDoAtaque = this.nivel + dado.Next(1,10) + bonus;
            this.valorUltimoAtaque = forcaDoAtaque;
            return this.nome + " Ataca com bônus com seu cajado e da " +forcaDoAtaque + " de dado";

        }
    }
}