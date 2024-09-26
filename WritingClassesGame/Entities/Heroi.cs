namespace WritingClassesGame.Entities;

public class Heroi(string nome, int idade, string tipo)
{
    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
    public string Tipo { get; set; } = tipo;

    public void Atacar()
    {
        string ataque;

        if (Tipo.Equals("mago", StringComparison.CurrentCultureIgnoreCase))
        {
            ataque = "magia";
        }
        else if (Tipo.Equals("guerreiro", StringComparison.CurrentCultureIgnoreCase))
        {
            ataque = "espada";
        }
        else if (Tipo.Equals("monge", StringComparison.CurrentCultureIgnoreCase))
        {
            ataque = "artes marciais";
        }
        else if (Tipo.Equals("ninja", StringComparison.CurrentCultureIgnoreCase))
        {
            ataque = "shuriken";
        }
        else
        {
            ataque = "ataque desconhecido";
        }
        Console.WriteLine($"O {Tipo} atacou usando {ataque}.");
    }
}
