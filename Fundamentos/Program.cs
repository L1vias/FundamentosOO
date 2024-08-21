using Fundamentos;

internal class Program
{
    private static void Main(string[] args)
    {/*
        // Instanciar um Objeto do Tipo Aluno
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();

        // Preencher os atributos do objeto
        aluno1.Nome = "Cristiano de Paula";
        aluno1.RM = "1234TI";
        aluno1.Email = "cristiano.paula@sp.senai.br";
        aluno1.Nascimento = new DateOnly(1981, 07, 16);

        aluno2.Nome = "José da Silva";
        aluno2.RM = "2244TI";
        aluno2.Email = "jose.silva@sp.senai.br";
        aluno2.Nascimento = new DateOnly(2000, 07, 16);

        // Imprimir na Tela
        Console.WriteLine("Aluno 1");
        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("RM: " + aluno1.RM);
        Console.WriteLine("E-mail: " + aluno1.Email);
        Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        Console.WriteLine("================================================");

        Console.WriteLine("Aluno 2");
        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("RM: " + aluno2.RM);
        Console.WriteLine("E-mail: " + aluno2.Email);
        Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        Console.WriteLine("================================================");
        Console.WriteLine();

        // Instanciar um Objeto do Tipo Produto
        Produto p1 = new Produto();
        p1.Codigo = 123456;
        p1.Nome = "Coca-Cola 3 Litros";
        p1.Preco = 12.99;
        p1.Estoque = 96;
        // Chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();
        p1.Estoque = 85;
        // Chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();

        Console.WriteLine("================================================");
        Console.WriteLine();

        // Instanciar um objeto do tipo Carro
        Carro carro1 = new Carro();
        carro1.Marca = "Ferrari";
        carro1.Modelo = "488";
        carro1.Velocidade = 80;

        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Desacelerar();

        Console.WriteLine("================================================");
        Console.WriteLine();

        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "José";
        pessoa1.Idade = 18;

        pessoa1.Envelhecer(5);
        pessoa1.Envelhecer(2);

        Console.WriteLine("================================================");
        Console.WriteLine();

        Funcionario func1 = new Funcionario();
        func1.Nome = "Luis Santos";
        func1.Idade = 20;
        func1.Cargo = "Aprendiz";
        func1.Salario = 1400.00;
        func1.ApresentarSe();

        Console.WriteLine("================================================");
        Console.WriteLine();*/
        /*
        //Instanciar um objeto
        Animal animal1 = new Animal();

        //Inserindo dados no Atributo
        animal1.Especie = "Cachorro";

        //chamando o metodo do objeto
        animal1.emitirSom();

        //imprimindo a informação na tela
        Console.WriteLine(" O animal " + animal1.Especie + " emitiu um som.");*/
        /*
        Gato gato = new Gato();
        gato.Nome = "Frajola";
        Console.WriteLine(gato.Nome + " faz: ");
        gato.emitirSom();

        Porco porco = new Porco();
        porco.Nome = "Catarina";
        Console.WriteLine(porco.Nome + " faz: ");
        porco.emitirSom();

        Galinha galinha = new Galinha();
        galinha.Nome = "neuza";
        Console.WriteLine(galinha.Nome + " faz: ");
        galinha.emitirSom();*/

        Mago merlin = new Mago();
        merlin.Nome = "Mago Merlin";
        merlin.Vida = 100;
        merlin.Inteligencia = 87;
        merlin.Agilidade = 65;
        merlin.Forca = 80;
        merlin.Nivel = 1;

        Elfo elfo = new Elfo();
        elfo.Nome = "Julius";
        elfo.Vida = 100;
        elfo.Inteligencia = 83;
        elfo.Forca = 56;
        elfo.Agilidade = 90;
        elfo.Nivel = 1;


        merlin.apresentarSe();
        elfo.apresentarSe();

        int ataque = merlin.atacar();
        int defesa = merlin.Defender();
        Console.WriteLine("Força do Ataque: " + ataque);
        Console.WriteLine("Força do Defesa: " + defesa);

        Cavaleiro cavaleiro = new Cavaleiro();

        cavaleiro.Nome = " Jerson ";
        cavaleiro.Forca = 10;
        cavaleiro.Vida = 100;
        cavaleiro.Agilidade = 70;
        cavaleiro.Inteligencia = 33;
        cavaleiro.Nivel = 1;


        merlin.apresentarSe();
        cavaleiro.apresentarSe();
        merlin.batalhar(cavaleiro);


    }
}