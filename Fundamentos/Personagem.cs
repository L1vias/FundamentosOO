using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Personagem
    {
        //Atributos
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        //Metodos
        public virtual void apresentarSe() { }
        public virtual void evoluir()
        {
            this.Nivel += 2;
            this.Forca += 2;
            this.Inteligencia *= 2;
            this.Agilidade *= 2;
            Console.WriteLine("O jogador" + this.Nome + "evoluiu para o nível " + this.Nivel + ". Seus novos valores são: \nAgilidade:" + this.Agilidade + "\nInteligencia: " + this.Inteligencia + "\nForça: " + this.Forca);

        }
        public virtual int atacar()
        {
            int pontosAtaque = 0;
            pontosAtaque = (this.Inteligencia + this.Forca + this.Agilidade + this.Nivel + this.Vida) / 5;
            return pontosAtaque;
        }
        public virtual int Defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = ((this.Inteligencia * 2) + this.Forca + (this.Agilidade * 2) + this.Nivel + this.Vida) / 4;
            return pontosDefesa;
        }
        public virtual void batalhar(Personagem p)
        {
            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.atacar();
                int valorDefesaInimigo = p.Defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    Vida = 1;
                }

                p.Vida = p.Vida - Vida;
                Console.WriteLine("Dano na Vida do Inimigo em " + Vida);
                Console.WriteLine("O nível de vida do Inimigo agora é " + p.Vida);

                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.Defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Dano na Vida do Atacante em " + danoDeVida2);
                Console.WriteLine("O nível de vida do Atacante agora é " + this.Vida);
                Console.WriteLine("====================================================================================");
                if (this.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + p.Nome + "Venceu!");
                    vencedor = true;
                    p.evoluir();
                }

                if (p.Vida <= 0)
                {
                    Console.WriteLine("O vencedor " + this.Nome + "venceu");
                    vencedor = true;
                    this.evoluir();
                }
            }

        }
    }
}
