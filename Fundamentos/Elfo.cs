using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Elfo : Personagem
    {
        public override void apresentarSe()
        {

            Console.WriteLine("Olá, eu sou o Elfo " + this.Nome + " tenho " + this.Vida + " pontos de vida, inteligencia: " + this.Inteligencia + ", Agilidade: " + this.Agilidade + ", força: " + this.Forca + ", Meu nível atual é: " + this.Nivel);
            Console.WriteLine("================================================================");
        }
    }
}
